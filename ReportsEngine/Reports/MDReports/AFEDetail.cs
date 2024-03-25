using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.MDReports
{
    public partial class DetailAFE : DevExpress.XtraReports.UI.XtraReport
    {
        private int PageNumber = 1;
        private bool EndAFE = false;
        public DetailAFE()
        {
            InitializeComponent();
            xrAFEOver.PrintOnPage += XrAFEOver_PrintOnPage;
            xrPageNumber.PrintOnPage += XrPageNumber_PrintOnPage;
        }

        private void XrPageNumber_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel pageLabel = sender as XRLabel;
            pageLabel.Text = "Page " + PageNumber.ToString();
            if (!EndAFE)
            {
                PageNumber++;
            }
            else
            {
                EndAFE = true;
                PageNumber = 1;
            }

        }

        private void XrAFEOver_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            EndAFE = true;
        }
    }
}
