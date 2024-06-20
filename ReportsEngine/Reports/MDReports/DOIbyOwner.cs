using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using System.Drawing;


namespace ReportsEngine.Reports
{
    public partial class DOIbyOwner : ReportWithDescriptionParameters
    {
        public DOIbyOwner()
        {
            InitializeComponent();
            this.BeforePrint += DOIbyOwner_BeforePrint;
            xrPropertySelected.BeforePrint += XrPropertiesSelected_BeforePrint;
            xrOwnerSelected.BeforePrint += XrOwnersSelected_BeforePrint;
            xrDeckCodesSelected.BeforePrint += XrDeckCodesSelected_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
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
