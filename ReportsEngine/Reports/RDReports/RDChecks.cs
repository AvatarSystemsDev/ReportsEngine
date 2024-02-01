using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Drawing;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Diagnostics;
using DevExpress.Utils.Extensions;
using DevExpress.Drawing;
using Band = DevExpress.XtraReports.UI.Band;

namespace ReportsEngine
{
    public partial class RDChecks : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter = 1;
        private bool printChecks = false;
        private bool inRemittance = false;
        public RDChecks()
        {
            InitializeComponent();
            xrMICRAccountNumber.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrMICRTransitNumber.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrCheckNumber.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrMICRAccountNumberTwo.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrMICRTransitNumberTwo.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrCheckNumberTwo.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrPages.PrintOnPage += XrPages_PrintOnPage;
            RemittanceDetailBand.PrintOnPage += RemittanceDetailBand_PrintOnPage;
            CheckBegin.PrintOnPage += CheckBegin_PrintOnPage;
            //CheckEnd.PrintOnPage += CheckEnd_PrintOnPage;
            xrNonNegotiablePicture.PrintOnPage += XrNonNegotiablePicture_PrintOnPage;
            xrNonNegotiablePicture.PrintOnPage += XrNonNegotiablePicture_PrintOnPage;
            xrNonNegotiablePictureTwo.PrintOnPage += XrNonNegotiablePicture_PrintOnPage;
            xrMICRAccountNumber.PrintOnPage += XrMICRAccountNumber_PrintOnPage;
            xrMICRTransitNumber.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            xrCheckNumber.PrintOnPage += XrCheckNumber_PrintOnPage;
            xrMICRAccountNumberTwo.PrintOnPage += XrMICRAccountNumber_PrintOnPage;
            xrMICRTransitNumberTwo.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            xrCheckNumberTwo.PrintOnPage += XrCheckNumber_PrintOnPage;
            BeginningRemittance.PrintOnPage += BeginningRemittance_PrintOnPage;
            EndRemittance.PrintOnPage += EndRemittance_PrintOnPage;
            xrPictureBoxLogo.PrintOnPage += XrPictureBoxLogo_PrintOnPage;
            xrPictureBoxLogoTwo.PrintOnPage += XrPictureBoxLogo_PrintOnPage;
            xrPictureBoxTopSignature.PrintOnPage += XrPictureBoxTopSignature_PrintOnPage;
            xrPictureBoxBottomSignature.PrintOnPage += XrPictureBoxBottomSignature_PrintOnPage;
            xrPictureBoxTopSignatureTwo.PrintOnPage += XrPictureBoxTopSignature_PrintOnPage;
            xrPictureBoxBottomSignatureTwo.PrintOnPage += XrPictureBoxBottomSignature_PrintOnPage;
            xrTransitBottomCheck.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            xrTransitTopCheck.PrintOnPage += XrMICRTransitNumber_PrintOnPage;
            CheckStubBandBottomCheck.PrintOnPage += CheckStubBandBottomCheck_PrintOnPage;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckStubBandTopCheck_PrintOnPage;
            CheckInformationPart.PrintOnPage += CheckStubBandTopCheck_PrintOnPage;
            CheckCoverPage.PrintOnPage += CheckCoverPage_PrintOnPage;
            StubEnd.PrintOnPage += StubEnd_PrintOnPage;
            xrPageBeginningLabel.PrintOnPage += XrPageBeginningLabel_PrintOnPage;
            xrCheckEnderLabel.PrintOnPage += XrCheckEnderLabel_PrintOnPage;
            xrCompanyAddressBlockTopCheck.PrintOnPage += XrCompanyAddressBlockTopCheck_PrintOnPage;
            xrCompanyAddressBlockBottomCheck.PrintOnPage += XrCompanyAddressBlockBottomCheck_PrintOnPage;
            CheckTopBand.PrintOnPage += CheckTopBand_PrintOnPage;
            CheckBottomBand.PrintOnPage += CheckBottomBand_PrintOnPage;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckStubBandTopCheck_PrintOnPage1;
            CheckInformationPart.PrintOnPage += CheckStubBandTopCheck_PrintOnPage1;
            CheckStubBandBottomCheck.PrintOnPage += CheckStubBandBottomCheck_PrintOnPage1;
            PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.PrintOnPage += CheckTopBand_PrintOnPage;
            CheckInformationPart.PrintOnPage += CheckTopBand_PrintOnPage;
        }

        private void CheckStubBandBottomCheck_PrintOnPage1(object sender, PrintOnPageEventArgs e)
        {
            Band band = sender as Band;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
            band.Visible = pageCounter <= 1 || !OverflowHideValue;
            if (pageCounter <= 1 && OverflowHideValue) // Assuming you want to apply this on the first page
            {
                band.PageBreak = PageBreak.AfterBand;
            }
            else
            {
                band.PageBreak = PageBreak.None; // No page break on other pages
            }
        }

