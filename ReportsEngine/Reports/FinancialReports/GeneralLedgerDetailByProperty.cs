using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System;
using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class GeneralLedgerDetailByProperty : ReportWithDescriptionParameters
    {

        private double RunningBalance;
        private double BalanceForwardAmount;
        //private double RunningBalanceProperty;
        private int PreviousAccount;

        public GeneralLedgerDetailByProperty()
        {
            InitializeComponent();
            //Set initial total counts to zero
            this.BeforePrint += GeneralLedgerDetailByProperty_BeforePrint;

            //Parameter Selection Headers
            xrAccountsSelected.BeforePrint += XrAccountsSelected_BeforePrint;
            xrPropertiesSelected.BeforePrint += XrPropertiesSelected_BeforePrint;
            xrAccountingCentersSelected.BeforePrint += XrAccountingCentersSelected_BeforePrint;
            xrBatchesSelected.BeforePrint += XrBatchesSelected_BeforePrint;
            xrEntitiesSelected.BeforePrint += XrEntitiesSelected_BeforePrint;
            xrOwnersSelected.BeforePrint += XrOwnersSelected_BeforePrint;

            xrDebitForward.PrintOnPage += XrDebitForward_PrintOnPage;
            xrDebitForward.PrintOnPage += XrDebitForward_BeforePrint;
            xrCreditForward.PrintOnPage += XrCreditForward_PrintOnPage;
            xrCreditForward.PrintOnPage += XrCreditForward_BeforePrint;
            xrRunningBalance.PrintOnPage += XrRunningBalance_PrintOnPage;

            xrAccountRunningBalance.PrintOnPage += XrAccountRunningBalance_PrintOnPage;

            xrBalanceForward.BeforePrint += XrBalanceForward_BeforePrint;
            xrDebitLine.PrintOnPage += XrDebitLine_PrintOnPage;
            xrCreditLine.PrintOnPage += XrCreditLine_PrintOnPage;

            xrBalancedForwardAsteriskLabel.BeforePrint += XrBalancedForwardAsteriskLabel_BeforePrint;
            NewAccountLine.BeforePrint += NewAccountLine_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }

        private void NewAccountLine_BeforePrint(object sender, CancelEventArgs e)
        {
            var getGetCurrentColumnValue = GetCurrentColumnValue("AccountID").ToString();
            if (getGetCurrentColumnValue is null)
            {
                getGetCurrentColumnValue = "";
            }
            if (getGetCurrentColumnValue != "")
            {
                PreviousAccount = int.Parse(getGetCurrentColumnValue);
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

        private void XrBalanceForward_BeforePrint(object sender, CancelEventArgs e)
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
            if (getGetCurrentColumnValue is null || getGetCurrentColumnValue == "")
            {
                getGetCurrentColumnValue = "0";
            }
            if (RunningBalance < 0)
            {
                label.Text = '(' + (RunningBalance).ToString("N2").Replace("-", "") + ')';
                if (getGetCurrentColumnValue != "")
                {
                    PreviousAccount = int.Parse(getGetCurrentColumnValue);
                }
            }
            else
            {
                label.Text = (RunningBalance).ToString("N2");
                if (getGetCurrentColumnValue != "")
                {
                    PreviousAccount = int.Parse(getGetCurrentColumnValue);
                }
            }
        }

        private void XrCreditForward_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
                if (((XRLabel)sender).Text != "")
                {
                    try
                    {
                        RunningBalance -= Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                        BalanceForwardAmount -= Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                    }
                    catch
                    {

                    }
                }
        }

        private void XrDebitForward_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
                BalanceForwardAmount = 0;
                if (((XRLabel)sender).Text != "")
                {
                    try
                    {
                        RunningBalance += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                        BalanceForwardAmount += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                    }
                    catch
                    {

                    }
                }
        }

        private void XrCreditLine_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (((XRLabel)sender).Text != "")
            {
                try
                {
                    RunningBalance -= Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }

        private void XrDebitLine_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (((XRLabel)sender).Text != "")
            {
                try
                {
                    RunningBalance += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
                }
                catch
                {

                }
            }
        }
        private void GeneralLedgerDetailByProperty_BeforePrint(object sender, CancelEventArgs e)
        {
            RunningBalance = 0;
            BalanceForwardAmount = 0;
            PreviousAccount = 0;
        }
    }
}
