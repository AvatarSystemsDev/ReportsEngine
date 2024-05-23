using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Drawing;
using System.ComponentModel;
using DevExpress.Drawing;
using Band = DevExpress.XtraReports.UI.Band;
using System;
using DevExpress.DataAccess.DataFederation;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using ReportsEngine.Services;
using WebMatrix.Data;
using System.ServiceModel;

namespace ReportsEngine
{
    public partial class RDChecks : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter = 1;
        private static readonly string ReportUser = Environment.GetEnvironmentVariable("Report_User", EnvironmentVariableTarget.Machine) ?? "reportuser";
        private static readonly string ReportUserPassword = Environment.GetEnvironmentVariable("Report_User_Password", EnvironmentVariableTarget.Machine) ?? "Re.port_243";
        public RDChecks() : this(0, 0)
        {

        }
        public RDChecks(int databaseID = 0, int companyID = 0)
        {
            InitializeComponent();
            LoadOverflowOptionCodeID(databaseID, companyID);
            xrMICRAccountNumber.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrTransitBottomCheck.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrCheckNumber.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrMICRAccountNumberTwo.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrTransitTopCheck.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrCheckNumberTwo.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrPages.PrintOnPage += XrPages_PrintOnPage;
            RemittanceDetailBand.PrintOnPage += RemittanceDetailBand_PrintOnPage;
            CheckBegin.PrintOnPage += CheckBegin_PrintOnPage;
            xrNonNegotiablePicture.PrintOnPage += XrNonNegotiablePicture_PrintOnPage;
            xrNonNegotiablePictureTwo.PrintOnPage += XrNonNegotiablePicture_PrintOnPage;
            xrMICRAccountNumber.PrintOnPage += XrMICRAccountNumber_PrintOnPage;
            xrTransitBottomCheck.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            xrCheckNumber.PrintOnPage += XrCheckNumber_PrintOnPage;
            xrMICRAccountNumberTwo.PrintOnPage += XrMICRAccountNumber_PrintOnPage;
            xrTransitTopCheck.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            xrCheckNumberTwo.PrintOnPage += XrCheckNumber_PrintOnPage;
            xrPictureBoxLogo.BeforePrint += XrPictureBoxLogo_BeforePrint;
            xrPictureBoxLogoTwo.BeforePrint += XrPictureBoxLogo_BeforePrint;
            xrPictureBoxTopSignature.BeforePrint += XrPictureBoxTopSignature_BeforePrint;
            xrPictureBoxBottomSignature.BeforePrint += XrPictureBoxBottomSignature_BeforePrint;
            xrPictureBoxTopSignatureTwo.BeforePrint += XrPictureBoxTopSignatureTwo_BeforePrint;
            xrPictureBoxBottomSignatureTwo.BeforePrint += XrPictureBoxBottomSignatureTwo_BeforePrint;
            xrTransitBottomCheck.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            xrTransitTopCheck.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            CheckStubBandBottomCheck.PrintOnPage += CheckStubBandBottomCheck_PrintOnPage;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckStubBandTopCheck_PrintOnPage;
            CheckInformationPart.PrintOnPage += CheckStubBandTopCheck_PrintOnPage;
            CheckCoverPage.PrintOnPage += CheckCoverPage_PrintOnPage;
            xrPageBeginningLabel.PrintOnPage += XrPageBeginningLabel_PrintOnPage;
            xrCheckEnderLabel.PrintOnPage += XrCheckEnderLabel_PrintOnPage;
            CheckTopBand.PrintOnPage += CheckTopBand_PrintOnPage;
            CheckBottomBand.PrintOnPage += CheckBottomBand_PrintOnPage;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckStubBandTopCheck_PrintOnPage1;
            CheckInformationPart.PrintOnPage += CheckStubBandTopCheck_PrintOnPage1;
            CheckStubBandBottomCheck.PrintOnPage += CheckStubBandBottomCheck_PrintOnPage1;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckTopBand_PrintOnPage;
            CheckInformationPart.PrintOnPage += CheckTopBand_PrintOnPage;
            xrTopCheckPanel.PrintOnPage += XrTopCheckPanel_PrintOnPage;
            xrEndCoverPage.PrintOnPage += XrEndCoverPage_PrintOnPage;
            //CheckBeginningHeader.RepeatEveryPage = OverflowOptionCodeIDValue == "1";
            //CheckGroupBottom.RepeatEveryPage = OverflowOptionCodeIDValue == "1";
        }

