using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReportsEngine.Reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace ReportsEngine.Services
{
    public class CustomReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension
    {
        readonly string reportDirectory;
        const string FileExtension = ".repx";

        private const string ReportUser = "reportuser";
        private const string ReportUserPassword = "Re.port_243";
        private const string PulseServerName = "Pulse.Avatar.Local";
        private const string PulseDatabaseName = "AvatarPulse";
        private const string Pulseuser = "RoyaltyOwnerRelationsUser";
        private const string Pulsepassword = "SzCz0tka";

        public CustomReportStorageWebExtension(string reportDirectory)
        {
            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }
            this.reportDirectory = reportDirectory;
        }

        private bool IsWithinReportsFolder(string url, string folder)
        {
            var rootDirectory = new DirectoryInfo(folder);
            var fileInfo = new FileInfo(Path.Combine(folder, url));
            return fileInfo.Directory.FullName.ToLower().StartsWith(rootDirectory.FullName.ToLower());
        }

        public override bool CanSetData(string url)
        {
            // Determines whether or not it is possible to store a report by a given URL. 
            // For instance, make the CanSetData method return false for reports that should be read-only in your storage. 
            // This method is called only for valid URLs (i.e., if the IsValidUrl method returned true) before the SetData method is called.

            return true;
        }

        public override bool IsValidUrl(string url)
        {
            // Determines whether or not the URL passed to the current Report Storage is valid. 
            // For instance, implement your own logic to prohibit URLs that contain white spaces or some other special characters. 
            // This method is called before the CanSetData and GetData methods.

            return Path.GetFileName(url) == url;
        }

        public override byte[] GetData(string url)
        {
            // Returns report layout data stored in a Report Storage using the specified URL. 
            // This method is called only for valid URLs after the IsValidUrl method is called.
            try
            {
                url = url.Substring(0, url.IndexOf('?') + 1) + url.Substring(url.IndexOf('?') + 1).Replace("?", "&");
                string[] parts = url.Split('?');
                string reportName = parts[0];
                string parametersString = parts.Length > 1 ? parts[1] : String.Empty;
                int companyidindex = url.IndexOf("=", url.IndexOf("plngCompanyID")) + 1; // Find equal sign after plngCompanyID
                int companyid;
                int indexQ = url.IndexOf("?", companyidindex);
                int indexA = url.IndexOf("&", companyidindex);

                if (indexA == -1 && indexQ == -1)
                {
                    companyid = Int32.Parse(url.Substring(companyidindex));
                }
                else if (indexA > indexQ)
                {
                    companyid = Int32.Parse(url.Substring(companyidindex, indexA - companyidindex));
                }
                else
                {
                    companyid = Int32.Parse(url.Substring(companyidindex, indexQ - companyidindex));
                }
                XtraReport report = null;

                if (ReportsFactory.Reports.ContainsKey(reportName))
                {
                    report = ReportsFactory.Reports[reportName]();
                }

                if (report != null)
                {
                    //TODO names of these parameters will be different by report
                    //Set Date Ranges to current month 
                    DateTime now = DateTime.Now;
                    var startDate = new DateTime(now.Year, now.Month, 1);

                    // Assign parameters here
                    setReportParameters(report, HttpUtility.ParseQueryString(parametersString), companyid);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        report.SaveLayoutToXml(ms);
                        return ms.ToArray();
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new FaultException("Could not get report data." + ex.Message);
            }
            throw new FaultException(
                string.Format("Could not find report '{0}'.", url));
        }

        public override Dictionary<string, string> GetUrls()
        {
            // Returns a dictionary of the existing report URLs and display names. 
            // This method is called when running the Report Designer, 
            // before the Open Report and Save Report dialogs are shown and after a new report is saved to a storage.

            return Directory.GetFiles(reportDirectory, "*" + FileExtension)
                                     .Select(Path.GetFileNameWithoutExtension)
                                     .Union(ReportsFactory.Reports.Select(x => x.Key))
                                     .ToDictionary<string, string>(x => x);
        }

        public override void SetData(XtraReport report, string url)
        {
            // Stores the specified report to a Report Storage using the specified URL. 
            // This method is called only after the IsValidUrl and CanSetData methods are called.
            if (!IsWithinReportsFolder(url, reportDirectory))
                throw new FaultException(new FaultReason("Invalid report name."), new FaultCode("Server"), "GetData");
            report.SaveLayoutToXml(Path.Combine(reportDirectory, url + FileExtension));
        }

        public override string SetNewData(XtraReport report, string defaultUrl)
        {
            // Stores the specified report using a new URL. 
            // The IsValidUrl and CanSetData methods are never called before this method. 
            // You can validate and correct the specified URL directly in the SetNewData method implementation 
            // and return the resulting URL used to save a report in your storage.
            SetData(report, defaultUrl);
            return defaultUrl;
        }

        public static void setReportParameters(XtraReport report, System.Collections.Specialized.NameValueCollection parameters, int companyid)
        {
            bool AwaitParameterInputPassed = false;

            foreach (string parameterName in parameters.AllKeys)
            {
                 if (parameterName == "plngDatabaseID")
                {
                    DynamicConnectionHandler.ConnectionStringInfo connectionStringParts = new DynamicConnectionHandler.ConnectionStringInfo();
                    string currentDatabaseID = parameters["plngDatabaseID"];
                    //Get the Database ConnectionString based on plngDatabaseID
                    connectionStringParts = DynamicConnectionHandler.getConnectionStringInfo(currentDatabaseID);
                        report.Parameters["pstrServerName"].Value = connectionStringParts.ServerName;
                        report.Parameters["pstrDatabaseName"].Value = connectionStringParts.DatabaseName;
                    if (report.Parameters["plngCompanyID"] != null)
                    {
                        report.Parameters["plngCompanyID"].Value = companyid;
                    }

                    string connectionStringDynamic = @"XpoProvider=MSSqlServer;Data Source=" + report.Parameters["pstrServerName"].Value + "; User ID=" + ReportUser + ";Password=" + ReportUserPassword + ";Initial Catalog=" + report.Parameters["pstrDatabaseName"].Value + ";Persist Security Info=true;TrustServerCertificate=true;";
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
                }
                else if (parameterName == "pstrSubtitle")
                {
                    report.Parameters["Subtitle"].Value = parameters["pstrSubtitle"].ToString();
                }
                else if (parameterName == "pstrParamVisibility")
                {
                    List<Parameter> para = report.Parameters.Cast<Parameter>().ToList();
                    string temp = parameters.ToString().Substring(parameters.ToString().IndexOf("pstrParamVisibility") + 20);
                    string index = "";
                    for (int x = 0; x < temp.Length; x++)
                    {
                        if (temp[x] == 'T' || temp[x] == 't')
                        {
                            para[Int32.Parse(index)].Visible = true;
                        }
                        else if (temp[x] == 'F' || temp[x] == 'f')
                        {
                            para[Int32.Parse(index)].Visible = false;
                        }
                        else if (temp[x] == '-')
                        {

                        }
                        else if (temp[x] == '&' || temp[x] == '?'){
                            break;
                        }
                        else
                        {
                            index += temp[x];
                        }
                    }
                }
                else if (parameterName == "pbooAwaitParameterInput")
                {
                    AwaitParameterInputPassed = true;
                    report.RequestParameters = (parameters["pbooAwaitParameterInput"].ToString().ToLower() == "true");
                }
                else if (parameterName.Contains("pstrSelect"))
                {
                    //string[] multivariateParameter = JsonConvert.DeserializeObject<string[]>(parameters.Get(parameterName));
                    // report.Parameters[parameterName].Value = multivariateParameter;
                    JToken token = JToken.Parse(parameters.Get(parameterName));
                    if (token.Type == JTokenType.Array)
                    {
                        report.Parameters[parameterName].Value = token.ToObject<string[]>();
                    }
                    else
                    {
                        // Handle the single token value (whether it's a string, int, or any other simple type)
                        report.Parameters[parameterName].Value = new string[] { token.ToString() };
                    }

                }
                else if (parameterName == "plngUserID")
                {
                    try
                    {
                        report.Parameters[parameterName].Value = Convert.ChangeType(parameters.Get(parameterName), report.Parameters[parameterName].Type); // Run Report button passes in User ID parameter but that is not usually necessary on the report. Many reports do not have user ID and that causes an error.
                    }
                    catch
                    {

                    }
                }
                else
                {
                    report.Parameters[parameterName].Value = Convert.ChangeType(parameters.Get(parameterName), report.Parameters[parameterName].Type);
                }
            }

            if (!AwaitParameterInputPassed)
            {
                report.RequestParameters = false;
            }
        }

    }
}
