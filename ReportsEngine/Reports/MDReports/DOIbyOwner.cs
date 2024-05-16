﻿using DevExpress.Data.Browsing;
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
                    label.Text = "All Properties/Wells";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Property/Well to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                    {
                        label.Text += "Last Property/Well";
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
                    label.Text = "Selected Properties/Wells";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Property/Well to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ-ZZZZZZZZZZ")
                    {
                        label.Text += "Last Property/Well";
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
