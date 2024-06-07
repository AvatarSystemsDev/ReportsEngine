using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace ReportsEngine.Reports.CommonReportsFunctions
{
    internal class XSelected_PrintOnPageLabelFunction
    {
        internal void XrChecksSelected_PrintOnPage(object sender, PrintOnPageEventArgs e, ParameterCollection Parameters,)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = Parameters["pstrSelectAPCheckID"];
            Parameter start = Parameters["plngBeginningCheckSortNumber"];
            Parameter end = Parameters["plngEndingCheckSortNumber"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value.ToString() == "0" && end.Value.ToString() == "999999999")
                {
                    label.Text = "All Checks";
                }
                else
                {
                    if (start.Value.ToString() == "0")
                    {
                        label.Text = "First Check to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "999999999")
                    {
                        label.Text += "Last Check";
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
                if (start.Value.ToString() == "0" && end.Value.ToString() == "999999999")
                {
                    label.Text = "Selected Checks";
                }
                else
                {
                    if (start.Value.ToString() == "0")
                    {
                        label.Text = "First Check to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "999999999")
                    {
                        label.Text += "Last Check";
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