        private void CheckStubBandTopCheck_PrintOnPage1(object sender, PrintOnPageEventArgs e)
        {
            Band band = sender as Band;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
            band.Visible = pageCounter <= 1 || !OverflowHideValue;
            if (pageCounter <= 1 && OverflowHideValue) // Assuming you want to apply this on the first page
            {
                band.PageBreak = PageBreak.AfterBand;
            }
            else
            {
                band.PageBreak = PageBreak.None; // No page break on other pages
            }
        }

        private void CheckBottomBand_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Band band = sender as Band;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
            band.Visible = pageCounter <= 1 || !OverflowHideValue;
        }

        private void CheckTopBand_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Band band = sender as Band;
            bool OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID").ToString() == "4" || GetCurrentColumnValue("OverflowOptionCodeID").ToString() == "3";
            band.Visible = pageCounter <= 1 || !OverflowOptionCodeIDValue;
        }

        private void XrCompanyAddressBlockBottomCheck_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            bool WillPrintCompanyAddressOnStubValue = GetCurrentColumnValue("WillPrintCompanyAddressOnStub").ToString() == "True";
            label.Visible = pageCounter > 1 || WillPrintCompanyAddressOnStubValue;
        }

        private void XrCompanyAddressBlockTopCheck_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            bool WillPrintCompanyAddressOnStubValue = GetCurrentColumnValue("WillPrintCompanyAddressOnStub").ToString() == "True";
            label.Visible = pageCounter > 1 || WillPrintCompanyAddressOnStubValue;
        }

        private void XrCheckEnderLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 0;
        }

        private void XrPageBeginningLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter++;
        }

        private void StubEnd_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            printChecks = true;
        }

        private void CheckStubBandTopCheck_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Band band = sender as Band;
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("IsCheckOnTopOfForm").ToString() == "True";
            band.Visible = TwoSignaturesRequiredValue && pageCounter > 2;
        }

        private void CheckCoverPage_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 0;
        }

        private void CheckStubBandBottomCheck_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Band band = sender as Band;
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("IsCheckOnTopOfForm").ToString() == "False";
            band.Visible = TwoSignaturesRequiredValue && pageCounter > 2;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            bool OverflowHideValue = OverflowOptionCodeIDValue == "4" || OverflowOptionCodeIDValue == "3";
            if (pageCounter <= 2 && OverflowHideValue) // Assuming you want to apply this on the first page
            {
                band.PageBreak = PageBreak.BeforeBand;
            }
            else
            {
                band.PageBreak = PageBreak.None; // No page break on other pages
            }
        }

        private void CheckBegin_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
           pageCounter = 0;
        }

        private void XrPictureBoxBottomSignature_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRPictureBox pictureBox = sender as XRPictureBox;
            string imagePathSignature = GetCurrentColumnValue("SignaturePath").ToString();
            string imagePathSecondSignature = GetCurrentColumnValue("SecondSignaturePath").ToString();
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("WillPrintTwoSignatureLines").ToString() == "True";
            if (TwoSignaturesRequiredValue)
            {
                try
                {
                    pictureBox.ImageSource = ImageSource.FromFile(imagePathSecondSignature); // Second Signature
                }
                catch
                {
                    // Probably add some error handling here.
                }
            }
            else
            {
                try
                {
                    pictureBox.ImageSource = ImageSource.FromFile(imagePathSignature); // First Signature
                }
                catch
                {
                    // Probably add some error handling here.
                }
            }
        }

        private void XrPictureBoxTopSignature_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            string imagePath = GetCurrentColumnValue("SignaturePath").ToString(); // Replace with your column name
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("WillPrintTwoSignatureLines").ToString() == "True";
            if (TwoSignaturesRequiredValue)
            {
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
        }

        private void XrPictureBoxLogo_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRPictureBox pictureBox = sender as XRPictureBox;
            string imagePathLogo = GetCurrentColumnValue("LogoPath").ToString();
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
            inRemittance = false;
        }

        private void BeginningRemittance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            inRemittance = true;
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
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("WillPrintDetailOnStub").ToString() == "True";
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

        //private XRSubreport CreateRDChecksSubreport(int level, int maxLevel)
        //{
        //    if (level > maxLevel)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        XRSubreport rdChecksSubreport = new XRSubreport();
        //        rdChecksSubreport.ReportSource = new RDChecks(); // Your RDChecks report class
        //        foreach (Parameter param in this.Parameters)
        //        {
        //            // Check if the subreport has this parameter
        //            if (((RDChecks)rdChecksSubreport.ReportSource).Parameters[param.Name] != null)
        //            {
        //                ((RDChecks)rdChecksSubreport.ReportSource).Parameters[param.Name].Value = param.Value;
        //            }
        //        }
        //        // Override specific parameters
        //        ((RDChecks)rdChecksSubreport.ReportSource).Parameters["lngLevel"].Value = level;
        //        ((RDChecks)rdChecksSubreport.ReportSource).Parameters["plngPrintRemittance"].Value = 2;
        //        return rdChecksSubreport;
        //    }
        //}
    }
}
