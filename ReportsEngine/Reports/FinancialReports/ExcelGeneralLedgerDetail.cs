using System.ComponentModel;

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
