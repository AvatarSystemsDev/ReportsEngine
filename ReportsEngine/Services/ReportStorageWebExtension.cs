using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Newtonsoft.Json.Linq;
using ReportsEngine.Reports;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Web;

namespace ReportsEngine.Services
{
    public class CustomReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension
    {
        readonly string reportDirectory;
        const string FileExtension = ".repx";

        private const string PulseServerName = "Pulse.Avatar.Local";
        private const string PulseDatabaseName = "AvatarPulse";
        private static readonly string Pulseuser = Environment.GetEnvironmentVariable("Pulse_Report_User", EnvironmentVariableTarget.Machine) ?? "RoyaltyOwnerRelationsUser"; // Use these as a backup for testing only. Should get username and password from environment variables from server instead of hard coded values in code.
        private static readonly string Pulsepassword = Environment.GetEnvironmentVariable("Pulse_Report_Password", EnvironmentVariableTarget.Machine) ?? "SzCz0tka";
        private static readonly string ReportUser = Environment.GetEnvironmentVariable("Report_User", EnvironmentVariableTarget.Machine) ?? "reportuser";
        private static readonly string ReportUserPassword = Environment.GetEnvironmentVariable("Report_User_Password", EnvironmentVariableTarget.Machine) ?? "Re.port_243";

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

