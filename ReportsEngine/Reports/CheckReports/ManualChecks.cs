using DevExpress.Drawing;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Web;

namespace ReportsEngine
{
    public partial class ManualChecks : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter = 1;
        public ManualChecks()
        {
            InitializeComponent();
            xrMICRAccountNumber.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Bold, DXGraphicsUnit.Point);
            xrTransitBottomCheck.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Bold, DXGraphicsUnit.Point);
            xrCheckNumber.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Bold, DXGraphicsUnit.Point);
            xrMICRAccountNumberTwo.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Bold, DXGraphicsUnit.Point);
            xrTransitTopCheck.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Bold, DXGraphicsUnit.Point);
            xrCheckNumberTwo.Font = new DXFont("IDAutomationMICRB10", 12F, DXFontStyle.Bold, DXGraphicsUnit.Point);
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
            xrPictureBoxLogo.PrintOnPage += XrPictureBoxLogo_PrintOnPage;
            xrPictureBoxLogoTwo.PrintOnPage += XrPictureBoxLogo_PrintOnPage;
            xrPictureBoxTopSignature.PrintOnPage += XrPictureBoxTopSignature_PrintOnPage;
            xrPictureBoxBottomSignature.PrintOnPage += XrPictureBoxBottomSignature_PrintOnPage;
            xrPictureBoxTopSignatureTwo.PrintOnPage += XrPictureBoxTopSignatureTwo_PrintOnPage;
            xrPictureBoxBottomSignatureTwo.PrintOnPage += XrPictureBoxBottomSignatureTwo_PrintOnPage;
            xrTransitBottomCheck.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            xrTransitTopCheck.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            CheckStubandBottomCheck.PrintOnPage += CheckStubBandBottomCheck_PrintOnPage;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckStubBandTopCheck_PrintOnPage;
            CheckInformationPart.PrintOnPage += CheckStubBandTopCheck_PrintOnPage;
            CheckCoverPage.PrintOnPage += CheckCoverPage_PrintOnPage;
            xrPageBeginningLabel.PrintOnPage += XrPageBeginningLabel_PrintOnPage;
            CheckTopBand.PrintOnPage += CheckTopBand_PrintOnPage;
            CheckBottomBand.PrintOnPage += CheckBottomBand_PrintOnPage;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckStubBandTopCheck_PrintOnPage1;
            CheckInformationPart.PrintOnPage += CheckStubBandTopCheck_PrintOnPage1;
            CheckStubandBottomCheck.PrintOnPage += CheckStubBandBottomCheck_PrintOnPage1;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckTopBand_PrintOnPage;
            CheckInformationPart.PrintOnPage += CheckTopBand_PrintOnPage;
            xrTopCheckPanel.PrintOnPage += XrTopCheckPanel_PrintOnPage;
            xrEndCoverPage.PrintOnPage += XrEndCoverPage_PrintOnPage;
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
            if (pageCounter <= 1 && OverflowHideValue) // Assuming you want to apply this on the first page
            {
                //band.PageBreak = PageBreak.AfterBand;
            }
            else
            {
                //band.PageBreak = PageBreak.None; // No page break on other pages
            }
        }

        private void CheckStubBandTopCheck_PrintOnPage1(object sender, PrintOnPageEventArgs e)
        {
            SubBand band = sender as SubBand;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
            band.Visible = pageCounter <= 1 || !OverflowHideValue;
            if (pageCounter <= 1 && OverflowHideValue) // Assuming you want to apply this on the first page
            {
                //band.PageBreak = PageBreak.AfterBand;
            }
            else
            {
                //band.PageBreak = PageBreak.None; // No page break on other pages
            }
        }

        private void CheckBottomBand_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            SubBand band = sender as SubBand;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
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
            if (pageCounter <= 2 && OverflowHideValue) // Assuming you want to apply this on the first page
            {
                //band.PageBreak = PageBreak.BeforeBand;
            }
            else
            {
                //band.PageBreak = PageBreak.None; // No page break on other pages
            }
        }

        private void CheckBegin_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void XrPictureBoxBottomSignature_PrintOnPage(object sender, PrintOnPageEventArgs e)
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

        private void XrPictureBoxBottomSignatureTwo_PrintOnPage(object sender, PrintOnPageEventArgs e)
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

        private void XrPictureBoxTopSignature_PrintOnPage(object sender, PrintOnPageEventArgs e)
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

        private void XrPictureBoxTopSignatureTwo_PrintOnPage(object sender, PrintOnPageEventArgs e)
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

        private void XrPictureBoxLogo_PrintOnPage(object sender, PrintOnPageEventArgs e)
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
            label.Text = "Page " + pageCounter.ToString();
        }

        private void XrNonNegotiablePicture_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRPictureBox picture = sender as XRPictureBox;
            picture.Visible = pageCounter > 1; // This will make the nonnegotiable image visible if it is at the top of the form. I guess that is the same as void or something. That's the way that was explained to me, I have nothing else.
        }

    }
}
