using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class SummaryWithholding : DevExpress.XtraReports.UI.XtraReport
    {
        private int VendorCount;
        public SummaryWithholding()
        {
            InitializeComponent();
            xrVendorTotal.AfterPrint += xrTotalVendor_AfterPrint;
            xrVendorCount.PrintOnPage += XrVendorCount_PrintOnPage;
        }

        private void XrVendorCount_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            ((XRLabel)sender).Text = VendorCount.ToString("N0");
        }

        private void xrTotalVendor_AfterPrint(object sender, EventArgs e)
        {
            XRLabel label = sender as XRLabel;
            try
            { 
                VendorCount += 1;
            }
            catch
            {

            }
        }

        private void SummaryWithholding_BeforePrint(object sender, CancelEventArgs e)
        {
            VendorCount = 0;
        }
    }
}
