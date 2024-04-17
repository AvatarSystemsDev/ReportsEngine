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
            this.Landscape = this.Parameters["pbooShowDetail"].Value.ToString().ToLower() == "true";
        }

    }
}
