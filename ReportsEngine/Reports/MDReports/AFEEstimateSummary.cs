using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.MDReports
{
    public partial class AFEEstimateSummary : ReportWithDescriptionParameters
    {
        private bool AFEOwnerBreakdownPart = false;
        private bool NextAFE = false;
        private int PageNumber = 1;
        public AFEEstimateSummary()
        {
            InitializeComponent();
            xrOwnerFooterLabel.PrintOnPage += xrOwnerFooterLabel_BeforePrint;
            xrOwnerFooterLabelEnd.PrintOnPage += XrOwnerFooterLabelEnd_BeforePrint;
            xrDescriptionAFESummary.PrintOnPage += XrDescriptionAFESummary_BeforePrint;
            xrEstimateCostAFESummary.PrintOnPage += XrEstimateCostAFESummary_BeforePrint;
            xrPageNumber.PrintOnPage += XrPageNumber_PrintOnPage;
            xrAFEOver.PrintOnPage += XrAFEOver_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }

        private void XrAFEOver_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            NextAFE = true;
        }

        private void XrPageNumber_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel PageNumberLabel = sender as XRLabel;
            if (NextAFE)
            {
                PageNumber = 1;
            }
            PageNumberLabel.Text = "Page " + PageNumber.ToString();
            PageNumber++;
            NextAFE = false;
        }

        private void XrEstimateCostAFESummary_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Visible = !AFEOwnerBreakdownPart;
        }

        private void XrDescriptionAFESummary_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Visible = !AFEOwnerBreakdownPart;
        }

        private void XrOwnerFooterLabelEnd_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            AFEOwnerBreakdownPart = false;
        }

        private void xrOwnerFooterLabel_BeforePrint(object sender, PrintOnPageEventArgs e)
        {
            AFEOwnerBreakdownPart = true;
        }
    }
}
