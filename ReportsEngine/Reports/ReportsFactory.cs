﻿using DevExpress.XtraReports.UI;
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
            Reports.Add("APEditListcs", () => new APEditListcs());
            Reports.Add("AFEMasterList", () => new AFEMasterList());
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
        }
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>();
    }
}