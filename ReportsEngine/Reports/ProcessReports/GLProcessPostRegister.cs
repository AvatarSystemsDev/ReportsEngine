using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.ProcessReports
{
    public partial class GLProcessPostRegister : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageNumber = 1;
        public GLProcessPostRegister()
        {
            InitializeComponent();
            xrPageLabel.PrintOnPage += XrPageLabel_PrintOnPage;
        }

        private void XrPageLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel xrPageLabel = sender as XRLabel;
            xrPageLabel.Text = "Page " + pageNumber;
            pageNumber++;
        }

        private void GLProcessPostRegister_BeforePrint(object sender, CancelEventArgs e)
        {
            pageNumber = 1;
        }
    }
}
