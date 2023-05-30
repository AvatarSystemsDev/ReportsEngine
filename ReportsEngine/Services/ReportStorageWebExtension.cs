using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using ReportsEngine.Reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using WebApiODataServiceProject;

namespace ReportsEngine.Services
{
    public class CustomReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension
    {
        readonly string reportDirectory;
        const string FileExtension = ".repx";
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
                string[] parts = url.Split('?');
                string reportName = parts[0];
                string parametersString = parts.Length > 1 ? parts[1] : String.Empty;
                string currentDatabaseID = "";
                XtraReport report = null;

                if (ReportsFactory.Reports.ContainsKey(reportName))
                {
                    report = ReportsFactory.Reports[reportName]();
                }

                if (report != null)
                {
                    string user = "reportuser";
                    string password = "Re.port_243";
                    
                    string PulseServerName = "Pulse.Avatar.Local";
                    string PulseDatabaseName = "AvatarPulse";
                    string Pulseuser = "RoyaltyOwnerRelationsUser";
                    string Pulsepassword = "SzCz0tka";

                    ConnectionStringInfo connectionStringParts = new ConnectionStringInfo();
                    //Get the Database ConnectionString based on plngDatabaseID
                    connectionStringParts = WebApiODataServiceProject.DatabaseSelection.getConnectionStringInfo(currentDatabaseID);
                   



                    // Assign parameters here
                    var parameters = HttpUtility.ParseQueryString(parametersString);
                    foreach (string parameterName in parameters.AllKeys)
                    {
                        //if (parameterName == "plngDatabaseID")
                        //{

                        //}
                        //else
                        //{
                        //    report.Parameters[parameterName].Value = Convert.ChangeType(
                        //        parameters.Get(parameterName), report.Parameters[parameterName].Type);
                        //}

                        report.Parameters["pstrServerName"].Value = "Developer1";
                        report.Parameters["pstrDatabaseName"].Value = "Providence";
                        report.Parameters["plngCompanyID"].Value =  1;
                        report.Parameters["plngUserID"].Value = 1043;

                        string connectionStringDynamic = @"XpoProvider=MSSqlServer;Data Source=" + report.Parameters["pstrServerName"].Value + "; User ID=" + user + ";Password=" + password + ";Initial Catalog=" + report.Parameters["pstrDatabaseName"].Value + ";Persist Security Info=true;";
                        string connectionStringPulse = @"XpoProvider=MSSqlServer;Data Source=" + PulseServerName + "; User ID=" + Pulseuser + ";Password=" + Pulsepassword + ";Initial Catalog=" + PulseDatabaseName + ";Persist Security Info=true;";

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
                                else
                                {
                                    if (sds.Name == "Pulse")
                                    {
                                        OlapConnectionParameters olapParams = new OlapConnectionParameters();
                                        olapParams.ConnectionString = connectionStringPulse;
                                        sds.ConnectionParameters = olapParams;
                                    }

                                }

                            }
                        }



                    }
                    report.RequestParameters = false;

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
    }
}
