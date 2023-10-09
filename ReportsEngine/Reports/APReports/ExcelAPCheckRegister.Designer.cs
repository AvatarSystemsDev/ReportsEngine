namespace ReportsEngine.Reports.APReports
{
    partial class ExcelAPCheckRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelAPCheckRegister));
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix2 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox20 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox22 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox18 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox16 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox13 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox33 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox7 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox149 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox10 = new DevExpress.XtraReports.UI.XRLabel();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngRunType = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngSortOrder = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.plngTransactionSourceCodeID = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSAPCheckRegister";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            queryParameter2.Name = "@plngID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngID", typeof(string));
            queryParameter3.Name = "@plngRunType";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?plngRunType", typeof(string));
            queryParameter4.Name = "@plngSortOrder";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?plngSortOrder", typeof(string));
            queryParameter5.Name = "@plngUserID";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?plngUserID", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5});
            storedProcQuery1.StoredProcName = "Report_APCheckRegister";
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
            // Tablix2
            // 
            this.Tablix2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel1,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9});
            this.Tablix2.HeightF = 17F;
            this.Tablix2.MultiColumn.ColumnSpacing = 50F;
            this.Tablix2.Name = "Tablix2";
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel11.BorderColor = System.Drawing.Color.Black;
            this.xrLabel11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.BorderWidth = 1F;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckDate]")});
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel11.ForeColor = System.Drawing.Color.Black;
            this.xrLabel11.KeepTogether = true;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(210.0726F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(75.42F, 17F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorderDashStyle = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseBorderWidth = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UsePadding = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel11.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceVoucher]")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(410.4142F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(86.62997F, 17F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorderDashStyle = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckNumber]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(285.4926F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(124.9216F, 17F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FormattedVendorNumber]")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(210.0726F, 17F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceNumber]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([InvoiceVoucher] = \'BU\', False, True)")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.KeepTogether = true;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(497.0442F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(79.22101F, 17F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceDate]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([InvoiceVoucher] = \'BU\', False, True)")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.KeepTogether = true;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(576.2651F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(75.42096F, 17F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorderDashStyle = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel5.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel6.BorderColor = System.Drawing.Color.Black;
            this.xrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.BorderWidth = 1F;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PONumber]")});
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel6.ForeColor = System.Drawing.Color.Black;
            this.xrLabel6.KeepTogether = true;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(651.6862F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(108.8489F, 17F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorderDashStyle = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.BorderWidth = 1F;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceAmount]")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel7.ForeColor = System.Drawing.Color.Black;
            this.xrLabel7.KeepTogether = true;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(760.5452F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(109.9001F, 17F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorderDashStyle = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseBorderWidth = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel7.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel8.BorderColor = System.Drawing.Color.Black;
            this.xrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.BorderWidth = 1F;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiscountTaken]")});
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel8.ForeColor = System.Drawing.Color.Black;
            this.xrLabel8.KeepTogether = true;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(870.4453F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(80.73004F, 17F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorderDashStyle = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseBorderWidth = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel8.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel9.BorderColor = System.Drawing.Color.Black;
            this.xrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.BorderWidth = 1F;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmount]")});
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel9.ForeColor = System.Drawing.Color.Black;
            this.xrLabel9.KeepTogether = true;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(951.1752F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(88.02F, 17F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorderDashStyle = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseBorderWidth = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel9.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.Textbox20,
            this.Textbox22,
            this.Textbox18,
            this.Textbox16,
            this.Textbox13,
            this.Textbox33,
            this.Textbox7,
            this.Textbox149,
            this.Textbox10});
            this.pageHeaderBand1.HeightF = 35.00001F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BorderColor = System.Drawing.Color.Black;
            this.xrLabel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.BorderWidth = 1F;
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel10.KeepTogether = true;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(210.0685F, 0F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(75.42001F, 35.00001F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.Text = "Check Date";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox20
            // 
            this.Textbox20.BorderColor = System.Drawing.Color.Black;
            this.Textbox20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox20.BorderWidth = 1F;
            this.Textbox20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox20.KeepTogether = true;
            this.Textbox20.LocationFloat = new DevExpress.Utils.PointFloat(951.1685F, 0F);
            this.Textbox20.Multiline = true;
            this.Textbox20.Name = "Textbox20";
            this.Textbox20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox20.SizeF = new System.Drawing.SizeF(88.02F, 35F);
            this.Textbox20.StylePriority.UseFont = false;
            this.Textbox20.StylePriority.UsePadding = false;
            this.Textbox20.StylePriority.UseTextAlignment = false;
            this.Textbox20.Text = "Amount";
            this.Textbox20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox20.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            // 
            // Textbox22
            // 
            this.Textbox22.BorderColor = System.Drawing.Color.Black;
            this.Textbox22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox22.BorderWidth = 1F;
            this.Textbox22.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox22.KeepTogether = true;
            this.Textbox22.LocationFloat = new DevExpress.Utils.PointFloat(870.4386F, 0F);
            this.Textbox22.Multiline = true;
            this.Textbox22.Name = "Textbox22";
            this.Textbox22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox22.SizeF = new System.Drawing.SizeF(80.72998F, 35.00001F);
            this.Textbox22.StylePriority.UseFont = false;
            this.Textbox22.StylePriority.UsePadding = false;
            this.Textbox22.StylePriority.UseTextAlignment = false;
            this.Textbox22.Text = "Disc";
            this.Textbox22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox22.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            // 
            // Textbox18
            // 
            this.Textbox18.BorderColor = System.Drawing.Color.Black;
            this.Textbox18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox18.BorderWidth = 1F;
            this.Textbox18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox18.KeepTogether = true;
            this.Textbox18.LocationFloat = new DevExpress.Utils.PointFloat(760.5384F, 0F);
            this.Textbox18.Multiline = true;
            this.Textbox18.Name = "Textbox18";
            this.Textbox18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox18.SizeF = new System.Drawing.SizeF(109.9F, 35.00001F);
            this.Textbox18.StylePriority.UseFont = false;
            this.Textbox18.StylePriority.UsePadding = false;
            this.Textbox18.StylePriority.UseTextAlignment = false;
            this.Textbox18.Text = "Invoice Amount";
            this.Textbox18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox18.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            // 
            // Textbox16
            // 
            this.Textbox16.BorderColor = System.Drawing.Color.Black;
            this.Textbox16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox16.BorderWidth = 1F;
            this.Textbox16.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox16.KeepTogether = true;
            this.Textbox16.LocationFloat = new DevExpress.Utils.PointFloat(651.6786F, 0F);
            this.Textbox16.Multiline = true;
            this.Textbox16.Name = "Textbox16";
            this.Textbox16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox16.SizeF = new System.Drawing.SizeF(108.85F, 35.00001F);
            this.Textbox16.StylePriority.UseFont = false;
            this.Textbox16.StylePriority.UsePadding = false;
            this.Textbox16.Text = "PO Number";
            this.Textbox16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox13
            // 
            this.Textbox13.BorderColor = System.Drawing.Color.Black;
            this.Textbox13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox13.BorderWidth = 1F;
            this.Textbox13.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox13.KeepTogether = true;
            this.Textbox13.LocationFloat = new DevExpress.Utils.PointFloat(576.2585F, 0F);
            this.Textbox13.Multiline = true;
            this.Textbox13.Name = "Textbox13";
            this.Textbox13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox13.SizeF = new System.Drawing.SizeF(75.42001F, 35.00001F);
            this.Textbox13.StylePriority.UseFont = false;
            this.Textbox13.StylePriority.UsePadding = false;
            this.Textbox13.Text = "Inv Date";
            this.Textbox13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox33
            // 
            this.Textbox33.BorderColor = System.Drawing.Color.Black;
            this.Textbox33.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox33.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox33.BorderWidth = 1F;
            this.Textbox33.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox33.KeepTogether = true;
            this.Textbox33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Textbox33.Multiline = true;
            this.Textbox33.Name = "Textbox33";
            this.Textbox33.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox33.SizeF = new System.Drawing.SizeF(210.0685F, 35.00001F);
            this.Textbox33.StylePriority.UseFont = false;
            this.Textbox33.StylePriority.UsePadding = false;
            this.Textbox33.StylePriority.UseTextAlignment = false;
            this.Textbox33.Text = "Vendor";
            this.Textbox33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox7
            // 
            this.Textbox7.BorderColor = System.Drawing.Color.Black;
            this.Textbox7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox7.BorderWidth = 1F;
            this.Textbox7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox7.KeepTogether = true;
            this.Textbox7.LocationFloat = new DevExpress.Utils.PointFloat(410.4085F, 0F);
            this.Textbox7.Multiline = true;
            this.Textbox7.Name = "Textbox7";
            this.Textbox7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox7.SizeF = new System.Drawing.SizeF(86.63F, 35.00001F);
            this.Textbox7.StylePriority.UseFont = false;
            this.Textbox7.StylePriority.UsePadding = false;
            this.Textbox7.StylePriority.UseTextAlignment = false;
            this.Textbox7.Text = "Voucher";
            this.Textbox7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox149
            // 
            this.Textbox149.BorderColor = System.Drawing.Color.Black;
            this.Textbox149.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox149.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox149.BorderWidth = 1F;
            this.Textbox149.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox149.KeepTogether = true;
            this.Textbox149.LocationFloat = new DevExpress.Utils.PointFloat(285.4885F, 0F);
            this.Textbox149.Multiline = true;
            this.Textbox149.Name = "Textbox149";
            this.Textbox149.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox149.SizeF = new System.Drawing.SizeF(124.92F, 35.00001F);
            this.Textbox149.StylePriority.UseFont = false;
            this.Textbox149.StylePriority.UsePadding = false;
            this.Textbox149.Text = "Check #";
            this.Textbox149.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox10
            // 
            this.Textbox10.BorderColor = System.Drawing.Color.Black;
            this.Textbox10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox10.BorderWidth = 1F;
            this.Textbox10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox10.KeepTogether = true;
            this.Textbox10.LocationFloat = new DevExpress.Utils.PointFloat(497.0385F, 0F);
            this.Textbox10.Multiline = true;
            this.Textbox10.Name = "Textbox10";
            this.Textbox10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox10.SizeF = new System.Drawing.SizeF(79.22003F, 35.00001F);
            this.Textbox10.StylePriority.UseFont = false;
            this.Textbox10.StylePriority.UsePadding = false;
            this.Textbox10.StylePriority.UseTextAlignment = false;
            this.Textbox10.Text = "Inv #";
            this.Textbox10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pstrServerName
            // 
            this.pstrServerName.Description = "pstrServerName";
            this.pstrServerName.Name = "pstrServerName";
            this.pstrServerName.Visible = false;
            // 
            // pstrDatabaseName
            // 
            this.pstrDatabaseName.Description = "pstrDatabaseName";
            this.pstrDatabaseName.Name = "pstrDatabaseName";
            this.pstrDatabaseName.Visible = false;
            // 
            // plngUserID
            // 
            this.plngUserID.Description = "plngUserID";
            this.plngUserID.Name = "plngUserID";
            this.plngUserID.Type = typeof(int);
            this.plngUserID.ValueInfo = "0";
            this.plngUserID.Visible = false;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            this.plngCompanyID.Visible = false;
            // 
            // plngRunType
            // 
            this.plngRunType.Description = "plngRunType";
            this.plngRunType.Name = "plngRunType";
            this.plngRunType.Type = typeof(int);
            this.plngRunType.ValueInfo = "1";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "Accounts Payable Computer Check Register"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(2, "Accounts Payable Manual Check Register"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(3, "Accounts Payable Clear Zero Items"));
            this.plngRunType.ValueSourceSettings = staticListLookUpSettings1;
            this.plngRunType.Visible = false;
            // 
            // plngID
            // 
            this.plngID.Description = "plngID";
            this.plngID.Name = "plngID";
            this.plngID.Type = typeof(int);
            this.plngID.ValueInfo = "3179";
            this.plngID.Visible = false;
            // 
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Description = "Show Criteria";
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "True";
            // 
            // plngSortOrder
            // 
            this.plngSortOrder.Description = "plngSortOrder";
            this.plngSortOrder.Name = "plngSortOrder";
            this.plngSortOrder.Type = typeof(int);
            this.plngSortOrder.ValueInfo = "0";
            this.plngSortOrder.Visible = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2});
            this.ReportFooter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngTransactionSourceCodeID>0")});
            this.ReportFooter.HeightF = 1.986821E-06F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Subtitle", this.Subtitle));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCompanyID", this.plngCompanyID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngBatchID", null, null));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngPostDestinationCodeID", null, null));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrPostType", null, null));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooShowCriteria", null, null));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngTransactionSourceCodeID", this.plngTransactionSourceCodeID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngAPCheckProcessTrackingID", this.plngID));
            this.xrSubreport2.ReportSource = new ReportsEngine.Reports.ProcessReports.ExcelGLProcessPostRegister();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(1039.189F, 1.986821E-06F);
            // 
            // plngTransactionSourceCodeID
            // 
            this.plngTransactionSourceCodeID.Description = "plngTransactionSourceCodeID";
            this.plngTransactionSourceCodeID.Name = "plngTransactionSourceCodeID";
            this.plngTransactionSourceCodeID.Type = typeof(int);
            this.plngTransactionSourceCodeID.ValueInfo = "0";
            this.plngTransactionSourceCodeID.Visible = false;
            // 
            // ExcelAPCheckRegister
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix2,
            this.pageHeaderBand1,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "DSAPCheckRegister";
            this.DataSource = this.Dynamic;
            this.DisplayName = "APCheckRegister";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 22F, 20F, 20F);
            this.PageWidth = 1700;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Ledger;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngRunType, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowCriteria, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngSortOrder, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.plngCompanyID,
            this.plngRunType,
            this.plngID,
            this.Subtitle,
            this.pbooShowCriteria,
            this.plngSortOrder,
            this.plngTransactionSourceCodeID});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel Textbox20;
        private DevExpress.XtraReports.UI.XRLabel Textbox22;
        private DevExpress.XtraReports.UI.XRLabel Textbox18;
        private DevExpress.XtraReports.UI.XRLabel Textbox16;
        private DevExpress.XtraReports.UI.XRLabel Textbox13;
        private DevExpress.XtraReports.UI.XRLabel Textbox33;
        private DevExpress.XtraReports.UI.XRLabel Textbox7;
        private DevExpress.XtraReports.UI.XRLabel Textbox149;
        private DevExpress.XtraReports.UI.XRLabel Textbox10;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter plngRunType;
        private DevExpress.XtraReports.Parameters.Parameter plngID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.Parameters.Parameter plngSortOrder;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.Parameters.Parameter plngTransactionSourceCodeID;
    }
}
