using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.MDReports
{
    public partial class VendorOptionsListing : ReportWithDescriptionParameters
    {
        public VendorOptionsListing()
        {
            InitializeComponent();
            xrEntitiesSelected.BeforePrint += XrVendorsSelected_BeforePrint;
            xrRoleType.BeforePrint += XrRoleType_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }

        private void XrRoleType_BeforePrint(object sender, CancelEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            Parameter roleType = this.Parameters["pstrSelectRoleTypeID"];
            if (roleType.MultiValue == false || roleType.LookUpSettings == null)
            {
                return;
            }
            var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
            LookUpValueCollection col = LookUpHelper.GetLookUpValues(roleType.LookUpSettings, dataContext);
            if (col.Count == (roleType.Value as Array).Length)
            {
                label.Text = "All Roles";
            }
            else if ((roleType.Value as Array).Length == 1)
            {
                //Array roleTypeArray = roleType.Value as Array;
                //label.Text = roleTypeArray.GetValue(0).ToString();
            }
            else
            {
                label.Text = "Selected Roles";
            }
        }
    }
}
