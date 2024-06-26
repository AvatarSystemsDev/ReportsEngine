namespace ReportsEngine.Reports.JIBReports
{
    partial class TestRemittanceSubreportOnly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooTestOverflow = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrCompanyAddressBlockLong = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngOverflowOptionCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooRunningAtEnd = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooWillPrintCompanyNameOnStub = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooWillCenterCompanyNameOnStub = new DevExpress.XtraReports.Parameters.Parameter();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.plngPrintRemittance = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooPrintDetailOnChecks = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 0F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 0F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2});
            this.detailBand1.HeightF = 2F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            // 
            // pstrDatabaseName
            // 
            this.pstrDatabaseName.Description = "pstrDatabaseName";
            this.pstrDatabaseName.Name = "pstrDatabaseName";
            this.pstrDatabaseName.Visible = false;
            // 
            // pstrServerName
            // 
            this.pstrServerName.Description = "pstrServerName";
            this.pstrServerName.Name = "pstrServerName";
            this.pstrServerName.Visible = false;
            // 
            // plngUserID
            // 
            this.plngUserID.Description = "plngUserID";
            this.plngUserID.Name = "plngUserID";
            this.plngUserID.Type = typeof(int);
            this.plngUserID.ValueInfo = "0";
            this.plngUserID.Visible = false;
            // 
            // pbooTestOverflow
            // 
            this.pbooTestOverflow.Description = "test overflow";
            this.pbooTestOverflow.Name = "pbooTestOverflow";
            this.pbooTestOverflow.Type = typeof(bool);
            this.pbooTestOverflow.ValueInfo = "False";
            // 
            // pstrCompanyAddressBlockLong
            // 
            this.pstrCompanyAddressBlockLong.Description = "pstrCompanyAddressBlockLong";
            this.pstrCompanyAddressBlockLong.Name = "pstrCompanyAddressBlockLong";
            this.pstrCompanyAddressBlockLong.Visible = false;
            // 
            // plngOverflowOptionCode
            // 
            this.plngOverflowOptionCode.Description = "Overflow Option Code";
            this.plngOverflowOptionCode.Name = "plngOverflowOptionCode";
            this.plngOverflowOptionCode.Type = typeof(int);
            this.plngOverflowOptionCode.ValueInfo = "0";
            this.plngOverflowOptionCode.Visible = false;
            // 
            // pbooRunningAtEnd
            // 
            this.pbooRunningAtEnd.Description = "Running At End";
            this.pbooRunningAtEnd.Name = "pbooRunningAtEnd";
            this.pbooRunningAtEnd.Type = typeof(bool);
            this.pbooRunningAtEnd.ValueInfo = "False";
            this.pbooRunningAtEnd.Visible = false;
            // 
            // pbooWillPrintCompanyNameOnStub
            // 
            this.pbooWillPrintCompanyNameOnStub.Description = "Will Print Company Name On Stub";
            this.pbooWillPrintCompanyNameOnStub.Name = "pbooWillPrintCompanyNameOnStub";
            this.pbooWillPrintCompanyNameOnStub.Type = typeof(bool);
            this.pbooWillPrintCompanyNameOnStub.ValueInfo = "False";
            this.pbooWillPrintCompanyNameOnStub.Visible = false;
            // 
            // pbooWillCenterCompanyNameOnStub
            // 
            this.pbooWillCenterCompanyNameOnStub.Description = "Will Center Company Name On Stub";
            this.pbooWillCenterCompanyNameOnStub.Name = "pbooWillCenterCompanyNameOnStub";
            this.pbooWillCenterCompanyNameOnStub.Type = typeof(bool);
            this.pbooWillCenterCompanyNameOnStub.ValueInfo = "False";
            this.pbooWillCenterCompanyNameOnStub.Visible = false;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            customSqlQuery1.Name = "TestRemttanceAtEnd";
            customSqlQuery1.Sql = "select 1 AS Row";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.Dynamic.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0iRHluYW1pYyI+PFZpZXcgTmFtZT0iVGVzdFJlbXR0YW5jZUF0RW5kIj48Rmllb" +
    "GQgTmFtZT0iUm93IiBUeXBlPSJJbnQzMiIgLz48L1ZpZXc+PC9EYXRhU2V0Pg==";
            // 
            // plngPrintRemittance
            // 
            this.plngPrintRemittance.Description = "Print Remittance";
            this.plngPrintRemittance.Name = "plngPrintRemittance";
            this.plngPrintRemittance.Type = typeof(int);
            this.plngPrintRemittance.ValueInfo = "0";
            this.plngPrintRemittance.Visible = false;
            // 
            // pbooPrintDetailOnChecks
            // 
            this.pbooPrintDetailOnChecks.Description = "Print Detail On Checks";
            this.pbooPrintDetailOnChecks.Name = "pbooPrintDetailOnChecks";
            this.pbooPrintDetailOnChecks.Type = typeof(bool);
            this.pbooPrintDetailOnChecks.ValueInfo = "False";
            this.pbooPrintDetailOnChecks.Visible = false;
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 2 \n")});
            this.xrSubreport2.GenerateOwnPages = true;
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooTestOverflow", this.pbooTestOverflow));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", this.pstrCompanyAddressBlockLong));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngOverflowOptionCode", this.plngOverflowOptionCode));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooRunningAtEnd", this.pbooRunningAtEnd));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooWillPrintCompanyNameOnStub", this.pbooWillPrintCompanyNameOnStub));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooWillCenterCompanyNameOnStub", this.pbooWillCenterCompanyNameOnStub));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooPrintDetailOnChecks", this.pbooPrintDetailOnChecks));
            this.xrSubreport2.ReportSource = new ReportsEngine.Reports.JIBReports.TestRemittance();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(810F, 2F);
            // 
            // TestRemittanceSubreportOnly
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "TestRemttanceAtEnd";
            this.DataSource = this.Dynamic;
            this.DisplayName = "RDCheckRemittanceSubreport";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 20F, 0F, 0F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrCompanyAddressBlockLong, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngOverflowOptionCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooRunningAtEnd, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.pstrCompanyAddressBlockLong,
            this.plngOverflowOptionCode,
            this.pbooRunningAtEnd,
            this.plngPrintRemittance,
            this.pbooTestOverflow,
            this.pbooWillPrintCompanyNameOnStub,
            this.pbooWillCenterCompanyNameOnStub,
            this.pbooPrintDetailOnChecks});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.Parameters.Parameter pstrCompanyAddressBlockLong;
        private DevExpress.XtraReports.Parameters.Parameter plngOverflowOptionCode;
        private DevExpress.XtraReports.Parameters.Parameter pbooRunningAtEnd;
        private DevExpress.XtraReports.Parameters.Parameter plngPrintRemittance;
        private DevExpress.XtraReports.Parameters.Parameter pbooTestOverflow;
        private DevExpress.XtraReports.Parameters.Parameter pbooWillPrintCompanyNameOnStub;
        private DevExpress.XtraReports.Parameters.Parameter pbooWillCenterCompanyNameOnStub;
        private DevExpress.XtraReports.Parameters.Parameter pbooPrintDetailOnChecks;
    }
}
