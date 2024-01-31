using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.ProcessReports
{
    public partial class JIBWriteOffSelection : DevExpress.XtraReports.UI.XtraReport
    {
        public JIBWriteOffSelection()
        {
            InitializeComponent();
            //WriteOffAccount.BeforePrint += WriteOffAccount_BeforePrint;
        }

        //private void WriteOffAccount_BeforePrint(object sender, CancelEventArgs e)
        //{
        //    XRLabel label = sender as XRLabel;
        //    Parameter p = this.Parameters["pstrSelectVendor"];
        //    label.Text = "Write-Off Account: " + ;
        //}
    }
}
