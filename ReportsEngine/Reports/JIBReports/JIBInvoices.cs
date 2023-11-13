using DevExpress.CodeParser;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class JIBInvoices : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageIndex = 1;
        public JIBInvoices()
        {
            InitializeComponent();
            xrPageCounter.BeforePrint += xrPageCounter_BeforePrint;
            pageHeaderBand1.BeforePrint += PageHeaderBand_BeforePrint;
            OwnerGroup.BeforePrint += OwnerGroup_BeforePrint;
        }

        private void OwnerGroup_BeforePrint(object sender, CancelEventArgs e)
        {
            pageIndex = 1;
        }

        private void PageHeaderBand_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private void xrPageCounter_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = ""+pageIndex;
            pageIndex++;
        }

    }
}
