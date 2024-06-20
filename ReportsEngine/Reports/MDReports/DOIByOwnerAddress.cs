using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;

namespace ReportsEngine.Reports
{
    public partial class DOIbyOwnerAddress : ReportWithDescriptionParameters
    {
        public DOIbyOwnerAddress()
        {
            InitializeComponent();
            xrPropertiesSelected.BeforePrint += XrPropertiesSelected_BeforePrint;
            xrOwnersSelected.BeforePrint += XrOwnersSelected_BeforePrint;
            xrDeckCodesSelected.BeforePrint += XrDeckCodesSelected_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }
    }
}
