using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using ReportsEngine.Reports.CommonReportsFunctions;
using ReportsEngine.Services;
using System.Diagnostics;
using System.Globalization;
using DevExpress.CodeParser;
using DevExpress.XtraReports.Web.WebDocumentViewer.DataContracts;
using Newtonsoft.Json;

namespace ReportsEngine.Reports
{
    public partial class GeneralLedgerDetail : DevExpress.XtraReports.UI.XtraReport
    {
        private double RunningBalance;
        private double BalanceForwardAmount;
        private int PreviousAccount;
        public GeneralLedgerDetail()
        {
            InitializeComponent();
            this.BeforePrint += GeneralLedgerDetail_BeforePrint;

            xrAccountsSelected.PrintOnPage += xrAccountsSelected_PrintOnPage;
            xrPropertiesSelected.PrintOnPage += xrPropertiesSelected_PrintOnPage;
            xrAccountingCentersSelected.PrintOnPage += xrAccountingCentersSelected_PrintOnPage;
            xrBatchesSelected.PrintOnPage += xrBatchesSelected_PrintOnPage;
            xrEntitiesSelected.PrintOnPage += xrEntitiesSelected_PrintOnPage;
            xrOwnersSelected.PrintOnPage += xrOwnersSelected_PrintOnPage;
            xrDebitLine.PrintOnPage += XrDebitLine_PrintOnPage;
            xrCreditLine.PrintOnPage += XrCreditLine_PrintOnPage;
            // Balance forward
            xrDebitForward.PrintOnPage += XrDebitForward_PrintOnPage;
            xrDebitForward.BeforePrint += XrDebitForward_BeforePrint;

            xrCreditForward.PrintOnPage += XrCreditForward_PrintOnPage;
            xrCreditForward.BeforePrint += XrCreditForward_BeforePrint;

            xrRunningBalance.PrintOnPage += XrRunningBalance_PrintOnPage;

            xrAccountRunningBalance.PrintOnPage += XrAccountRunningBalance_PrintOnPage;
            xrBalanceForward.BeforePrint += xrBalanceForward_BeforePrint;
            xrBalancedForwardAsteriskLabel.BeforePrint += XrBalancedForwardAsteriskLabel_BeforePrint;
            NewAccountLine.BeforePrint += NewAccountLine_BeforePrint;
        }

        private void NewAccountLine_BeforePrint(object sender, CancelEventArgs e)
        {
            var getGetCurrentColumnValue = GetCurrentColumnValue("AccountID").ToString();
            if (getGetCurrentColumnValue is null)
            {
                getGetCurrentColumnValue = "";
            }
            if (getGetCurrentColumnValue != "") { 
                PreviousAccount = int.Parse(getGetCurrentColumnValue);
            }
        }

        private void XrDebitForward_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            var getGetCurrentColumnValue = GetCurrentColumnValue("AccountID").ToString();
            if (getGetCurrentColumnValue is null)
            {
                getGetCurrentColumnValue = "";
            }
            if (getGetCurrentColumnValue == "" || PreviousAccount == int.Parse(getGetCurrentColumnValue))
            {
                label.Text = "";
            }
        }

        private void XrCreditForward_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            var getGetCurrentColumnValue = GetCurrentColumnValue("AccountID").ToString();
            if (getGetCurrentColumnValue is null)
            {
                getGetCurrentColumnValue = "";
            }
            if (getGetCurrentColumnValue == "" || PreviousAccount == int.Parse(getGetCurrentColumnValue))
            {
                label.Text = "";

            }
        }

        private void xrBalanceForward_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            var getGetCurrentColumnValue = GetCurrentColumnValue("AccountID").ToString();
            if (getGetCurrentColumnValue is null)
            {
                getGetCurrentColumnValue = "";
            }
            if (getGetCurrentColumnValue == "" || PreviousAccount == int.Parse(getGetCurrentColumnValue))
            {
                label.Text = "";
            }
        }

        private void XrBalancedForwardAsteriskLabel_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            var getGetCurrentColumnValue = GetCurrentColumnValue("AccountID").ToString();
            if (getGetCurrentColumnValue is null)
            {
                getGetCurrentColumnValue = "";
            }
            if (getGetCurrentColumnValue == "" || PreviousAccount == int.Parse(getGetCurrentColumnValue))
            {
                label.Text = "";
            }
        }

        private void XrAccountRunningBalance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            RunningBalance = 0;
        }

        private void XrRunningBalance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;

            string text = label.Text.Replace(",", "");
            text = text.Replace("(", "-");
            text = text.Replace(")", "");
            var getGetCurrentColumnValue = GetCurrentColumnValue("AccountID").ToString();
            if (getGetCurrentColumnValue is null)
            {
                getGetCurrentColumnValue = "";
            }

            double netAmountCurrent = Double.Parse(text);
                if (RunningBalance + netAmountCurrent < 0)
                {
                    label.Text = '(' + (RunningBalance + netAmountCurrent).ToString("N2").Replace("-", "") + ')';
                if (getGetCurrentColumnValue != "")
                {
                    PreviousAccount = int.Parse(getGetCurrentColumnValue);
                }
            }
                else
                {
                    label.Text = (RunningBalance + netAmountCurrent).ToString("N2");
                if (getGetCurrentColumnValue != "")
                {
                    PreviousAccount = int.Parse(getGetCurrentColumnValue);
                }
            }
        }

        private void XrCreditForward_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
                try
                {
                    RunningBalance -= Double.Parse(label.Text.Replace(",", ""));
                    BalanceForwardAmount -= Double.Parse(label.Text.Replace(",", ""));
                }
                catch
                {

                }
            
        }

        private void XrDebitForward_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
                BalanceForwardAmount = 0;
                if (label.Text != "")
                {
                    try
                    {
                        RunningBalance += Double.Parse(label.Text.Replace(",", ""));
                        BalanceForwardAmount += Double.Parse(label.Text.Replace(",", ""));
                    }
                    catch
                    {

                    }
                }
        }

        private void XrCreditLine_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (label.Text != "")
            {
                try
                {
                    RunningBalance -= Double.Parse(label.Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }

        private void XrDebitLine_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (label.Text != "")
            {
                try
                {
                    RunningBalance += Double.Parse(label.Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }

        private void xrAccountsSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Account", this.Name, true, true);
        }

        private void xrAccountingCentersSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "AccountingCenter", this.Name, true, true);
        }

        private void xrPropertiesSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Property", this.Name, true, true);
        }
        private void xrOwnersSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Owner", this.Name, true, true);
        }
        private void xrBatchesSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Batch", this.Name, false, true);
        }
        private void xrEntitiesSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Vendor", this.Name, true, true);
        }
        private void GeneralLedgerDetail_BeforePrint(object sender, CancelEventArgs e)
        {
            RunningBalance = 0;
            BalanceForwardAmount = 0;
            PreviousAccount = 0;            
        }
    }
}
