﻿using DevExpress.Drawing;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.APReports
{
    public partial class APCheckStubs : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter = 0;
        private int OverflowOptionCodeID = 1;
        public APCheckStubs()
        {
            InitializeComponent();
            xrPages.PrintOnPage += XrPages_PrintOnPage;
            RemittanceDetailBand.PrintOnPage += RemittanceDetailBand_PrintOnPage;
            CheckBegin.PrintOnPage += CheckBegin_PrintOnPage;
            xrNonNegotiablePicture.PrintOnPage += XrNonNegotiablePicture_PrintOnPage;
            xrNonNegotiablePictureTwo.PrintOnPage += XrNonNegotiablePicture_PrintOnPage;
            BeginningRemittance.PrintOnPage += BeginningRemittance_PrintOnPage;
            EndRemittance.PrintOnPage += EndRemittance_PrintOnPage;
            xrPictureBoxLogo.PrintOnPage += XrPictureBoxLogo_PrintOnPage;
            xrPictureBoxLogoTwo.PrintOnPage += XrPictureBoxLogo_PrintOnPage;
            CheckStubBandBottomCheck.PrintOnPage += CheckStubBandBottomCheck_PrintOnPage;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckStubBandTopCheck_PrintOnPage;
            CheckInformationPart.PrintOnPage += CheckStubBandTopCheck_PrintOnPage;
            CheckCoverPage.PrintOnPage += CheckCoverPage_PrintOnPage;
            StubEnd.PrintOnPage += StubEnd_PrintOnPage;
            xrPageBeginningLabel.PrintOnPage += XrPageBeginningLabel_PrintOnPage;
            CheckTopBand.PrintOnPage += CheckTopBand_PrintOnPage;
            CheckBottomBand.PrintOnPage += CheckBottomBand_PrintOnPage;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckStubBandTopCheck_PrintOnPage1;
            CheckInformationPart.PrintOnPage += CheckStubBandTopCheck_PrintOnPage1;
            CheckStubBandBottomCheck.PrintOnPage += CheckStubBandBottomCheck_PrintOnPage1;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckTopBand_PrintOnPage;
            CheckInformationPart.PrintOnPage += CheckTopBand_PrintOnPage;
            xrTopCheckPanel.PrintOnPage += XrTopCheckPanel_PrintOnPage;
            CheckBeginningHeader.BeforePrint += CheckBeginningHeader_BeforePrint;
            CheckGroupBottom.BeforePrint += CheckGroupBottom_BeforePrint;
            EndRemittance.BeforePrint += EndRemittance_BeforePrint;
            EntryBegin.BeforePrint += EntryBegin_BeforePrint;
            xrEndCoverPage.PrintOnPage += XrEndCoverPage_PrintOnPage;
            CheckGroupBottom.BeforePrint += CheckBottomBand_BeforePrint;
        }

        private void CheckBottomBand_BeforePrint(object sender, CancelEventArgs e)
        {
            GroupFooterBand band = sender as GroupFooterBand;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            band.RepeatEveryPage = OverflowOptionCodeIDValue == "1";
        }

        private void XrEndCoverPage_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 0;
        }

        private void EndRemittance_BeforePrint(object sender, CancelEventArgs e)
        {
        }

        private void EntryBegin_BeforePrint(object sender, CancelEventArgs e)
        {
            //lastDetail = int.Parse(GetCurrentColumnValue("RecordCount").ToString());
            object temp = GetCurrentColumnValue("OverflowOptionCodeID");
            bool success = int.TryParse(temp?.ToString(), out int result);
            OverflowOptionCodeID = success ? result : 1;
            //CheckGroupBottom.PrintAtBottom = OverflowOptionCodeID == 1 || OverflowOptionCodeID == 2;
        }

        private void CheckGroupBottom_BeforePrint(object sender, CancelEventArgs e)
        {
            //GroupBand CheckGroupBottom = sender as GroupBand;
            //CheckGroupBottom.RepeatEveryPage = OverflowOptionCodeID == 1 || OverflowOptionCodeID == 2;
            //CheckGroupBottom.Visible = checkIndex <= lastDetail;
        }

        private void CheckBeginningHeader_BeforePrint(object sender, CancelEventArgs e)
        {
            //GroupBand CheckGroupTop = sender as GroupBand;
            //CheckGroupTop.RepeatEveryPage = OverflowOptionCodeID == 1 || OverflowOptionCodeID == 2;
            //CheckGroupTop.Visible = checkIndex <= lastDetail;
        }

        //private void RDChecksRemittanceOnly_BeforePrint(object sender, CancelEventArgs e)
        //{
        //    CheckGroupBottom.RepeatEveryPage = false;
        //    CheckBeginningHeader.RepeatEveryPage = false;
        //}

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

        private void StubEnd_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
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
            pageCounter = 0;
        }

        private void XrPictureBoxBottomSignature_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRPictureBox pictureBox = sender as XRPictureBox;
            string imagePathSecondSignature = GetCurrentColumnValue("SecondSignaturePath") is null ? "" : GetCurrentColumnValue("SecondSignaturePath").ToString();
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
            string imagePathSecondSignature = GetCurrentColumnValue("SecondSignaturePath") is null ? "" : GetCurrentColumnValue("SecondSignaturePath").ToString();
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
            string imagePath = GetCurrentColumnValue("SignaturePath") is null ? "" : GetCurrentColumnValue("SignaturePath").ToString();
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
            string imagePath = GetCurrentColumnValue("SignaturePath") is null ? "" : GetCurrentColumnValue("SignaturePath").ToString();
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

        private void EndRemittance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {

        }

        private void BeginningRemittance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
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
