using DevExpress.XtraReports.UI;
using System;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDCheckStubs : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter;
        public RDCheckStubs()
        {
            InitializeComponent();
            xrCompanyHeader.BeforePrint += XrCompanyHeader_BeforePrint;
            groupFooterBand1.BeforePrint += GroupFooterBand1_BeforePrint;
        }

        private void GroupFooterBand1_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pageCounter++;
        }

        private void XrCompanyHeader_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pageCounter = 1;
        }


        private void XtraReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
            //// Assuming 'dataSource' is your data source and 'myParameter' is your parameter
            //if (Convert.ToInt32(this.Parameters["plngCheckPrintingProcessTrackingID"].Value) == 0)
            //{
            //    // Access the dynamic data source and get the first value
            //    // Note: This part is pseudo-code and will need to be adapted based on how your data source is structured
            //    var dataSource = this.GetDataSource("CheckPrintingProcessTracking"); // This method needs to be defined by you to get the correct data source
            //    var firstIdValue = dataSource.Rows[0]["ID"];

            //    // Set the default value of the parameter
            //    this.Parameters["plngCheckPrintingProcessTrackingID"].Value = firstIdValue;
        }


    }
}
