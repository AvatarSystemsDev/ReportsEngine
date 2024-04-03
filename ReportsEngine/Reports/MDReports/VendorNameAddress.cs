using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSpreadsheet.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace ReportsEngine.Reports.MDReports
{
    public partial class VendorNameAddress : DevExpress.XtraReports.UI.XtraReport
    {
        public VendorNameAddress()
        {
            InitializeComponent();
            xrVendorsSelected.BeforePrint += xrOwnersSelected_BeforePrint;
            xrRoleType.BeforePrint += XrRoleType_BeforePrint;
        }

        private void XrRoleType_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter roleType = this.Parameters["pstrSelectRoleTypeID"];
            if (roleType.MultiValue == false || roleType.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(roleType.LookUpSettings, dataContext);
            if (col.Count == (roleType.Value as Array).Length)
            {
                label.Text = "All Roles";
            }
            else if((roleType.Value as Array).Length == 1)
            {
                //Array roleTypeArray = roleType.Value as Array;
                //label.Text = roleTypeArray.GetValue(0).ToString();
            }
            else
            {
                label.Text = "Selected Roles";
            }
        }

        private void xrOwnersSelected_BeforePrint(object sender, CancelEventArgs e)
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