        private void LoadOverflowOptionCodeID(int databaseID, int companyID)
        {
            if (databaseID != 0)
            {
                DynamicConnectionHandler.ConnectionStringInfo connectionStringParts = DynamicConnectionHandler.getConnectionStringInfo((int)databaseID);
                //Get the Database ConnectionString based on plngDatabaseID
                string connectionStringDynamic = $"Data Source={connectionStringParts.ServerName}; User ID={ReportUser}; Password={ReportUserPassword}; Initial Catalog={connectionStringParts.DatabaseName}; Persist Security Info=true; TrustServerCertificate=true;";

                using (SqlConnection connection = new SqlConnection(connectionStringDynamic))
                {
                    using (SqlCommand command = new SqlCommand("CheckFormattingOptions_ReportLookup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.Add(new SqlParameter("@plngCompanyID", SqlDbType.Int)).Value = companyID;
                        command.Parameters.Add(new SqlParameter("@plngCheckTypeCode", SqlDbType.Int)).Value = 2;
                        command.Parameters.Add(new SqlParameter("@plngDatabaseID", SqlDbType.Int)).Value = databaseID;
                        command.Parameters.Add(new SqlParameter("@plngCompanyCheckPrintingFormatID", SqlDbType.Int)).Value = 0;
                        command.Parameters.Add(new SqlParameter("@plngCheckPrintingFormatID", SqlDbType.Int)).Value = 0;

                        connection.Open();
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Assuming OverflowOptionCodeID is a column in the result set
                                    var overflowOptionCodeID = reader["OverflowOptionCodeID"].ToString();

                                    // Using the retrieved value to set RepeatEveryPage properties
                                    CheckBeginningHeader.RepeatEveryPage = overflowOptionCodeID == "1";
                                    CheckGroupBottom.RepeatEveryPage = overflowOptionCodeID == "1";
                                }
                            }
                        }
                        catch (SystemException ex)
                        {
                            throw new FaultException("Could not get report data." + ex.Message);
                        }
                    }
                }
            }
        }

        private void XrEndCoverPage_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void XrTopCheckPanel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRPanel XrPanel = sender as XRPanel;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
            XrPanel.Visible = pageCounter <= 1 || !OverflowHideValue;
        }

        private void CheckStubBandBottomCheck_PrintOnPage1(object sender, PrintOnPageEventArgs e)
        {
            SubBand band = sender as SubBand;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
            band.Visible = pageCounter <= 1 || !OverflowHideValue;
        }

        private void CheckStubBandTopCheck_PrintOnPage1(object sender, PrintOnPageEventArgs e)
        {
            SubBand band = sender as SubBand;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
            band.Visible = pageCounter <= 1 || !OverflowHideValue;
        }

        private void CheckBottomBand_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            GroupBand band = sender as GroupBand;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            band.RepeatEveryPage = OverflowOptionCodeIDValue == "1";
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
            band.Visible = pageCounter <= 1 || !OverflowHideValue;
        }

        private void CheckTopBand_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Band band = sender as Band; 
            string OverflowOptionCodeID = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowOptionCodeIDValue = OverflowOptionCodeID == "4" || OverflowOptionCodeID == "3";
            band.Visible = pageCounter <= 1 || !OverflowOptionCodeIDValue;
        }


        private void XrCompanyAddressBlockTopCheck_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            bool WillPrintCompanyAddressOnStubValue = GetCurrentColumnValue("WillPrintCompanyAddressOnStub") is null ? false : GetCurrentColumnValue("WillPrintCompanyAddressOnStub").ToString() == "True";
            label.Visible = pageCounter > 1 || WillPrintCompanyAddressOnStubValue;
        }

        private void XrCheckEnderLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void XrPageBeginningLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter++;
        }

        private void CheckStubBandTopCheck_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Band band = sender as Band;
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("IsCheckOnTopOfForm") is null ? false : GetCurrentColumnValue("IsCheckOnTopOfForm").ToString() == "True";
            band.Visible = TwoSignaturesRequiredValue && pageCounter > 2;
        }

        private void CheckCoverPage_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void CheckStubBandBottomCheck_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Band band = sender as Band;
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("IsCheckOnTopOfForm") is null ? false : GetCurrentColumnValue("IsCheckOnTopOfForm").ToString() == "False";
            band.Visible = TwoSignaturesRequiredValue && pageCounter > 2;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
        }

        private void CheckBegin_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
           pageCounter = 1;
        }

        private void XrPictureBoxBottomSignature_BeforePrint(object sender, CancelEventArgs e)
        {
            XRPictureBox pictureBox = sender as XRPictureBox;
            var column = GetCurrentColumnValue("SignaturePath");
            string imagePathSecondSignature = column is null ? "" : column.ToString();
            try
            {
                pictureBox.ImageSource = ImageSource.FromFile(imagePathSecondSignature); // Second Signature
            }
            catch
            {
                // Probably add some error handling here.
            }
        }

        private void XrPictureBoxBottomSignatureTwo_BeforePrint(object sender, CancelEventArgs e)
        {
            XRPictureBox pictureBox = sender as XRPictureBox;
            string imagePathSecondSignature = GetCurrentColumnValue("SignaturePath") is null ? "" : GetCurrentColumnValue("SignaturePath").ToString();
            try
            {
                pictureBox.ImageSource = ImageSource.FromFile(imagePathSecondSignature); // Second Signature
            }
            catch
            {
                // Probably add some error handling here.
            }
        }

        private void XrPictureBoxTopSignature_BeforePrint(object sender, CancelEventArgs e)
        {
            string imagePath = GetCurrentColumnValue("SecondSignaturePath") is null ? "" : GetCurrentColumnValue("SecondSignaturePath").ToString();
            XRPictureBox pictureBox = sender as XRPictureBox;
            try
            {
                pictureBox.ImageSource = ImageSource.FromFile(imagePath);
            }
            catch
            {
                // Probably add some error handling here.
            }
        }

        private void XrPictureBoxTopSignatureTwo_BeforePrint(object sender, CancelEventArgs e)
        {
            string imagePath = GetCurrentColumnValue("SecondSignaturePath") is null ? "" : GetCurrentColumnValue("SecondSignaturePath").ToString();
            XRPictureBox pictureBox = sender as XRPictureBox;
            try
            {
                pictureBox.ImageSource = ImageSource.FromFile(imagePath);
            }
            catch
            {
                // Probably add some error handling here.
            }
        }

        private void XrPictureBoxLogo_BeforePrint(object sender, CancelEventArgs e)
        {
            XRPictureBox pictureBox = sender as XRPictureBox;
            string imagePathLogo = GetCurrentColumnValue("LogoPath") is null ? "" : GetCurrentColumnValue("LogoPath").ToString();
            try
            {
                pictureBox.ImageSource = ImageSource.FromFile(imagePathLogo);
            }
            catch
            {
                // Probably add some error handling here.
            }
        }

        private void XrCheckNumber_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 1; // This will make the check number visible if it is at the top of the form.
        }
        
        private void XrMICRTransitNumber_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 1; // This will make the check number visible if it is at the top of the form.
        }
        
        private void XrMICRAccountNumber_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 1; // This will make the check number visible if it is at the top of the form.
        }

        private void RemittanceDetailBand_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            DetailBand band = sender as DetailBand;
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("WillPrintDetailOnStub") is null ? false : GetCurrentColumnValue("WillPrintDetailOnStub").ToString() == "True";
            band.Visible = TwoSignaturesRequiredValue || pageCounter <= 1; //Only have remittance visible if it is the first page (don't print remittance on subsequent pages).
        }

        private void XrPages_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page "+pageCounter.ToString();
        }

        private void XrNonNegotiablePicture_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRPictureBox picture = sender as XRPictureBox;
            picture.Visible = pageCounter > 1; // This will make the nonnegotiable image visible if it is at the top of the form. I guess that is the same as void or something. That's the way that was explained to me, I have nothing else.
        }

    }
}
