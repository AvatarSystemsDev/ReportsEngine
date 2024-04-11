using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System;
using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class GeneralLedgerDetailByProperty : DevExpress.XtraReports.UI.XtraReport
    {
        //private double GrandAccountTotalDebitx;
        //private double GrandAccountTotalCreditx;

        //private double GrandPeriodTotalDebitx;
        //private double GrandPeriodTotalCreditx;

        //private double GrandPropertyTotalDebitx;
        //private double GrandPropertyTotalCreditx;

        //private double GrandPeriodTotalBalance;
        //private double GrandAccountTotalBalance;

        private double RunningBalance;
        private double BalanceForwardAmount;
        //private double RunningBalanceProperty;
        private int PreviousAccount;

        public GeneralLedgerDetailByProperty()
        {
            InitializeComponent();
            //Set initial total counts to zero
            this.BeforePrint += GeneralLedgerDetailByProperty_BeforePrint;

            //xrReportAccountSumDebit.PrintOnPage += xrReportAccountSumDebit_PrintOnPage;
            //xrReportAccountSumCredit.PrintOnPage += xrReportAccountSumCredit_PrintOnPage;

            //xrAccountTotalDebit.PrintOnPage += xrAccountTotalDebit_PrintOnPage;
            //xrAccountTotalCredit.PrintOnPage += xrAccountTotalCredit_PrintOnPage;

            //xrReportPeriodSumDebit.PrintOnPage += xrReportPeriodSumDebit_PrintOnPage;
            //xrReportPeriodSumCredit.PrintOnPage += xrReportPeriodSumCredit_PrintOnPage;

            //xrPeriodTotalDebit.PrintOnPage += xrPeriodTotalDebit_PrintOnPage;
            //xrPeriodTotalCredit.PrintOnPage += xrPeriodTotalCredit_PrintOnPage;

            //xrReportPropertySumDebit.PrintOnPage += xrReportPropertySumDebit_PrintOnPage;
            //xrReportPropertySumCredit.PrintOnPage += xrReportPropertySumCredit_PrintOnPage;

            //xrPropertyTotalDebit.PrintOnPage += xrPropertyTotalDebit_PrintOnPage;
            //xrPropertyTotalCredit.PrintOnPage += xrPropertyTotalCredit_PrintOnPage;

            //Parameter Selection Headers
            xrAccountsSelected.PrintOnPage += xrAccountsSelected_PrintOnPage;
            xrPropertiesSelected.PrintOnPage += xrPropertiesSelected_PrintOnPage;
            xrAccountingCentersSelected.PrintOnPage += xrAccountingCentersSelected_PrintOnPage;
            xrBatchesSelected.PrintOnPage += xrBatchesSelected_PrintOnPage;
            xrEntitiesSelected.PrintOnPage += xrEntitiesSelected_PrintOnPage;
            xrOwnersSelected.PrintOnPage += xrOwnersSelected_PrintOnPage;

            xrDebitForward.PrintOnPage += XrDebitForward_PrintOnPage;
            xrDebitForward.BeforePrint += XrDebitForward_BeforePrint;
            xrCreditForward.PrintOnPage += XrCreditForward_PrintOnPage;
            xrCreditForward.BeforePrint += XrCreditForward_BeforePrint;
            xrRunningBalance.PrintOnPage += XrRunningBalance_PrintOnPage;

            //xrPeriodRunningBalance.PrintOnPage += XrPeriodRunningBalance_PrintOnPage;
            //xrAccountRunningBalance.PrintOnPage += XrAccountRunningBalance_PrintOnPage;
            //xrReportPeriodSumBalance.PrintOnPage += XrReportPeriodSumBalance_PrintOnPage;
            //xrReportAccountSumBalance.PrintOnPage += XrReportAccountSumBalance_PrintOnPage;
            xrBalanceForward.BeforePrint += XrBalanceForward_BeforePrint;
            //xrPropertyRunningBalance.PrintOnPage += XrPropertyRunningBalance_PrintOnPage;
            //xrReportPropertySumBalance.PrintOnPage += XrReportPropertySumBalance_PrintOnPage;

            xrDebitLine.PrintOnPage += XrDebitLine_PrintOnPage;
            xrCreditLine.PrintOnPage += XrCreditLine_PrintOnPage;

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


        //private void XrReportPropertySumBalance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (GrandAccountTotalBalance < 0)
        //    {
        //        ((XRLabel)sender).Text = '(' + GrandAccountTotalBalance.ToString("N2").Replace("-", "") + ')';
        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = GrandAccountTotalBalance.ToString("N2");
        //    }
        //    GrandAccountTotalBalance = 0;
        //}

        //private void XrReportAccountSumBalance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (GrandAccountTotalBalance < 0)
        //    {
        //        ((XRLabel)sender).Text = '(' + GrandAccountTotalBalance.ToString("N2").Replace("-", "") + ')';
        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = GrandAccountTotalBalance.ToString("N2");
        //    }
        //}

        //private void XrReportPeriodSumBalance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (GrandPeriodTotalBalance < 0)
        //    {
        //        ((XRLabel)sender).Text = '(' + GrandPeriodTotalBalance.ToString("N2").Replace("-", "") + ')';
        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = GrandPeriodTotalBalance.ToString("N2");
        //    }
        //    GrandPeriodTotalBalance = 0;
        //}

        private void XrAccountRunningBalance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            //if (RunningBalance < 0)
            //{
            //    ((XRLabel)sender).Text = '(' + RunningBalance.ToString("N2").Replace("-", "") + ')';
            //    GrandAccountTotalBalance += RunningBalance;
            //    RunningBalanceProperty += RunningBalance;

            //}
            //else
            //{
            //    ((XRLabel)sender).Text = RunningBalance.ToString("N2");
            //    GrandAccountTotalBalance += RunningBalance;
            //    RunningBalanceProperty += RunningBalance;
            //}
            RunningBalance = 0;
        }

        //private void XrPropertyRunningBalance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (RunningBalanceProperty < 0)
        //    {
        //        ((XRLabel)sender).Text = '(' + RunningBalanceProperty.ToString("N2").Replace("-", "") + ')';

        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = RunningBalanceProperty.ToString("N2");
        //    }
        //    RunningBalanceProperty = 0;
        //}

        //private void XrPeriodRunningBalance_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (RunningBalance < 0)
        //    {
        //        ((XRLabel)sender).Text = '(' + (RunningBalance - BalanceForwardAmount).ToString("N2").Replace("-", "") + ')';

        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = (RunningBalance - BalanceForwardAmount).ToString("N2");
        //    }
        //    GrandPeriodTotalBalance += (RunningBalance - BalanceForwardAmount);
        //}


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
        private void xrAccountsSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectAccount"];
            Parameter start = this.Parameters["pstrBeginningAccountNumber"];
            Parameter end = this.Parameters["pstrEndingAccountNumber"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ-ZZZZ")
                {
                    label.Text = "All Accounts";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Account to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZ")
                    {
                        label.Text += "Last Account";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
            else if ((p.Value as Array).Length == 0)
            {
                label.Text = "No Values Selected";
            }
            else
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ-ZZZZ")
                {
                    label.Text = "Selected Accounts";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Account to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZ")
                    {
                        label.Text += "Last Account";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }
        private void xrAccountingCentersSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectAccountingCenter"];
            Parameter start = this.Parameters["pstrBeginningCostCenter"];
            Parameter end = this.Parameters["pstrEndingCostCenter"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZ")
                {
                    label.Text = "All Accounting Centers";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Accounting Center to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZ")
                    {
                        label.Text += "Last Accounting Center";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
            else if ((p.Value as Array).Length == 0)
            {
                label.Text = "No Values Selected";
            }
            else
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZ")
                {
                    label.Text = "Selected Accounting Centers";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Accounting Center to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZ")
                    {
                        label.Text += "Last Accounting Center";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }

        private void xrPropertiesSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectProperty"];
            Parameter start = this.Parameters["pstrBeginningPropertyNumber"];
            Parameter end = this.Parameters["pstrEndingPropertyNumber"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                {
                    label.Text = "All Properties/Wells";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Property/Well to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                    {
                        label.Text += "Last Property/Well";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
            else if ((p.Value as Array).Length == 0)
            {
                label.Text = "No Values Selected";
            }
            else
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                {
                    label.Text = "Selected Properties/Wells";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Property/Well to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                    {
                        label.Text += "Last Property/Well";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }
        private void xrOwnersSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectOwner"];
            Parameter start = this.Parameters["pstrBeginningOwnerNumber"];
            Parameter end = this.Parameters["pstrEndingOwnerNumber"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ")
                {
                    label.Text = "All Owners";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Owner to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ")
                    {
                        label.Text += "Last Owner";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
            else if ((p.Value as Array).Length == 0)
            {
                label.Text = "No Values Selected";
            }
            else
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ")
                {
                    label.Text = "Selected Owners";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Owner to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ")
                    {
                        label.Text += "Last Owner";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }
        private void xrBatchesSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectBatch"];
            Parameter start = this.Parameters["plngBeginningBatch"];
            Parameter end = this.Parameters["plngEndingBatch"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value is int && (int)start.Value == -1 && end.Value is int && (int)end.Value == 999999999)
                {
                    label.Text = "All Batches";
                }
                else
                {
                    if (start.Value is int && (int)start.Value == -1)
                    {
                        label.Text = "First Batch to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value is int && (int)end.Value == 999999999)
                    {
                        label.Text += "Last Batch";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
            else if ((p.Value as Array).Length == 0)
            {
                label.Text = "No Values Selected";
            }
            else
            {
                if (start.Value is int && (int)start.Value == -1 && end.Value is int && (int)end.Value == 999999999)
                {
                    label.Text = "Selected Batches";
                }
                else
                {
                    if (start.Value is int && (int)start.Value == -1)
                    {
                        label.Text = "First Batch to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value is int && (int)end.Value == 999999999)
                    {
                        label.Text += "Last Batch";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }
        private void xrEntitiesSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectVendor"];
            Parameter start = this.Parameters["pstrBeginningVendorNumber"];
            Parameter end = this.Parameters["pstrEndingVendorNumber"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ")
                {
                    label.Text = "All Entities";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Entity to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ")
                    {
                        label.Text += "Last Entity";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
            else if ((p.Value as Array).Length == 0)
            {
                label.Text = "No Values Selected";
            }
            else
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ")
                {
                    label.Text = "Selected Entities";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Entity to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ")
                    {
                        label.Text += "Last Entity";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }


        private void GeneralLedgerDetailByProperty_BeforePrint(object sender, CancelEventArgs e)
        {
            //GrandAccountTotalDebitx = 0;
            //GrandAccountTotalCreditx = 0;
            //GrandPeriodTotalDebitx = 0;
            //GrandPeriodTotalCreditx = 0;
            //GrandPropertyTotalDebitx = 0;
            //GrandPropertyTotalCreditx = 0;
            RunningBalance = 0;
            //RunningBalanceProperty = 0;
            //GrandAccountTotalBalance = 0;
            BalanceForwardAmount = 0;
            PreviousAccount = 0;
        }
        //private void xrAccountTotalDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    XRLabel label = sender as XRLabel;
        //    if (((XRLabel)sender).Text != "")
        //    {
        //        try
        //        {
        //            GrandAccountTotalDebitx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
        //        }
        //        catch
        //        {

        //        }
        //    }
        //}
        //private void xrAccountTotalCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    XRLabel label = sender as XRLabel;
        //    if (((XRLabel)sender).Text != "")
        //    {
        //        try
        //        {
        //            GrandAccountTotalCreditx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
        //        }
        //        catch
        //        {

        //        }
        //    }
        //}
        //private void xrPropertyTotalDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    XRLabel label = sender as XRLabel;
        //    if (((XRLabel)sender).Text != "")
        //    {
        //        try
        //        {
        //            GrandPropertyTotalDebitx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
        //        }
        //        catch
        //        {

        //        }
        //    }
        //}
        //private void xrPropertyTotalCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    XRLabel label = sender as XRLabel;
        //    if (((XRLabel)sender).Text != "")
        //    {
        //        try
        //        {
        //            GrandPropertyTotalCreditx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
        //        }
        //        catch
        //        {

        //        }
        //    }
        //}

        //private void xrReportAccountSumDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (GrandAccountTotalDebitx <= 0)
        //    {
        //        ((XRLabel)sender).Text = GrandAccountTotalDebitx.ToString("N2");
        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = GrandAccountTotalDebitx.ToString("N2");
        //    }
        //}
        //private void xrReportAccountSumCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (GrandAccountTotalDebitx <= 0)
        //    {
        //        ((XRLabel)sender).Text = GrandAccountTotalCreditx.ToString("N2");
        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = GrandAccountTotalCreditx.ToString("N2");
        //    }
        //}
        //private void xrReportPropertySumDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (GrandAccountTotalDebitx <= 0)
        //    {
        //        ((XRLabel)sender).Text = GrandPropertyTotalDebitx.ToString("N2");
        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = GrandPropertyTotalDebitx.ToString("N2");
        //    }
        //}
        //private void xrReportPropertySumCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (GrandAccountTotalDebitx <= 0)
        //    {
        //        ((XRLabel)sender).Text = GrandPropertyTotalCreditx.ToString("N2");
        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = GrandPropertyTotalCreditx.ToString("N2");
        //    }
        //}






        //private void xrPeriodTotalDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    XRLabel label = sender as XRLabel;
        //    if (((XRLabel)sender).Text != "")
        //    {
        //        try
        //        {
        //            GrandPeriodTotalDebitx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
        //        }
        //        catch
        //        {

        //        }
        //    }
        //}
        //private void xrPeriodTotalCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    XRLabel label = sender as XRLabel;
        //    if (((XRLabel)sender).Text != "")
        //    {
        //        try
        //        {
        //            GrandPeriodTotalCreditx += Double.Parse(((XRLabel)sender).Text.Replace(",", ""));
        //        }
        //        catch
        //        {

        //        }
        //    }
        //}


        //private void xrReportPeriodSumDebit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (GrandPeriodTotalDebitx <= 0)
        //    {
        //        ((XRLabel)sender).Text = GrandPeriodTotalDebitx.ToString("N2");
        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = GrandPeriodTotalDebitx.ToString("N2");
        //    }
        //}
        //private void xrReportPeriodSumCredit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (GrandPeriodTotalDebitx <= 0)
        //    {
        //        ((XRLabel)sender).Text = GrandPeriodTotalCreditx.ToString("N2");
        //    }
        //    else
        //    {
        //        ((XRLabel)sender).Text = GrandPeriodTotalCreditx.ToString("N2");
        //    }
        //}


    }
}
