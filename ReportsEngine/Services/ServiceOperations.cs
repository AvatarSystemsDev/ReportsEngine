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
using Providence.Common.Data;
using System.Web.WebPages;
using Newtonsoft.Json;

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

            using (var stream = new MemoryStream())
            {
                printingSystemWithEditingFields.ExportToPdf(stream);
                stream.Position = 0;
                //var mailAddress = new MailAddress(request.CustomData);
                //var recipients = new MailAddressCollection() { mailAddress };
                var emailDataJson = request.CustomData; // Assuming request.CustomData is the JSON string
                dynamic emailData = JsonConvert.DeserializeObject(emailDataJson);

                String emailAddress = emailData.emailAddress;
                String emailMessage = emailData.emailMessage;
                String emailSubject = emailData.emailSubject;
                String attachmentName = emailData.attachmentName;
                var attachment = new Attachment(stream, attachmentName + ".pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
                return SendEmail(emailAddress, emailSubject, emailMessage, attachment);
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