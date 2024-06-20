using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using ReportsEngine.Reports.RDReports;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.APReports
{
    public partial class AFEBudgetReceivables : ReportWithDescriptionParameters
    {
        public AFEBudgetReceivables()
        {
            InitializeComponent();
            xrPropertiesSelected.BeforePrint += XrPropertiesSelected_BeforePrint;
            xrSelectedAFEs.BeforePrint += XrAFEsSelected_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }        
    }
}
