using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports
{
    public partial class CloseProfitAndLossPostingRegister : DevExpress.XtraReports.UI.XtraReport
    {
        public CloseProfitAndLossPostingRegister()
        {
            InitializeComponent();
        }

        private void Tablix1_GroupHeaderBand_1_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
