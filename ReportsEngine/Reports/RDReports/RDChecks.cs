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

namespace ReportsEngine
{
    public partial class RDChecks : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter = 1;
        private bool inRemittance = false;
        public RDChecks()
        {
            InitializeComponent();
            xrMICRAccountNumber.Font = new Font(CustomFontsHelper.GetFamily("MICRE13B"), 12F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
            xrMICRTransitNumber.Font = new Font(CustomFontsHelper.GetFamily("MICRE13B"), 12F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
            xrCheckNumber.Font = new Font(CustomFontsHelper.GetFamily("MICRE13B"), 12F, FontStyle.Regular, GraphicsUnit.Point, ((0)));

            xrPages.BeforePrint += XrPages_BeforePrint;
            RemittanceDetailBand.BeforePrint += RemittanceDetailBand_BeforePrint;
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

        private void XrPictureBoxBottomSignature_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter TwoSignaturesRequired = this.Parameters["plngIsTwoSignaturesRequired"];
            Parameter SignPath = this.Parameters["pstrSignPath"];
            Parameter SecondSignPath = this.Parameters["pstrSecondSignPath"];

            XRPictureBox pictureBox = sender as XRPictureBox;
            bool TwoSignaturesRequiredValue = TwoSignaturesRequired.Value.ToString() == "True";
            if (TwoSignaturesRequiredValue)
            {
                try
                {
                    pictureBox.ImageSource = ImageSource.FromFile(SecondSignPath.Value.ToString());
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
                    pictureBox.ImageSource = ImageSource.FromFile(SignPath.Value.ToString());
                }
                catch
                {
                    // Probably add some IO error handling here.
                }
            }
        }

        private void XrPictureBoxTopSignature_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter TwoSignaturesRequired = this.Parameters["plngIsTwoSignaturesRequired"];
            Parameter SignPath = this.Parameters["pstrSignPath"];
            bool TwoSignaturesRequiredValue = TwoSignaturesRequired.Value.ToString() == "True";
            if (TwoSignaturesRequiredValue)
            {
                XRPictureBox pictureBox = sender as XRPictureBox;
                try
                {
                    pictureBox.ImageSource = ImageSource.FromFile(SignPath.Value.ToString());
                }
                catch
                {
                    // Probably add some IO error handling here.
                }
            }
        }

        private void XrPictureBoxLogo_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["pstrLogoPath"];
            XRPictureBox pictureBox = sender as XRPictureBox;
            try
            {
                pictureBox.ImageSource = ImageSource.FromFile(p.Value.ToString());
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

        private class CustomFontsHelper
        {
            static PrivateFontCollection fontCollection;
            public static FontCollection FontCollection
            {
                get
                {
                    if (fontCollection == null)
                    {
                        fontCollection = new PrivateFontCollection();
                        fontCollection.AddFontFile(HttpContext.Current.Server.MapPath("~/Views/MICRE13B.TTF")); // I don't think this works anyway. Whatever...
                    }
                    return fontCollection;
                }
            }

            public static FontFamily GetFamily(string familyName)
            {
                return FontCollection.Families.FirstOrDefault(ff => ff.Name == familyName);
            }
        }
        private void CheckBegin_BeforePrint(object sender, CancelEventArgs e)
        {
            pageCounter = 1;
        }
        // This is the first part of the remittance at the bottom of the check.
        private void XrCheckNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["pbooIsCheckOnTopOfForm"];
            bool checkOnTopOfForm = p.Value.ToString() == "True";
            XRLabel label = sender as XRLabel;
            if (!checkOnTopOfForm) {
                label.Visible = pageCounter <= 2; // This will make the check number visible if it is at the top of the form.
            }
            else
            {
                label.Visible = inRemittance; // This will make the check number in that remittance part only print if there is a boolean value for remittance.
            }
        }
        // Also part of the remittance
        private void XrMICRTransitNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["pbooIsCheckOnTopOfForm"];
            bool checkOnTopOfForm = p.Value.ToString() == "True";
            XRLabel label = sender as XRLabel;
            if (!checkOnTopOfForm)
            {
                label.Visible = pageCounter <= 2; // This will make the check number visible if it is at the top of the form.
            }
            else
            {
                label.Visible = inRemittance; // This will make the Transit Number in that remittance part only print if there is a boolean value for remittance, ie at the bottom of the form.
            }
        }
        // Also part of the remittance
        private void XrMICRAccountNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["pbooIsCheckOnTopOfForm"];
            XRLabel label = sender as XRLabel;
            bool checkOnTopOfForm = p.Value.ToString() == "True";
            if (!checkOnTopOfForm)
            {
                label.Visible = pageCounter <= 2; // This will make the check number visible if it is at the top of the form.
            }
            else
            {
                label.Visible = inRemittance; // This will make the Account Number in that remittance part only print if there is a boolean value for remittance.
            }
        }

        private void CheckEnd_BeforePrint(object sender, CancelEventArgs e)
        {
            //pageCounter = 1;
        }


        //private void CheckBeginningHeader_PrintOnPage(object sender, CancelEventArgs e)
        //{
        //    xrNonNegotiablePicture.Visible = true;
        //    pageCounter = 1;
        //}

        private void RemittanceDetailBand_BeforePrint(object sender, CancelEventArgs e)
        {
            DetailBand band = sender as DetailBand;
            Parameter p = this.Parameters["pbooWillPrintDetailOnStub"];
            band.Visible = p.Value.ToString() != "False" || pageCounter <= 2; //Only have remittance visible if it is the first page (don't print remittance on subsequent pages).
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
            Parameter p = this.Parameters["pbooIsCheckOnTopOfForm"];
            bool checkOnTopOfForm = p.Value.ToString() == "True";
            if (!checkOnTopOfForm)
            {
                picture.Visible = pageCounter > 2; // This will make the nonnegotiable image visible if it is at the top of the form. I guess that is the same as void or something. That's the way that was explained to, I have nothing else.
            }
            else
            {
                picture.Visible = inRemittance; // This will make the nonnegotiable image visible if it is at the bottom of the form.
            }
        }

    }
}
