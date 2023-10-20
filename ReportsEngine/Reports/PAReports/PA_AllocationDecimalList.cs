using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.MDReports
{
    public partial class PA_AllocationDecimalList : DevExpress.XtraReports.UI.XtraReport
    {
        private int rowCountInnerGroup = 0;
        private int rowCountOuterGroup = 0;
        public PA_AllocationDecimalList()
        {
            InitializeComponent();
            xrUWRow.AfterPrint += xrUWRow_AfterPrint;
            InnerGroupFooter.AfterPrint += InnerGroupFooter_AfterPrint;
            OuterGroupFooter.AfterPrint += OuterGroupFooter_AfterPrint;
            this.BeforePrint += PA_AllocationDecimalList_BeforePrint;
        }



        private void PA_AllocationDecimalList_BeforePrint(object sender, CancelEventArgs e)
        {
            rowCountInnerGroup = 0;
            rowCountOuterGroup = 0;
        }

        private void InnerGroupFooter_AfterPrint(object sender, EventArgs e)
        {
            if (rowCountInnerGroup <= 1)
            {
                InnerGroupFooter.Visible = false;
            }
            else
            {
                InnerGroupFooter.Visible = true;
            }
            rowCountOuterGroup++;
            rowCountInnerGroup = 0;

        }
        private void OuterGroupFooter_AfterPrint(object sender, EventArgs e)
        {
            if (rowCountOuterGroup <= 1)
            {
                OuterGroupFooter.Visible = false;
            }
            else
            {
                OuterGroupFooter.Visible = true;
            }
            rowCountOuterGroup = 0;
            rowCountInnerGroup = 0;
        }

        private void xrUWRow_AfterPrint(object sender, EventArgs e)
        {
            if (xrUWRow.Visible)
            {
                rowCountInnerGroup++;
            }

        }
    }
}
