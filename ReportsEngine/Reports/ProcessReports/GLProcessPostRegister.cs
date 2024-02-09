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
        private int pageCounter = 1;
        public GLProcessPostRegister()
        {
            InitializeComponent();
            BatchFooter.PrintOnPage += BatchFooter_BeforePrint;
            xrPageCountPortrait.PrintOnPage += XrPageCountPortrait_BeforePrint;
            xrPageCountLandscape.PrintOnPage += XrPageCountLandscape_BeforePrint;
            RepeatEveryPageBand.PrintOnPage += RepeatEveryPageBand_BeforePrint;
            ReportHeader.PrintOnPage += ReportHeader_BeforePrint;
        }

        private void ReportHeader_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void RepeatEveryPageBand_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            pageCounter++;
        }

        private void XrPageCountLandscape_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageCounter.ToString();
        }

        private void XrPageCountPortrait_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageCounter.ToString();
        }

        private void BatchFooter_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }
    }
}
