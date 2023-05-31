namespace ReportsEngine.Reports
{
    partial class ChartofAccountListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartofAccountListing));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.AccountNumber = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.AccountTypeDescription = new DevExpress.XtraReports.UI.XRTableCell();
            this.TypicalBalance = new DevExpress.XtraReports.UI.XRTableCell();
            this.CashFlowCategory = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Rectangle2 = new DevExpress.XtraReports.UI.XRPanel();
            this.Textbox50 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox10 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.Rectangle4 = new DevExpress.XtraReports.UI.XRPanel();
            this.Textbox4 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox14 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox17 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox18 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox19 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox20 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox7 = new DevExpress.XtraReports.UI.XRRichText();
            this.ExecutionTime = new DevExpress.XtraReports.UI.XRRichText();
            this.Textbox5 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox12 = new DevExpress.XtraReports.UI.XRLabel();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningAccountNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingAccountNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowNotes = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Textbox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExecutionTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 20F;
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
            this.Details_table});
            this.Tablix1.HeightF = 20F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Textbox10,
            this.ReportTitle,
            this.Rectangle4,
            this.Textbox4,
            this.Textbox14,
            this.Textbox17,
            this.Textbox18,
            this.Textbox19,
            this.Textbox20});
            this.pageHeaderBand1.HeightF = 125.14F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.BorderColor = System.Drawing.Color.Black;
            this.pageFooterBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageFooterBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageFooterBand1.BorderWidth = 1F;
            this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.ExecutionTime,
            this.Textbox5,
            this.Textbox12});
            this.pageFooterBand1.HeightF = 52.78F;
            this.pageFooterBand1.Name = "pageFooterBand1";
            this.pageFooterBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(2.89F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.Details_table.SizeF = new System.Drawing.SizeF(778.59F, 20F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.AccountNumber,
            this.Textbox8,
            this.AccountTypeDescription,
            this.TypicalBalance,
            this.CashFlowCategory,
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.5D;
            // 
            // AccountNumber
            // 
            this.AccountNumber.BackColor = System.Drawing.Color.White;
            this.AccountNumber.BorderColor = System.Drawing.Color.Black;
            this.AccountNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.AccountNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AccountNumber.BorderWidth = 1F;
            this.AccountNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountNumber]")});
            this.AccountNumber.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.AccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AccountNumber.KeepTogether = true;
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.AccountNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.AccountNumber.Weight = 11021.963636363636D;
            // 
            // Textbox8
            // 
            this.Textbox8.BorderColor = System.Drawing.Color.Black;
            this.Textbox8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox8.BorderWidth = 1F;
            this.Textbox8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountDescription]")});
            this.Textbox8.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox8.KeepTogether = true;
            this.Textbox8.Name = "Textbox8";
            this.Textbox8.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox8.Weight = 25517.336363636365D;
            // 
            // AccountTypeDescription
            // 
            this.AccountTypeDescription.BackColor = System.Drawing.Color.White;
            this.AccountTypeDescription.BorderColor = System.Drawing.Color.Black;
            this.AccountTypeDescription.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.AccountTypeDescription.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AccountTypeDescription.BorderWidth = 1F;
            this.AccountTypeDescription.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountTypeDescription]")});
            this.AccountTypeDescription.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.AccountTypeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AccountTypeDescription.KeepTogether = true;
            this.AccountTypeDescription.Name = "AccountTypeDescription";
            this.AccountTypeDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.AccountTypeDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.AccountTypeDescription.Weight = 9402.4303030303035D;
            // 
            // TypicalBalance
            // 
            this.TypicalBalance.BackColor = System.Drawing.Color.White;
            this.TypicalBalance.BorderColor = System.Drawing.Color.Black;
            this.TypicalBalance.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TypicalBalance.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TypicalBalance.BorderWidth = 1F;
            this.TypicalBalance.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TypicalBalance]")});
            this.TypicalBalance.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.TypicalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TypicalBalance.KeepTogether = true;
            this.TypicalBalance.Name = "TypicalBalance";
            this.TypicalBalance.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.TypicalBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.TypicalBalance.Weight = 7081.859848484848D;
            // 
            // CashFlowCategory
            // 
            this.CashFlowCategory.BackColor = System.Drawing.Color.White;
            this.CashFlowCategory.BorderColor = System.Drawing.Color.Black;
            this.CashFlowCategory.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CashFlowCategory.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CashFlowCategory.BorderWidth = 1F;
            this.CashFlowCategory.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CashFlowCategory]")});
            this.CashFlowCategory.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.CashFlowCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CashFlowCategory.KeepTogether = true;
            this.CashFlowCategory.Name = "CashFlowCategory";
            this.CashFlowCategory.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CashFlowCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.CashFlowCategory.Weight = 19125.589393939394D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Rectangle2});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Weight = 5161.456439393939D;
            // 
            // Rectangle2
            // 
            this.Rectangle2.BorderColor = System.Drawing.Color.Black;
            this.Rectangle2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Rectangle2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Rectangle2.BorderWidth = 1F;
            this.Rectangle2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Textbox50});
            this.Rectangle2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Rectangle2.Name = "Rectangle2";
            this.Rectangle2.SizeF = new System.Drawing.SizeF(51.98F, 20F);
            // 
            // Textbox50
            // 
            this.Textbox50.BorderColor = System.Drawing.Color.Black;
            this.Textbox50.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox50.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox50.BorderWidth = 1F;
            this.Textbox50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([IsBillable], \'X\', \'\')")});
            this.Textbox50.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox50.KeepTogether = true;
            this.Textbox50.LocationFloat = new DevExpress.Utils.PointFloat(5.56F, 4.62F);
            this.Textbox50.Multiline = true;
            this.Textbox50.Name = "Textbox50";
            this.Textbox50.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox50.SizeF = new System.Drawing.SizeF(15F, 15F);
            this.Textbox50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox10
            // 
            this.Textbox10.BorderColor = System.Drawing.Color.Black;
            this.Textbox10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox10.BorderWidth = 1F;
            this.Textbox10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dynamic_LookupCompanies].[Description]\n")});
            this.Textbox10.Font = new DevExpress.Drawing.DXFont("Segoe UI Light", 14F);
            this.Textbox10.KeepTogether = true;
            this.Textbox10.LocationFloat = new DevExpress.Utils.PointFloat(0.59F, 0F);
            this.Textbox10.Multiline = true;
            this.Textbox10.Name = "Textbox10";
            this.Textbox10.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox10.SizeF = new System.Drawing.SizeF(779.84F, 30F);
            this.Textbox10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ReportTitle
            // 
            this.ReportTitle.BorderColor = System.Drawing.Color.Black;
            this.ReportTitle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.ReportTitle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ReportTitle.BorderWidth = 1F;
            this.ReportTitle.Font = new DevExpress.Drawing.DXFont("Segoe UI Light", 14F);
            this.ReportTitle.KeepTogether = true;
            this.ReportTitle.LocationFloat = new DevExpress.Utils.PointFloat(0.59F, 31.39F);
            this.ReportTitle.Multiline = true;
            this.ReportTitle.Name = "ReportTitle";
            this.ReportTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.ReportTitle.SizeF = new System.Drawing.SizeF(779.84F, 30F);
            this.ReportTitle.Text = "Chart of Accounts Master List";
            this.ReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Rectangle4
            // 
            this.Rectangle4.BorderColor = System.Drawing.Color.Black;
            this.Rectangle4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Rectangle4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Rectangle4.BorderWidth = 1F;
            this.Rectangle4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Textbox7});
            this.Rectangle4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?pbooShowCriteria = True, True, False)")});
            this.Rectangle4.LocationFloat = new DevExpress.Utils.PointFloat(0.5899747F, 61.39F);
            this.Rectangle4.Name = "Rectangle4";
            this.Rectangle4.SizeF = new System.Drawing.SizeF(779.84F, 26.94F);
            // 
            // Textbox4
            // 
            this.Textbox4.BackColor = System.Drawing.Color.White;
            this.Textbox4.BorderColor = System.Drawing.Color.Black;
            this.Textbox4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox4.BorderWidth = 1F;
            this.Textbox4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox4.KeepTogether = true;
            this.Textbox4.LocationFloat = new DevExpress.Utils.PointFloat(6.26F, 88.33F);
            this.Textbox4.Multiline = true;
            this.Textbox4.Name = "Textbox4";
            this.Textbox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox4.SizeF = new System.Drawing.SizeF(107.63F, 36.81F);
            this.Textbox4.Text = "Account Number";
            this.Textbox4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Textbox14
            // 
            this.Textbox14.BackColor = System.Drawing.Color.White;
            this.Textbox14.BorderColor = System.Drawing.Color.Black;
            this.Textbox14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox14.BorderWidth = 1F;
            this.Textbox14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox14.KeepTogether = true;
            this.Textbox14.LocationFloat = new DevExpress.Utils.PointFloat(113.89F, 88.33F);
            this.Textbox14.Multiline = true;
            this.Textbox14.Name = "Textbox14";
            this.Textbox14.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox14.SizeF = new System.Drawing.SizeF(256.98F, 36.81F);
            this.Textbox14.Text = "Account Description";
            this.Textbox14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Textbox17
            // 
            this.Textbox17.BackColor = System.Drawing.Color.White;
            this.Textbox17.BorderColor = System.Drawing.Color.Black;
            this.Textbox17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox17.BorderWidth = 1F;
            this.Textbox17.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox17.KeepTogether = true;
            this.Textbox17.LocationFloat = new DevExpress.Utils.PointFloat(370.87F, 88.33F);
            this.Textbox17.Multiline = true;
            this.Textbox17.Name = "Textbox17";
            this.Textbox17.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox17.SizeF = new System.Drawing.SizeF(94.69F, 36.81F);
            this.Textbox17.Text = "Account Type ";
            this.Textbox17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Textbox18
            // 
            this.Textbox18.BackColor = System.Drawing.Color.White;
            this.Textbox18.BorderColor = System.Drawing.Color.Black;
            this.Textbox18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox18.BorderWidth = 1F;
            this.Textbox18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox18.KeepTogether = true;
            this.Textbox18.LocationFloat = new DevExpress.Utils.PointFloat(465.56F, 88.33F);
            this.Textbox18.Multiline = true;
            this.Textbox18.Name = "Textbox18";
            this.Textbox18.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox18.SizeF = new System.Drawing.SizeF(71.32F, 36.81F);
            this.Textbox18.Text = "Balance Type ";
            this.Textbox18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Textbox19
            // 
            this.Textbox19.BackColor = System.Drawing.Color.White;
            this.Textbox19.BorderColor = System.Drawing.Color.Black;
            this.Textbox19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox19.BorderWidth = 1F;
            this.Textbox19.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox19.KeepTogether = true;
            this.Textbox19.LocationFloat = new DevExpress.Utils.PointFloat(536.89F, 88.33F);
            this.Textbox19.Multiline = true;
            this.Textbox19.Name = "Textbox19";
            this.Textbox19.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox19.SizeF = new System.Drawing.SizeF(192.61F, 36.81F);
            this.Textbox19.Text = "Cash Flow Category";
            this.Textbox19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Textbox20
            // 
            this.Textbox20.BackColor = System.Drawing.Color.White;
            this.Textbox20.BorderColor = System.Drawing.Color.Black;
            this.Textbox20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox20.BorderWidth = 1F;
            this.Textbox20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox20.KeepTogether = true;
            this.Textbox20.LocationFloat = new DevExpress.Utils.PointFloat(729.39F, 88.33F);
            this.Textbox20.Multiline = true;
            this.Textbox20.Name = "Textbox20";
            this.Textbox20.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox20.SizeF = new System.Drawing.SizeF(51.04F, 36.81F);
            this.Textbox20.Text = "Is Billable";
            this.Textbox20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Textbox7
            // 
            this.Textbox7.BorderColor = System.Drawing.Color.Black;
            this.Textbox7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox7.BorderWidth = 1F;
            this.Textbox7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "Iif(?pstrBeginningAccountNumber<= \'!\' AND ?pstrEndingAccountNumber= \'ZZZZZZZZZZ-Z" +
                    "ZZZ\', \'All Accounts\', FormatString(?pstrBeginningAccountNumber) & \' to \' & Forma" +
                    "tString(?pstrEndingAccountNumber))")});
            this.Textbox7.KeepTogether = true;
            this.Textbox7.LocationFloat = new DevExpress.Utils.PointFloat(2.3F, 0F);
            this.Textbox7.Name = "Textbox7";
            this.Textbox7.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox7.SerializableRtfString = resources.GetString("Textbox7.SerializableRtfString");
            this.Textbox7.SizeF = new System.Drawing.SizeF(267.83F, 20F);
            // 
            // ExecutionTime
            // 
            this.ExecutionTime.BorderColor = System.Drawing.Color.Black;
            this.ExecutionTime.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.ExecutionTime.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ExecutionTime.BorderWidth = 1F;
            this.ExecutionTime.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "\'Run Date:\' + Now()\n")});
            this.ExecutionTime.KeepTogether = true;
            this.ExecutionTime.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.ExecutionTime.Name = "ExecutionTime";
            this.ExecutionTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.ExecutionTime.SerializableRtfString = resources.GetString("ExecutionTime.SerializableRtfString");
            this.ExecutionTime.SizeF = new System.Drawing.SizeF(284.38F, 25F);
            // 
            // Textbox5
            // 
            this.Textbox5.BorderColor = System.Drawing.Color.Black;
            this.Textbox5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox5.BorderWidth = 1F;
            this.Textbox5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'User: \' + [Pulse_Master_UserRecord].[FirstName] +  \' \' + [Pulse_Master_UserRecor" +
                    "d].[LastName]")});
            this.Textbox5.KeepTogether = true;
            this.Textbox5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 27.77999F);
            this.Textbox5.Multiline = true;
            this.Textbox5.Name = "Textbox5";
            this.Textbox5.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox5.SizeF = new System.Drawing.SizeF(284.38F, 25F);
            this.Textbox5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox12
            // 
            this.Textbox12.BorderColor = System.Drawing.Color.Black;
            this.Textbox12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox12.BorderWidth = 1F;
            this.Textbox12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CopyrightMessage]")});
            this.Textbox12.KeepTogether = true;
            this.Textbox12.LocationFloat = new DevExpress.Utils.PointFloat(539.0901F, 22.99999F);
            this.Textbox12.Multiline = true;
            this.Textbox12.Name = "Textbox12";
            this.Textbox12.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox12.SizeF = new System.Drawing.SizeF(254.91F, 25F);
            this.Textbox12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Connection";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DataSet1";
            queryParameter1.Name = "@pstrBeginningAccountNumber";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?pstrBeginningAccountNumber", typeof(string));
            queryParameter2.Name = "@pstrEndingAccountNumber";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?pstrEndingAccountNumber", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            storedProcQuery1.StoredProcName = "Report_ChartOfAccountsListing";
            storedProcQuery2.Name = "LookupCompanies";
            storedProcQuery2.StoredProcName = "Companies_ReportLookup";
            storedProcQuery3.Name = "LookupAccounts";
            storedProcQuery3.StoredProcName = "Accounts_ReportLookup";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3});
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
            this.plngUserID.Visible = false;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            dynamicListLookUpSettings1.DataMember = "LookupCompanies";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.ValueMember = "ID";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings1;
            this.plngCompanyID.Visible = false;
            // 
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // pstrBeginningAccountNumber
            // 
            this.pstrBeginningAccountNumber.Description = "Beginning Account";
            this.pstrBeginningAccountNumber.Name = "pstrBeginningAccountNumber";
            this.pstrBeginningAccountNumber.ValueInfo = "!";
            dynamicListLookUpSettings2.DataMember = "LookupAccounts";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "Description";
            dynamicListLookUpSettings2.ValueMember = "Number";
            this.pstrBeginningAccountNumber.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // pstrEndingAccountNumber
            // 
            this.pstrEndingAccountNumber.Description = "Ending Account";
            this.pstrEndingAccountNumber.Name = "pstrEndingAccountNumber";
            this.pstrEndingAccountNumber.ValueInfo = "ZZZZZZZZZZ-ZZZZ";
            dynamicListLookUpSettings3.DataMember = "LookupAccounts";
            dynamicListLookUpSettings3.DataSource = this.Dynamic;
            dynamicListLookUpSettings3.DisplayMember = "Description";
            dynamicListLookUpSettings3.ValueMember = "Number";
            this.pstrEndingAccountNumber.ValueSourceSettings = dynamicListLookUpSettings3;
            // 
            // pbooShowNotes
            // 
            this.pbooShowNotes.Description = "Show Notes";
            this.pbooShowNotes.Name = "pbooShowNotes";
            this.pbooShowNotes.Type = typeof(bool);
            this.pbooShowNotes.ValueInfo = "False";
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Description = "Show Criteria";
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "True";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(559.17F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(234.83F, 23F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrPageInfo1.TextFormatString = "Page {0} of {1}";
            // 
            // ChartofAccountListing
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1,
            this.pageHeaderBand1,
            this.pageFooterBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "DataSet1";
            this.DataSource = this.Dynamic;
            this.DisplayName = "ChartofAccountListing";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 36F, 20F, 0F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.plngCompanyID,
            this.Subtitle,
            this.pstrBeginningAccountNumber,
            this.pstrEndingAccountNumber,
            this.pbooShowNotes,
            this.pbooShowCriteria});
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Textbox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExecutionTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1;
        private DevExpress.XtraReports.UI.XRTable Details_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell AccountNumber;
        private DevExpress.XtraReports.UI.XRTableCell Textbox8;
        private DevExpress.XtraReports.UI.XRTableCell AccountTypeDescription;
        private DevExpress.XtraReports.UI.XRTableCell TypicalBalance;
        private DevExpress.XtraReports.UI.XRTableCell CashFlowCategory;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRPanel Rectangle2;
        private DevExpress.XtraReports.UI.XRLabel Textbox50;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel Textbox10;
        private DevExpress.XtraReports.UI.XRLabel ReportTitle;
        private DevExpress.XtraReports.UI.XRPanel Rectangle4;
        private DevExpress.XtraReports.UI.XRRichText Textbox7;
        private DevExpress.XtraReports.UI.XRLabel Textbox4;
        private DevExpress.XtraReports.UI.XRLabel Textbox14;
        private DevExpress.XtraReports.UI.XRLabel Textbox17;
        private DevExpress.XtraReports.UI.XRLabel Textbox18;
        private DevExpress.XtraReports.UI.XRLabel Textbox19;
        private DevExpress.XtraReports.UI.XRLabel Textbox20;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.XRRichText ExecutionTime;
        private DevExpress.XtraReports.UI.XRLabel Textbox5;
        private DevExpress.XtraReports.UI.XRLabel Textbox12;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningAccountNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingAccountNumber;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowNotes;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    }
}
