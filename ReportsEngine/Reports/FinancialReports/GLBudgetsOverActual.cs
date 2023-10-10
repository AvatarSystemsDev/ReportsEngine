using DevExpress.Drawing.Printing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class GLBudgetsOverActual : DevExpress.XtraReports.UI.XtraReport
    {
        public GLBudgetsOverActual()
        {
            InitializeComponent();
            this.BeforePrint += GLBudgetsOverActual_BeforePrint;
        }
        private void GLBudgetsOverActual_BeforePrint(object sender, CancelEventArgs e)
        {
            if (Convert.ToBoolean(this.Parameters["pbooShowMonthly"].Value))
            {
                this.PaperKind = DXPaperKind.Ledger;
            }
            else
            {
                this.PaperKind = DXPaperKind.Letter;
            }

        }

    }
}
