using DevExpress.XtraReports.UI;
using ReportsEngine.Reports.APReports;
using ReportsEngine.Reports.FinancialReports;
using ReportsEngine.Reports.MDReports;
using ReportsEngine.Reports.RDReports;
using System;
using System.Collections.Generic;

namespace ReportsEngine.Reports
{
    public class ReportsFactory
    {
        static ReportsFactory()
        {
            Reports.Add("APEditListcs", () => new APEditList());
            Reports.Add("AFEMasterList", () => new AFEMasterList());
            Reports.Add("ExcelAFEMasterList", () => new ExcelAFEMasterList());
            Reports.Add("ChartofAccountListing", () => new ChartofAccountListing());
            Reports.Add("ExcelChartofAccountListing", () => new ExcelChartofAccountListing());
            Reports.Add("DOIByOwnerAddress", () => new DOIbyOwnerAddress());
            Reports.Add("ExcelDOIByOwnerAddress", () => new ExcelDOIbyOwnerAddress());
            Reports.Add("DOIbyOwner", () => new DOIbyOwner());
            Reports.Add("ExcelDOIbyOwner", () => new DOIByOwnerExcel());
            Reports.Add("GeneralLedgerDetail", () => new GeneralLedgerDetail());
            Reports.Add("ExcelGeneralLedgerDetail", () => new ExcelGeneralLedgerDetail());
            Reports.Add("AccountingCenterListing", () => new AccountingCenterListing());
            Reports.Add("ExcelAccountingCenterListing", () => new ExcelAccountingCenterListing());
            Reports.Add("FiscalYearOpeningTrialBalance", () => new FiscalYearOpeningTrialBalance());
            Reports.Add("ExcelFiscalYearOpeningTrialBalance", () => new ExcelFiscalYearOpeningTrialBalance());
            Reports.Add("SummaryGeneralLedger", () => new SummaryGeneralLedger());
            Reports.Add("ExcelSummaryGeneralLedger", () => new ExcelSummaryGeneralLedger());
            Reports.Add("TrialBalance", () => new TrialBalance());
            Reports.Add("ExcelTrialBalance", () => new ExcelTrialBalance());
            Reports.Add("GLBudgets", () => new GLBudgets());
            Reports.Add("ExcelGLBudgets", () => new ExcelGLBudgets());
            Reports.Add("GLBudgetsSemiannual", () => new GLBudgetsSemiannual()); // Told to incorporate the features into GL Budgets. Not actually using this report. Does not exist in Report Information table.
            Reports.Add("ExcelGLBudgetsSemiannual", () => new ExcelGLBudgets()); // We can use the same Excel report becuase we are not crunched for space
            Reports.Add("JournalRegister", () => new JournalRegister());
            Reports.Add("ExcelJournalRegister", () => new ExcelJournalRegister());
            Reports.Add("GeneralLedgerDetailbyProperty", () => new GeneralLedgerDetailByProperty());
            Reports.Add("ExcelGeneralLedgerDetailbyProperty", () => new ExcelGeneralLedgerDetailbyProperty());
            Reports.Add("ChartOfAccountsAmounts", () => new ChartOfAccountsAmounts());
            Reports.Add("ExcelChartOfAccountsAmounts", () => new ExcelChartOfAccountsAmounts());
            Reports.Add("RDCheckStubs", () => new RDCheckStubs()); // Will print RD Check Stubs. Might delete later. Just need to see what the report looks like.
            Reports.Add("ExcelRDCheckStubs", () => new ExcelRDCheckStubs());
            Reports.Add("DOIbyOwnerDetail", () => new DOIbyOwnerDetail());
            Reports.Add("ExcelDOIbyOwnerDetail", () => new ExcelDOIbyOwnerDetail());
            Reports.Add("DOIbyProperty", () => new DOIbyProperty());
            Reports.Add("ExcelDOIbyProperty", () => new ExcelDOIbyProperty());
            Reports.Add("DOIDeckInformation", () => new DOIDeckInformation());
            Reports.Add("ExcelDOIDeckInformation", () => new ExcelDOIDeckInformation());
            Reports.Add("GLBudgetsOverActual", () => new GLBudgetsOverActual());
            Reports.Add("ExcelGLBudgetsOverActual", () => new ExcelGLBudgetsOverActual());
            Reports.Add("GLPostRegister", () => new GLPostRegister());
            Reports.Add("ExcelGLPostRegister", () => new ExcelGLPostRegister());
            Reports.Add("CheckHistory", () => new CheckHistory());
            Reports.Add("ExcelCheckHistory", () => new ExcelCheckHistory());
            Reports.Add("CashDepositSummary", () => new CashDepositSummary());
            Reports.Add("ExcelCashDepositSummary", () => new ExcelCashDepositSummary());
            Reports.Add("APEditList", () => new APEditList());
            Reports.Add("ExcelAPEditList", () => new ExcelAPEditList());
            Reports.Add("APVoucherRegister", () => new APVoucherRegister());
            Reports.Add("ExcelAPVoucherRegister", () => new ExcelAPVoucherRegister());
            Reports.Add("RDProofList", () => new RDProofList());
            Reports.Add("ExcelRDProofList", () => new ExcelRDProofList());
            Reports.Add("RDPreliminaryDistribution", () => new RDPreliminaryDistribution());
            Reports.Add("ExcelRDPreliminaryDistribution", () => new ExcelRDPreliminaryDistribution());
            Reports.Add("RDProductionTaxDetail", () => new RDProductionTaxDetail());
            Reports.Add("ExcelRDProductionTaxDetail", () => new ExcelRDProductionTaxDetail());
            Reports.Add("CheckReconciliationDetail", () => new CheckReconciliationDetail());
            Reports.Add("ExcelCheckReconciliationDetail", () => new ExcelCheckReconciliationDetail());
            Reports.Add("CheckReconciliationSummary", () => new CheckReconciliationSummary());
            Reports.Add("ExcelCheckReconciliationSummary", () => new ExcelCheckReconciliationSummary());
            Reports.Add("CashRequirements", () => new CashRequirements());
            Reports.Add("ExcelCashRequirements", () => new ExcelCashRequirements());
            Reports.Add("CashRequirementsSummary", () => new CashRequirementsSummary());
            Reports.Add("ExcelCashRequirementsSummary", () => new ExcelCashRequirementsSummary());
            Reports.Add("APOpenItemsAgedSummary", () => new APOpenItemsAgedSummary());
            Reports.Add("ExcelAPOpenItemsAgedSummary", () => new ExcelAPOpenItemsAgedSummary());
            Reports.Add("APHistoryDetail", () => new APHistoryDetail());
            Reports.Add("ExcelAPHistoryDetail", () => new ExcelAPHistoryDetail());
            Reports.Add("APOpenItemsAgedDetail", () => new APOpenItemsAgedDetail());
            Reports.Add("ExcelAPOpenItemsAgedDetail", () => new ExcelAPOpenItemsAgedDetail());
            Reports.Add("APOpenByProperty", () => new APOpenByProperty());
            Reports.Add("ExcelAPOpenByProperty", () => new ExcelAPOpenByProperty());
            Reports.Add("APPaymentsHistoryRecap", () => new APPaymentsHistoryRecap());
            Reports.Add("ExcelAPPaymentsHistoryRecap", () => new ExcelAPPaymentsHistoryRecap());
        }
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>();
    }
}