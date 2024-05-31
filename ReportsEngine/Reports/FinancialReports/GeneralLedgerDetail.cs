using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
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
            Parameter start = this.Parameters["plngBeginningBatch"];
            Parameter end = this.Parameters["plngEndingBatch"];
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
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
        private void GeneralLedgerDetail_BeforePrint(object sender, CancelEventArgs e)
        {
            RunningBalance = 0;
            BalanceForwardAmount = 0;
            PreviousAccount = 0;            
        }
    }
}
