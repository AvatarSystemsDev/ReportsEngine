using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDImportEditList : DevExpress.XtraReports.UI.XtraReport
    {
        public RDImportEditList()
        {
            InitializeComponent();
            //this.BeforePrint += RDImportEditList_BeforePrint;
            
        }

        private void RDImportEditList_BeforePrint(object sender, CancelEventArgs e)
        {
            this.Landscape = this.Parameters["pbooShowDetail"].Value.ToString().ToLower() == "true";
            this.PaperKind = this.Parameters["pbooShowDetail"].Value.ToString().ToLower() == "true" ? DevExpress.Drawing.Printing.DXPaperKind.Legal : DevExpress.Drawing.Printing.DXPaperKind.Letter;
        }
    }
}
