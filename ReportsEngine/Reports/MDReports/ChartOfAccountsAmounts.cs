namespace ReportsEngine.Reports.MDReports
{
    public partial class ChartOfAccountsAmounts : ReportWithDescriptionParameters
    {
        public ChartOfAccountsAmounts()
        {
            InitializeComponent();
            xrAccountsSelected.BeforePrint += XrAccountsSelected_BeforePrint;
            xrSelectAccountingCenters.BeforePrint += XrAccountingCentersSelected_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }

    }
}
