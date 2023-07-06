using WebApiODataServiceProject;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using DevExpress.XtraReports.Web.WebDocumentViewer.DataContracts;
using System.Linq;
using System.Collections.Generic;
using System.Web.WebPages;
using Newtonsoft.Json;
using DevExpress.XtraReports.UI;
using ReportsEngine.Reports;
using DevExpress.XtraReports.Web.Native.ParametersPanel;
using System.Text.RegularExpressions;
using System.Web;
using System.Security.Policy;
using DevExpress.XtraReports.Parameters;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports;
using static DevExpress.Web.Internal.ColorPicker;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace ReportsEngine.Services
{
    public class ServiceOperations : DocumentOperationService
    {
        public override bool CanPerformOperation(DocumentOperationRequest request)
        {
            Debug.WriteLine("PerformOperation");
            return true;
        }

        public override DocumentOperationResponse PerformOperation(DocumentOperationRequest request, PrintingSystemBase initialPrintingSystem, PrintingSystemBase printingSystemWithEditingFields)
        {
            string customDataJson = request.CustomData;
            dynamic customData = JsonConvert.DeserializeObject(customDataJson);
            if (customData.action == "email")
            {
                using (var stream = new MemoryStream())
                {
                    printingSystemWithEditingFields.ExportToPdf(stream);
                    stream.Position = 0;
                    //var mailAddress = new MailAddress(request.CustomData);
                    //var recipients = new MailAddressCollection() { mailAddress };
                    //var emailDataJson = request.CustomData; // Assuming request.CustomData is the JSON string

                    string emailAddress = customData.emailAddress;
                    string emailMessage = customData.emailMessage;
                    string emailSubject = customData.emailSubject;
                    string attachmentName = customData.attachmentName;
                    var attachment = new Attachment(stream, attachmentName + ".pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
                    return SendEmail(emailAddress, emailSubject, emailMessage, attachment);
                }
            }
            else if (customData.action == "save parameters")
            {
                /*
                string message = "Save parameters not currently set up ";
                foreach (var parameter in customData.parameters)
                {
                    message += parameter.path;
                    message += parameter.value;
                }
                */
                return new DocumentOperationResponse
                {
                    Succeeded = customData.success,
                    Message = customData.message
                };
            }
            else if (customData.action == "save parameters team")
            {
                /*
                string message = "Save parameters not currently set up ";
                foreach (var parameter in customData.parameters)
                {
                    message += parameter.path;
                    message += parameter.value;
                }
                */
                return new DocumentOperationResponse
                {
                    Succeeded = customData.success,
                    Message = customData.message
                };
            }
            else if (customData.action == "retrieve saved parameters")
            {
                string message = "Retrieve parameters not currently set up";
                return new DocumentOperationResponse
                {
                    Succeeded = customData.success,
                    Message = customData.message
                };
            }
            else if (customData.action == "retrieve saved parameters team")
            {
                return new DocumentOperationResponse
                {
                    Succeeded = customData.success,
                    Message = customData.message
                };
            }
            else if (customData.action == "export to excel")
            {
                try
                {
                    

                    string reportType = customData.reportNameExcel;
                    XtraReport report = ReportsFactory.Reports[reportType]();
                    string reportTitle = Regex.Replace(reportType, @"(?<!^)(?=\p{Lu})", " ");
                    reportTitle = reportTitle.Substring(reportTitle.IndexOf(" ")+1);

                    //string[] parts = url.Split('?');
                    //string parametersString = parts.Length > 1 ? parts[1] : String.Empty;
                    //List<Parameter> para = report.Parameters.Cast<Parameter>().ToList();
                    //var parameters = HttpUtility.ParseQueryString(parametersString);

                    //if (report != null)
                    //{
                    //}
                    //report.Parameters /
                    foreach (dynamic parameterData in customData.reportParameters)
                    {
                        if (parameterData.Name.Value == "DatabaseID")
                        {
                            string user = "reportuser";
                            string password = "Re.port_243";

                            string PulseServerName = "Pulse.Avatar.Local";
                            string PulseDatabaseName = "AvatarPulse";
                            string Pulseuser = "RoyaltyOwnerRelationsUser";
                            string Pulsepassword = "SzCz0tka";


                            DynamicConnectionHandler.ConnectionStringInfo connectionStringParts = new DynamicConnectionHandler.ConnectionStringInfo();
                            int currentDatabaseID = ((int) parameterData.Value.Value);
                            //Get the Database ConnectionString based on plngDatabaseID
                            connectionStringParts = DynamicConnectionHandler.getConnectionStringInfo(currentDatabaseID);
                            report.Parameters["pstrServerName"].Value = connectionStringParts.ServerName;
                            report.Parameters["pstrDatabaseName"].Value = connectionStringParts.DatabaseName;

                            string connectionStringDynamic = @"XpoProvider=MSSqlServer;Data Source=" + report.Parameters["pstrServerName"].Value + "; User ID=" + user + ";Password=" + password + ";Initial Catalog=" + report.Parameters["pstrDatabaseName"].Value + ";Persist Security Info=true;TrustServerCertificate=true;";
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
                        else
                        {
                            report.Parameters[parameterData.Name.Value].Value = parameterData.Value;
                        }

                    }

                    string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),"Downloads");
                    //downloadsPath = Path.Combine(downloadsPath, reportType + ".xlsx");
                    string fileName = $"{reportTitle} {DateTime.Now:MM-dd-yyyy HH mm}.xlsx";
                    downloadsPath = Path.Combine(downloadsPath, fileName);
                    XlsxExportOptions exportOptions = new XlsxExportOptions();
                    exportOptions.TextExportMode = TextExportMode.Value;
                    report.ExportToXlsx(downloadsPath,exportOptions);

                    return new DocumentOperationResponse
                    {
                        Succeeded = true,
                        Message = "Printed to Excel",
                    };
                }
                catch
                {
                    return new DocumentOperationResponse
                    {
                        Succeeded = false,
                        Message = "Error getting report to excel",
                    };
                }
            }
            else
            {
                string message = "Invalid custom operation. Custom Operation set up in ServiceOperations";
                return new DocumentOperationResponse
                {
                    Succeeded = false,
                    Message = "asdf"
                };
            }


        }
        public DocumentOperationResponse customDocumentOperation(DocumentOperationRequest request, PrintingSystemBase initialPrintingSystem, PrintingSystemBase printingSystemWithEditingFields)
        {
            return null;
        }
        DocumentOperationResponse SendEmail(string recipients, string subject, string messageBody, Attachment attachment)
        {
            // There was a repository off the internet that was doing the same thing that I copied from
            // Necessary to get that little message at the bottom of the report viewer whenever a document is sent successfully. Very satisfying.
            string currentRecipient = "";
            string message = "Message could not be sent to:";
            bool SentToEveryone = true;
            List<string> SendTo = recipients.Split(';').ToList();
            foreach(string recipient in SendTo)
            {
                currentRecipient = recipient;
                try
                {
                    EmailSystem.SendEmail(recipient, subject, messageBody, attachment);
                }
                catch (Exception)
                {
                    message += " " + currentRecipient;
                    SentToEveryone = false;
                }
            }
            if (SentToEveryone)
            {
                message = "Message was sent successfully";
                return new DocumentOperationResponse
                {
                    Succeeded = true,
                    Message = message
                };
            }
            return new DocumentOperationResponse
            {
                Succeeded = false,
                Message = message
            };            
        }

        protected string RemoveNewLineSymbols(string value)
        {
            return value;
        }
    }
}