using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class SummaryGeneralLedger : DevExpress.XtraReports.UI.XtraReport
    {
        public SummaryGeneralLedger()
        {
            InitializeComponent();
        }

        private void SummaryGeneralLedger_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
