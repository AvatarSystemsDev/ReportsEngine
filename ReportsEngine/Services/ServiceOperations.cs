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
            string SmtpHost = "smtp.office365.com";
            int SmtpPort = 25;
            if (string.IsNullOrEmpty(SmtpHost) || SmtpPort == -1)
            {
                return new DocumentOperationResponse { Message = "Please configure the SMTP server settings." };
            }

            string SmtpUserName = "CFox@avatarcloud.net";
            string SmtpUserPassword = "CMF_187559"; // Password not used for anything else. Knock yourself out.
            string SmtpFrom = "CFox@avatarcloud.net";
            string SmtpFromDisplayName = "Carter Fox Avatar Systems";
            using (var smtpClient = new SmtpClient(SmtpHost, SmtpPort))
            {
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;

                if (!string.IsNullOrEmpty(SmtpUserName))
                {
                    smtpClient.Credentials = new NetworkCredential(SmtpUserName, SmtpUserPassword);
                }

                using (var message = new MailMessage())
                {
                    message.Subject = subject.Replace("\r", "").Replace("\n", "");
                    message.IsBodyHtml = true;
                    message.Body = messageBody;
                    message.From = new MailAddress(SmtpFrom, SmtpFromDisplayName);

                    foreach (var item in recipients)
                    {
                        message.To.Add(item);
                    }

                    try
                    {
                        if (attachment != null)
                        {
                            message.Attachments.Add(attachment);
                        }
                        smtpClient.Send(message);
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
                    finally
                    {
                        message.Attachments.Clear();
                    }
                }
            }
        }

        protected string RemoveNewLineSymbols(string value)
        {
            return value;
        }
    }
}