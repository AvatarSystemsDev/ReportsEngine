using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Newtonsoft.Json;
using ReportsEngine.Reports;
using ReportsEngine.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Services;

namespace ReportsEngine.WebServices
{
    /// <summary>
    /// Summary description for ReportOperations
    /// </summary>
    [Authorize]
    [WebService(Namespace = "https://providence.avatarsystems.net/WebServices")]    //May need to be changed
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class ReportOperations : WebService
    {
        private const string ReportUser = "reportuser";
        private const string ReportUserPassword = "Re.port_243";
        private const string PulseServerName = "Pulse.Avatar.Local";
        private const string PulseDatabaseName = "AvatarPulse";
        private const string Pulseuser = "RoyaltyOwnerRelationsUser";
        private const string Pulsepassword = "SzCz0tka";

        [WebMethod]
        public object ReturnReportPDF(string reportName, string reportParamsJson, int companyid, int databaseID)
        {
            dynamic reportParams = null;
            List<dynamic> paramCollection = new List<dynamic>();
            if (reportParamsJson != null)
            {
                reportParams = JsonConvert.DeserializeObject(reportParamsJson);
                paramCollection = new List<dynamic>(reportParams);
            }

            XtraReport report = ReportsFactory.Reports[reportName]();

            DynamicConnectionHandler.ConnectionStringInfo connectionStringParts = new DynamicConnectionHandler.ConnectionStringInfo();
            string currentDatabaseID = databaseID.ToString();
            //Get the Database ConnectionString based on plngDatabaseID
            connectionStringParts = DynamicConnectionHandler.getConnectionStringInfo(currentDatabaseID);
            report.Parameters["pstrServerName"].Value = connectionStringParts.ServerName;
            report.Parameters["pstrDatabaseName"].Value = connectionStringParts.DatabaseName;
            if (report.Parameters["plngCompanyID"] != null)
            {
                report.Parameters["plngCompanyID"].Value = companyid;
            }

            string connectionStringDynamic = @"XpoProvider=MSSqlServer;Data Source=" + report.Parameters["pstrServerName"].Value + "; User ID=" + ReportUser + ";Password=" + ReportUserPassword + ";Initial Catalog=" + report.Parameters["pstrDatabaseName"].Value + ";Persist Security Info=true;TrustServerCertificate=true;";
            //TODO Change the connectionStringPulse to use DynamicConnectionHandler.GetPulseDataBaseConnectionString()
            string connectionStringPulse = @"XpoProvider=MSSqlServer;Data Source=" + PulseServerName + "; User ID=" + Pulseuser + ";Password=" + Pulsepassword + ";Initial Catalog=" + PulseDatabaseName + ";Persist Security Info=true;TrustServerCertificate=true;";

            var dataSources = DataSourceManager.GetDataSources(report, true);
            foreach (var dataSource in dataSources)
            {
                if (dataSource is DevExpress.DataAccess.Sql.SqlDataSource sds && !String.IsNullOrEmpty(sds.ConnectionName))
                {
                    if (sds.Name == "Dynamic")
                    {
                        OlapConnectionParameters olapParams = new OlapConnectionParameters();
                        olapParams.ConnectionString = connectionStringDynamic;
                        sds.ConnectionParameters = olapParams;
                    }
                    else if (sds.Name == "Pulse")
                    {
                        OlapConnectionParameters olapParams = new OlapConnectionParameters();
                        olapParams.ConnectionString = connectionStringPulse;
                        sds.ConnectionParameters = olapParams;
                    }
                }
            }

            if (reportParamsJson != null)
            {
                foreach (var reportParameter in report.Parameters)
                {
                    var userParameter = paramCollection.Where(parameter => parameter.Name == reportParameter.Description).FirstOrDefault();
                    if (userParameter != null)
                    {
                        if (reportParameter.MultiValue)
                        {
                            string[] multivariateParameter = userParameter.Value.ToString().Split();
                            reportParameter.Value = multivariateParameter;
                        }
                        else
                        {
                            reportParameter.Value = userParameter.Value;
                        }
                    }
                }
            }

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    report.ExportToPdf(ms);
                    ms.Position = 0;
                    byte[] documentByteArray = ms.ToArray();
                    String base64String = Convert.ToBase64String(documentByteArray);
                    return new { success = true, pdf = base64String};
                }
            }
            catch (Exception e)
            {
                return new { success = false, msg = e.Message };

                throw;
            }
            
        }                
        
    }
}