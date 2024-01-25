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
            xrPages.BeforePrint += XrPages_BeforePrint;
            RemittanceDetailBand.BeforePrint += RemittanceDetailBand_BeforePrint;
            CheckBegin.AfterPrint += CheckBegin_AfterPrint;
            CheckEnd.BeforePrint += CheckEnd_BeforePrint;
            xrNonNegotiablePicture.BeforePrint += XrNonNegotiablePicture_BeforePrint;
            xrNonNegotiablePictureTwo.BeforePrint += XrNonNegotiablePicture_BeforePrint;
            xrMICRAccountNumber.BeforePrint += XrMICRAccountNumber_BeforePrint;
            xrMICRTransitNumber.BeforePrint += XrMICRTransitNumber_BeforePrint;
            xrCheckNumber.BeforePrint += XrCheckNumber_BeforePrint;
            xrMICRAccountNumberTwo.BeforePrint += XrMICRAccountNumber_BeforePrint;
            xrMICRTransitNumberTwo.BeforePrint += XrMICRTransitNumber_BeforePrint;
            xrCheckNumberTwo.BeforePrint += XrCheckNumber_BeforePrint;
            BeginningRemittance.BeforePrint += BeginningRemittance_BeforePrint;
            EndRemittance.BeforePrint += EndRemittance_BeforePrint;
            xrPictureBoxLogo.BeforePrint += XrPictureBoxLogo_BeforePrint;
            xrPictureBoxLogoTwo.BeforePrint += XrPictureBoxLogo_BeforePrint;
            xrPictureBoxTopSignature.BeforePrint += XrPictureBoxTopSignature_BeforePrint;
            xrPictureBoxBottomSignature.BeforePrint += XrPictureBoxBottomSignature_BeforePrint;
            xrPictureBoxTopSignatureTwo.BeforePrint += XrPictureBoxTopSignature_BeforePrint;
            xrPictureBoxBottomSignatureTwo.BeforePrint += XrPictureBoxBottomSignature_BeforePrint;
            xrTransitBottomCheck.BeforePrint += XrMICRTransitNumber_BeforePrint;
            xrTransitTopCheck.BeforePrint += XrMICRTransitNumber_BeforePrint;
            CheckStubBandBottomCheck.BeforePrint += CheckStubBandBottomCheck_BeforePrint;
            CheckStubBandTopCheck.BeforePrint += CheckStubBandTopCheck_BeforePrint;
            PageHeader.BeforePrint += PageHeader_BeforePrint;
            CheckCoverPage.AfterPrint += CheckCoverPage_AfterPrint;
        }

        private void CheckStubBandTopCheck_BeforePrint(object sender, CancelEventArgs e)
        {
            Band band = sender as Band;
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("IsCheckOnTopOfForm").ToString() == "True";
            band.Visible = TwoSignaturesRequiredValue && pageCounter > 1;
        }

        private void CheckCoverPage_AfterPrint(object sender, EventArgs e)
        {
            pageCounter = 1;
        }

        private void PageHeader_BeforePrint(object sender, CancelEventArgs e)
        {
            pageCounter++;
        }

        private void CheckStubBandBottomCheck_BeforePrint(object sender, CancelEventArgs e)
        {
            Band band = sender as Band;
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("IsCheckOnTopOfForm").ToString() == "False";
            band.Visible = TwoSignaturesRequiredValue && pageCounter > 1;
        }

        private void CheckBegin_AfterPrint(object sender, EventArgs e)
        {
            pageCounter = 1;
        }

        private void XrPictureBoxBottomSignature_BeforePrint(object sender, CancelEventArgs e)
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

        private void XrPictureBoxTopSignature_BeforePrint(object sender, CancelEventArgs e)
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

        private void XrPictureBoxLogo_BeforePrint(object sender, CancelEventArgs e)
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
        private void EndRemittance_BeforePrint(object sender, CancelEventArgs e)
        {
            inRemittance = false;
        }

        private void BeginningRemittance_BeforePrint(object sender, CancelEventArgs e)
        {
            inRemittance = true;
        }

        // This is the first part of the remittance at the bottom of the check.
        private void XrCheckNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 1; // This will make the check number visible if it is at the top of the form.
        }
        // Also part of the remittance
        private void XrMICRTransitNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 1; // This will make the check number visible if it is at the top of the form.
        }
        // Also part of the remittance
        private void XrMICRAccountNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 1; // This will make the check number visible if it is at the top of the form.
        }

        private void CheckEnd_BeforePrint(object sender, CancelEventArgs e)
        {
            //pageCounter = 1;
        }


        //private void CheckBeginningHeader_BeforePrint(object sender, CancelEventArgs e)
        //{
        //    xrNonNegotiablePicture.Visible = true;
        //    pageCounter = 1;
        //}

        private void RemittanceDetailBand_BeforePrint(object sender, CancelEventArgs e)
        {
            DetailBand band = sender as DetailBand;
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("WillPrintDetailOnStub").ToString() == "True";

            band.Visible = TwoSignaturesRequiredValue || pageCounter <= 1; //Only have remittance visible if it is the first page (don't print remittance on subsequent pages).
            //band.Visible = p.Value.ToString() != "False";
        }

        private void XrPages_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page "+pageCounter.ToString();
        }

        //private void GroupFooterBand1_BeforePrint(object sender, CancelEventArgs e)
        //{
        //    xrNonNegotiablePicture.Visible = true;
        //}

        //private void RDChecks_BeforePrint(object sender, CancelEventArgs e)
        //{
        //    pageCounter = -1;
        //}

        private void XrNonNegotiablePicture_BeforePrint(object sender, CancelEventArgs e)
        {
            XRPictureBox picture = sender as XRPictureBox;
            picture.Visible = pageCounter > 1; // This will make the nonnegotiable image visible if it is at the top of the form. I guess that is the same as void or something. That's the way that was explained to, I have nothing else.
        }

    }
}
