using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.MDReports
{
    public partial class CompanyProfile : DevExpress.XtraReports.UI.XtraReport
    {
        public CompanyProfile() : this(null) { }
        public CompanyProfile(int? CompanyID)
        {
            InitializeComponent();
            instantiateCompanyParameters(CompanyID);
        }
        private void instantiateCompanyParameters(int? CompanyID)
        {
            if (CompanyID != null)
            {
                pstrSelectCompanyID.Value = CompanyID;
            }
        }

    }
}
