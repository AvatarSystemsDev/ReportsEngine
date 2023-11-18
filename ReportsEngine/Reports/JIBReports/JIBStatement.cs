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
        private int pageIndexStatement;
        private bool isSubreport;
        private bool didOnce;
        private bool didAnotherThingBefore;
        private bool didAnotherThingBeforeThat;


        private int totalPages;
        public JIBStatement()
        {
            InitializeComponent();
            xrPageCounter.BeforePrint += xrPageCounter_BeforePrint;
            //pageHeaderBand.BeforePrint += PageHeaderBand_PrintOnPage;
            //groupFooterBand1.BeforePrint  += GroupFooterBand1_BeforePrint;
            //GroupHeaderPageBreak.BeforePrint += GroupHeaderPageBreak_PrintOnPage;
            //JIBInvoiceSubBand.BeforePrint += JIBInvoiceSubBand_BeforePrint;
            //JIBInvoiceSubBand.AfterPrint += JIBInvoiceSubBand_AfterPrint;
            //StartInvoicesBand.BeforePrint += StartInvoicesBand_BeforePrint;
            //AfterJIBInvoiceSubBand.BeforePrint += AfterJIBInvoiceSubBand_BeforePrint;
            PageFooterStatement.BeforePrint += PageFooter_BeforePrint;
            this.BeforePrint += JIBStatement_BeforePrint;
            InvoiceSubreport.BeforePrint += InvoiceSubreport_BeforePrint;
            InvoiceSubreport.AfterPrint += InvoiceSubreport_AfterPrint;

        }

        private void InvoiceSubreport_AfterPrint(object sender, EventArgs e)
        {
            pageIndexStatement = -1;
            isSubreport = false;
        }

        private void InvoiceSubreport_BeforePrint(object sender, CancelEventArgs e)
        {
            pageIndexStatement = 0;
            isSubreport = true;
        }

        private void PageFooter_BeforePrint(object sender, CancelEventArgs e)
        {
            if (isSubreport == false && !didOnce && didAnotherThingBefore && didAnotherThingBeforeThat)
            {
                pageIndexStatement+=1;
            }
            else if (isSubreport)
            {
                pageIndexStatement = 1;
            }
            if (didAnotherThingBefore)
            {
                didAnotherThingBeforeThat = true;
            }
            didAnotherThingBefore = true;
            didOnce = !didOnce;
            totalPages += 1;
        }

        private void xrPageCounter_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            if (pageIndexStatement == 0 || isSubreport)
            {
                label.Text = "";
            }
            else if (pageIndexStatement == -1)
            {
                label.Text = "1";
            }
            else
            {
                label.Text = "" + pageIndexStatement;
            }
        }

        private void JIBStatement_BeforePrint(object sender, CancelEventArgs e)
        {
            pageIndexStatement = -1;
            totalPages = 1;
            isSubreport = false;
            didOnce = false;
            didAnotherThingBefore = false;
            didAnotherThingBeforeThat = false;
        }
    }
}
