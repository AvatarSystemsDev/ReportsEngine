using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.RDReports
{
    public partial class JIBGLPostingRegister : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter = 1;
        public JIBGLPostingRegister()
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
            pageCounter = 1;
        }

        private void RepeatEveryPageBand_BeforePrint(object sender, CancelEventArgs e)
        {
            pageCounter++;
        }

        private void XrPageCountLandscape_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = pageCounter.ToString();
        }

        private void XrPageCountPortrait_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = pageCounter.ToString();
        }

        private void BatchFooter_BeforePrint(object sender, CancelEventArgs e)
        {
            pageCounter = 1;
        }
    }
}
