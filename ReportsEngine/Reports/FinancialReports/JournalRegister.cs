using DevExpress.DataAccess.DataFederation;
using System;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class JournalRegister : ReportWithDescriptionParameters
    {
        public JournalRegister()
        {
            InitializeComponent();
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            xrAccountsSelected.BeforePrint += XrAccountsSelected_BeforePrint;
            xrAccountingCentersSelected.BeforePrint += XrAccountingCentersSelected_BeforePrint;
            xrEntitiesSelected.BeforePrint += XrEntitiesSelected_BeforePrint;
            xrOwnersSelected.BeforePrint += XrOwnersSelected_BeforePrint;
            xrPropertiesSelected.BeforePrint += XrPropertiesSelected_BeforePrint;
            xrBatchesSelected.BeforePrint += XrBatchesSelected_BeforePrint;
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.BeforePrint += EnableDescriptionParametersOnDataSourceDemanded;
            this.BeforePrint += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters, true);
        }
    }
}
