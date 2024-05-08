using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using DevExpress.XtraReports.Web.WebDocumentViewer.DataContracts;
using Newtonsoft.Json;
using ReportsEngine.Reports;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using WebApiODataServiceProject;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using DevExpress.XtraCharts.Native;
using DevExpress.Office.Utils;


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
            else if (customData.action == "document archive" || customData.action == "export to pdf")
            {
                using (var stream = new MemoryStream())
                {
                    printingSystemWithEditingFields.ExportToPdf(stream);
                    stream.Position = 0;

                    byte[] documentByteArray = stream.ToArray();
                    String base64String = Convert.ToBase64String(documentByteArray);
                    //var archived = SendToArchiveAsync(stream, systemID, userID);  //If call Providence webservice from here. 
                    string message = "";
                    if (customData.action == "export to pdf")
                    {
                        message = "Saved as PDF";
                    }
                    else if (customData.action == "document archive")
                    {
                        message = "Saved to Archive";
                    }
                    return new DocumentOperationResponse
                    {
                        Succeeded = true,
                        Message = message,
                        CustomData = base64String,
                    };

                    //return SendEmail(emailAddress, emailSubject, emailMessage, attachment);
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
            else if (customData.action == "Out of balance")
            {
                string message = "The General Ledger is out of balance. If you might need to reclose the fiscal year.";
                return new DocumentOperationResponse
                {
                    Succeeded = false,
                    Message = message,
                };
            }
            /// Add custom print
            else if (customData.action == "Custom-Print")
            {
                using (var stream = new MemoryStream())
                {
                    printingSystemWithEditingFields.ExportToPdf(stream);
                    stream.Position = 0;

                    byte[] documentByteArray = stream.ToArray();
                    String base64String = Convert.ToBase64String(documentByteArray);
                    List < KeyValuePair<int, int> > keyValuePagesToTray = new List<KeyValuePair<int, int>>();
                    DocumentDataWithPDFAndKeyValuePairs documentDataWithPDFAndKeyValuePairs = null;
                    try
                    {
                        MemoryStream pdfStream = new MemoryStream(documentByteArray);
                        var pdfReader = new PdfReader(pdfStream);
                        var pdfDocument = new PdfDocument(pdfReader);
                        int numberOfPages = pdfDocument.GetNumberOfPages();

                        int checkTray = customData.checkTray;
                        int coverSheetTray = customData.coverSheetTray;
                        int remittanceTray = customData.remittanceTray;

                        List<int> CheckPages = FindPagesWithText(pdfStream, "PLEASE DETACH THIS REMITTANCE ADVICE BEFORE DEPOSITING CHECK", "Page 1"); // Should be the only pages on check pager. Will not work if this is changed.
                        List<int> CoverSheetPages = FindMissingIndices(numberOfPages, FindPagesWithText(pdfStream, "Page ","")); // Set to empty list if PrintCoverSheet passed is false. Cover Sheets should be the only pages without a page number.
                        // List<int> RemittanceSheetPages = FindMissingIndices(NumberOfPages, (List<int>) CheckPages.Concat(CoverSheetPages)); // I don't think that I need this, but this is how you get the rest of the pages.

                        keyValuePagesToTray = SetPagesToKeyValuePairList(numberOfPages, CheckPages, CoverSheetPages, checkTray, coverSheetTray, remittanceTray);

                        documentDataWithPDFAndKeyValuePairs = new DocumentDataWithPDFAndKeyValuePairs(base64String, keyValuePagesToTray);
 
                    }
                    catch
                    {
                        return new DocumentOperationResponse
                        {
                            Succeeded = false,
                            Message = "PDF parsing unsuccessful",
                            CustomData = JsonConvert.SerializeObject(new DocumentDataWithPDFAndKeyValuePairs(base64String, keyValuePagesToTray)),
                        };
                    }
                    //var archived = SendToArchiveAsync(stream, systemID, userID);  //If call Providence webservice from here. 
                    //string message = "Sent to Printer";
                    return new DocumentOperationResponse
                    {
                        Succeeded = true,
                        //Message = message,
                        CustomData = JsonConvert.SerializeObject(documentDataWithPDFAndKeyValuePairs),
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
        public static DocumentOperationResponse GeneralLedgerOutOfBalance()
        {
            string message = "The General Ledger is out of balance. If you might need to reclose the fiscal year.";
            return new DocumentOperationResponse
            {
                Succeeded = false,
                Message = message
            };
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
            foreach (string recipient in SendTo)
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

        //Trying to call the providence webservice from this webservice.
        //public async Task<HttpResponseMessage> SendToArchiveAsync(MemoryStream memoryStream, int systemID, int userID)
        //{
        //    HttpClient client = new HttpClient();
        //    MultipartFormDataContent multipartContent = new MultipartFormDataContent();

        //    byte[] buffer = memoryStream.ToArray();

        //    multipartContent.Add(new ByteArrayContent(buffer));

        //    HttpResponseMessage response = await client.PostAsync(
        //"http://localhost:58170/PostFileToStorage?systemID=" + systemID + "&userID=" + userID, multipartContent).ConfigureAwait(continueOnCapturedContext: false);

        //    return response;
        //}

        protected string RemoveNewLineSymbols(string value)
        {
            return value;
        }
        private List<int> FindPagesWithText(MemoryStream pdfStream, string searchText, string searchTextTwo)
        {
            List<int> pagesWithText = new List<int>();

            // Make sure to reset the position of the stream before reading
            pdfStream.Position = 0;

            using (var pdfReader = new PdfReader(pdfStream))
            using (var pdfDocument = new PdfDocument(pdfReader))
            {
                int numberOfPages = pdfDocument.GetNumberOfPages();

                for (int i = 1; i <= numberOfPages; i++)
                {
                    var page = pdfDocument.GetPage(i);
                    var text = PdfTextExtractor.GetTextFromPage(page, new SimpleTextExtractionStrategy());

                    if (text.Contains(searchText) && text.Contains(searchTextTwo))
                    {
                        pagesWithText.Add(i);
                    }
                }
            }

            return pagesWithText;
        }
        // This finds every page index that does not exist in pagesWithText from 1 to the number of Pages. Kind of like 
        private List<int> FindMissingIndices(int numberOfPages, List<int> pagesWithText)
        {
            HashSet<int> pagesWithTextSet = new HashSet<int>(pagesWithText);
            List<int> missingIndices = new List<int>();

            for (int i = 1; i <= numberOfPages; i++)
            {
                if (!pagesWithTextSet.Contains(i))
                {
                    missingIndices.Add(i);
                }
            }

            return missingIndices;
        }
        // Pages are keys, values are sheet types
        private List<KeyValuePair<int, int>> SetPagesToKeyValuePairList(int numberOfPages, List<int> CheckPages, List<int> CoverSheetPages, int checkTray, int coverSheetTray, int remittanceTray)
        {
            List<KeyValuePair<int, int>> keyValuePairList = new List<KeyValuePair<int, int>>();
            for (int i = 1; i <= numberOfPages; i++)
            {
                if (CheckPages.Contains(i))
                {
                    keyValuePairList.Add(new KeyValuePair<int, int>(i, checkTray));
                }
                else if (CoverSheetPages.Contains(i))
                {
                    keyValuePairList.Add(new KeyValuePair<int, int>(i, coverSheetTray));
                }
                else
                {
                    keyValuePairList.Add(new KeyValuePair<int, int>(i, remittanceTray));
                }
            }
            return keyValuePairList;
        }
        // This is for Custom-Print. I want to serialize the PDF String and also the key value
        private class DocumentDataWithPDFAndKeyValuePairs
        {

            public DocumentDataWithPDFAndKeyValuePairs(string base64String, List<KeyValuePair<int, int>> keyValuePagesToTray)
            {
                this.Base64String = base64String;
                this.keyValuePagesToTray = keyValuePagesToTray;
            }

            public String Base64String { get; set; }
            public List<KeyValuePair<int, int>> keyValuePagesToTray { get; set; }
        }

    }
}