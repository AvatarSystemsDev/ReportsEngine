using DevExpress.Drawing;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDCheckStubs : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter = 1;
        public RDCheckStubs()
        {
            InitializeComponent();

            xrPages.PrintOnPage += XrPages_PrintOnPage;
            CheckBegin.PrintOnPage += CheckBegin_PrintOnPage;
            CheckCoverPage.PrintOnPage += CheckCoverPage_PrintOnPage;
            xrPageBeginningLabel.PrintOnPage += XrPageBeginningLabel_PrintOnPage;
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
            pageCounter = 1;
        }

        private void XrPageBeginningLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter++;
        }

        private void CheckCoverPage_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void CheckBegin_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
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
