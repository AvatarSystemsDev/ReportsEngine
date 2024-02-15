namespace ReportsEngine.Reports.RDReports
{
    partial class ExcelSalesLedger
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelSalesLedger));
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings2 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix4 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel95 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel96 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel97 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel80 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel92 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooIsFinal = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngReportType = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngBatchID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngSortOrder = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngBeginningPurchaserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngEndingPurchaserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngItemsToReport = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngRDProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectPurchaserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngBeginningPropertyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngEndingPropertyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectPropertyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooCodeOrDescription = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "EntryEditList";
            queryParameter1.Name = "@plngBatchID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngBatchID", typeof(int));
            queryParameter2.Name = "@plngCompanyID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter3.Name = "@pdteBeginningCheckDate";
            queryParameter3.Type = typeof(System.DateTime);
            queryParameter3.ValueInfo = "1753-01-01";
            queryParameter4.Name = "@pdteEndingCheckDate";
            queryParameter4.Type = typeof(System.DateTime);
            queryParameter4.ValueInfo = "1753-01-01";
            queryParameter5.Name = "@plngSortOrder";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?plngSortOrder", typeof(int));
            queryParameter6.Name = "@plngItemsToReport";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?plngItemsToReport", typeof(int));
            queryParameter7.Name = "@plngRDProcessTrackingID";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?plngRDProcessTrackingID", typeof(int));
            queryParameter8.Name = "@plngReportType";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("?plngReportType", typeof(int));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5,
            queryParameter6,
            queryParameter7,
            queryParameter8});
            storedProcQuery1.StoredProcName = "Report_SalesLedger";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 20F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 20F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // Tablix4
            // 
            this.Tablix4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel93,
            this.xrLabel94,
            this.xrLabel95,
            this.xrLabel96,
            this.xrLabel97,
            this.xrLabel25,
            this.xrLabel21,
            this.xrLabel12,
            this.xrLabel80,
            this.xrLabel92,
            this.xrLabel43});
            this.Tablix4.HeightF = 17F;
            this.Tablix4.MultiColumn.ColumnSpacing = 50F;
            this.Tablix4.Name = "Tablix4";
            // 
            // xrLabel93
            // 
            this.xrLabel93.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel93.BorderColor = System.Drawing.Color.Black;
            this.xrLabel93.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel93.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel93.BorderWidth = 1F;
            this.xrLabel93.CanGrow = false;
            this.xrLabel93.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([UseMCFVolume], [EnteredMCF], [EnteredBBL])")});
            this.xrLabel93.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel93.ForeColor = System.Drawing.Color.Black;
            this.xrLabel93.KeepTogether = true;
            this.xrLabel93.LocationFloat = new DevExpress.Utils.PointFloat(387.7082F, 0F);
            this.xrLabel93.Name = "xrLabel93";
            this.xrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel93.SizeF = new System.Drawing.SizeF(88.54169F, 17F);
            this.xrLabel93.StylePriority.UseBackColor = false;
            this.xrLabel93.StylePriority.UseBorderColor = false;
            this.xrLabel93.StylePriority.UseBorderDashStyle = false;
            this.xrLabel93.StylePriority.UseBorders = false;
            this.xrLabel93.StylePriority.UseBorderWidth = false;
            this.xrLabel93.StylePriority.UseFont = false;
            this.xrLabel93.StylePriority.UseForeColor = false;
            this.xrLabel93.StylePriority.UsePadding = false;
            this.xrLabel93.StylePriority.UseTextAlignment = false;
            this.xrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel93.TextFormatString = "{0:N2}";
            // 
            // xrLabel94
            // 
            this.xrLabel94.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel94.BorderColor = System.Drawing.Color.Black;
            this.xrLabel94.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel94.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel94.BorderWidth = 1F;
            this.xrLabel94.CanGrow = false;
            this.xrLabel94.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EnteredGross]")});
            this.xrLabel94.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel94.ForeColor = System.Drawing.Color.Black;
            this.xrLabel94.KeepTogether = true;
            this.xrLabel94.LocationFloat = new DevExpress.Utils.PointFloat(476.25F, 0F);
            this.xrLabel94.Name = "xrLabel94";
            this.xrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel94.SizeF = new System.Drawing.SizeF(88.54153F, 17F);
            this.xrLabel94.StylePriority.UseBackColor = false;
            this.xrLabel94.StylePriority.UseBorderColor = false;
            this.xrLabel94.StylePriority.UseBorderDashStyle = false;
            this.xrLabel94.StylePriority.UseBorders = false;
            this.xrLabel94.StylePriority.UseBorderWidth = false;
            this.xrLabel94.StylePriority.UseFont = false;
            this.xrLabel94.StylePriority.UseForeColor = false;
            this.xrLabel94.StylePriority.UsePadding = false;
            this.xrLabel94.StylePriority.UseTextAlignment = false;
            this.xrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel94.TextFormatString = "{0:N2}";
            // 
            // xrLabel95
            // 
            this.xrLabel95.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel95.BorderColor = System.Drawing.Color.Black;
            this.xrLabel95.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel95.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel95.BorderWidth = 1F;
            this.xrLabel95.CanGrow = false;
            this.xrLabel95.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EnteredTax]")});
            this.xrLabel95.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel95.ForeColor = System.Drawing.Color.Black;
            this.xrLabel95.KeepTogether = true;
            this.xrLabel95.LocationFloat = new DevExpress.Utils.PointFloat(564.7916F, 0F);
            this.xrLabel95.Name = "xrLabel95";
            this.xrLabel95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel95.SizeF = new System.Drawing.SizeF(88.54156F, 17F);
            this.xrLabel95.StylePriority.UseBackColor = false;
            this.xrLabel95.StylePriority.UseBorderColor = false;
            this.xrLabel95.StylePriority.UseBorderDashStyle = false;
            this.xrLabel95.StylePriority.UseBorders = false;
            this.xrLabel95.StylePriority.UseBorderWidth = false;
            this.xrLabel95.StylePriority.UseFont = false;
            this.xrLabel95.StylePriority.UseForeColor = false;
            this.xrLabel95.StylePriority.UsePadding = false;
            this.xrLabel95.StylePriority.UseTextAlignment = false;
            this.xrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel95.TextFormatString = "{0:N2}";
            // 
            // xrLabel96
            // 
            this.xrLabel96.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel96.BorderColor = System.Drawing.Color.Black;
            this.xrLabel96.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel96.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel96.BorderWidth = 1F;
            this.xrLabel96.CanGrow = false;
            this.xrLabel96.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EnteredDeductions]")});
            this.xrLabel96.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel96.ForeColor = System.Drawing.Color.Black;
            this.xrLabel96.KeepTogether = true;
            this.xrLabel96.LocationFloat = new DevExpress.Utils.PointFloat(653.3333F, 0F);
            this.xrLabel96.Name = "xrLabel96";
            this.xrLabel96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel96.SizeF = new System.Drawing.SizeF(88.54169F, 17F);
            this.xrLabel96.StylePriority.UseBackColor = false;
            this.xrLabel96.StylePriority.UseBorderColor = false;
            this.xrLabel96.StylePriority.UseBorderDashStyle = false;
            this.xrLabel96.StylePriority.UseBorders = false;
            this.xrLabel96.StylePriority.UseBorderWidth = false;
            this.xrLabel96.StylePriority.UseFont = false;
            this.xrLabel96.StylePriority.UseForeColor = false;
            this.xrLabel96.StylePriority.UsePadding = false;
            this.xrLabel96.StylePriority.UseTextAlignment = false;
            this.xrLabel96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel96.TextFormatString = "{0:N2}";
            // 
            // xrLabel97
            // 
            this.xrLabel97.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel97.BorderColor = System.Drawing.Color.Black;
            this.xrLabel97.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel97.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel97.BorderWidth = 1F;
            this.xrLabel97.CanGrow = false;
            this.xrLabel97.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EnteredNet]")});
            this.xrLabel97.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel97.ForeColor = System.Drawing.Color.Black;
            this.xrLabel97.KeepTogether = true;
            this.xrLabel97.LocationFloat = new DevExpress.Utils.PointFloat(741.8749F, 0F);
            this.xrLabel97.Name = "xrLabel97";
            this.xrLabel97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel97.SizeF = new System.Drawing.SizeF(88.54169F, 17F);
            this.xrLabel97.StylePriority.UseBackColor = false;
            this.xrLabel97.StylePriority.UseBorderColor = false;
            this.xrLabel97.StylePriority.UseBorderDashStyle = false;
            this.xrLabel97.StylePriority.UseBorders = false;
            this.xrLabel97.StylePriority.UseBorderWidth = false;
            this.xrLabel97.StylePriority.UseFont = false;
            this.xrLabel97.StylePriority.UseForeColor = false;
            this.xrLabel97.StylePriority.UsePadding = false;
            this.xrLabel97.StylePriority.UseTextAlignment = false;
            this.xrLabel97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel97.TextFormatString = "{0:N2}";
            // 
            // xrLabel25
            // 
            this.xrLabel25.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel25.BorderColor = System.Drawing.Color.Black;
            this.xrLabel25.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel25.BorderWidth = 1F;
            this.xrLabel25.CanGrow = false;
            this.xrLabel25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GroupNumber]")});
            this.xrLabel25.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel25.ForeColor = System.Drawing.Color.Black;
            this.xrLabel25.KeepTogether = true;
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(1.041667F, 0F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(87.49997F, 17F);
            this.xrLabel25.StylePriority.UseBackColor = false;
            this.xrLabel25.StylePriority.UseBorderColor = false;
            this.xrLabel25.StylePriority.UseBorderDashStyle = false;
            this.xrLabel25.StylePriority.UseBorders = false;
            this.xrLabel25.StylePriority.UseBorderWidth = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseForeColor = false;
            this.xrLabel25.StylePriority.UsePadding = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel21.BorderColor = System.Drawing.Color.Black;
            this.xrLabel21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.BorderWidth = 1F;
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductionDate]")});
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel21.ForeColor = System.Drawing.Color.Black;
            this.xrLabel21.KeepTogether = true;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(242.9895F, 0F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(77.22162F, 17F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorderColor = false;
            this.xrLabel21.StylePriority.UseBorderDashStyle = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseBorderWidth = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseForeColor = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel21.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel12.BorderColor = System.Drawing.Color.Black;
            this.xrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.BorderWidth = 1F;
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0:MM/dd/yyyy}\', [PostDate])")});
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel12.ForeColor = System.Drawing.Color.Black;
            this.xrLabel12.KeepTogether = true;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(165.7656F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(77.22391F, 17F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorderDashStyle = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseBorderWidth = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel12.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel80
            // 
            this.xrLabel80.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel80.BorderColor = System.Drawing.Color.Black;
            this.xrLabel80.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel80.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel80.BorderWidth = 1F;
            this.xrLabel80.CanGrow = false;
            this.xrLabel80.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PurchaserCheckDate]")});
            this.xrLabel80.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel80.ForeColor = System.Drawing.Color.Black;
            this.xrLabel80.KeepTogether = true;
            this.xrLabel80.LocationFloat = new DevExpress.Utils.PointFloat(88.54166F, 0F);
            this.xrLabel80.Name = "xrLabel80";
            this.xrLabel80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel80.SizeF = new System.Drawing.SizeF(77.22391F, 17F);
            this.xrLabel80.StylePriority.UseBackColor = false;
            this.xrLabel80.StylePriority.UseBorderColor = false;
            this.xrLabel80.StylePriority.UseBorderDashStyle = false;
            this.xrLabel80.StylePriority.UseBorders = false;
            this.xrLabel80.StylePriority.UseBorderWidth = false;
            this.xrLabel80.StylePriority.UseFont = false;
            this.xrLabel80.StylePriority.UseForeColor = false;
            this.xrLabel80.StylePriority.UsePadding = false;
            this.xrLabel80.StylePriority.UseTextAlignment = false;
            this.xrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel80.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel92
            // 
            this.xrLabel92.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel92.BorderColor = System.Drawing.Color.Black;
            this.xrLabel92.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel92.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel92.BorderWidth = 1F;
            this.xrLabel92.CanGrow = false;
            this.xrLabel92.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EnteredPrice]")});
            this.xrLabel92.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel92.ForeColor = System.Drawing.Color.Black;
            this.xrLabel92.KeepTogether = true;
            this.xrLabel92.LocationFloat = new DevExpress.Utils.PointFloat(830.4166F, 0F);
            this.xrLabel92.Name = "xrLabel92";
            this.xrLabel92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel92.SizeF = new System.Drawing.SizeF(88.54254F, 17F);
            this.xrLabel92.StylePriority.UseBackColor = false;
            this.xrLabel92.StylePriority.UseBorderColor = false;
            this.xrLabel92.StylePriority.UseBorderDashStyle = false;
            this.xrLabel92.StylePriority.UseBorders = false;
            this.xrLabel92.StylePriority.UseBorderWidth = false;
            this.xrLabel92.StylePriority.UseFont = false;
            this.xrLabel92.StylePriority.UseForeColor = false;
            this.xrLabel92.StylePriority.UsePadding = false;
            this.xrLabel92.StylePriority.UseTextAlignment = false;
            this.xrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel92.TextFormatString = "{0:N2}";
            // 
            // xrLabel43
            // 
            this.xrLabel43.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel43.BorderColor = System.Drawing.Color.Black;
            this.xrLabel43.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel43.BorderWidth = 1F;
            this.xrLabel43.CanGrow = false;
            this.xrLabel43.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountingCenterNumber]")});
            this.xrLabel43.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel43.ForeColor = System.Drawing.Color.Black;
            this.xrLabel43.KeepTogether = true;
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(320.2112F, 0F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(67.49695F, 17F);
            this.xrLabel43.StylePriority.UseBackColor = false;
            this.xrLabel43.StylePriority.UseBorderColor = false;
            this.xrLabel43.StylePriority.UseBorderDashStyle = false;
            this.xrLabel43.StylePriority.UseBorders = false;
            this.xrLabel43.StylePriority.UseBorderWidth = false;
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseForeColor = false;
            this.xrLabel43.StylePriority.UsePadding = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "\'\'")});
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // pbooIsFinal
            // 
            this.pbooIsFinal.Description = "pbooIsFinal";
            this.pbooIsFinal.Name = "pbooIsFinal";
            this.pbooIsFinal.Type = typeof(bool);
            this.pbooIsFinal.ValueInfo = "False";
            this.pbooIsFinal.Visible = false;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            this.plngCompanyID.Visible = false;
            // 
            // plngReportType
            // 
            this.plngReportType.Description = "Report Type";
            this.plngReportType.Name = "plngReportType";
            this.plngReportType.Type = typeof(int);
            this.plngReportType.ValueInfo = "1";
            // 
            // plngBatchID
            // 
            this.plngBatchID.Description = "Batch";
            this.plngBatchID.Name = "plngBatchID";
            this.plngBatchID.Type = typeof(int);
            this.plngBatchID.ValueInfo = "0";
            // 
            // plngSortOrder
            // 
            this.plngSortOrder.Description = "Sort Order";
            this.plngSortOrder.Name = "plngSortOrder";
            this.plngSortOrder.Type = typeof(int);
            this.plngSortOrder.ValueInfo = "0";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(0, "Purchaser/Sale Date"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "Entry Order"));
            this.plngSortOrder.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Description = "Show Criteria";
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "True";
            // 
            // plngBeginningPurchaserID
            // 
            this.plngBeginningPurchaserID.Description = "Beginning Purchaser";
            this.plngBeginningPurchaserID.Name = "plngBeginningPurchaserID";
            this.plngBeginningPurchaserID.Type = typeof(int);
            this.plngBeginningPurchaserID.ValueInfo = "0";
            // 
            // plngEndingPurchaserID
            // 
            this.plngEndingPurchaserID.Description = "Ending Purchaser";
            this.plngEndingPurchaserID.Name = "plngEndingPurchaserID";
            this.plngEndingPurchaserID.Type = typeof(int);
            this.plngEndingPurchaserID.ValueInfo = "-1";
            // 
            // plngItemsToReport
            // 
            this.plngItemsToReport.Description = "Show Suspended";
            this.plngItemsToReport.Name = "plngItemsToReport";
            this.plngItemsToReport.Type = typeof(int);
            this.plngItemsToReport.ValueInfo = "0";
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(0, "All Revenue"));
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "Suspended"));
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(2, "Not Suspended"));
            this.plngItemsToReport.ValueSourceSettings = staticListLookUpSettings2;
            // 
            // plngRDProcessTrackingID
            // 
            this.plngRDProcessTrackingID.Description = "plngRDProcessTrackingID";
            this.plngRDProcessTrackingID.Name = "plngRDProcessTrackingID";
            this.plngRDProcessTrackingID.Type = typeof(int);
            this.plngRDProcessTrackingID.ValueInfo = "0";
            this.plngRDProcessTrackingID.Visible = false;
            // 
            // pstrSelectPurchaserID
            // 
            this.pstrSelectPurchaserID.Description = "Select Purchaser";
            this.pstrSelectPurchaserID.MultiValue = true;
            this.pstrSelectPurchaserID.Name = "pstrSelectPurchaserID";
            this.pstrSelectPurchaserID.Type = typeof(int);
            // 
            // plngBeginningPropertyID
            // 
            this.plngBeginningPropertyID.Description = "Beginning Property";
            this.plngBeginningPropertyID.Name = "plngBeginningPropertyID";
            this.plngBeginningPropertyID.Type = typeof(int);
            this.plngBeginningPropertyID.ValueInfo = "0";
            // 
            // plngEndingPropertyID
            // 
            this.plngEndingPropertyID.Description = "Ending Property";
            this.plngEndingPropertyID.Name = "plngEndingPropertyID";
            this.plngEndingPropertyID.Type = typeof(int);
            this.plngEndingPropertyID.ValueInfo = "-1";
            // 
            // pstrSelectPropertyID
            // 
            this.pstrSelectPropertyID.Description = "Select Property";
            this.pstrSelectPropertyID.MultiValue = true;
            this.pstrSelectPropertyID.Name = "pstrSelectPropertyID";
            this.pstrSelectPropertyID.Type = typeof(int);
            // 
            // pbooCodeOrDescription
            // 
            this.pbooCodeOrDescription.Description = "Code Or Description";
            this.pbooCodeOrDescription.Name = "pbooCodeOrDescription";
            this.pbooCodeOrDescription.Type = typeof(bool);
            this.pbooCodeOrDescription.ValueInfo = "False";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel33,
            this.xrLabel31,
            this.xrLabel26,
            this.xrLabel24,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel9,
            this.xrLabel7,
            this.xrLabel40});
            this.ReportHeader.HeightF = 36.20483F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel33
            // 
            this.xrLabel33.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel33.BorderColor = System.Drawing.Color.Black;
            this.xrLabel33.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel33.BorderWidth = 1F;
            this.xrLabel33.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel33.ForeColor = System.Drawing.Color.Black;
            this.xrLabel33.KeepTogether = true;
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(741.8748F, 0F);
            this.xrLabel33.Multiline = true;
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(88.54169F, 36.2F);
            this.xrLabel33.StylePriority.UseBackColor = false;
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseForeColor = false;
            this.xrLabel33.StylePriority.UsePadding = false;
            this.xrLabel33.Text = "\r\nSh. Net Amt";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel31
            // 
            this.xrLabel31.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel31.BorderColor = System.Drawing.Color.Black;
            this.xrLabel31.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel31.BorderWidth = 1F;
            this.xrLabel31.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel31.ForeColor = System.Drawing.Color.Black;
            this.xrLabel31.KeepTogether = true;
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(653.3331F, 0F);
            this.xrLabel31.Multiline = true;
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(88.54169F, 36.2F);
            this.xrLabel31.StylePriority.UseBackColor = false;
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseForeColor = false;
            this.xrLabel31.StylePriority.UsePadding = false;
            this.xrLabel31.Text = "\r\nSh. Ded.";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel26.BorderColor = System.Drawing.Color.Black;
            this.xrLabel26.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.BorderWidth = 1F;
            this.xrLabel26.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel26.ForeColor = System.Drawing.Color.Black;
            this.xrLabel26.KeepTogether = true;
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(564.7915F, 0F);
            this.xrLabel26.Multiline = true;
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(88.54163F, 36.2F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseForeColor = false;
            this.xrLabel26.StylePriority.UsePadding = false;
            this.xrLabel26.Text = "\r\nSh. Sev Tax";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel24
            // 
            this.xrLabel24.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel24.BorderColor = System.Drawing.Color.Black;
            this.xrLabel24.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel24.BorderWidth = 1F;
            this.xrLabel24.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel24.ForeColor = System.Drawing.Color.Black;
            this.xrLabel24.KeepTogether = true;
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(476.2498F, 0F);
            this.xrLabel24.Multiline = true;
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(88.54166F, 36.2F);
            this.xrLabel24.StylePriority.UseBackColor = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseForeColor = false;
            this.xrLabel24.StylePriority.UsePadding = false;
            this.xrLabel24.Text = "\r\nSh. Gross";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel23.BorderColor = System.Drawing.Color.Black;
            this.xrLabel23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel23.BorderWidth = 1F;
            this.xrLabel23.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel23.ForeColor = System.Drawing.Color.Black;
            this.xrLabel23.KeepTogether = true;
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(387.7082F, 0F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(88.54166F, 36.2F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseForeColor = false;
            this.xrLabel23.StylePriority.UsePadding = false;
            this.xrLabel23.Text = "\r\nSh. Volume";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel22.BorderColor = System.Drawing.Color.Black;
            this.xrLabel22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.BorderWidth = 1F;
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel22.ForeColor = System.Drawing.Color.Black;
            this.xrLabel22.KeepTogether = true;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(88.54166F, 36.2F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UsePadding = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Check ";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel20.BorderColor = System.Drawing.Color.Black;
            this.xrLabel20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.BorderWidth = 1F;
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel20.ForeColor = System.Drawing.Color.Black;
            this.xrLabel20.KeepTogether = true;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(88.54166F, 0F);
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(77.22388F, 36.20483F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Check Date";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel19.BorderColor = System.Drawing.Color.Black;
            this.xrLabel19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.BorderWidth = 1F;
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel19.ForeColor = System.Drawing.Color.Black;
            this.xrLabel19.KeepTogether = true;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(165.7656F, 0F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(77.22395F, 36.20483F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UsePadding = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "GL Date";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel9.BorderColor = System.Drawing.Color.Black;
            this.xrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.BorderWidth = 1F;
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel9.ForeColor = System.Drawing.Color.Black;
            this.xrLabel9.KeepTogether = true;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(242.9896F, 0F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(77.22166F, 36.2F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Prod\r\nDate";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.BorderWidth = 1F;
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel7.ForeColor = System.Drawing.Color.Black;
            this.xrLabel7.KeepTogether = true;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(830.4167F, 6.357829E-05F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(88.54169F, 36.2F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.Text = "\r\nSh. Price";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel40
            // 
            this.xrLabel40.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel40.BorderColor = System.Drawing.Color.Black;
            this.xrLabel40.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel40.BorderWidth = 1F;
            this.xrLabel40.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel40.ForeColor = System.Drawing.Color.Black;
            this.xrLabel40.KeepTogether = true;
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(320.2112F, 6.357829E-05F);
            this.xrLabel40.Multiline = true;
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(67.49695F, 36.2F);
            this.xrLabel40.StylePriority.UseBackColor = false;
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseForeColor = false;
            this.xrLabel40.StylePriority.UsePadding = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "Acct. Cntr.";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // ExcelSalesLedger
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix4,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "EntryEditList";
            this.DataSource = this.Dynamic;
            this.DisplayName = "RDEntryEditList";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 20F, 20F, 20F);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooIsFinal, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngReportType, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooCodeOrDescription, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngBatchID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngSortOrder, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngBeginningPurchaserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngEndingPurchaserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectPurchaserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngBeginningPropertyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngEndingPropertyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectPropertyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngItemsToReport, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngRDProcessTrackingID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowCriteria, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.pbooIsFinal,
            this.plngCompanyID,
            this.plngReportType,
            this.pbooCodeOrDescription,
            this.plngBatchID,
            this.plngSortOrder,
            this.plngBeginningPurchaserID,
            this.plngEndingPurchaserID,
            this.pstrSelectPurchaserID,
            this.plngBeginningPropertyID,
            this.plngEndingPropertyID,
            this.pstrSelectPropertyID,
            this.plngItemsToReport,
            this.plngRDProcessTrackingID,
            this.pbooShowCriteria});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix4;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pbooIsFinal;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter plngReportType;
        private DevExpress.XtraReports.Parameters.Parameter plngBatchID;
        private DevExpress.XtraReports.Parameters.Parameter plngSortOrder;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.Parameters.Parameter plngBeginningPurchaserID;
        private DevExpress.XtraReports.Parameters.Parameter plngEndingPurchaserID;
        private DevExpress.XtraReports.Parameters.Parameter plngItemsToReport;
        private DevExpress.XtraReports.Parameters.Parameter plngRDProcessTrackingID;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectPurchaserID;
        private DevExpress.XtraReports.Parameters.Parameter plngBeginningPropertyID;
        private DevExpress.XtraReports.Parameters.Parameter plngEndingPropertyID;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectPropertyID;
        private DevExpress.XtraReports.Parameters.Parameter pbooCodeOrDescription;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel xrLabel93;
        private DevExpress.XtraReports.UI.XRLabel xrLabel94;
        private DevExpress.XtraReports.UI.XRLabel xrLabel95;
        private DevExpress.XtraReports.UI.XRLabel xrLabel96;
        private DevExpress.XtraReports.UI.XRLabel xrLabel97;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel80;
        private DevExpress.XtraReports.UI.XRLabel xrLabel92;
        private DevExpress.XtraReports.UI.XRLabel xrLabel43;
    }
}
