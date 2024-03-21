using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class IncomeAndExpenseStatement : DevExpress.XtraReports.UI.XtraReport
    {
        public IncomeAndExpenseStatement()
        {
            InitializeComponent();
            xrAccountingCentersSelected.BeforePrint += xrAccountingCentersSelected_BeforePrint;
        }

        private void xrAccountingCentersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter start = this.Parameters["pstrBeginningAccountingCenter"];
            Parameter end = this.Parameters["pstrEndingAccountingCenter"];

            if (true)
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
        }
    }
}
