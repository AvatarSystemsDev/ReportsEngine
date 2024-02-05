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
        private int TransactionSourceCodeID = 0;
        public APCheckRegister()
        {
            InitializeComponent();
            ReportTitle.BeforePrint += ReportTitle_PrintOnPage;
            // xrPageLabel.PrintOnPage += XrPageLabel_PrintOnPage;
            CheckFooterBand.BeforePrint += CheckFooterBand_BeforePrint;
            GLProcessPostRegisterSubreport.BeforePrint += GLProcessPostRegisterSubreport_BeforePrint;
        }

        private void GLProcessPostRegisterSubreport_BeforePrint(object sender, CancelEventArgs e)
        {
            //var subreport = sender as XRSubreport; // Cast the sender to XRSubreport
            //if (TransactionSourceCodeID == 0)
            //{
            //    subreport.Visible = false;
            //}
            //else if (subreport != null && subreport.ReportSource != null)
            //{
            //    // Check if the subreport and its source are properly initialized
            //    var subReportSource = subreport.ReportSource as GLProcessPostRegister; // Cast the ReportSource to your specific subreport class

            //    if (subReportSource != null)
            //    {
            //        // Check if the subreport has the parameter we want to set
            //        if (subReportSource.Parameters["plngTransactionSourceCodeID"] != null)
            //        {
            //            // Set the parameter value based on the TransactionSourceCodeID calculated in the APCheckRegister report
            //            subReportSource.Parameters["plngTransactionSourceCodeID"].Value = this.TransactionSourceCodeID;
            //        }
            //    }
            //}
        }


        private void XrPageLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel xrPageLabel = sender as XRLabel;
            xrPageLabel.Text = "Page " + pageNumber;
            pageNumber++;
        }

        private void ReportTitle_PrintOnPage(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["plngRunType"];
            var dataContext = ((IServiceProvider)this).GetService(typeof(DataContext)) as DataContext;
            var displayText = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext).Where(x => x.Value.ToString() == p.Value.ToString()).Select(x => x.RealDescription).FirstOrDefault();
            Parameter ShowDetail = this.Parameters["pbooGroupByCheck"];
            displayText += ShowDetail.Value.ToString() == "True" ? " Detail" : " Summary";
            ReportTitle.Text = displayText;
        }
        private void APCheckRegister_BeforePrint(object sender, CancelEventArgs e)
        {
            pageNumber = 1;
        }
        
        private void CheckFooterBand_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["plngTransactionSourceCodeID"];
            if(p.Value is object && int.Parse(p.Value.ToString()) <= 0)
            {
                TransactionSourceCodeID = GetCurrentColumnValue("TransactionSourceCodeID") is null ? 0 : int.Parse(GetCurrentColumnValue("TransactionSourceCodeID").ToString());
            }
            else if(p.Value is object)
            {
                TransactionSourceCodeID = int.Parse(p.Value.ToString());
            }
            else
            {
                TransactionSourceCodeID = 0;
            }
        }
    }
}
