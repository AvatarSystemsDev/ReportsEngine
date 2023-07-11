using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.Security.Resources;
using DevExpress.Utils.About;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Microsoft.AspNet.Identity;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;


namespace ReportsEngine.Reports
{
    public partial class DOIbyOwner : DevExpress.XtraReports.UI.XtraReport
    {
        public DOIbyOwner()
        {
            InitializeComponent();

            // Assign Query
            //SelectQuery query = SelectQueryFluentBuilder
            //    .AddTable("Categories")
            //    .SelectAllColumns()
            //    .Build("Categories");
            //this.sqlDataSource1.Queries.Clear();
            //this.sqlDataSource1.Queries.Add(query);

            // Assign a set of values to the report parameter.
            //this.parameter1.Value = new int[] { 1, 2, 3 };

            // Handle the DataSourceDemanded event of a report.
            // EventHandler<EventArgs> dataSourceDemanded +=

            //pstrServerName.Value = "Developer1";
            //pstrDatabaseName.Value = "Providence";
            //string user = "reportuser";
            //string password = "Re.port_243";
            //plngCompanyID.Value = 1;
            //plngUserID.Value = 1043;

            //string PulseServerName = "Pulse.Avatar.Local";
            //string PulseDatabaseName = "AvatarPulse";
            //string Pulseuser = "RoyaltyOwnerRelationsUser";
            //string Pulsepassword = "SzCz0tka";

            //string connectionStringDynamic = @"XpoProvider=MSSqlServer;Data Source=" + pstrServerName.Value + "; User ID=" + user + ";Password=" + password + ";Initial Catalog=" + pstrDatabaseName.Value + ";Persist Security Info=true;";
            //string connectionStringPulse = @"XpoProvider=MSSqlServer;Data Source=" + PulseServerName + "; User ID=" + Pulseuser + ";Password=" + Pulsepassword + ";Initial Catalog=" + PulseDatabaseName + ";Persist Security Info=true;";

            //var dataSources = DataSourceManager.GetDataSources(this, true);
            //foreach (var dataSource in dataSources)
            //{
            //    if (dataSource is DevExpress.DataAccess.Sql.SqlDataSource sds && !String.IsNullOrEmpty(sds.ConnectionName))
            //    {
            //        if (sds.Name == "Dynamic")
            //        {
            //            OlapConnectionParameters olapParams = new OlapConnectionParameters();
            //            olapParams.ConnectionString = connectionStringDynamic;
            //            sds.ConnectionParameters = olapParams;
            //        }
            //        else
            //        {
            //            if (sds.Name == "Pulse")
            //            {
            //                OlapConnectionParameters olapParams = new OlapConnectionParameters();
            //                olapParams.ConnectionString = connectionStringPulse;
            //                sds.ConnectionParameters = olapParams;
            //            }

            //        }

            //    }
            //}

            // Handle the DataSourceDemanded event of a report.
            //this.DataSourceDemanded += DOIbyOwner_DataSourceDemanded;
            this.BeforePrint += DOIbyOwner_BeforePrint;
        }

        private void DOIbyOwner_DataSourceDemanded(object sender, EventArgs e)
        {
            var x = this;
            
            //var dataSources = DataSourceManager.GetDataSources(this, true);
            //foreach (var dataSource in dataSources)
            //{
            //    if (dataSource is DevExpress.DataAccess.Sql.SqlDataSource sds && !String.IsNullOrEmpty(sds.ConnectionName))
            //    {
            //        if (sds.Name == "Pulse")
            //        {
            //            FindControl("Textbox5", true).ExpressionBindings.
            //            Add(new ExpressionBinding()
            //            {
            //                EventName = "BeforePrint",
            //                PropertyName = "Text",
            //                Expression = "[FirstName]"
            //            });

            //        }
            //    }
            //}
            
        }

        private void DOIbyOwner_BeforePrint(object sender, CancelEventArgs e)
        {   
            string path =  @"..\Styles\";
            // Set the report's StyleSheetPath property to specify the report's style sheet.
            ((XtraReport)this).StyleSheetPath = path + "xr9ptBLStyle.repss";
            

        }
        public XRCheckBox CreateXRCheckBox()
        {
            // Creates the XRCheckBox control.
            XRCheckBox xrCheckBox1 = new XRCheckBox();
            xrCheckBox1.SizeF = new SizeF(150F, 20F);

            return xrCheckBox1;
        }
    }



        
}
