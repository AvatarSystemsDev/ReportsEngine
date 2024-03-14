using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.APReports
{
    public partial class APCheckRemittanceSubreport : DevExpress.XtraReports.UI.XtraReport
    {
        int pageCounter = 2;
        bool pageRun = false;
        public APCheckRemittanceSubreport()
        {
            InitializeComponent();
            xrPages.PrintOnPage += XrPages_PrintOnPage;
            this.PrintOnPage += RDChecksRemittanceOnly_BeforePrint;
            groupHeaderBand2.PrintOnPage += GroupHeaderBand2_PrintOnPage;
            ReportHeader.PrintOnPage += ReportHeader_PrintOnPage;
            xrHeaderBand.PrintOnPage += XrHeaderBand_PrintOnPage;
            pageRun = false;
        }
        private void XrHeaderBand_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Parameter p = this.Parameters["plngOverflowOptionCode"];
            string code = p.Value.ToString();
            if (code == "1" || code == "2")
            {
                pageCounter = 1;
            }
            else
            {
                pageCounter = 2;
            }
            pageRun = false;
        }

        private void ReportHeader_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Parameter p = this.Parameters["plngOverflowOptionCode"];
            string code = p.Value.ToString();
            if (code == "1" || code == "2")
            {
                pageCounter = 1;
            }
            else
            {
                pageCounter = 2;
            }
            pageRun = false;
        }

        private void GroupHeaderBand2_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Parameter p = this.Parameters["plngOverflowOptionCode"];
            string code = p.Value.ToString();
            if (code == "1" || code == "2")
            {
                pageCounter = 1;
            }
            else
            {
                pageCounter = 2;
            }
            pageRun = false;
        }

        private void xrEndOfRemittanceLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Parameter p = this.Parameters["plngOverflowOptionCode"];
            string code = p.Value.ToString();
            if (code == "1" || code == "2")
            {
                pageCounter = 1;
            }
            else
            {
                pageCounter = 2;
            }
            pageRun = false;
        }

        private void RDChecksRemittanceOnly_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            Parameter p = this.Parameters["plngOverflowOptionCode"];
            string code = p.Value.ToString();
            if (code == "1" || code == "2")
            {
                pageCounter = 1;
            }
            else
            {
                pageCounter = 2;
            }
            pageRun = false;
        }

        private void XrPages_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (pageRun == false)
            {
                Parameter p = this.Parameters["plngOverflowOptionCode"];
                string code = p.Value.ToString();
                if (code == "1" || code == "2")
                {
                    pageCounter = 1;
                }
                else
                {
                    pageCounter = 2;
                }
                pageRun = true;
            }
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageCounter.ToString();
            pageCounter++;
        }
    }
}
