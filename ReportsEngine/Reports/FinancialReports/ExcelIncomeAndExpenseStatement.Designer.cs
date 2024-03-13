namespace ReportsEngine.Reports.FinancialReports
{
    partial class ExcelIncomeAndExpenseStatement
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelIncomeAndExpenseStatement));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.Textbox20 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox19 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox18 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox17 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox14 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox4 = new DevExpress.XtraReports.UI.XRLabel();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningAccountingCenter = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingAccountingCenter = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteBeginningPostDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteEndingPostDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningAccountNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingAccountNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngBookCodeID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooIncludeStartingBalances = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowAccountNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectAccount = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectAccountingCenter = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngShowZeroBalances = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowDetail = new DevExpress.XtraReports.Parameters.Parameter();
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
            // Tablix1
            // 
            this.Tablix1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel9});
            this.Tablix1.HeightF = 17.00005F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.BorderWidth = 0F;
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountingCenterName]")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.KeepTogether = true;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(393.1966F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(183.4328F, 16.99999F);
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
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 0F;
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DebitAmount]\n")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.KeepTogether = true;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(576.6293F, 6.357829E-05F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(95.09052F, 16.99999F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel4.TextFormatString = "{0:N2}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 0F;
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountingCenterNumber]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(113.3014F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(49.99986F, 16.99999F);
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
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 0F;
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountDescription]")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(163.3013F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(229.8952F, 16.99999F);
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
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 0F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountNumber]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?pbooShowAccountNumber")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(113.3F, 17F);
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
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel9.BorderColor = System.Drawing.Color.Black;
            this.xrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.BorderWidth = 0F;
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CreditAmount]\n")});
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel9.ForeColor = System.Drawing.Color.Black;
            this.xrLabel9.KeepTogether = true;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(671.72F, 0F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(98.28027F, 17.00002F);
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
            this.xrLabel9.TextFormatString = "{0:N2}";
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Textbox20,
            this.Textbox19,
            this.Textbox18,
            this.Textbox17,
            this.Textbox14,
            this.Textbox4});
            this.pageHeaderBand1.HeightF = 36.81002F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox20
            // 
            this.Textbox20.BackColor = System.Drawing.Color.Transparent;
            this.Textbox20.BorderColor = System.Drawing.Color.Black;
            this.Textbox20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox20.BorderWidth = 0F;
            this.Textbox20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox20.KeepTogether = true;
            this.Textbox20.LocationFloat = new DevExpress.Utils.PointFloat(671.7197F, 1.525879E-05F);
            this.Textbox20.Multiline = true;
            this.Textbox20.Name = "Textbox20";
            this.Textbox20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.Textbox20.SizeF = new System.Drawing.SizeF(98.28033F, 36.80999F);
            this.Textbox20.StylePriority.UseBackColor = false;
            this.Textbox20.StylePriority.UseBorderWidth = false;
            this.Textbox20.StylePriority.UseFont = false;
            this.Textbox20.StylePriority.UsePadding = false;
            this.Textbox20.StylePriority.UseTextAlignment = false;
            this.Textbox20.Text = "Credit";
            this.Textbox20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Textbox19
            // 
            this.Textbox19.BackColor = System.Drawing.Color.Transparent;
            this.Textbox19.BorderColor = System.Drawing.Color.Black;
            this.Textbox19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox19.BorderWidth = 0F;
            this.Textbox19.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox19.KeepTogether = true;
            this.Textbox19.LocationFloat = new DevExpress.Utils.PointFloat(393.1966F, 3.051758E-05F);
            this.Textbox19.Multiline = true;
            this.Textbox19.Name = "Textbox19";
            this.Textbox19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.Textbox19.SizeF = new System.Drawing.SizeF(183.4328F, 36.80999F);
            this.Textbox19.StylePriority.UseBackColor = false;
            this.Textbox19.StylePriority.UseBorderWidth = false;
            this.Textbox19.StylePriority.UseFont = false;
            this.Textbox19.StylePriority.UsePadding = false;
            this.Textbox19.StylePriority.UseTextAlignment = false;
            this.Textbox19.Text = "Acct. Center Name";
            this.Textbox19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox18
            // 
            this.Textbox18.BackColor = System.Drawing.Color.Transparent;
            this.Textbox18.BorderColor = System.Drawing.Color.Black;
            this.Textbox18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox18.BorderWidth = 0F;
            this.Textbox18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox18.KeepTogether = true;
            this.Textbox18.LocationFloat = new DevExpress.Utils.PointFloat(576.6292F, 1.525879E-05F);
            this.Textbox18.Multiline = true;
            this.Textbox18.Name = "Textbox18";
            this.Textbox18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.Textbox18.SizeF = new System.Drawing.SizeF(95.09033F, 36.81001F);
            this.Textbox18.StylePriority.UseBackColor = false;
            this.Textbox18.StylePriority.UseBorderWidth = false;
            this.Textbox18.StylePriority.UseFont = false;
            this.Textbox18.StylePriority.UsePadding = false;
            this.Textbox18.StylePriority.UseTextAlignment = false;
            this.Textbox18.Text = "Debit";
            this.Textbox18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Textbox17
            // 
            this.Textbox17.BackColor = System.Drawing.Color.Transparent;
            this.Textbox17.BorderColor = System.Drawing.Color.Black;
            this.Textbox17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox17.BorderWidth = 0F;
            this.Textbox17.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox17.KeepTogether = true;
            this.Textbox17.LocationFloat = new DevExpress.Utils.PointFloat(113.3013F, 0F);
            this.Textbox17.Multiline = true;
            this.Textbox17.Name = "Textbox17";
            this.Textbox17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.Textbox17.SizeF = new System.Drawing.SizeF(50F, 36.81F);
            this.Textbox17.StylePriority.UseBackColor = false;
            this.Textbox17.StylePriority.UseBorderWidth = false;
            this.Textbox17.StylePriority.UseFont = false;
            this.Textbox17.StylePriority.UsePadding = false;
            this.Textbox17.StylePriority.UseTextAlignment = false;
            this.Textbox17.Text = "Acct.\r\nCenter";
            this.Textbox17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox14
            // 
            this.Textbox14.BackColor = System.Drawing.Color.Transparent;
            this.Textbox14.BorderColor = System.Drawing.Color.Black;
            this.Textbox14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox14.BorderWidth = 0F;
            this.Textbox14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox14.KeepTogether = true;
            this.Textbox14.LocationFloat = new DevExpress.Utils.PointFloat(163.3013F, 0F);
            this.Textbox14.Multiline = true;
            this.Textbox14.Name = "Textbox14";
            this.Textbox14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.Textbox14.SizeF = new System.Drawing.SizeF(229.8952F, 36.81001F);
            this.Textbox14.StylePriority.UseBackColor = false;
            this.Textbox14.StylePriority.UseBorderWidth = false;
            this.Textbox14.StylePriority.UseFont = false;
            this.Textbox14.StylePriority.UsePadding = false;
            this.Textbox14.StylePriority.UseTextAlignment = false;
            this.Textbox14.Text = "Account Description";
            this.Textbox14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox4
            // 
            this.Textbox4.BackColor = System.Drawing.Color.Transparent;
            this.Textbox4.BorderColor = System.Drawing.Color.Black;
            this.Textbox4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox4.BorderWidth = 0F;
            this.Textbox4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?pbooShowAccountNumber")});
            this.Textbox4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox4.KeepTogether = true;
            this.Textbox4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Textbox4.Multiline = true;
            this.Textbox4.Name = "Textbox4";
            this.Textbox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.Textbox4.SizeF = new System.Drawing.SizeF(113.3014F, 36.81F);
            this.Textbox4.StylePriority.UseBackColor = false;
            this.Textbox4.StylePriority.UseBorderWidth = false;
            this.Textbox4.StylePriority.UseFont = false;
            this.Textbox4.StylePriority.UsePadding = false;
            this.Textbox4.StylePriority.UseTextAlignment = false;
            this.Textbox4.Text = "Account Number";
            this.Textbox4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSIncomeAndExpense";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter2.Name = "@pdteBeginningPostDate";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?pdteBeginningPostDate", typeof(System.DateTime));
            queryParameter3.Name = "@pdteEndingPostDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?pdteEndingPostDate", typeof(System.DateTime));
            queryParameter4.Name = "@pstrBeginningAccountNumber";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?pstrBeginningAccountNumber", typeof(string));
            queryParameter5.Name = "@pstrEndingAccountNumber";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?pstrEndingAccountNumber", typeof(string));
            queryParameter6.Name = "@pstrBeginningCostCenter";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?pstrBeginningAccountingCenter", typeof(string));
            queryParameter7.Name = "@pstrEndingCostCenter";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?pstrEndingAccountingCenter", typeof(string));
            queryParameter8.Name = "@pbooIncludeStartingBalances";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("?pbooIncludeStartingBalances", typeof(bool));
            queryParameter9.Name = "@plngBalanceSheetOrIncomeAndExpense";
            queryParameter9.Type = typeof(int);
            queryParameter9.ValueInfo = "2";
            queryParameter10.Name = "@plngShowZeroBalances";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("?plngShowZeroBalances", typeof(int));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5,
            queryParameter6,
            queryParameter7,
            queryParameter8,
            queryParameter9,
            queryParameter10});
            storedProcQuery1.StoredProcName = "Report_BalanceSheetAndIncomeStatements";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
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
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "1";
            this.plngCompanyID.Visible = false;
            // 
            // pstrBeginningAccountingCenter
            // 
            this.pstrBeginningAccountingCenter.Description = "Beginning Accounting Center";
            this.pstrBeginningAccountingCenter.Name = "pstrBeginningAccountingCenter";
            this.pstrBeginningAccountingCenter.ValueInfo = "!";
            // 
            // pstrEndingAccountingCenter
            // 
            this.pstrEndingAccountingCenter.Description = "Ending Accounting Center";
            this.pstrEndingAccountingCenter.Name = "pstrEndingAccountingCenter";
            this.pstrEndingAccountingCenter.ValueInfo = "ZZZZZZZZZZ-ZZZZZZZZZZ";
            // 
            // pdteBeginningPostDate
            // 
            this.pdteBeginningPostDate.Description = "Beginning Post Date";
            this.pdteBeginningPostDate.Name = "pdteBeginningPostDate";
            this.pdteBeginningPostDate.Type = typeof(System.DateTime);
            this.pdteBeginningPostDate.ValueInfo = "1900-01-01";
            // 
            // pdteEndingPostDate
            // 
            this.pdteEndingPostDate.Description = "Ending Post Date";
            this.pdteEndingPostDate.Name = "pdteEndingPostDate";
            this.pdteEndingPostDate.Type = typeof(System.DateTime);
            this.pdteEndingPostDate.ValueInfo = "9999-12-31";
            // 
            // pstrBeginningAccountNumber
            // 
            this.pstrBeginningAccountNumber.Description = "Beginning Account";
            this.pstrBeginningAccountNumber.Name = "pstrBeginningAccountNumber";
            this.pstrBeginningAccountNumber.ValueInfo = "!";
            // 
            // pstrEndingAccountNumber
            // 
            this.pstrEndingAccountNumber.Description = "Ending Account";
            this.pstrEndingAccountNumber.Name = "pstrEndingAccountNumber";
            this.pstrEndingAccountNumber.ValueInfo = "ZZZZZZZZZZ-ZZZZ";
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Description = "Show Criteria";
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "True";
            // 
            // plngBookCodeID
            // 
            this.plngBookCodeID.Description = "plngBookCodeID";
            this.plngBookCodeID.Name = "plngBookCodeID";
            this.plngBookCodeID.Type = typeof(int);
            this.plngBookCodeID.ValueInfo = "0";
            this.plngBookCodeID.Visible = false;
            // 
            // pbooIncludeStartingBalances
            // 
            this.pbooIncludeStartingBalances.Description = "Include Starting Balances";
            this.pbooIncludeStartingBalances.Name = "pbooIncludeStartingBalances";
            this.pbooIncludeStartingBalances.Type = typeof(bool);
            this.pbooIncludeStartingBalances.ValueInfo = "False";
            // 
            // pbooShowAccountNumber
            // 
            this.pbooShowAccountNumber.Description = "Show Account Number";
            this.pbooShowAccountNumber.Name = "pbooShowAccountNumber";
            this.pbooShowAccountNumber.Type = typeof(bool);
            this.pbooShowAccountNumber.ValueInfo = "False";
            // 
            // pstrSelectAccount
            // 
            this.pstrSelectAccount.Description = "Select Account";
            this.pstrSelectAccount.MultiValue = true;
            this.pstrSelectAccount.Name = "pstrSelectAccount";
            // 
            // pstrSelectAccountingCenter
            // 
            this.pstrSelectAccountingCenter.Description = "Select Accounting Center";
            this.pstrSelectAccountingCenter.MultiValue = true;
            this.pstrSelectAccountingCenter.Name = "pstrSelectAccountingCenter";
            // 
            // plngShowZeroBalances
            // 
            this.plngShowZeroBalances.Description = "Show Zero Balances";
            this.plngShowZeroBalances.Name = "plngShowZeroBalances";
            this.plngShowZeroBalances.Type = typeof(int);
            this.plngShowZeroBalances.ValueInfo = "0";
            // 
            // pbooShowDetail
            // 
            this.pbooShowDetail.Description = "Show Detail";
            this.pbooShowDetail.Name = "pbooShowDetail";
            this.pbooShowDetail.Type = typeof(bool);
            this.pbooShowDetail.ValueInfo = "False";
            // 
            // ExcelIncomeAndExpenseStatement
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1,
            this.pageHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "DSIncomeAndExpense";
            this.DataSource = this.Dynamic;
            this.DisplayName = "ExcelIncomeAndExpenseStatement";
            this.FilterString = "[AccountNumber] In (?pstrSelectAccount) And ([AccountingCenterNumber] In (?pstrSe" +
    "lectAccountingCenter) Or IsNullOrEmpty([AccountingCenterNumber]) And \'!\' In (?ps" +
    "trSelectAccountingCenter))";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 0F, 0F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningAccountingCenter, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingAccountingCenter, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteBeginningPostDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteEndingPostDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningAccountNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingAccountNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngBookCodeID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowCriteria, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooIncludeStartingBalances, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowAccountNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectAccount, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectAccountingCenter, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngShowZeroBalances, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.plngCompanyID,
            this.pstrBeginningAccountingCenter,
            this.pstrEndingAccountingCenter,
            this.pdteBeginningPostDate,
            this.pdteEndingPostDate,
            this.pstrBeginningAccountNumber,
            this.pstrEndingAccountNumber,
            this.plngBookCodeID,
            this.pbooShowCriteria,
            this.pbooIncludeStartingBalances,
            this.pbooShowAccountNumber,
            this.pstrSelectAccount,
            this.pstrSelectAccountingCenter,
            this.plngShowZeroBalances,
            this.pbooShowDetail});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningAccountingCenter;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingAccountingCenter;
        private DevExpress.XtraReports.Parameters.Parameter pdteBeginningPostDate;
        private DevExpress.XtraReports.Parameters.Parameter pdteEndingPostDate;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningAccountNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingAccountNumber;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.Parameters.Parameter plngBookCodeID;
        private DevExpress.XtraReports.UI.XRLabel Textbox20;
        private DevExpress.XtraReports.UI.XRLabel Textbox19;
        private DevExpress.XtraReports.UI.XRLabel Textbox18;
        private DevExpress.XtraReports.UI.XRLabel Textbox17;
        private DevExpress.XtraReports.UI.XRLabel Textbox14;
        private DevExpress.XtraReports.UI.XRLabel Textbox4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.Parameters.Parameter pbooIncludeStartingBalances;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowAccountNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectAccount;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectAccountingCenter;
        private DevExpress.XtraReports.Parameters.Parameter plngShowZeroBalances;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowDetail;
    }
}
