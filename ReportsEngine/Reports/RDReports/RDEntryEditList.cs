using DevExpress.Utils.Helpers;
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
    public partial class RDEntryEditList : ReportWithDescriptionParameters
    {
        public RDEntryEditList()
        {
            InitializeComponent();
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }

        private void ShowingReportType_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["plngReportType"];
            List<LookUpValue> staticValueCollection = (p.LookUpSettings as StaticListLookUpSettings).LookUpValues.ToList();
            (sender as XRLabel).Text = "Report Type:  " + staticValueCollection.FirstOrDefault(x => Object.Equals(x.Value, this.Parameters["plngReportType"].Value)).Description;
        }

    }
}
