using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports;
using System;

namespace ReportsEngine.Reports
{
    public partial class Report1 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report1()
        {
            InitializeComponent();

            var dataSources = DataSourceManager.GetDataSources(this, true);
            foreach (var dataSource in dataSources)
            {
                if (dataSource is SqlDataSource sds && !String.IsNullOrEmpty(sds.ConnectionName))
                {
                    OlapConnectionParameters olapParams = new OlapConnectionParameters();
                    olapParams.ConnectionString = "XpoProvider = MSSqlServer; Data Source = Developer1; User ID = reportuser; Password = Re.port_243; Initial Catalog = ProvidenceTestingMB; Persist Security Info = true";
                    sds.ConnectionParameters = olapParams;
                }
            }
        }

    }
}
