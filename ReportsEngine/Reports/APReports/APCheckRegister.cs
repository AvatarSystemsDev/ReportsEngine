using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
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
        }

        private void XrPageLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel xrPageLabel = sender as XRLabel;
            xrPageLabel.Text = "Page " + pageNumber;
            pageNumber++;
        }

        private void ReportTitle_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            Parameter p = this.Parameters["plngRunType"];
            var dataContext = ((IServiceProvider)this).GetService(typeof(DataContext)) as DataContext;
            var displayText = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext).Where(x => x.Value.ToString() == p.Value.ToString()).Select(x => x.RealDescription).FirstOrDefault();
            ReportTitle.Text = displayText;
        }
        private void APCheckRegister_BeforePrint(object sender, CancelEventArgs e)
        {
            pageNumber = 1;
        }
    }
}
