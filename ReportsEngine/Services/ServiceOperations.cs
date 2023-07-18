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
            else if (customData.action == "export to excel")
            {
                try
                {
                    const string fileDownloadPath = "C:\\AvatarSystemsRepository\\TemporaryReportDownloadFiles\\";
                    System.IO.Directory.CreateDirectory(fileDownloadPath);
                    var allFiles = System.IO.Directory.GetFiles(fileDownloadPath, "*", System.IO.SearchOption.AllDirectories);
                    string fileName = allFiles.Count().ToString();
                    string fileDownloadName = fileDownloadPath + fileName;

                    string reportType = customData.reportNameExcel;
                    XtraReport report = ReportsFactory.Reports[reportType]();
                    int companyID = customData.CompanyID;
                    string parameters = customData.reportParameters.ToString();

                    CustomReportStorageWebExtension.setReportParameters(report, HttpUtility.ParseQueryString(parameters), companyID);

                    XlsxExportOptions exportOptions = new XlsxExportOptions();
                    //exportOptions.TextExportMode = TextExportMode.Value;
                    exportOptions.ShowGridLines = true;

                    report.ExportToXlsx(fileDownloadName, exportOptions);

                    return new DocumentOperationResponse
                    {
                        Succeeded = true,
                        Message = "Printed to Excel",
                        CustomData = fileName,
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
                    Message = message,
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