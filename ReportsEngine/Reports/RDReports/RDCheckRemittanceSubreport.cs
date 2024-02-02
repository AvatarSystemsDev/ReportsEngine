using DevExpress.XtraReports.Parameters;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDCheckRemittanceSubreport : DevExpress.XtraReports.UI.XtraReport
    {
        public RDCheckRemittanceSubreport()
        {
            InitializeComponent();
            ReportHeader.BeforePrint += ReportHeader_BeforePrint;
        }

        private void ReportHeader_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //int CountedLineItems = int.Parse(GetCurrentColumnValue("CountedLineItems").ToString());
            //int CountedDeductionTypes = int.Parse(GetCurrentColumnValue("CountedImbursementDeductionTypes").ToString());
            //Parameter OverflowOptionCode = this.Parameters["plngOverflowOptionCode"];
            //if (OverflowOptionCode.Value.ToString() == "3" && (CountedLineItems * 2 + CountedDeductionTypes >= 32)) {
                //ReportHeader.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
            //}
        }
    }
}
