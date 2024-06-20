using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.PAReports
{
    public partial class LeaseOperatingStatement : ReportWithDescriptionParameters
    {
        public LeaseOperatingStatement()
        {
            InitializeComponent();
            xrPropertiesSelected.BeforePrint += XrPropertiesSelected_BeforePrint;
            xrOwnersSelected.BeforePrint += XrOwnersSelected_BeforePrint;
            xrAcquisitionSelection.BeforePrint += xrAcquisitionSelection_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }
        private void xrAcquisitionSelection_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["plngAcquisitionID"];
            if (string.IsNullOrEmpty((p.Value + "")) || ((p.Value +"" == "0")))
            {
                label.Text = "All Acquisitions";
            }
            else
            {
                label.Text = p.Value+": "+p.Description;
            }
        }
    }
}
