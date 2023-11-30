using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace ReportsEngine.Reports.PAReports
{
    public partial class Texas_PR : DevExpress.XtraReports.UI.XtraReport
    {
        private string prevsValue = "";
        public Texas_PR()
        {
            InitializeComponent();
            xrChange.BeforePrint += xrChange_BeforePrint;
            prevsValue = "";
        }
        private void xrChange_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            var currentRow = this.GetCurrentRow() as DataRowView; // Using DataRowView for a more generic approach

            if (currentRow != null)
            {
                string leaseType = currentRow["PA_TXP_LEASETYPE"].ToString();
                string stfedwid = currentRow["PA_TXP_STFEDWID"].ToString();
                string staprprnam = currentRow["PA_TXP_STAPRPNAM"].ToString();

                string currentValue = leaseType == "G" && stfedwid.Length > 0
                                      ? $"{staprprnam} ({stfedwid})"
                                      : staprprnam;

                if (currentValue == prevsValue)
                {
                    label.Text = "";
                }
                else
                {
                    label.Text = currentValue;
                    prevsValue = currentValue;
                }
            }

        }
    }
}