        private static int? GetDatabaseIDFromUrl(string url)
        {
            Regex regex = new Regex(@"plngDatabaseID=(\d+)");
            Match match = regex.Match(url);

            if (match.Success)
            {
                return int.Parse(match.Groups[1].Value);  // The first group (1) captures the digits following "plngDatabaseID="
            }
            return null;
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
                int? databaseID = GetDatabaseIDFromUrl(url);

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
                try
                {
                    if (ReportsFactory.Reports.ContainsKey(reportName))
                    {
                        report = ReportsFactory.Reports[reportName](databaseID, companyid);
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
                catch (SystemException e)
                {
                    throw new SystemException("Company: " + companyid + Environment.NewLine + "Database: " + databaseID + Environment.NewLine + "Report Name: " + reportName + Environment.NewLine + e.ToString());
                }
            }
            catch (SystemException ex)
            {
                FaultException couldNotGetReportData =  new FaultException("Could not get report data." + ex.Message);
                DebugErrorHandler.Error_Occurred(couldNotGetReportData);
                throw new FaultException("Could not get report data.");
            }
            // Will only get to this point if there is an error.
            // I don't just want to return a message with the query string.
            FaultException faultException = new FaultException(string.Format("Could not find report '{0}'.", url));
            DebugErrorHandler.Error_Occurred(faultException);

            // Get report name from query string.
            string pattern = @"[&?]pstrReportName=([^&]+)"; 
            Match match = Regex.Match(url, pattern);
            if (match.Success) // report name found
            {
                throw new FaultException("Could not get report data: " + match.Groups[1].Value);
            }
            throw new FaultException("Could not get report data.");
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
        public static bool ParameterExists(ParameterCollection parameters, string paramName)
        {
            return parameters.Cast<Parameter>().Any(p => p.Name == paramName);
        }


        public static void setReportParameters(XtraReport report, System.Collections.Specialized.NameValueCollection parameters, int companyid)
        {
            bool AwaitParameterInputPassed = false;
            foreach (Parameter parameter in report.Parameters)
            {
                if (parameter.Name.ToLower() == "pbooawaitparameterinput")
                {
                    AwaitParameterInputPassed = parameter.Value.ToString().ToLower() == "true";
                }
            }

            //  Margie wants the default parameters for the reports to be the current day.
            foreach (Parameter parameter in report.Parameters)
            {

                if (parameter.Type.Name.ToString() == "DateTime" && AwaitParameterInputPassed)
                {
                    parameter.Value = DateTime.Today;
                }
            }

            try
            {
                foreach (string parameterName in parameters.AllKeys)
                {
                    if (parameterName == null)
                    {
                        continue;
                    }
                    if (parameterName == "plngDatabaseID")
                    {
                        DynamicConnectionHandler.ConnectionStringInfo connectionStringParts = new DynamicConnectionHandler.ConnectionStringInfo();
                        string currentDatabaseID = parameters["plngDatabaseID"];
                        //Get the Database ConnectionString based on plngDatabaseID
                        connectionStringParts = DynamicConnectionHandler.getConnectionStringInfo(currentDatabaseID);
                        try
                        {
                            report.Parameters["pstrServerName"].Value = connectionStringParts.ServerName;
                        }
                        catch (SystemException ex)
                        {
                            throw new SystemException(ex.ToString() + Environment.NewLine + "pstrServerName either not on the report or unable to get connection string from databaseID: " + currentDatabaseID);
                        }
                        try
                        {
                            report.Parameters["pstrDatabaseName"].Value = connectionStringParts.DatabaseName;
                        }
                        catch (SystemException ex)
                        {
                            throw new SystemException(ex.ToString() + Environment.NewLine + "pstrDatabaseName either not on the report or unable to get connection string from databaseID: " + currentDatabaseID);
                        }
                        if (ParameterExists(report.Parameters, "plngDatabaseID"))
                        {
                            report.Parameters["plngDatabaseID"].Value = int.Parse(currentDatabaseID.ToString());
                        }
                        if (report.Parameters["plngCompanyID"] != null)
                        {
                            report.Parameters["plngCompanyID"].Value = companyid;
                        }

                        string connectionStringDynamic = $"Data Source={report.Parameters["pstrServerName"].Value}; User ID={ReportUser}; Password={ReportUserPassword}; Initial Catalog={report.Parameters["pstrDatabaseName"].Value}; Persist Security Info=true; TrustServerCertificate=true;";
                        string connectionStringPulse = $"Data Source={PulseServerName}; User ID={Pulseuser}; Password={Pulsepassword}; Initial Catalog={PulseDatabaseName}; Persist Security Info=true; TrustServerCertificate=true;";

                        var dataSources = DataSourceManager.GetDataSources(report, true);
                        foreach (var dataSource in dataSources)
                        {
                            if (dataSource is DevExpress.DataAccess.Sql.SqlDataSource sds && !String.IsNullOrEmpty(sds.ConnectionName))
                            {
                                if (sds.Name == "Dynamic")
                                {
                                    try
                                    {
                                        OlapConnectionParameters olapParams = new OlapConnectionParameters();
                                        olapParams.ConnectionString = connectionStringDynamic;
                                        sds.ConnectionParameters = olapParams;
                                    }
                                    catch (SystemException ex)
                                    {
                                        throw new SystemException(ex.ToString() + Environment.NewLine + "Dynamic connection could not be established from connection string " + connectionStringDynamic);
                                    }
                                }
                                else if (sds.Name == "Pulse")
                                {
                                    try
                                    {
                                        OlapConnectionParameters olapParams = new OlapConnectionParameters();
                                        olapParams.ConnectionString = connectionStringPulse;
                                        sds.ConnectionParameters = olapParams;
                                    }
                                    catch (SystemException ex)
                                    {
                                        throw new SystemException(ex.ToString() + Environment.NewLine + "Pulse connection could not be established from connection string " + connectionStringPulse);
                                    }
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
                        List<Parameter> reportParameters = report.Parameters.Cast<Parameter>().ToList(); //The unsorted parameters from the report
                        string[] hiddenIndexes = Regex.Split(parameters["pstrParamVisibility"], "-");
                        if (hiddenIndexes.Length > 0)
                        {
                            for (int i = 0; i < hiddenIndexes.Length; i++) //for each index seperated by -
                            {
                                string indexWithBool = hiddenIndexes[i]; //get the string
                                string strIndexOnly = indexWithBool.Substring(0, indexWithBool.Length - 1); //get just the index part of the string
                                int indexOnly = Int32.Parse(strIndexOnly); //convert the index to an int
                                string visiBoolChar = indexWithBool.Substring(indexWithBool.Length - 1, 1); //get the T or F at the end of the string.
                                bool visiBool = true; //default visible value. If visiBoolChar is not defined, it will always be visible.
                                if (visiBoolChar.ToUpper() == "T")
                                    visiBool = true;
                                else if (visiBoolChar.ToUpper() == "F")
                                    visiBool = false;

                                //NOTE indexOnly is incremented by the 3 hardcoded parameters always passed to reports
                                string parameterKey = parameters.GetKey(indexOnly + 3);
                                var foundParameter = reportParameters.Find(param => param.Name == parameterKey);
                                if (foundParameter != null)
                                {
                                    foundParameter.Visible = visiBool;
                                }
                            }
                        }
                    }
                    else if (parameterName == "pbooAwaitParameterInput")
                    {
                        AwaitParameterInputPassed = true;
                        var RequestParametersAwait = parameters["pbooAwaitParameterInput"].ToString().ToLower();
                        report.RequestParameters = RequestParametersAwait == "true";
                        bool parameterExists = false;
                        foreach (var param in report.Parameters)
                        {
                            if (param.Name == "pbooAwaitParameterInput")
                            {
                                parameterExists = true;
                                break;
                            }
                        }

                        if (parameterExists)
                        {
                            try
                            {
                                report.Parameters[parameterName].Value = Convert.ChangeType(parameters.Get(parameterName), report.Parameters[parameterName].Type);
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                    else if (parameterName.Contains("pstrReportName"))
                    {
                        report.DisplayName = parameters.Get(parameterName).ToString();
                        report.Name = parameters.Get(parameterName).ToString();
                    }
                    else if (parameterName.Contains("pstrSelect")) // I've made all my multivariate parameters with this naming convention. I know that sucks.
                    {
                        //string[] multivariateParameter = JsonConvert.DeserializeObject<string[]>(parameters.Get(parameterName));
                        // report.Parameters[parameterName].Value = multivariateParameter;

                        JToken token = JToken.Parse(parameters.Get(parameterName));
                        string jsonInput = parameters.Get(parameterName);
                        switch (token.Type)
                        {
                            case JTokenType.Array:
                                switch (report.Parameters[parameterName].Type.Name)
                                {
                                    case "Int32": report.Parameters[parameterName].Value = token.ToObject<int[]>(); break;
                                    case "String": report.Parameters[parameterName].Value = token.ToObject<string[]>(); break;
                                    case "Bool": report.Parameters[parameterName].Value = token.ToObject<bool[]>(); break;
                                    case "Float": report.Parameters[parameterName].Value = token.ToObject<float[]>(); break;
                                    case "DateTime": report.Parameters[parameterName].Value = token.ToObject<DateTime[]>(); break;
                                    default: report.Parameters[parameterName].Value = token.ToObject<string[]>(); break;
                                }
                                break;

                            case JTokenType.Object:
                                JObject jsonObject = JObject.Parse(jsonInput);
                                List<string> values = new List<string>();

                                // Iterate through the properties of the object
                                foreach (var prop in jsonObject.Properties())
                                {
                                    // Add the property value to the list
                                    values.Add(prop.Value.ToString());
                                }

                                // Set the parameter value as an array of strings
                                report.Parameters[parameterName].Value = values.ToArray();
                                break;
                            case JTokenType.Integer: report.Parameters[parameterName].Value = new int[] { int.Parse(token.ToString()) }; break;
                            case JTokenType.Boolean: report.Parameters[parameterName].Value = new bool[] { bool.Parse(token.ToString()) }; break;
                            case JTokenType.Date: report.Parameters[parameterName].Value = new DateTime[] { DateTime.Parse(token.ToString()) }; break;
                            case JTokenType.Float: report.Parameters[parameterName].Value = new float[] { float.Parse(token.ToString()) }; break;
                            default: report.Parameters[parameterName].Value = new string[] { token.ToString() }; break;
                        }

                    }
                    else if (parameterName == "plngUserID")
                    {
                        try
                        {
                            report.Parameters[parameterName].Value = Convert.ChangeType(parameters.Get(parameterName), report.Parameters[parameterName].Type); // Run Report button passes in User ID parameter but that is not usually necessary on the report. Many reports do not have user ID and that causes an error.
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    else if (parameterName == "plngCompanyID")
                    {
                        try
                        {
                            report.Parameters[parameterName].Value = companyid; // Run Report button passes in User ID parameter but that is not usually necessary on the report. Many reports do not have user ID and that causes an error.
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    else if (report.Parameters[parameterName] is null)
                    {
                        throw new Exception("Parameter " + parameterName + " passed to report " + report.DisplayName + " is invalid.");
                    }
                    else if (report.Parameters[parameterName].Type == typeof(DateTime))
                    {
                        string dateTimeString = parameters.Get(parameterName).ToString();
                        DateTime dateTimeParameter = DateTime.Parse(dateTimeString);
                        report.Parameters[parameterName].Value = dateTimeParameter;
                    }
                    else
                    {
                        switch (parameters.Get(parameterName)) // Not always a string
                        {
                            case null:
                            case "null":
                            case "undefined":
                                report.Parameters[parameterName].Value = null;
                                break;
                            default:
                                report.Parameters[parameterName].Value = Convert.ChangeType(parameters.Get(parameterName), report.Parameters[parameterName].Type);
                                break;
                        }
                    }
                }

                if (!AwaitParameterInputPassed)
                {
                    report.RequestParameters = false;
                }
            }
            catch (Exception ex)
            {
                string errorString = "Company: " + companyid + Environment.NewLine + "Report Name: " + report.GetType().ToString() + Environment.NewLine + "Parameter could not be read." + Environment.NewLine + "Error: " + Environment.NewLine + ex.ToString();
                Exception error = new Exception(errorString);
                DebugErrorHandler.Error_Occurred(error);
                throw new Exception("Error reading report parameters. Please contact customer support");
            }
        }

    }
}
