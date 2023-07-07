using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsEngine.Reports
{
    public class ReportsFactory
    {
        static ReportsFactory()
        {
            Reports.Add("APEditListcs", () => new APEditListcs());
            Reports.Add("AFEMasterList", () => new AFEMasterList());
            Reports.Add("ChartofAccountListing", () => new ChartofAccountListing());
            Reports.Add("ExcelChartofAccountListing", () => new ExcelChartofAccountListing());
            Reports.Add("DOIByOwnerAddress", () => new DOIbyOwnerAddress());
            Reports.Add("DOIbyOwner", () => new DOIbyOwner());
            Reports.Add("GeneralLedgerDetail", () => new GeneralLedgerDetail());
            Reports.Add("ExcelGeneralLedgerDetail", () => new ExcelGeneralLedgerDetail());

        }
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>();
    }
}