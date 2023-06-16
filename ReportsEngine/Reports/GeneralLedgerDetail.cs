using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports
{
    public partial class GeneralLedgerDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public GeneralLedgerDetail()
        {
            InitializeComponent();
        }

        private void GeneralLedgerDetail_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
