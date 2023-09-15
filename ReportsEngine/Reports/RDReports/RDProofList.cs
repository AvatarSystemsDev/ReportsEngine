using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDProofList : DevExpress.XtraReports.UI.XtraReport
    {
        private double LeaseCashDifferenceGroupSum;
        private double NetCashDifferenceGroupSum;
        public RDProofList()
        {
            InitializeComponent();
            LeaseCashDifferenceGroupSum = 0;
            NetCashDifferenceGroupSum = 0;
            xrLeaseCashDifferenceGroup.PrintOnPage += xrNetCashDifferenceGroupSum_PrintOnPage;
            xrNetCashDifferenceGroup.PrintOnPage += xrNetCashDifferenceGroupSum_PrintOnPage;
            xrLeaseCashDifferenceReport.PrintOnPage += xrLeaseCashDifferenceReport_PrintOnPage;
            xrNetCashDifferenceReport.PrintOnPage += xrNetCashDifferenceReport_PrintOnPage;
        }
        private void RDProofList_BeforePrint(object sender, CancelEventArgs e)
        {
            LeaseCashDifferenceGroupSum = 0;
            NetCashDifferenceGroupSum = 0;
        }
        private void xrLeaseCashDifferenceGroup_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (((XRLabel)sender).Text != "")
            {
                try
                {
                    LeaseCashDifferenceGroupSum += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }
        private void xrNetCashDifferenceGroupSum_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (((XRLabel)sender).Text != "")
            {
                try
                {
                    NetCashDifferenceGroupSum += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }



        private void xrLeaseCashDifferenceReport_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (LeaseCashDifferenceGroupSum <= 0)
            {
                ((XRLabel)sender).Text = LeaseCashDifferenceGroupSum.ToString("N2");
            }
            else
            {
                ((XRLabel)sender).Text = LeaseCashDifferenceGroupSum.ToString("N2");
            }
        }
        private void xrNetCashDifferenceReport_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (NetCashDifferenceGroupSum <= 0)
            {
                ((XRLabel)sender).Text = NetCashDifferenceGroupSum.ToString("N2");
            }
            else
            {
                ((XRLabel)sender).Text = NetCashDifferenceGroupSum.ToString("N2");
            }
        }

    }
}
