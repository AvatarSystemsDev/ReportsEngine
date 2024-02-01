using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDChecksRemittanceOnly : DevExpress.XtraReports.UI.XtraReport
    {
        int pageCounter = 2;
        public RDChecksRemittanceOnly()
        {
            InitializeComponent();
            xrPages.PrintOnPage += XrPages_PrintOnPage;
            this.BeforePrint += RDChecksRemittanceOnly_BeforePrint;
            xrEndOfRemittanceLabel.PrintOnPage += xrEndOfRemittanceLabel_PrintOnPage;
        }

        private void xrEndOfRemittanceLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 2;
        }

        private void RDChecksRemittanceOnly_BeforePrint(object sender, CancelEventArgs e)
        {
            pageCounter = 2;
        }

        private void XrPages_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageCounter.ToString();
            pageCounter++;
        }

    }
}
