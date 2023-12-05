using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using System.Drawing;


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
            xrPropertySelected.BeforePrint += xrPropertiesSelected_BeforePrint;
            xrOwnerSelected.BeforePrint += xrOwnersSelected_BeforePrint;
            xrDeckCodesSelected.BeforePrint += XrDeckCodesSelected_BeforePrint;
        }
        private void XrDeckCodesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectDeckCode"];
            Parameter start = this.Parameters["pstrBeginningDeckCode"];
            Parameter end = this.Parameters["pstrEndingDeckCode"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value.ToString() == "" && end.Value.ToString() == "ZZZZZZ")
                {
                    label.Text = "All Deck Codes";
                }
                else
                {
                    if (start.Value.ToString() == "")
                    {
                        label.Text = "First Deck Code to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZ")
                    {
                        label.Text += "Last Deck Code";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
            else if ((p.Value as Array).Length == 0)
            {
                label.Text = "No Values Selected";
            }
            else
            {
                if (start.Value.ToString() == "" && end.Value.ToString() == "ZZZZZZ")
                {
                    label.Text = "Selected Deck Codes";
                }
                else
                {
                    if (start.Value.ToString() == "")
                    {
                        label.Text = "First Deck Code to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZ")
                    {
                        label.Text += "Last Deck Code";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }
        private void DOIbyOwnerAddress_DataSourceDemanded(object sender, EventArgs e)
        {

        }

        private void DOIbyOwnerAddress_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        private void DOIbyOwnerAddress_BeforePrint_1(object sender, CancelEventArgs e)
        {

        }
        private void xrPropertiesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectProperty"];
            Parameter start = this.Parameters["pstrBeginningPropertyNumber"];
            Parameter end = this.Parameters["pstrEndingPropertyNumber"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                {
                    label.Text = "All Properties";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Property to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                    {
                        label.Text += "Last Property";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
            else if ((p.Value as Array).Length == 0)
            {
                label.Text = "No Values Selected";
            }
            else
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                {
                    label.Text = "Selected Properties";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Property to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                    {
                        label.Text += "Last Property";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }
        private void xrOwnersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectOwner"];
            Parameter start = this.Parameters["pstrBeginningOwnerNumber"];
            Parameter end = this.Parameters["pstrEndingOwnerNumber"];

            if (p.MultiValue == false || p.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext);
            if (col.Count == (p.Value as Array).Length)
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ")
                {
                    label.Text = "All Owners";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Owner to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ")
                    {
                        label.Text += "Last Owner";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
            else if ((p.Value as Array).Length == 0)
            {
                label.Text = "No Values Selected";
            }
            else
            {
                if (start.Value.ToString() == "!" && end.Value.ToString() == "ZZZZZZZZZZ")
                {
                    label.Text = "Selected Owners";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Owner to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ")
                    {
                        label.Text += "Last Owner";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
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
            string path = @"..\Styles\";
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
