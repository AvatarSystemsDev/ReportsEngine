namespace ReportsEngine.Reports.RDReports
{
    partial class CheckCoverPage
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
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrCoverPageAddress = new DevExpress.XtraReports.Parameters.Parameter();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.CheckAmountLongString14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pstrCompanyAddressBlockLong = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 25F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 12.5F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.HeightF = 0F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            customSqlQuery1.Name = "CoverSheetEnding";
            customSqlQuery1.Sql = "select 1 AS GroupEnder";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.Dynamic.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0iRHluYW1pYyI+PFZpZXcgTmFtZT0iQ292ZXJTaGVldEVuZGluZyI+PEZpZWxkI" +
    "E5hbWU9Ikdyb3VwRW5kZXIiIFR5cGU9IkludDMyIiAvPjwvVmlldz48L0RhdGFTZXQ+";
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
            // pstrCoverPageAddress
            // 
            this.pstrCoverPageAddress.Description = "Cover Page Address";
            this.pstrCoverPageAddress.Name = "pstrCoverPageAddress";
            this.pstrCoverPageAddress.Visible = false;
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("GroupEnder", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.HeightF = 0F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.CheckAmountLongString14,
            this.xrLabel1});
            this.groupFooterBand1.HeightF = 298.0316F;
            this.groupFooterBand1.Name = "groupFooterBand1";
            this.groupFooterBand1.PrintAtBottom = true;
            // 
            // CheckAmountLongString14
            // 
            this.CheckAmountLongString14.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountLongString14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountLongString14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountLongString14.BorderWidth = 1F;
            this.CheckAmountLongString14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pstrCompanyAddressBlockLong")});
            this.CheckAmountLongString14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountLongString14.KeepTogether = true;
            this.CheckAmountLongString14.LocationFloat = new DevExpress.Utils.PointFloat(33.96161F, 1.589457E-05F);
            this.CheckAmountLongString14.Multiline = true;
            this.CheckAmountLongString14.Name = "CheckAmountLongString14";
            this.CheckAmountLongString14.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountLongString14.SizeF = new System.Drawing.SizeF(302.1501F, 89.10995F);
            this.CheckAmountLongString14.StylePriority.UseFont = false;
            this.CheckAmountLongString14.StylePriority.UseTextAlignment = false;
            this.CheckAmountLongString14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pstrCoverPageAddress")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(33.96161F, 166.6083F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(322.92F, 131.4233F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pstrCompanyAddressBlockLong
            // 
            this.pstrCompanyAddressBlockLong.Description = "Company Address Block Long";
            this.pstrCompanyAddressBlockLong.Name = "pstrCompanyAddressBlockLong";
            // 
            // CheckCoverPage
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.groupHeaderBand1,
            this.groupFooterBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "CoverSheetEnding";
            this.DataSource = this.Dynamic;
            this.DisplayName = "RDCheckRemittanceSubreport";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(25F, 25F, 25F, 12.5F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrCoverPageAddress, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.pstrCoverPageAddress,
            this.pstrCompanyAddressBlockLong});
            this.Version = "23.1";
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
        private DevExpress.XtraReports.Parameters.Parameter pstrCoverPageAddress;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountLongString14;
        private DevExpress.XtraReports.Parameters.Parameter pstrCompanyAddressBlockLong;
    }
}
