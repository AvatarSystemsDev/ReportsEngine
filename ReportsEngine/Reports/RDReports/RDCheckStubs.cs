using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDCheckStubs : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter;
        public RDCheckStubs()
        {
            InitializeComponent();

            xrPages.BeforePrint += XrPages_BeforePrint;
            CheckBegin.BeforePrint += CheckBegin_BeforePrint;
            CheckEnd.BeforePrint += CheckEnd_BeforePrint;
            //xrNonNegotiablePicture.BeforePrint += XrNonNegotiablePicture_BeforePrint;
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


        private void RemittanceDetailBand_BeforePrint(object sender, CancelEventArgs e)
        {
        }

        private void XrPages_BeforePrint(object sender, CancelEventArgs e)
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
