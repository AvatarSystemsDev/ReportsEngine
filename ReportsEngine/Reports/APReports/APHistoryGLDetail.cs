using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace ReportsEngine.Reports.APReports
{
    public partial class APHistoryGLDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public APHistoryGLDetail()
        {
            InitializeComponent();
            xrDisplayDateUsed.BeforePrint += xrDisplayDateUsed_BeforePrint;

        }

        private void xrDisplayDateUsed_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["plngDateUsed"];
            List<LookUpValue> staticValueCollection = (p.LookUpSettings as StaticListLookUpSettings).LookUpValues.ToList();
            (sender as XRLabel).Text = staticValueCollection.FirstOrDefault(x => Object.Equals(x.Value, this.Parameters["plngDateUsed"].Value)).Description;
        }

        private void xrLabel1_BeforePrint(object sender, CancelEventArgs e)
        {

        }
    }
}
