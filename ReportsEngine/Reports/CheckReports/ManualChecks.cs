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
                        fontCollection.AddFontFile(HttpContext.Current.Server.MapPath("~/Views/MICRE13B.TTF"));
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

        private void XrCheckNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 2;
        }

        private void XrMICRTransitNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 2;
        }

        private void XrMICRAccountNumber_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 2;
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
        }

        private void XrPages_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageCounter.ToString();
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
            picture.Visible = pageCounter > 2;
        }
    }
}
