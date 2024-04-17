using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using ReportsEngine.Reports.ProcessReports;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace ReportsEngine.Reports.APReports
{
    public partial class APCheckRegister : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageNumber = 1;
        public APCheckRegister()
        {
            InitializeComponent();
            ReportTitle.PrintOnPage += ReportTitle_PrintOnPage;
            xrPageLabel.PrintOnPage += XrPageLabel_PrintOnPage;
            //CheckFooterBand.BeforePrint += CheckFooterBand_BeforePrint;
            //GLProcessPostRegisterSubreport.BeforePrint += GLProcessPostRegisterSubreport_BeforePrint;
            xrEntitiesSelected.PrintOnPage += xrEntitiesSelected_PrintOnPage;
        }

        private void XrPageLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel pageLabel = sender as XRLabel;
            pageLabel.Text = "Page " + pageNumber.ToString();
            pageNumber++;
        }

        private void ReportTitle_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Parameter p = this.Parameters["plngRunType"];
            var dataContext = ((IServiceProvider)this).GetService(typeof(DataContext)) as DataContext;
            var displayText = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext).Where(x => x.Value.ToString() == p.Value.ToString()).Select(x => x.RealDescription).FirstOrDefault();
            Parameter ShowDetail = this.Parameters["pbooGroupByCheck"];
            displayText += ShowDetail.Value.ToString() == "True" ? " Detail" : " Summary";
            ReportTitle.Text = displayText;
        }

        private void xrEntitiesSelected_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter p = this.Parameters["pstrSelectVendor"];
            Parameter start = this.Parameters["pstrBeginningVendorNumber"];
            Parameter end = this.Parameters["pstrEndingVendorNumber"];

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
                    label.Text = "All Vendors";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Vendor to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ")
                    {
                        label.Text += "Last Vendor";
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
                    label.Text = "Selected Vendors";
                }
                else
                {
                    if (start.Value.ToString() == "!")
                    {
                        label.Text = "First Vendor to ";
                    }
                    else
                    {
                        label.Text = start.Value.ToString() + " to ";
                    }
                    if (end.Value.ToString() == "ZZZZZZZZZZ")
                    {
                        label.Text += "Last Vendor";
                    }
                    else
                    {
                        label.Text += end.Value.ToString();
                    }
                }
            }
        }
    }
}
