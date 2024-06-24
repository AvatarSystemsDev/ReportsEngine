﻿using DevExpress.XtraReports.UI;
using ReportsEngine.Reports.APReports;
using ReportsEngine.Reports.CheckReports;
using ReportsEngine.Reports.FinancialReports;
using ReportsEngine.Reports.GLReports;
using ReportsEngine.Reports.JIBReports;
using ReportsEngine.Reports.LTMReports;
using ReportsEngine.Reports.MDReports;
using ReportsEngine.Reports.PAReports;
using ReportsEngine.Reports.ProcessReports;
using ReportsEngine.Reports.PRReports;
using ReportsEngine.Reports.RDReports;
using ReportsEngine.Reports.TaxReports;
using System;
using System.Collections.Generic;

namespace ReportsEngine.Reports
{
    public class ReportsFactory
    {
        static ReportsFactory()
        {
            Reports.Add("APEditListcs", (databaseID, companyID) => new APEditList());
            Reports.Add("AFEMasterList", (databaseID, companyID) => new AFEMasterList());
            Reports.Add("ExcelAFEMasterList", (databaseID, companyID) => new ExcelAFEMasterList());
            Reports.Add("ChartofAccountListing", (databaseID, companyID) => new ChartofAccountListing());
            Reports.Add("ExcelChartofAccountListing", (databaseID, companyID) => new ExcelChartofAccountListing());
            Reports.Add("DOIByOwnerAddress", (databaseID, companyID) => new DOIbyOwnerAddress());
            Reports.Add("ExcelDOIByOwnerAddress", (databaseID, companyID) => new ExcelDOIbyOwnerAddress());
            Reports.Add("DOIbyOwner", (databaseID, companyID) => new DOIbyOwner());
            Reports.Add("ExcelDOIbyOwner", (databaseID, companyID) => new DOIByOwnerExcel());
            Reports.Add("GeneralLedgerDetail", (databaseID, companyID) => new GeneralLedgerDetail());
            Reports.Add("ExcelGeneralLedgerDetail", (databaseID, companyID) => new ExcelGeneralLedgerDetail());
            Reports.Add("AccountingCenterListing", (databaseID, companyID) => new AccountingCenterListing());
            Reports.Add("ExcelAccountingCenterListing", (databaseID, companyID) => new ExcelAccountingCenterListing());
            Reports.Add("FiscalYearOpeningTrialBalance", (databaseID, companyID) => new FiscalYearOpeningTrialBalance());
            Reports.Add("ExcelFiscalYearOpeningTrialBalance", (databaseID, companyID) => new ExcelFiscalYearOpeningTrialBalance());
            Reports.Add("SummaryGeneralLedger", (databaseID, companyID) => new SummaryGeneralLedger());
            Reports.Add("ExcelSummaryGeneralLedger", (databaseID, companyID) => new ExcelSummaryGeneralLedger());
            Reports.Add("TrialBalance", (databaseID, companyID) => new TrialBalance());
            Reports.Add("ExcelTrialBalance", (databaseID, companyID) => new ExcelTrialBalance());
            Reports.Add("GLBudgets", (databaseID, companyID) => new GLBudgets());
            Reports.Add("ExcelGLBudgets", (databaseID, companyID) => new ExcelGLBudgets());
            Reports.Add("GLBudgetsSemiannual", (databaseID, companyID) => new GLBudgetsSemiannual()); // Told to incorporate the features into GL Budgets. Not actually using this report. Does not exist in Report Information table.
            Reports.Add("ExcelGLBudgetsSemiannual", (databaseID, companyID) => new ExcelGLBudgets()); // We can use the same Excel report becuase we are not crunched for space
            Reports.Add("JournalRegister", (databaseID, companyID) => new JournalRegister());
            Reports.Add("ExcelJournalRegister", (databaseID, companyID) => new ExcelJournalRegister());
            Reports.Add("GeneralLedgerDetailbyProperty", (databaseID, companyID) => new GeneralLedgerDetailByProperty());
            Reports.Add("ExcelGeneralLedgerDetailbyProperty", (databaseID, companyID) => new ExcelGeneralLedgerDetailbyProperty());
            Reports.Add("ChartOfAccountsAmounts", (databaseID, companyID) => new ChartOfAccountsAmounts());
            Reports.Add("ExcelChartOfAccountsAmounts", (databaseID, companyID) => new ExcelChartOfAccountsAmounts());
            Reports.Add("RDCheckStubs", (databaseID, companyID) => new RDCheckStubs(databaseID ?? 0, companyID ?? 0));
            Reports.Add("ExcelRDCheckStubs", (databaseID, companyID) => new ExcelRDCheckStubs());
            Reports.Add("DOIbyOwnerDetail", (databaseID, companyID) => new DOIbyOwnerDetail());
            Reports.Add("ExcelDOIbyOwnerDetail", (databaseID, companyID) => new ExcelDOIbyOwnerDetail());
            Reports.Add("DOIbyProperty", (databaseID, companyID) => new DOIbyProperty());
            Reports.Add("ExcelDOIbyProperty", (databaseID, companyID) => new ExcelDOIbyProperty());
            Reports.Add("DOIDeckInformation", (databaseID, companyID) => new DOIDeckInformation());
            Reports.Add("ExcelDOIDeckInformation", (databaseID, companyID) => new ExcelDOIDeckInformation());
            Reports.Add("GLBudgetsOverActual", (databaseID, companyID) => new GLBudgetsOverActual());
            Reports.Add("ExcelGLBudgetsOverActual", (databaseID, companyID) => new ExcelGLBudgetsOverActual());
            Reports.Add("GLPostRegister", (databaseID, companyID) => new GLPostRegister());
            Reports.Add("ExcelGLPostRegister", (databaseID, companyID) => new ExcelGLPostRegister());
            Reports.Add("CheckHistory", (databaseID, companyID) => new CheckHistory());
            Reports.Add("ExcelCheckHistory", (databaseID, companyID) => new ExcelCheckHistory());
            Reports.Add("CashDepositSummary", (databaseID, companyID) => new CashDepositSummary());
            Reports.Add("ExcelCashDepositSummary", (databaseID, companyID) => new ExcelCashDepositSummary());
            Reports.Add("APEditList", (databaseID, companyID) => new APEditList());
            Reports.Add("ExcelAPEditList", (databaseID, companyID) => new ExcelAPEditList());
            Reports.Add("APVoucherRegister", (databaseID, companyID) => new APVoucherRegister());
            Reports.Add("ExcelAPVoucherRegister", (databaseID, companyID) => new ExcelAPVoucherRegister());
            Reports.Add("RDProofList", (databaseID, companyID) => new RDProofList());
            Reports.Add("ExcelRDProofList", (databaseID, companyID) => new ExcelRDProofList());
            Reports.Add("RDPreliminaryDistribution", (databaseID, companyID) => new RDPreliminaryDistribution());
            Reports.Add("ExcelRDPreliminaryDistribution", (databaseID, companyID) => new ExcelRDPreliminaryDistribution());
            Reports.Add("RDProductionTaxDetail", (databaseID, companyID) => new RDProductionTaxDetail());
            Reports.Add("ExcelRDProductionTaxDetail", (databaseID, companyID) => new ExcelRDProductionTaxDetail());
            Reports.Add("CheckReconciliationDetail", (databaseID, companyID) => new CheckReconciliationDetail());
            Reports.Add("ExcelCheckReconciliationDetail", (databaseID, companyID) => new ExcelCheckReconciliationDetail());
            Reports.Add("CheckReconciliationSummary", (databaseID, companyID) => new CheckReconciliationSummary());
            Reports.Add("ExcelCheckReconciliationSummary", (databaseID, companyID) => new ExcelCheckReconciliationSummary());
            Reports.Add("CashRequirements", (databaseID, companyID) => new CashRequirements());
            Reports.Add("ExcelCashRequirements", (databaseID, companyID) => new ExcelCashRequirements());
            Reports.Add("CashRequirementsSummary", (databaseID, companyID) => new CashRequirementsSummary());
            Reports.Add("ExcelCashRequirementsSummary", (databaseID, companyID) => new ExcelCashRequirementsSummary());
            Reports.Add("APOpenItemsAgedSummary", (databaseID, companyID) => new APOpenItemsAgedSummary());
            Reports.Add("ExcelAPOpenItemsAgedSummary", (databaseID, companyID) => new ExcelAPOpenItemsAgedSummary());
            Reports.Add("APHistoryDetail", (databaseID, companyID) => new APHistoryDetail());
            Reports.Add("ExcelAPHistoryDetail", (databaseID, companyID) => new ExcelAPHistoryDetail());
            Reports.Add("APOpenItemsAgedDetail", (databaseID, companyID) => new APOpenItemsAgedDetail());
            Reports.Add("ExcelAPOpenItemsAgedDetail", (databaseID, companyID) => new ExcelAPOpenItemsAgedDetail());
            Reports.Add("APOpenByProperty", (databaseID, companyID) => new APOpenByProperty());
            Reports.Add("ExcelAPOpenByProperty", (databaseID, companyID) => new ExcelAPOpenByProperty());
            Reports.Add("APPaymentsHistoryRecap", (databaseID, companyID) => new APPaymentsHistoryRecap());
            Reports.Add("ExcelAPPaymentsHistoryRecap", (databaseID, companyID) => new ExcelAPPaymentsHistoryRecap());
            Reports.Add("APHistoryGLDetail", (databaseID, companyID) => new APHistoryGLDetail());
            Reports.Add("ExcelAPHistoryGLDetail", (databaseID, companyID) => new ExcelAPHistoryGLDetail());
            Reports.Add("1099Form", (databaseID, companyID) => new The1099Form());
            Reports.Add("Excel1099Form", (databaseID, companyID) => new ExcelThe1099Form());
            Reports.Add("APInvoicesWithProperty", (databaseID, companyID) => new APInvoicesWithProperty());
            Reports.Add("ExcelAPInvoicesWithProperty", (databaseID, companyID) => new ExcelAPInvoicesWithProperty());
            Reports.Add("APPreCheckWriting", (databaseID, companyID) => new APPreCheckWriting());
            Reports.Add("ExcelAPPreCheckWriting", (databaseID, companyID) => new ExcelAPPreCheckWriting());
            Reports.Add("APGLPostRegister", (databaseID, companyID) => new APGLPostRegister());
            Reports.Add("ExcelAPGLPostRegister", (databaseID, companyID) => new ExcelAPGLPostRegister());
            Reports.Add("CashReceiptsEditList", (databaseID, companyID) => new CashReceiptsEditList());
            Reports.Add("ExcelCashReceiptsEditList", (databaseID, companyID) => new ExcelCashReceiptsEditList());
            Reports.Add("JEEditList", (databaseID, companyID) => new JEEditList());
            Reports.Add("ExcelJEEditList", (databaseID, companyID) => new ExcelJEEditList());
            Reports.Add("RDEntryEditList", (databaseID, companyID) => new RDEntryEditList());
            Reports.Add("ExcelRDEntryEditList", (databaseID, companyID) => new ExcelRDEntryEditList());
            Reports.Add("RDSuspenseActionReport", (databaseID, companyID) => new RDSuspenseActionReport());
            Reports.Add("ExcelRDSuspenseActionReport", (databaseID, companyID) => new ExcelRDSuspenseActionReport());
            Reports.Add("RDCheckStateWithholding", (databaseID, companyID) => new RDCheckStateWithholding());
            Reports.Add("ExcelRDCheckStateWithholding", (databaseID, companyID) => new ExcelRDCheckStateWithholding());
            Reports.Add("RDNettedRegister", (databaseID, companyID) => new CombinedRevenueReport());
            Reports.Add("ExcelRDNettedRegister", (databaseID, companyID) => new ExcelRDNettedRegister());
            Reports.Add("RDCheckRegister", (databaseID, companyID) => new RDCheckRegister());
            Reports.Add("ExcelRDCheckRegister", (databaseID, companyID) => new ExcelRDCheckRegister());
            Reports.Add("RDSummaryCheckRegister", (databaseID, companyID) => new RDSummaryCheckRegister());
            Reports.Add("ExcelRDSummaryCheckRegister", (databaseID, companyID) => new ExcelRDSummaryCheckRegister());
            Reports.Add("CheckPrintingGLPostingRegister", (databaseID, companyID) => new CheckPrintingGLPostingRegister());
            Reports.Add("ExcelCheckPrintingGLPostingRegister", (databaseID, companyID) => new ExcelCheckPrintingGLPostingRegister());
            Reports.Add("RDAllocation", (databaseID, companyID) => new RDAllocation());
            Reports.Add("ExcelRDAllocation", (databaseID, companyID) => new ExcelRDAllocation());
            Reports.Add("RDCheckSuspenseActivity", (databaseID, companyID) => new RDCheckSuspenseActivity());
            Reports.Add("ExcelRDCheckSuspenseActivity", (databaseID, companyID) => new ExcelRDCheckSuspenseActivity());
            Reports.Add("RDChecks", (databaseID, companyID) => new RDChecks(databaseID ?? 0, companyID ?? 0)); // Uses the provided databaseID, or 0 if null
            Reports.Add("ExcelRDChecks", (databaseID, companyID) => new ExcelRDCheckStubs()); //I'm thinking of using the same export for check stubs as checks. They pretty much show the same information.
            Reports.Add("SuspenseByOwner", (databaseID, companyID) => new SuspenseByOwner());
            Reports.Add("ExcelSuspenseByOwner", (databaseID, companyID) => new ExcelSuspenseByOwner());
            Reports.Add("SuspenseByProperty", (databaseID, companyID) => new SuspenseByProperty());
            Reports.Add("ExcelSuspenseByProperty", (databaseID, companyID) => new ExcelSuspenseByProperty());
            Reports.Add("JIBARDetailByOwner", (databaseID, companyID) => new JIBARDetailByOwner());
            Reports.Add("ExcelJIBARDetailByOwner", (databaseID, companyID) => new ExcelJIBARDetailByOwner());
            Reports.Add("JIBHistoryByOwner", (databaseID, companyID) => new JIBHistoryByOwner());
            Reports.Add("ExcelJIBHistoryByOwner", (databaseID, companyID) => new ExcelJIBHistoryByOwner());
            Reports.Add("JIBHistoryByProperty", (databaseID, companyID) => new JIBHistoryByProperty());
            Reports.Add("ExcelJIBHistoryByProperty", (databaseID, companyID) => new ExcelJIBHistoryByOwner());
            Reports.Add("RDOwnerYTDActivity", (databaseID, companyID) => new RDOwnerYTDActivity());
            Reports.Add("ExcelRDOwnerYTDActivity", (databaseID, companyID) => new ExcelRDOwnerYTDActivity());
            Reports.Add("RDImportEditList", (databaseID, companyID) => new RDImportEditList());
            Reports.Add("ExcelRDImportEditList", (databaseID, companyID) => new ExcelRDImportEditList());
            Reports.Add("RDGLPostingRegister", (databaseID, companyID) => new RDGLPostingRegister());
            Reports.Add("ExcelRDGLPostingRegister", (databaseID, companyID) => new ExcelRDGLPostingRegister());
            Reports.Add("RDSuspenseSelectedForEscheatRegister", (databaseID, companyID) => new RDSuspenseSelectedForEscheatRegister());
            Reports.Add("ExcelRDSuspenseSelectedForEscheatRegister", (databaseID, companyID) => new ExcelRDSuspenseSelectedForEscheatRegister());
            Reports.Add("APOpenSelectedForEscheatRegister", (databaseID, companyID) => new APOpenSelectedForEscheatRegister());
            Reports.Add("ExcelAPOpenSelectedForEscheatRegister", (databaseID, companyID) => new ExcelAPOpenSelectedForEscheatRegister());
            Reports.Add("APChecks", (databaseID, companyID) => new APChecks());
            Reports.Add("ExcelAPChecks", (databaseID, companyID) => new ExcelAPChecks());
            Reports.Add("GeneralLedgerPostingRegister", (databaseID, companyID) => new GLProcessPostRegister());
            Reports.Add("ExcelGeneralLedgerPostingRegister", (databaseID, companyID) => new ExcelGLProcessPostRegister());
            Reports.Add("APCheckRegister", (databaseID, companyID) => new APCheckRegister());
            Reports.Add("ExcelAPCheckRegister", (databaseID, companyID) => new ExcelAPCheckRegister());
            Reports.Add("APCheckStubs", (databaseID, companyID) => new APCheckStubs());
            Reports.Add("ExcelAPCheckStubs", (databaseID, companyID) => new ExcelAPChecks());
            Reports.Add("APPrepaidRegister", (databaseID, companyID) => new APPrepaidRegister());
            Reports.Add("ExcelAPPrepaidRegister", (databaseID, companyID) => new ExcelAPPrepaidRegister());
            Reports.Add("RDImmediatePostRegister", (databaseID, companyID) => new RDImmediatePostRegister());
            Reports.Add("ExcelRDImmediatePostRegister", (databaseID, companyID) => new ExcelRDImmediatePostRegister());
            Reports.Add("RDNoCrossRefList", (databaseID, companyID) => new RDNoCrossRefList());
            Reports.Add("ExcelRDNoCrossRefList", (databaseID, companyID) => new ExcelRDNoCrossRefList());
            Reports.Add("RDSuspenseReleaseChecks", (databaseID, companyID) => new RDSuspenseReleaseChecks());
            Reports.Add("ExcelRDSuspenseReleaseChecks", (databaseID, companyID) => new ExcelRDSuspenseReleaseChecks());
            Reports.Add("PropertyCashFlow", (databaseID, companyID) => new PropertyCashFlow());
            Reports.Add("ExcelPropertyCashFlow", (databaseID, companyID) => new ExcelPropertyCashFlow());
            Reports.Add("PropertyCashFlowbyInterestType", (databaseID, companyID) => new PropertyCashFlowbyInterestType());
            Reports.Add("ExcelPropertyCashFlowbyInterestType", (databaseID, companyID) => new ExcelPropertyCashFlowbyInterestType());
            Reports.Add("PropertyCashFlowbyState", (databaseID, companyID) => new PropertyCashFlowbyState());
            Reports.Add("ExcelPropertyCashFlowbyState", (databaseID, companyID) => new ExcelPropertyCashFlowbyState());
            Reports.Add("OutstandingCheck", (databaseID, companyID) => new OutstandingCheck());
            Reports.Add("ExcelOutstandingCheck", (databaseID, companyID) => new ExcelOutstandingCheck());
            Reports.Add("OwnerNameAddress", (databaseID, companyID) => new OwnerNameAddress());
            Reports.Add("ExcelOwnerNameAddress", (databaseID, companyID) => new ExcelOwnerNameAddress());
            Reports.Add("VendorNameAddress", (databaseID, companyID) => new VendorNameAddress());
            Reports.Add("ExcelVendorNameAddress", (databaseID, companyID) => new ExcelVendorNameAddress());
            Reports.Add("VendorOptionsListing", (databaseID, companyID) => new VendorOptionsListing());
            Reports.Add("ExcelVendorOptionsListing", (databaseID, companyID) => new ExcelVendorOptionsListing());
            Reports.Add("OwnerOptions", (databaseID, companyID) => new OwnerOptions());
            Reports.Add("ExcelOwnerOptions", (databaseID, companyID) => new ExcelOwnerOptions());
            Reports.Add("DOIDeck", (databaseID, companyID) => new DOIDeck());
            Reports.Add("ExcelDOIDeck", (databaseID, companyID) => new ExcelDOIDeck());
            Reports.Add("VendorLabels", (databaseID, companyID) => new VendorLabels());
            Reports.Add("ExcelVendorLabels", (databaseID, companyID) => new ExcelVendorLabels());
            Reports.Add("OwnerLabels", (databaseID, companyID) => new OwnerLabels());
            Reports.Add("ExcelOwnerLabels", (databaseID, companyID) => new ExcelOwnerLabels());
            Reports.Add("GLPostingRegisterByProcess", (databaseID, companyID) => new GLPostingRegisterByProcess());
            Reports.Add("ExcelGLPostingRegisterByProcess", (databaseID, companyID) => new ExcelGLPostingRegisterByProcess());
            Reports.Add("OwnerLabelsByProperty", (databaseID, companyID) => new OwnerLabelsByProperty());
            Reports.Add("ExcelOwnerLabelsByProperty", (databaseID, companyID) => new ExcelOwnerLabelsByProperty());
            Reports.Add("PA_LAOGP", (databaseID, companyID) => new PA_LAOGP());
            Reports.Add("ExcelPA_LAOGP", (databaseID, companyID) => new ExcelPA_LAOGP());
            Reports.Add("PA_LAR5D", (databaseID, companyID) => new PA_LAR5D());
            Reports.Add("ExcelPA_LAR5D", (databaseID, companyID) => new ExcelPA_LAR5D());
            Reports.Add("PA_AllocationRegisterFinalized", (databaseID, companyID) => new PA_AllocationRegisterFinalized());
            Reports.Add("ExcelPA_AllocationRegisterFinalized", (databaseID, companyID) => new ExcelPA_AllocationRegisterFinalized());
            Reports.Add("PA_AllocationDecimalList", (databaseID, companyID) => new PA_AllocationDecimalList());
            Reports.Add("ExcelPA_AllocationDecimalList", (databaseID, companyID) => new ExcelPA_AllocationDecimalList());
            Reports.Add("PA_NMC115", (databaseID, companyID) => new PA_NMC115());
            Reports.Add("ExcelPA_NMC115", (databaseID, companyID) => new ExcelPA_NMC115());
            Reports.Add("JIBInvoices", (databaseID, companyID) => new JIBInvoices());
            Reports.Add("ExcelJIBInvoices", (databaseID, companyID) => new ExcelJIBInvoices());
            Reports.Add("JIBStatement", (databaseID, companyID) => new JIBStatement());
            Reports.Add("ExcelJIBStatement", (databaseID, companyID) => new ExcelJIBStatement());
            Reports.Add("JIBGLPostingRegister", (databaseID, companyID) => new JIBGLPostingRegister());
            Reports.Add("ExcelJIBGLPostingRegister", (databaseID, companyID) => new ExcelJIBGLPostingRegister());
            Reports.Add("JIBCompanyRecap", (databaseID, companyID) => new JIBCompanyRecap());
            Reports.Add("ExcelJIBCompanyRecap", (databaseID, companyID) => new ExcelJIBCompanyRecap());
            Reports.Add("JIBPropertyExpenseDistribution", (databaseID, companyID) => new JIBPropertyExpenseDistribution());
            Reports.Add("ExcelJIBPropertyExpenseDistribution", (databaseID, companyID) => new ExcelJIBPropertyExpenseDistribution());
            Reports.Add("JIBClearedItems", (databaseID, companyID) => new JIBClearedItems());
            Reports.Add("ExcelJIBClearedItems", (databaseID, companyID) => new ExcelJIBClearedItems());
            Reports.Add("ComparativeOperatingStatement", (databaseID, companyID) => new ComparativeOperatingStatement());
            Reports.Add("ExcelComparativeOperatingStatement", (databaseID, companyID) => new ExcelComparativeOperatingStatement());
            Reports.Add("NetComparativeOperatingStatement", (databaseID, companyID) => new NetComparativeOperatingStatement());
            Reports.Add("ExcelNetComparativeOperatingStatement", (databaseID, companyID) => new ExcelNetComparativeOperatingStatement());
            Reports.Add("RDOwnerLevelEntry", (databaseID, companyID) => new RDOwnerLevelEntry());
            Reports.Add("ExcelRDOwnerLevelEntry", (databaseID, companyID) => new ExcelRDOwnerLevelEntry());
            Reports.Add("LeaseOperatingStatement", (databaseID, companyID) => new LeaseOperatingStatement());
            Reports.Add("ExcelLeaseOperatingStatement", (databaseID, companyID) => new ExcelLeaseOperatingStatement());
            Reports.Add("PropertyListAllCompanies", (databaseID, companyID) => new PropertyListAllCompanies());
            Reports.Add("ExcelPropertyListAllCompanies", (databaseID, companyID) => new ExcelPropertyListAllCompanies());
            Reports.Add("AFEBudgetList", (databaseID, companyID) => new AFEBudgetList());
            Reports.Add("ExcelAFEBudgetList", (databaseID, companyID) => new ExcelAFEBudgetList());
            Reports.Add("ManualCheckList", (databaseID, companyID) => new ManualCheckList());
            Reports.Add("ExcelManualCheckList", (databaseID, companyID) => new ExcelManualCheckList());
            Reports.Add("ManualChecks", (databaseID, companyID) => new ManualChecks());
            Reports.Add("ExcelManualCheck", (databaseID, companyID) => new ExcelManualChecks());
            Reports.Add("RDStateWithholding", (databaseID, companyID) => new RDStateWithholding());
            Reports.Add("ExcelRDStateWithholding", (databaseID, companyID) => new ExcelRDStateWithholding());
            Reports.Add("ReplacementCheckRegister", (databaseID, companyID) => new ReplacementCheckRegister());
            Reports.Add("ExcelReplacementCheckRegister", (databaseID, companyID) => new ExcelReplacementCheckRegister());
            Reports.Add("PaymentByCheckHistory", (databaseID, companyID) => new PaymentByCheckHistory());
            Reports.Add("ExcelPaymentByCheckHistory", (databaseID, companyID) => new ExcelPaymentByCheckHistory());
            Reports.Add("SummaryWithholding", (databaseID, companyID) => new SummaryWithholding());
            Reports.Add("ExcelSummaryWithholding", (databaseID, companyID) => new ExcelSummaryWithholding());
            Reports.Add("CloseProfitAndLossPostingRegister", (databaseID, companyID) => new CloseProfitAndLossPostingRegister());
            Reports.Add("ExcelCloseProfitAndLossPostingRegister", (databaseID, companyID) => new ExcelCloseProfitAndLossPostingRegister());
            Reports.Add("LTM_LeaseDataSheet", (databaseID, companyID) => new LTM_LeaseDataSheet());
            Reports.Add("ExcelLTM_LeaseDataSheet", (databaseID, companyID) => new ExcelLTM_LeaseDataSheet());
            Reports.Add("TexasTaxProducerDetail", (databaseID, companyID) => new TexasTaxProducerDetail());
            Reports.Add("ExcelTexasTaxProducerDetail", (databaseID, companyID) => new ExcelTexasTaxProducerDetail());
            Reports.Add("TexasTaxProducerSummary", (databaseID, companyID) => new TexasTaxProducerSummary());
            Reports.Add("ExcelTexasTaxProducerSummary", (databaseID, companyID) => new ExcelTexasTaxProducerSummary());
            Reports.Add("APOutstandingAccountsPayableDetailWithProperty", (databaseID, companyID) => new APOutstandingAccountsPayableDetailWithProperty());
            Reports.Add("ExcelAPOutstandingAccountsPayableDetailWithProperty", (databaseID, companyID) => new ExcelAPOutstandingAccountsPayableDetailWithProperty());
            Reports.Add("APPayablesDetail", (databaseID, companyID) => new APPayablesDetail());
            Reports.Add("ExcelAPPayablesDetail", (databaseID, companyID) => new ExcelAPPayablesDetail());
            Reports.Add("APPayables", (databaseID, companyID) => new APPayables());
            Reports.Add("ExcelAPPayables", (databaseID, companyID) => new ExcelAPPayables());
            Reports.Add("DOIDivisionOrderNADOA", (databaseID, companyID) => new DOIDivisionOrderNADOA());
            Reports.Add("ExcelDOIDivisionOrderNADOA", (databaseID, companyID) => new ExcelDOIDivisionOrderNADOA());
            Reports.Add("DOIDivisionOrderTx", (databaseID, companyID) => new DOIDivisionOrderTx());
            Reports.Add("ExcelDOIDivisionOrderTx", (databaseID, companyID) => new ExcelDOIDivisionOrderTx());
            Reports.Add("CashDepositTicket", (databaseID, companyID) => new CashDepositTicket());
            Reports.Add("ExcelCashDepositTicket", (databaseID, companyID) => new ExcelCashDepositTicket());
            Reports.Add("NewMexicoStateTaxDetail", (databaseID, companyID) => new NewMexicoStateTaxDetail());
            Reports.Add("ExcelNewMexicoStateTaxDetail", (databaseID, companyID) => new ExcelNewMexicoStateTaxDetail());
            Reports.Add("CashDepositSummaryInquiry", (databaseID, companyID) => new CashDepositSummaryInquiry());
            Reports.Add("ExcelCashDepositSummaryInquiry", (databaseID, companyID) => new ExcelCashDepositSummaryInquiry());
            Reports.Add("NewMexicoStateRoyaltyDetail", (databaseID, companyID) => new NewMexicoStateRoyaltyDetail());
            Reports.Add("ExcelNewMexicoStateRoyaltyDetail", (databaseID, companyID) => new ExcelNewMexicoStateRoyaltyDetail());
            Reports.Add("PA_TexasPR", (databaseID, companyID) => new Texas_PR());
            Reports.Add("ExcelPA_TexasPR", (databaseID, companyID) => new ExcelTexas_PR());
            Reports.Add("JIBProvisionalEntries", (databaseID, companyID) => new JIBProvisionalEntries());
            Reports.Add("ExcelJIBProvisionalEntries", (databaseID, companyID) => new ExcelJIBProvisionalEntries());
            Reports.Add("PA_FedOGOR", (databaseID, companyID) => new PA_FedOGOR());
            Reports.Add("ExcelPA_FedOGOR", (databaseID, companyID) => new ExcelPA_FedOGOR());
            Reports.Add("PA_TexasH10", (databaseID, companyID) => new PA_TexasH10());
            Reports.Add("PA_OSAGE101", (databaseID, companyID) => new PA_OSAGE101());
            Reports.Add("PA_OSAGE101A", (databaseID, companyID) => new PA_OSAGE101A());
            Reports.Add("PA_OSAGE133", (databaseID, companyID) => new PA_OSAGE133());
            Reports.Add("PA_OSAGE157", (databaseID, companyID) => new PA_OSAGE157());
            Reports.Add("PA_OSAGE300", (databaseID, companyID) => new PA_OSAGE300());
            Reports.Add("JIBServiceCharges", (databaseID, companyID) => new JIBServiceCharges());
            Reports.Add("ExcelJIBServiceCharges", (databaseID, companyID) => new ExcelJIBServiceCharges());
            Reports.Add("PA_MiscDispositions", (databaseID, companyID) => new PA_MiscDispositions());
            Reports.Add("CheckCoverPage", (databaseID, companyID) => new CheckCoverPage());
            Reports.Add("RDColoradoDR0021W", (databaseID, companyID) => new RDColoradoDR0021W());
            Reports.Add("ExcelRDColoradoDR0021W", (databaseID, companyID) => new ExcelRDColoradoDR0021W());
            Reports.Add("RDColoradoDR0456W", (databaseID, companyID) => new RDColoradoDR0456W());
            Reports.Add("ExcelRDColoradoDR0456", (databaseID, companyID) => new ExcelRDColoradoDR0456());
            Reports.Add("JIBCompanyStatementRecap", (databaseID, companyID) => new JIBCompanyStatementRecap());
            Reports.Add("ExcelJIBCompanyStatementRecap", (databaseID, companyID) => new ExcelJIBCompanyStatementRecap());
            Reports.Add("JIBARDetailbyPropertyWell", (databaseID, companyID) => new JIBARDetailbyPropertyWell());
            Reports.Add("ExcelJIBARDetailbyPropertyWell", (databaseID, companyID) => new ExcelJIBARDetailbyProperty());
            Reports.Add("JIBAROpenItems", (databaseID, companyID) => new JIBARBalance());
            Reports.Add("ExcelJIBAROpenItems", (databaseID, companyID) => new ExcelJIBAROpenItems());
            Reports.Add("TestMICRFonts", (databaseID, companyID) => new TestMICRFonts());
            Reports.Add("JIBWriteOffSelection", (databaseID, companyID) => new JIBWriteOffSelection());
            Reports.Add("ExcelJIBWriteOffSelection", (databaseID, companyID) => new ExcelJIBWriteOffSelection());
            Reports.Add("SalesLedger", (databaseID, companyID) => new SalesLedger());
            Reports.Add("ExcelSalesLedger", (databaseID, companyID) => new ExcelSalesLedger());
            Reports.Add("JIB88thsHistory", (databaseID, companyID) => new JIBHistory88ths());
            Reports.Add("ExcelJIB88thsHistory", (databaseID, companyID) => new ExcelJIBHistory88ths());
            Reports.Add("SalesLedgerTotal", (databaseID, companyID) => new SalesLedgerTotal());
            Reports.Add("ExcelSalesLedgerTotal", (databaseID, companyID) => new ExcelSalesLedgerTotal());
            Reports.Add("SuspenseByOwnerSummary", (databaseID, companyID) => new SuspenseByOwnerSummary());
            Reports.Add("ExcelSuspenseByOwnerSummary", (databaseID, companyID) => new ExcelSuspenseByOwnerSummary());
            Reports.Add("SuspenseByPropertySummary", (databaseID, companyID) => new SuspenseByPropertySummary());
            Reports.Add("ExcelSuspenseByPropertySummary", (databaseID, companyID) => new ExcelSuspenseByPropertySummary());
            Reports.Add("SuspenseByPropertyWellAndOwnerSummary", (databaseID, companyID) => new SuspenseByPropertyWellAndOwnerSummary());
            Reports.Add("ExcelSuspenseByPropertyWellAndOwnerSummary", (databaseID, companyID) => new ExcelSuspenseByPropertyWellAndOwnerSummary());
            Reports.Add("BalanceSheet", (databaseID, companyID) => new BalanceSheet());
            Reports.Add("ExcelBalanceSheet", (databaseID, companyID) => new ExcelBalanceSheet());
            Reports.Add("IncomeAndExpenseStatement", (databaseID, companyID) => new IncomeAndExpenseStatement());
            Reports.Add("ExcelIncomeAndExpenseStatement", (databaseID, companyID) => new ExcelIncomeAndExpenseStatement());
            Reports.Add("PreVoidCheckReport", (databaseID, companyID) => new PreVoidCheckReport());
            Reports.Add("ExcelPreVoidCheckReport", (databaseID, companyID) => new PreVoidCheckReport());
            Reports.Add("AFEEstimateSummary", (databaseID, companyID) => new AFEEstimateSummary());
            Reports.Add("ExcelAFEEstimateSummary", (databaseID, companyID) => new ExcelAFEEstimateSummary());
            Reports.Add("AFEDetail", (databaseID, companyID) => new DetailAFE(databaseID ?? 0, companyID ?? 0));
            Reports.Add("ExcelAFEDetail", (databaseID, companyID) => new ExcelAFEDetail());
            Reports.Add("AFEBudgetReceivables", (databaseID, companyID) => new AFEBudgetReceivables());
            Reports.Add("ExcelAFEBudgetReceivables", (databaseID, companyID) => new ExcelAFEBudgetReceivables());
            Reports.Add("ServiceAgreements", (databaseID, companyID) => new ServiceAgreements());
            Reports.Add("ExcelServiceAgreements", (databaseID, companyID) => new ExcelServiceAgreements());
            Reports.Add("InsuranceOptions", (databaseID, companyID) => new InsuranceOptions());
            Reports.Add("ExcelInsuranceOptions", (databaseID, companyID) => new ExcelInsuranceOptions());
            Reports.Add("GLProcessPostRegister", (databaseID, companyID) => new GLProcessPostRegister());
            Reports.Add("ExcelGLProcessPostRegister", (databaseID, companyID) => new ExcelGLProcessPostRegister());
            Reports.Add("TestCheckReport", (databaseID, companyID) => new TestCheckReport());
            Reports.Add("JIBSuspenseAction", (databaseID, companyID) => new JIBSuspenseAction());
            Reports.Add("ExcelJIBSuspenseAction", (databaseID, companyID) => new ExcelJIBSuspenseAction());
            Reports.Add("JIBAllocation", (databaseID, companyID) => new JIBAllocation());
            Reports.Add("ExcelJIBAllocation", (databaseID, companyID) => new ExcelJIBAllocation());
            Reports.Add("JIBAllocationInsideImmediate", (databaseID, companyID) => new JIBAllocation());
            Reports.Add("ExcelJIBAllocationInsideImmediate", (databaseID, companyID) => new ExcelJIBAllocation());
            Reports.Add("PR_StateTableListing", (databaseID, companyID) => new PR_StateTableListing());
            Reports.Add("ExcelPR_StateTableListing", (databaseID, companyID) => new ExcelPR_StateTableListing());
            Reports.Add("PR_WorkersCompGenLiabilityTableListing", (databaseID, companyID) => new PR_WorkersCompGenLiabilityTableListing());
            Reports.Add("ExcelPR_WorkersCompGenLiabilityTableListing", (databaseID, companyID) => new ExcelPR_WorkersCompGenLiabilityTableListing());
            Reports.Add("PR_Checks", (databaseID, companyID) => new PR_Checks());
            Reports.Add("PR_PreliminaryPaymentTimeRecordRecap", (databaseID, companyID) => new PR_PreliminaryPaymentTimeRecordRecap());
            Reports.Add("ExcelPR_PreliminaryPaymentTimeRecordRecap", (databaseID, companyID) => new ExcelPR_PreliminaryPaymentTimeRecordRecap());
            Reports.Add("PR_PreliminaryPayrollRegister", (databaseID, companyID) => new PR_PreliminaryPayrollRegister());
            Reports.Add("ExcelPR_PreliminaryPayrollRegister", (databaseID, companyID) => new ExcelPR_PreliminaryPayrollRegister());
            Reports.Add("PR_TaxableEarningsRegister", (databaseID, companyID) => new PR_TaxableEarningsRegister());
            Reports.Add("ExcelPR_TaxableEarningsRegister", (databaseID, companyID) => new ExcelPR_TaxableEarningsRegister());
            Reports.Add("PR_DepartmentRegister", (databaseID, companyID) => new PR_DepartmentRegister());
            Reports.Add("ExcelPR_DepartmentRegister", (databaseID, companyID) => new ExcelPR_DepartmentRegister());
            Reports.Add("PR_DeductionsRegister", (databaseID, companyID) => new PR_DeductionsRegister());
            Reports.Add("ExcelPR_DeductionsRegister", (databaseID, companyID) => new ExcelPR_DeductionsRegister());
            Reports.Add("SplitSuspenseEditList_NewOwners", (databaseID, companyID) => new SplitSuspenseEditList_NewOwners());
            Reports.Add("ExcelSplitSuspenseEditList_NewOwners", (databaseID, companyID) => new ExcelSplitSuspenseEditList_NewOwners());
            Reports.Add("SplitSuspenseEditList_CurrentOwner", (databaseID, companyID) => new SplitSuspenseEditList_CurrentOwner());
            Reports.Add("ExcelSplitSuspenseEditList_CurrentOwner", (databaseID, companyID) => new ExcelSplitSuspenseEditList_CurrentOwner());
            Reports.Add("SplitSuspenseEditList_ItemsToBeSplit", (databaseID, companyID) => new SplitSuspenseEditList_ItemsToBeSplit());
            Reports.Add("ExcelSplitSuspenseEditList_ItemsToBeSplit", (databaseID, companyID) => new ExcelSplitSuspenseEditList_ItemsToBeSplit());
            Reports.Add("PR_AllowanceRegister", (databaseID, companyID) => new PR_AllowanceRegister());
            Reports.Add("ExcelPR_AllowanceRegister", (databaseID, companyID) => new ExcelPR_AllowanceRegister());
            Reports.Add("PR_EmployerDepartmentExpenseRegister", (databaseID, companyID) => new PR_EmployerDepartmentExpenseRegister());
            Reports.Add("ExcelPR_EmployerDepartmentExpenseRegister", (databaseID, companyID) => new ExcelPR_EmployerDepartmentExpenseRegister());
            Reports.Add("CompanyProfile", (databaseID, companyID) => new CompanyProfile(companyID));
            Reports.Add("ExcelCompanyProfile", (databaseID, companyID) => new ExcelCompanyProfile());
            Reports.Add("PR_CompanyFundedDeductionRegister", (databaseID, companyID) => new PR_CompanyFundedDeductionRegister());
            Reports.Add("ExcelPR_CompanyFundedDeductionRegister", (databaseID, companyID) => new ExcelPR_CompanyFundedDeductionRegister());
            Reports.Add("PR_CompanyMatchedDeductionRegister", (databaseID, companyID) => new PR_CompanyMatchedDeductionRegister());
            Reports.Add("ExcelPR_CompanyMatchedDeductionRegister", (databaseID, companyID) => new ExcelPR_CompanyMatchedDeductionRegister());

        }
        public static Dictionary<string, Func<int?, int?, XtraReport>> Reports = new Dictionary<string, Func<int?, int?, XtraReport>>();
    }
}