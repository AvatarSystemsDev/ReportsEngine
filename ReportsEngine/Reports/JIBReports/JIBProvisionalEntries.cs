using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.JIBReports
{
    public partial class JIBProvisionalEntries : DevExpress.XtraReports.UI.XtraReport
    {
        public JIBProvisionalEntries()
        {
            InitializeComponent();
            //Parameter Selection Headers
            xrAccountsSelected.BeforePrint += xrAccountsSelected_BeforePrint;
            xrPropertiesSelected.BeforePrint += xrPropertiesSelected_BeforePrint;
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

    }
}
