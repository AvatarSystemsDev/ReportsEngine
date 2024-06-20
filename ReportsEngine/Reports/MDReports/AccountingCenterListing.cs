namespace ReportsEngine.Reports
{
    public partial class AccountingCenterListing : ReportWithDescriptionParameters
    {
        public AccountingCenterListing()
        {
            InitializeComponent();
            xrAccountingCentersSelected.BeforePrint += XrAccountingCentersSelected_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }
    }
}
