using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDGLPostingRegister : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter = 1;
        private string headerText = "";
        public RDGLPostingRegister()
        {
            InitializeComponent();
            xrPageCountPortrait.BeforePrint += XrPageCountPortrait_BeforePrint;
            xrPageCountLandscape.BeforePrint += XrPageCountLandscape_BeforePrint;
        }



        private void RepeatEveryPageBand_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private void XrPageCountLandscape_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            string newHeaderText = GetCurrentColumnValue("HeaderText") is null ? "" : GetCurrentColumnValue("HeaderText").ToString();

            label.Text = pageCounter.ToString();
            if (headerText != newHeaderText)
            {
                pageCounter++;
            }
            else
            {
                pageCounter = 1;
            }
            headerText = newHeaderText;
        }

        private void XrPageCountPortrait_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            string newHeaderText = GetCurrentColumnValue("HeaderText") is null ? "" : GetCurrentColumnValue("HeaderText").ToString();

            label.Text = pageCounter.ToString();
            if (headerText != newHeaderText)
            {
                pageCounter++;
            }
            else
            {
                pageCounter = 1;
            }
            headerText = newHeaderText;
        }
    }
}
