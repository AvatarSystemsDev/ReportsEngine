using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports
{
    public partial class ExcelGeneralLedgerDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public ExcelGeneralLedgerDetail()
        {
            InitializeComponent();
        }

        private void ExcelGeneralLedgerDetail_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
