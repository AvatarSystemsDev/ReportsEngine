using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace ReportsEngine.Reports.MDReports
{
    public partial class OwnerNameAddress : ReportWithDescriptionParameters
    {
        public OwnerNameAddress()
        {
            InitializeComponent();
            xrOwnersSelected.BeforePrint += XrOwnersSelected_BeforePrint;
            xrSortBy.BeforePrint += xrSortBy_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }

        private void xrSortBy_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["plngSortOrder"];
            List<LookUpValue> staticValueCollection = (p.LookUpSettings as StaticListLookUpSettings).LookUpValues.ToList();
            (sender as XRLabel).Text = staticValueCollection.FirstOrDefault(x => Object.Equals(x.Value, this.Parameters["plngSortOrder"].Value)).Description;
        }
    }
}
