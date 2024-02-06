using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDCheckRemittanceSubreport : DevExpress.XtraReports.UI.XtraReport
    {
        public RDCheckRemittanceSubreport()
        {
            InitializeComponent();
            ReportHeader.PrintOnPage += ReportHeader_PrintOnPage;
        }

        private void ReportHeader_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            int CountedLineItems = int.Parse(GetCurrentColumnValue("CountedLineItems") is null ? "0" : GetCurrentColumnValue("CountedLineItems").ToString());
            int CountedDeductionTypes = int.Parse(GetCurrentColumnValue("CountedImbursementDeductionTypes") is null ? "0" : GetCurrentColumnValue("CountedImbursementDeductionTypes").ToString());
            Parameter OverflowOptionCode = this.Parameters["plngOverflowOptionCode"];
            if (OverflowOptionCode is object && OverflowOptionCode.Value.ToString() == "3" && (CountedLineItems * 2 + CountedDeductionTypes >= 32))
            {
                //ReportHeader.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
            }
        }
    }
}
