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
            xrCheckEnderLabel.PrintOnPage += XrCheckEnderLabel_PrintOnPage;
            //xrNonNegotiablePicture.BeforePrint += XrNonNegotiablePicture_BeforePrint;
        }

        private void CheckBegin_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }
        private void XrCheckEnderLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void XrPages_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageCounter.ToString();
            pageCounter++;
        }

        //private void XrNonNegotiablePicture_BeforePrint(object sender, CancelEventArgs e)
        //{
        //    XRPictureBox picture = sender as XRPictureBox;
        //    picture.Visible = pageCounter > 2;
        //}

    }
}
