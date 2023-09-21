using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.MDReports
{
    public partial class CashRequirements : DevExpress.XtraReports.UI.XtraReport
    {
        private double positiveVendorTotals;
        public CashRequirements()
        {
            InitializeComponent();
            xrVendorTotal.PrintOnPage += xrVendorTotal_PrintOnPage;
            xrGrandTotal.PrintOnPage += xrGrandTotal_PrintOnPage;
        }

        private void CashRequirements_BeforePrint(object sender, CancelEventArgs e)
        {
            positiveVendorTotals = 0;
        }

        private void xrVendorTotal_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (((XRLabel)sender).Text != "")
            {
                try
                {
                    double vendorAmount = Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                    if (vendorAmount>0) {
                        positiveVendorTotals += vendorAmount;
                    }
                }
                catch
                {

                }
            }
        }

        private void xrGrandTotal_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            ((XRLabel)sender).Text = positiveVendorTotals.ToString("N2");
        }
    }
}
