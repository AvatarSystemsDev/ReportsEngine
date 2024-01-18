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
            Reports.Add("APHistoryGLDetail", () => new APHistoryGLDetail());
            Reports.Add("ExcelAPHistoryGLDetail", () => new ExcelAPHistoryGLDetail());
            Reports.Add("1099Form", () => new The1099Form());
            Reports.Add("Excel1099Form", () => new ExcelThe1099Form());
            Reports.Add("APInvoicesWithProperty", () => new APInvoicesWithProperty());
            Reports.Add("ExcelAPInvoicesWithProperty", () => new ExcelAPInvoicesWithProperty());
            Reports.Add("APPreCheckWriting", () => new APPreCheckWriting());
            Reports.Add("ExcelAPPreCheckWriting", () => new ExcelAPPreCheckWriting());
            Reports.Add("APGLPostRegister", () => new APGLPostRegister());
            Reports.Add("ExcelAPGLPostRegister", () => new ExcelAPGLPostRegister());
            Reports.Add("CashReceiptsEditList", () => new CashReceiptsEditList());
            Reports.Add("ExcelCashReceiptsEditList", () => new ExcelCashReceiptsEditList());
            Reports.Add("JEEditList", () => new JEEditList());
            Reports.Add("ExcelJEEditList", () => new ExcelJEEditList());
            Reports.Add("RDEntryEditList", () => new RDEntryEditList());
            Reports.Add("ExcelRDEntryEditList", () => new ExcelRDEntryEditList());
            Reports.Add("RDSuspenseActionReport", () => new RDSuspenseActionReport());
            Reports.Add("ExcelRDSuspenseActionReport", () => new ExcelRDSuspenseActionReport());
            Reports.Add("RDCheckStateWithholding", () => new RDCheckStateWithholding());
            Reports.Add("ExcelRDCheckStateWithholding", () => new ExcelRDCheckStateWithholding());
            Reports.Add("RDNettedRegister", () => new RDNettedRegister());
            Reports.Add("ExcelRDNettedRegister", () => new ExcelRDNettedRegister());
            Reports.Add("RDCheckRegister", () => new RDCheckRegister());
            Reports.Add("ExcelRDCheckRegister", () => new ExcelRDCheckRegister());
            Reports.Add("RDSummaryCheckRegister", () => new RDSummaryCheckRegister());
            Reports.Add("ExcelRDSummaryCheckRegister", () => new ExcelRDSummaryCheckRegister());
            Reports.Add("CheckPrintingGLPostingRegister", () => new CheckPrintingGLPostingRegister());
            Reports.Add("ExcelCheckPrintingGLPostingRegister", () => new ExcelCheckPrintingGLPostingRegister());
            Reports.Add("RDAllocation", () => new RDAllocation());
            Reports.Add("ExcelRDAllocation", () => new ExcelRDAllocation());
            Reports.Add("RDCheckSuspenseActivity", () => new RDCheckSuspenseActivity());
            Reports.Add("ExcelRDCheckSuspenseActivity", () => new ExcelRDCheckSuspenseActivity());
            Reports.Add("RDChecks", () => new RDChecks());
            Reports.Add("ExcelRDChecks", () => new ExcelRDCheckStubs()); //I'm thinking of using the same export for check stubs as checks. They pretty much show the same information.
            Reports.Add("SuspenseByOwner", () => new SuspenseByOwner());
            Reports.Add("ExcelSuspenseByOwner", () => new ExcelSuspenseByOwner());
            Reports.Add("SuspenseByProperty", () => new SuspenseByProperty());
            Reports.Add("ExcelSuspenseByProperty", () => new ExcelSuspenseByProperty());
            Reports.Add("JIBARDetailByOwner", () => new JIBARDetailByOwner());
            Reports.Add("ExcelJIBARDetailByOwner", () => new ExcelJIBARDetailByOwner());
            Reports.Add("JIBHistoryByOwner", () => new JIBHistoryByOwner());
            Reports.Add("ExcelJIBHistoryByOwner", () => new ExcelJIBHistoryByOwner());
            Reports.Add("JIBHistoryByProperty", () => new JIBHistoryByProperty());
            Reports.Add("ExcelJIBHistoryByProperty", () => new ExcelJIBHistoryByOwner());
            Reports.Add("RDOwnerYTDActivity", () => new RDOwnerYTDActivity());
            Reports.Add("ExcelRDOwnerYTDActivity", () => new ExcelRDOwnerYTDActivity());
            Reports.Add("RDImportEditList", () => new RDImportEditList());
            Reports.Add("ExcelRDImportEditList", () => new ExcelRDImportEditList());
            Reports.Add("RDGLPostingRegister", () => new RDGLPostingRegister());
            Reports.Add("ExcelRDGLPostingRegister", () => new ExcelRDGLPostingRegister());
            Reports.Add("RDSuspenseSelectedForEscheatRegister", () => new RDSuspenseSelectedForEscheatRegister());
            Reports.Add("ExcelRDSuspenseSelectedForEscheatRegister", () => new ExcelRDSuspenseSelectedForEscheatRegister());
            Reports.Add("APOpenSelectedForEscheatRegister", () => new APOpenSelectedForEscheatRegister());
            Reports.Add("ExcelAPOpenSelectedForEscheatRegister", () => new ExcelAPOpenSelectedForEscheatRegister());
            Reports.Add("APChecks", () => new APChecks());
            Reports.Add("ExcelAPChecks", () => new ExcelAPChecks());
            Reports.Add("GeneralLedgerPostingRegister", () => new GLProcessPostRegister());
            Reports.Add("ExcelGeneralLedgerPostingRegister", () => new ExcelGLProcessPostRegister());
            Reports.Add("APCheckRegister", () => new APCheckRegister());
            Reports.Add("ExcelAPCheckRegister", () => new ExcelAPCheckRegister());
            Reports.Add("APCheckStubs", () => new APCheckStubs());
            Reports.Add("ExcelAPCheckStubs", () => new ExcelAPChecks());
            Reports.Add("APPrepaidRegister", () => new APPrepaidRegister());
            Reports.Add("ExcelAPPrepaidRegister", () => new ExcelAPPrepaidRegister());
            Reports.Add("RDImmediatePostRegister", () => new RDImmediatePostRegister());
            Reports.Add("ExcelRDImmediatePostRegister", () => new ExcelRDImmediatePostRegister());
            Reports.Add("APManualCheck", () => new APManualCheck());
            Reports.Add("ExcelAPManualCheck", () => new ExcelAPManualCheck());
            Reports.Add("RDNoCrossRefList", () => new RDNoCrossRefList());
            Reports.Add("ExcelRDNoCrossRefList", () => new ExcelRDNoCrossRefList());
            Reports.Add("RDSuspenseReleaseChecks", () => new RDSuspenseReleaseChecks());
            Reports.Add("ExcelRDSuspenseReleaseChecks", () => new ExcelRDSuspenseReleaseChecks());
            Reports.Add("PropertyCashFlow", () => new PropertyCashFlow());
            Reports.Add("ExcelPropertyCashFlow", () => new ExcelPropertyCashFlow());
            Reports.Add("PropertyCashFlowbyInterestType", () => new PropertyCashFlowbyInterestType());
            Reports.Add("ExcelPropertyCashFlowbyInterestType", () => new ExcelPropertyCashFlowbyInterestType());
            Reports.Add("PropertyCashFlowbyState", () => new PropertyCashFlowbyState());
            Reports.Add("ExcelPropertyCashFlowbyState", () => new ExcelPropertyCashFlowbyState());
            Reports.Add("OutstandingCheck", () => new OutstandingCheck());
            Reports.Add("ExcelOutstandingCheck", () => new ExcelOutstandingCheck());
            Reports.Add("OwnerNameAddress", () => new OwnerNameAddress());
            Reports.Add("ExcelOwnerNameAddress", () => new ExcelOwnerNameAddress());
            Reports.Add("VendorNameAddress", () => new VendorNameAddress());
            Reports.Add("ExcelVendorNameAddress", () => new ExcelVendorNameAddress());
            Reports.Add("VendorOptionsListing", () => new VendorOptionsListing());
            Reports.Add("ExcelVendorOptionsListing", () => new ExcelVendorOptionsListing());
            Reports.Add("OwnerOptions", () => new OwnerOptions());
            Reports.Add("ExcelOwnerOptions", () => new ExcelOwnerOptions());
            Reports.Add("DOIDeck", () => new DOIDeck());
            Reports.Add("ExcelDOIDeck", () => new ExcelDOIDeck());
            Reports.Add("VendorLabels", () => new VendorLabels());
            Reports.Add("ExcelVendorLabels", () => new ExcelVendorLabels());
            Reports.Add("OwnerLabels", () => new OwnerLabels());
            Reports.Add("ExcelOwnerLabels", () => new ExcelOwnerLabels());
            Reports.Add("GLPostingRegisterByProcess", () => new GLPostingRegisterByProcess());
            Reports.Add("ExcelGLPostingRegisterByProcess", () => new ExcelGLPostingRegisterByProcess());
            Reports.Add("OwnerLabelsByProperty", () => new OwnerLabelsByProperty());
            Reports.Add("ExcelOwnerLabelsByProperty", () => new ExcelOwnerLabelsByProperty());
            Reports.Add("PA_LAOGP", () => new PA_LAOGP());
            Reports.Add("ExcelPA_LAOGP", () => new ExcelPA_LAOGP());
            Reports.Add("PA_LAR5D", () => new PA_LAR5D());
            Reports.Add("ExcelPA_LAR5D", () => new ExcelPA_LAR5D());
            Reports.Add("PA_AllocationRegisterFinalized", () => new PA_AllocationRegisterFinalized());
            Reports.Add("ExcelPA_AllocationRegisterFinalized", () => new ExcelPA_AllocationRegisterFinalized());
            Reports.Add("PA_AllocationDecimalList", () => new PA_AllocationDecimalList());
            Reports.Add("ExcelPA_AllocationDecimalList", () => new ExcelPA_AllocationDecimalList());
            Reports.Add("PA_NMC115", () => new PA_NMC115());
            Reports.Add("ExcelPA_NMC115", () => new ExcelPA_NMC115());
            Reports.Add("JIBInvoices", () => new JIBInvoices());
            Reports.Add("ExcelJIBInvoices", () => new ExcelJIBInvoices());
            Reports.Add("JIBStatement", () => new JIBStatement());
            Reports.Add("ExcelJIBStatement", () => new ExcelJIBStatement());
            Reports.Add("JIBGLPostingRegister", () => new JIBGLPostingRegister());
            Reports.Add("ExcelJIBGLPostingRegister", () => new ExcelJIBGLPostingRegister());
            Reports.Add("JIBCompanyRecap", () => new JIBCompanyRecap());
            Reports.Add("ExcelJIBCompanyRecap", () => new ExcelJIBCompanyRecap());
            Reports.Add("JIBPropertyExpenseDistribution", () => new JIBPropertyExpenseDistribution());
            Reports.Add("ExcelJIBPropertyExpenseDistribution", () => new ExcelJIBPropertyExpenseDistribution());
            Reports.Add("JIBClearedItems", () => new JIBClearedItems());
            Reports.Add("ExcelJIBClearedItems", () => new ExcelJIBClearedItems());
            Reports.Add("ComparativeOperatingStatement", () => new ComparativeOperatingStatement());
            Reports.Add("ExcelComparativeOperatingStatement", () => new ExcelComparativeOperatingStatement());
            Reports.Add("NetComparativeOperatingStatement", () => new NetComparativeOperatingStatement());
            Reports.Add("ExcelNetComparativeOperatingStatement", () => new ExcelNetComparativeOperatingStatement());
            Reports.Add("RDOwnerLevelEntry", () => new RDOwnerLevelEntry());
            Reports.Add("ExcelRDOwnerLevelEntry", () => new ExcelRDOwnerLevelEntry());
            Reports.Add("LeaseOperatingStatement", () => new LeaseOperatingStatement());
            Reports.Add("ExcelLeaseOperatingStatement", () => new ExcelLeaseOperatingStatement());
            Reports.Add("PropertyListAllCompanies", () => new PropertyListAllCompanies());
            Reports.Add("ExcelPropertyListAllCompanies", () => new ExcelPropertyListAllCompanies());
            Reports.Add("AFEBudgetList", () => new AFEBudgetList());
            Reports.Add("ExcelAFEBudgetList", () => new ExcelAFEBudgetList());
            Reports.Add("ManualCheckList", () => new ManualCheckList());
            Reports.Add("ExcelManualCheckList", () => new ExcelManualCheckList());
            Reports.Add("ManualChecks", () => new ManualChecks());
            Reports.Add("ExcelManualCheck", () => new ExcelManualChecks());
            Reports.Add("RDStateWithholding", () => new RDStateWithholding());
            Reports.Add("ExcelRDStateWithholding", () => new ExcelRDStateWithholding());
            Reports.Add("ReplacementCheckRegister", () => new ReplacementCheckRegister());
            Reports.Add("ExcelReplacementCheckRegister", () => new ExcelReplacementCheckRegister());
            Reports.Add("PaymentByCheckHistory", () => new PaymentByCheckHistory());
            Reports.Add("ExcelPaymentByCheckHistory", () => new ExcelPaymentByCheckHistory());
            Reports.Add("SummaryWithholding", () => new SummaryWithholding());
            Reports.Add("ExcelSummaryWithholding", () => new ExcelSummaryWithholding());
            Reports.Add("CloseProfitAndLossPostingRegister", () => new CloseProfitAndLossPostingRegister());
            Reports.Add("ExcelCloseProfitAndLossPostingRegister", () => new ExcelCloseProfitAndLossPostingRegister());
            Reports.Add("LTM_LeaseDataSheet", () => new LTM_LeaseDataSheet());
            Reports.Add("ExcelLTM_LeaseDataSheet", () => new ExcelLTM_LeaseDataSheet());
            Reports.Add("TexasTaxProducerDetail", () => new TexasTaxProducerDetail());
            Reports.Add("ExcelTexasTaxProducerDetail", () => new ExcelTexasTaxProducerDetail());
            Reports.Add("TexasTaxProducerSummary", () => new TexasTaxProducerSummary());
            Reports.Add("ExcelTexasTaxProducerSummary", () => new ExcelTexasTaxProducerSummary());
            Reports.Add("APOutstandingAccountsPayableDetailWithProperty", () => new APOutstandingAccountsPayableDetailWithProperty());
            Reports.Add("ExcelAPOutstandingAccountsPayableDetailWithProperty", () => new ExcelAPOutstandingAccountsPayableDetailWithProperty());
            Reports.Add("APPayablesDetail", () => new APPayablesDetail());
            Reports.Add("ExcelAPPayablesDetail", () => new ExcelAPPayablesDetail());
            Reports.Add("APPayables", () => new APPayables());
            Reports.Add("ExcelAPPayables", () => new ExcelAPPayables());
            Reports.Add("DOIDivisionOrderNADOA", () => new DOIDivisionOrderNADOA());
            Reports.Add("ExcelDOIDivisionOrderNADOA", () => new ExcelDOIDivisionOrderNADOA());
            Reports.Add("DOIDivisionOrderTx", () => new DOIDivisionOrderTx());
            Reports.Add("ExcelDOIDivisionOrderTx", () => new ExcelDOIDivisionOrderTx());
            Reports.Add("CashDepositTicket", () => new CashDepositTicket());
            Reports.Add("ExcelCashDepositTicket", () => new ExcelCashDepositTicket());
            Reports.Add("NewMexicoStateTaxDetail", () => new NewMexicoStateTaxDetail());
            Reports.Add("ExcelNewMexicoStateTaxDetail", () => new ExcelNewMexicoStateTaxDetail());
            Reports.Add("CashDepositSummaryInquiry", () => new CashDepositSummaryInquiry());
            Reports.Add("ExcelCashDepositSummaryInquiry", () => new ExcelCashDepositSummaryInquiry());
            Reports.Add("NewMexicoStateRoyaltyDetail", () => new NewMexicoStateRoyaltyDetail());
            Reports.Add("ExcelNewMexicoStateRoyaltyDetail", () => new ExcelNewMexicoStateRoyaltyDetail());
            Reports.Add("PA_TexasPR", () => new Texas_PR());
            Reports.Add("ExcelPA_TexasPR", () => new ExcelTexas_PR());
            Reports.Add("JIBProvisionalEntries", () => new JIBProvisionalEntries());
            Reports.Add("ExcelJIBProvisionalEntries", () => new ExcelJIBProvisionalEntries());
            Reports.Add("PA_FedOGOR", () => new PA_FedOGOR());
            Reports.Add("ExcelPA_FedOGOR", () => new ExcelPA_FedOGOR());
            Reports.Add("PA_TexasH10", () => new PA_TexasH10());
            Reports.Add("PA_OSAGE101", () => new PA_OSAGE101());
            Reports.Add("PA_OSAGE101A", () => new PA_OSAGE101A());
            Reports.Add("PA_OSAGE133", () => new PA_OSAGE133());
            Reports.Add("PA_OSAGE157", () => new PA_OSAGE157());
            Reports.Add("PA_OSAGE300", () => new PA_OSAGE300());
            Reports.Add("JIBServiceCharges", () => new JIBServiceCharges());
            Reports.Add("ExcelJIBServiceCharges", () => new ExcelJIBServiceCharges());
            Reports.Add("PA_MiscDispositions", () => new PA_MiscDispositions());
            Reports.Add("CheckCoverPage", () => new CheckCoverPage());
            Reports.Add("RDColoradoDR0021W", () => new RDColoradoDR0021W());
            Reports.Add("ExcelRDColoradoDR0021W", () => new ExcelRDColoradoDR0021W());
            Reports.Add("RDColoradoDR0456", () => new RDColoradoDR0456());
            Reports.Add("ExcelRDColoradoDR0456", () => new ExcelRDColoradoDR0456());
            Reports.Add("JIBCompanyStatementRecap", () => new JIBCompanyStatementRecap());
            Reports.Add("ExcelJIBCompanyStatementRecap", () => new ExcelJIBCompanyStatementRecap());
        }
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>();
    }
}