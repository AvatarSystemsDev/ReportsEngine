using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System;

namespace ReportsEngine.Reports
{
    public partial class AFEMasterList : ReportWithDescriptionParameters
    {
        public AFEMasterList()
        {
            InitializeComponent();
            xrAFEsSelected.BeforePrint += XrAFEsSelected_BeforePrint;
            xrOperatorsSelected.BeforePrint += XrOperatorsSelected_BeforePrint; ;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }
    }
}
