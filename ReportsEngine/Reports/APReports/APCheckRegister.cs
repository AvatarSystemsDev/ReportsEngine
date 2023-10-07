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
        public APCheckRegister()
        {
            InitializeComponent();
            ReportTitle.BeforePrint += ReportTitle_BeforePrint;
        }

        private void ReportTitle_BeforePrint(object sender, CancelEventArgs e)
        {
            Parameter p = this.Parameters["plngRunType"];
            var dataContext = ((IServiceProvider)this).GetService(typeof(DataContext)) as DataContext;
            var displayText = LookUpHelper.GetLookUpValues(p.LookUpSettings, dataContext).Where(x => x.Value.ToString() == p.Value.ToString()).Select(x => x.RealDescription).FirstOrDefault();
            ReportTitle.Text = displayText;
        }

    }
}
