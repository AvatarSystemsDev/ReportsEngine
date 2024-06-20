namespace ReportsEngine.Reports
{
    public partial class APEditList : ReportWithDescriptionParameters
    {
        public APEditList()
        {
            InitializeComponent();
            xrOwnersSelected.BeforePrint += XrOwnersSelected_BeforePrint;
            xrPropertiesSelected.BeforePrint += XrPropertiesSelected_BeforePrint;
            xrEntitiesSelected.BeforePrint += XrVendorsSelected_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }
    }
}
