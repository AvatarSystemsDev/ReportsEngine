using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class SummaryGeneralLedger : ReportWithDescriptionParameters
    {
        public SummaryGeneralLedger()
        {
            InitializeComponent();
            xrAccountsSelected.BeforePrint += XrAccountsSelected_BeforePrint;
            xrAccountingCentersSelected.BeforePrint += XrAccountingCentersSelected_BeforePrint;
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }
    }
}
