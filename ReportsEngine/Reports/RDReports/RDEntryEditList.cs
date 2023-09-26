using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDEntryEditList : DevExpress.XtraReports.UI.XtraReport
    {
        public RDEntryEditList()
        {
            InitializeComponent();
            ShowingReportType.BeforePrint += ShowingReportType_BeforePrint;

        }

        private void ShowingReportType_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["plngReportType"];
            List<LookUpValue> staticValueCollection = (p.LookUpSettings as StaticListLookUpSettings).LookUpValues.ToList();
            (sender as XRLabel).Text = "Showing: " + staticValueCollection.FirstOrDefault(x => Object.Equals(x.Value, this.Parameters["plngReportType"].Value)).Description;
        }

    }
}
