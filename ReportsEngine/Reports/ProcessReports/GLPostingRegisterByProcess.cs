using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.MDReports
{
    public partial class GLPostingRegisterByProcess : DevExpress.XtraReports.UI.XtraReport
    {
        int pageCounter = 0;
        public GLPostingRegisterByProcess()
        {
            InitializeComponent();
            BatchFooter.BeforePrint += BatchFooter_BeforePrint;
            xrPageCountPortrait.BeforePrint += XrPageCountPortrait_BeforePrint;
            xrPageCountLandscape.BeforePrint += XrPageCountLandscape_BeforePrint;
            RepeatEveryPageBand.BeforePrint += RepeatEveryPageBand_BeforePrint;
            ReportHeader.BeforePrint += ReportHeader_BeforePrint;
        }

        private void ReportHeader_BeforePrint(object sender, CancelEventArgs e)
        {
            pageCounter = 0;
        }

        private void RepeatEveryPageBand_BeforePrint(object sender, CancelEventArgs e)
        {
            pageCounter++;
        }

        private void XrPageCountLandscape_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageCounter.ToString();
        }

        private void XrPageCountPortrait_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageCounter.ToString();
        }

        private void BatchFooter_BeforePrint(object sender, CancelEventArgs e)
        {
            pageCounter = 0;
        }
    }
}
