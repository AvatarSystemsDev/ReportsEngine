using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.JIBReports
{
    public partial class ExcelJIBClearedItems : DevExpress.XtraReports.UI.XtraReport
    {
        public ExcelJIBClearedItems()
        {
            InitializeComponent();
        }

        private void Tablix1_GroupHeaderBand_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
