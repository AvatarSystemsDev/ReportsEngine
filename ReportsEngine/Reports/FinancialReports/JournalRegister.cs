using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class JournalRegister : DevExpress.XtraReports.UI.XtraReport
    {
        public JournalRegister()
        {
            InitializeComponent();
            xrAccountsSelected.BeforePrint += xrAccountsSelected_BeforePrint;
            xrPropertiesSelected.BeforePrint += xrPropertiesSelected_BeforePrint;
            xrAccountingCentersSelected.BeforePrint += xrAccountingCentersSelected_BeforePrint;
            xrBatchesSelected.BeforePrint += xrBatchesSelected_BeforePrint;
            xrEntitiesSelected.BeforePrint += xrEntitiesSelected_BeforePrint;
            xrOwnersSelected.BeforePrint += xrOwnersSelected_BeforePrint;
        }
        private void xrAccountsSelected_BeforePrint(object sender, CancelEventArgs e)
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
        private void xrAccountingCentersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectAccountingCenter"];
            Parameter start = this.Parameters["pstrBeginningCostCenterNumber"];
            Parameter end = this.Parameters["pstrEndingCostCenterNumber"];

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

        private void xrPropertiesSelected_BeforePrint(object sender, CancelEventArgs e)
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
                    label.Text = "All Properties";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Property to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                    {
                        label.Text += "Last Property";
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
                    label.Text = "Selected Properties";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Property to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                    {
                        label.Text += "Last Property";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }
        private void xrOwnersSelected_BeforePrint(object sender, CancelEventArgs e)
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
        private void xrBatchesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectBatch"];
            Parameter start = this.Parameters["plngBeginningBatchID"];
            Parameter end = this.Parameters["plngEndingBatchID"];

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
        private void xrEntitiesSelected_BeforePrint(object sender, CancelEventArgs e)
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
    }
}
