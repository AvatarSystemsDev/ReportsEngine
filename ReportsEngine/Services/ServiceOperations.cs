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
                var mailAddress = new MailAddress(request.CustomData);
                var recipients = new MailAddressCollection() { mailAddress };
                var attachment = new Attachment(stream, "Emailed Report.pdf", System.Net.Mime.MediaTypeNames.Application.Pdf);
                return SendEmail(recipients, "Avatar Systems Emailed Reports", "Attached is your emailed report", attachment);
            }
        }
        public DocumentOperationResponse customDocumentOperation(DocumentOperationRequest request, PrintingSystemBase initialPrintingSystem, PrintingSystemBase printingSystemWithEditingFields)
        {
            return null;
        }
        DocumentOperationResponse SendEmail(MailAddressCollection recipients, string subject, string messageBody, Attachment attachment)
        {
            // There was a repository off the internet that was doing the same thing that I copied from
            // Necessary to get that little message at the bottom of the report viewer whenever a document is sent successfully. Very satisfying.
            try
            {
                if (attachment == null)
                {
                    EmailSystem.SendEmail(recipients.ToString(), subject, messageBody, attachment);
                    return new DocumentOperationResponse
                    {
                        Succeeded = true,
                        Message = "Null Mail was sent successfully"
                    };
                }
                //smtpClient.Send(message);
                EmailSystem.SendEmail(recipients.ToString(), subject, messageBody, attachment);
                return new DocumentOperationResponse
                {
                    Succeeded = true,
                    Message = "Mail was sent successfully"
                };
                }
                catch (SmtpException e)
                {
                    return new DocumentOperationResponse
                    {
                        Message = "Sending an email message failed."
                    };
                }

        }

        protected string RemoveNewLineSymbols(string value)
        {
            return value;
        }
    }
}