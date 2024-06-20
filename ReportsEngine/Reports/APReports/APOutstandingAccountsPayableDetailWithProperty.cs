using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.APReports
{
    public partial class APOutstandingAccountsPayableDetailWithProperty : ReportWithDescriptionParameters
    {
        public APOutstandingAccountsPayableDetailWithProperty()
        {
            InitializeComponent();
            xrPropertiesSelected.BeforePrint += XrPropertiesSelected_BeforePrint;
            xrEntitiesSelected.BeforePrint += XrVendorsSelected_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }
    }
}
