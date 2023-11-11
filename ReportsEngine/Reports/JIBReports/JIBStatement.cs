using DevExpress.CodeParser;
using DevExpress.Data.Browsing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Emit;

namespace ReportsEngine.Reports.JIBReports
{
    public partial class JIBStatement : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageIndex = 0;
        public JIBStatement()
        {
            InitializeComponent();
            xrPageCounter.BeforePrint += xrPageCounter_BeforePrint;
            pageHeaderBand.BeforePrint += PageHeaderBand_PrintOnPage;
            groupFooterBand1.BeforePrint  += GroupFooterBand1_BeforePrint;
            GroupHeaderPageBreak.BeforePrint += GroupHeaderPageBreak_PrintOnPage;
        }

        private void GroupHeaderPageBreak_PrintOnPage(object sender, CancelEventArgs e)
        {

        }

        private void GroupFooterBand1_BeforePrint(object sender, CancelEventArgs e)
        {
            pageIndex = 0;
        }

        private void PageHeaderBand_PrintOnPage(object sender, CancelEventArgs e)
        {
            // Access the report's PrintingSystem
            //PrintingSystemBase printingSystem = this.PrintingSystem;
            //// Get the current page number
            //int pageNumber = printingSystem.PageCount;

            //// Set visibility based on whether the page number is even or odd
            //// For example, to only show the group header on odd pages:
            //GroupHeaderPageBreak.Visible = (pageNumber % 2 != 0);



            //XRLabel label = sender as XRLabel;
            //if (label != null)
            //{
            //    int pageNumber = e.PageIndex + 1; // Adding 1 because PageIndex is zero-based
            //    if (pageNumber%2==0)
            //    {
            //        pageBreak
            //    }
            //}
        }

        private void xrPageCounter_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageIndex;
            pageIndex++;
        }

    }
}
