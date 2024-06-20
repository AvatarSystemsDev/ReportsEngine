namespace ReportsEngine.Reports.FinancialReports
{
    public partial class GLBudgetsSemiannual : ReportWithDescriptionParameters
    {
        public GLBudgetsSemiannual()
        {
            InitializeComponent();
            xrAccountingCentersSelected.BeforePrint += XrAccountingCentersSelected_BeforePrint;
            xrAccountsSelected.BeforePrint += XrAccountsSelected_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }
    }
}
