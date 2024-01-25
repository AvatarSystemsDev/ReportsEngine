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

            xrPages.BeforePrint += XrPages_BeforePrint;
            RemittanceDetailBand.BeforePrint += RemittanceDetailBand_BeforePrint;
            CheckBegin.BeforePrint += CheckBegin_BeforePrint;
            CheckBegin.BeforePrint += CheckBegin_BeforePrint;
            CheckEnd.BeforePrint += CheckEnd_BeforePrint;
            xrNonNegotiablePicture.BeforePrint += XrNonNegotiablePicture_BeforePrint;
            xrMICRAccountNumber.BeforePrint += XrMICRAccountNumber_BeforePrint;
            xrMICRTransitNumber.BeforePrint += XrMICRTransitNumber_BeforePrint;
            xrCheckNumber.BeforePrint += XrCheckNumber_BeforePrint;
            BeginningRemittance.BeforePrint += BeginningRemittance_BeforePrint;
            EndRemittance.BeforePrint += EndRemittance_BeforePrint;
            xrPictureBoxLogo.BeforePrint += XrPictureBoxLogo_BeforePrint;
            xrPictureBoxTopSignature.BeforePrint += XrPictureBoxTopSignature_BeforePrint;
            xrPictureBoxBottomSignature.BeforePrint += XrPictureBoxBottomSignature_BeforePrint;
        }

        private void CheckBegin_BeforePrint(object sender, CancelEventArgs e)
        {
            pageCounter = 1;
        }

        private void XrPictureBoxBottomSignature_BeforePrint(object sender, CancelEventArgs e)
        {
            //Parameter TwoSignaturesRequired = this.Parameters["plngIsTwoSignaturesRequired"];
            //Parameter SignPath = this.Parameters["pstrSignPath"];
            //Parameter SecondSignPath = this.Parameters["pstrSecondSignPath"];

            XRPictureBox pictureBox = sender as XRPictureBox;
            var currentRow = this.GetCurrentRow();
            var rowArray = currentRow.YieldArray();
            string imagePathSignature = GetCurrentColumnValue("SignaturePath").ToString();
            string imagePathSecondSignature = GetCurrentColumnValue("SecondSignaturePath").ToString();

            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("WillPrintTwoSignatureLines").ToString() == "True";

            //bool TwoSignaturesRequiredValue = TwoSignaturesRequired.Description.ToString() == "True";
            if (TwoSignaturesRequiredValue)
            {
                try
                {
                    pictureBox.ImageSource = ImageSource.FromFile(imagePathSecondSignature); // Second Signature
                }
                catch
                {
                    // Probably add some IO error handling here.
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
                    // Probably add some IO error handling here.
                }
            }
        }

        private void XrPictureBoxTopSignature_BeforePrint(object sender, CancelEventArgs e)
        {
            //Parameter TwoSignaturesRequired = this.Parameters["plngIsTwoSignaturesRequired"];
            //Parameter SignPath = this.Parameters["pstrSignPath"];
            var currentRow = this.GetCurrentRow();
            //var rowArray = currentRow.YieldArray();
           
            string imagePath = GetCurrentColumnValue("SignaturePath").ToString(); // Replace with your column name
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("WillPrintTwoSignatureLines").ToString() == "True";
            //bool TwoSignaturesRequiredValue = TwoSignaturesRequired.Description.ToString() == "True";
            if (TwoSignaturesRequiredValue)
            {
                XRPictureBox pictureBox = sender as XRPictureBox;
                try
                {
                    pictureBox.ImageSource = ImageSource.FromFile(imagePath);
                }
                catch
                {
                    // Probably add some IO error handling here.
                }
            }
        }

        private void XrPictureBoxLogo_BeforePrint(object sender, CancelEventArgs e)
        {
            //Parameter p = this.Parameters["pstrLogoPath"];
            XRPictureBox pictureBox = sender as XRPictureBox;

            var currentRow = this.GetCurrentRow();
            var rowArray = currentRow.YieldArray();
            string imagePathLogo = GetCurrentColumnValue("LogoPath").ToString();
            try
            {
                pictureBox.ImageSource = ImageSource.FromFile(imagePathLogo);
            }
            catch
            {
                // Probably add some IO error handling here.
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
            //label.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            label.Visible = pageCounter <= 2; // This will make the check number visible if it is at the top of the form.
        }
        // Also part of the remittance
        private void XrMICRTransitNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            //label.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            label.Visible = pageCounter <= 2; // This will make the check number visible if it is at the top of the form.
        }
        // Also part of the remittance
        private void XrMICRAccountNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            //label.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            label.Visible = pageCounter <= 2; // This will make the check number visible if it is at the top of the form.
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
            Parameter p = this.Parameters["pbooWillPrintDetailOnStub"];
            bool TwoSignaturesRequiredValue = GetCurrentColumnValue("WillPrintDetailOnStub").ToString() == "True";

            band.Visible = TwoSignaturesRequiredValue || pageCounter <= 2; //Only have remittance visible if it is the first page (don't print remittance on subsequent pages).
            //band.Visible = p.Value.ToString() != "False";
        }

        private void XrPages_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page "+pageCounter.ToString();
            pageCounter++;
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
            picture.Visible = pageCounter > 2; // This will make the nonnegotiable image visible if it is at the top of the form. I guess that is the same as void or something. That's the way that was explained to, I have nothing else.
        }

    }
}
