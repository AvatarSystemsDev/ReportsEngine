using DevExpress.Data.Browsing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Emit;

namespace ReportsEngine.Reports.JIBReports
{
    public partial class JIBStatement : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageIndex = 1;
        public JIBStatement()
        {
            InitializeComponent();
            xrPageCounter.BeforePrint += xrPageCounter_BeforePrint;
            pageHeaderBand.BeforePrint += PageHeaderBand_BeforePrint;
            groupFooterBand1.BeforePrint += GroupFooterBand1_BeforePrint;
        }

        private void GroupFooterBand1_BeforePrint(object sender, CancelEventArgs e)
        {
            pageIndex = 1;
        }

        private void PageHeaderBand_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private void xrPageCounter_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageIndex;
            pageIndex++;
        }

    }
}
