using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.Utils.About;
using DevExpress.Web.Internal.XmlProcessor;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

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
