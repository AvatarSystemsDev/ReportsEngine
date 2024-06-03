namespace ReportsEngine.Reports.PRReports
{
    partial class ExcelPR_PreliminaryPaymentTimeRecordRecap
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelPR_PreliminaryPaymentTimeRecordRecap));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Number = new DevExpress.XtraReports.UI.XRTableCell();
            this.Name_1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PayFrequencyCode = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.XPAYDATE = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "dsLookupCompany";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "0";
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "Companies_ReportLookup";
            storedProcQuery2.Name = "dsUnpaidTime";
            queryParameter2.Name = "@plngCompanyID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter2});
            storedProcQuery2.StoredProcName = "PR_Processing_Report_PreliminaryPaymentTimeRecordRecap";
            customSqlQuery1.Name = "dsPaymentProcessTracking";
            queryParameter3.Name = "plngCompanyID";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            customSqlQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter3});
            customSqlQuery1.Sql = "SELECT\n  PRPaymentProcessTracking.PeriodEndingDate\nFROM\n  PRPaymentProcessTrackin" +
    "g\nWHERE CompanyID = @plngCompanyID AND IsPosted = 0\nand TransactionSourceCodeID=" +
    "65";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            customSqlQuery1});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 0F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 33.33333F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // Tablix1
            // 
            this.Tablix1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details_table});
            this.Tablix1.HeightF = 31.24339F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 5.41172F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.Details_table.SizeF = new System.Drawing.SizeF(1039.651F, 20F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Number,
            this.Name_1,
            this.xrTableCell1,
            this.PayFrequencyCode,
            this.Textbox2,
            this.Textbox4,
            this.Textbox35,
            this.Textbox40,
            this.Textbox45,
            this.Textbox50,
            this.Textbox55});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.5D;
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.Color.White;
            this.Number.BorderColor = System.Drawing.Color.Black;
            this.Number.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Number.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Number.BorderWidth = 1F;
            this.Number.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Number]")});
            this.Number.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Number.KeepTogether = true;
            this.Number.Name = "Number";
            this.Number.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Number.StylePriority.UseFont = false;
            this.Number.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Number.Weight = 0.11539143935596563D;
            // 
            // Name_1
            // 
            this.Name_1.BackColor = System.Drawing.Color.White;
            this.Name_1.BorderColor = System.Drawing.Color.Black;
            this.Name_1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Name_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Name_1.BorderWidth = 1F;
            this.Name_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")});
            this.Name_1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Name_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Name_1.KeepTogether = true;
            this.Name_1.Name = "Name_1";
            this.Name_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Name_1.StylePriority.UseFont = false;
            this.Name_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Name_1.Weight = 0.28301067315456091D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.White;
            this.xrTableCell1.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell1.BorderWidth = 1F;
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PropertyAndWellNumber] + \'    \' + [PropertyDescription]\n")});
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrTableCell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell1.Weight = 0.33809340309094454D;
            // 
            // PayFrequencyCode
            // 
            this.PayFrequencyCode.BackColor = System.Drawing.Color.White;
            this.PayFrequencyCode.BorderColor = System.Drawing.Color.Black;
            this.PayFrequencyCode.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PayFrequencyCode.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PayFrequencyCode.BorderWidth = 1F;
            this.PayFrequencyCode.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PayFrequencyCode] + \'  \' + Iif([PayFrequency_SYEnumID] = 907, Iif([TransactionDa" +
                    "te] <= ?XPAYDATE, \'W1\', \'W2\'), \'\')")});
            this.PayFrequencyCode.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.PayFrequencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PayFrequencyCode.KeepTogether = true;
            this.PayFrequencyCode.Name = "PayFrequencyCode";
            this.PayFrequencyCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.PayFrequencyCode.StylePriority.UseFont = false;
            this.PayFrequencyCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.PayFrequencyCode.Weight = 0.081161192978704721D;
            // 
            // Textbox2
            // 
            this.Textbox2.BackColor = System.Drawing.Color.White;
            this.Textbox2.BorderColor = System.Drawing.Color.Black;
            this.Textbox2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox2.BorderWidth = 1F;
            this.Textbox2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0:d}\', [TransactionDate])\n")});
            this.Textbox2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Textbox2.KeepTogether = true;
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox2.StylePriority.UseFont = false;
            this.Textbox2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox2.Weight = 0.10421553858882227D;
            // 
            // Textbox4
            // 
            this.Textbox4.BackColor = System.Drawing.Color.White;
            this.Textbox4.BorderColor = System.Drawing.Color.Black;
            this.Textbox4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox4.BorderWidth = 1F;
            this.Textbox4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("Textbox4.ExpressionBindings"))});
            this.Textbox4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Textbox4.KeepTogether = true;
            this.Textbox4.Name = "Textbox4";
            this.Textbox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox4.StylePriority.UseFont = false;
            this.Textbox4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox4.Weight = 0.078080078256799079D;
            // 
            // Textbox35
            // 
            this.Textbox35.BackColor = System.Drawing.Color.White;
            this.Textbox35.BorderColor = System.Drawing.Color.Black;
            this.Textbox35.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox35.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox35.BorderWidth = 1F;
            this.Textbox35.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PayRateCode]\n")});
            this.Textbox35.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Textbox35.KeepTogether = true;
            this.Textbox35.Name = "Textbox35";
            this.Textbox35.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox35.StylePriority.UseFont = false;
            this.Textbox35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox35.Weight = 0.078080198739862161D;
            // 
            // Textbox40
            // 
            this.Textbox40.BackColor = System.Drawing.Color.White;
            this.Textbox40.BorderColor = System.Drawing.Color.Black;
            this.Textbox40.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox40.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox40.BorderWidth = 1F;
            this.Textbox40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShortDescription]\n")});
            this.Textbox40.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Textbox40.KeepTogether = true;
            this.Textbox40.Name = "Textbox40";
            this.Textbox40.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox40.StylePriority.UseFont = false;
            this.Textbox40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox40.Weight = 0.16937244204200136D;
            // 
            // Textbox45
            // 
            this.Textbox45.BackColor = System.Drawing.Color.White;
            this.Textbox45.BorderColor = System.Drawing.Color.Black;
            this.Textbox45.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox45.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox45.BorderWidth = 1F;
            this.Textbox45.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HoursWorkedOrUnits]\n")});
            this.Textbox45.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Textbox45.KeepTogether = true;
            this.Textbox45.Name = "Textbox45";
            this.Textbox45.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox45.StylePriority.UseFont = false;
            this.Textbox45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox45.Weight = 0.10638440547214685D;
            // 
            // Textbox50
            // 
            this.Textbox50.BackColor = System.Drawing.Color.White;
            this.Textbox50.BorderColor = System.Drawing.Color.Black;
            this.Textbox50.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox50.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox50.BorderWidth = 1F;
            this.Textbox50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Rate]\n")});
            this.Textbox50.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Textbox50.KeepTogether = true;
            this.Textbox50.Name = "Textbox50";
            this.Textbox50.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox50.StylePriority.UseFont = false;
            this.Textbox50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox50.Weight = 0.12590358021594794D;
            // 
            // Textbox55
            // 
            this.Textbox55.BackColor = System.Drawing.Color.White;
            this.Textbox55.BorderColor = System.Drawing.Color.Black;
            this.Textbox55.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox55.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox55.BorderWidth = 1F;
            this.Textbox55.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Amount]\n")});
            this.Textbox55.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Textbox55.KeepTogether = true;
            this.Textbox55.Name = "Textbox55";
            this.Textbox55.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox55.StylePriority.UseFont = false;
            this.Textbox55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox55.Weight = 0.14382104544759344D;
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel11,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel2});
            this.pageHeaderBand1.HeightF = 40.62667F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.White;
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(73.89336F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(181.2316F, 36.46F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "EMPLOYEE NAME";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.White;
            this.xrLabel11.BorderColor = System.Drawing.Color.Black;
            this.xrLabel11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.BorderWidth = 1F;
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel11.KeepTogether = true;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(947.5518F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(92.09875F, 36.46F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorderDashStyle = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseBorderWidth = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UsePadding = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "AMOUNT";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.White;
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(255.1249F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(216.5051F, 36.46F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = " PROPERTY";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.White;
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel4.KeepTogether = true;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(471.63F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(51.00009F, 36.46F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "PAY\r\nFREQ";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.White;
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel5.KeepTogether = true;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(522.6299F, 0F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(67.71F, 36.46F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorderDashStyle = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "DATE\r\nWORKED";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.White;
            this.xrLabel6.BorderColor = System.Drawing.Color.Black;
            this.xrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.BorderWidth = 1F;
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel6.KeepTogether = true;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(590.3401F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(50F, 36.46F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorderDashStyle = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "EARN\r\nCODE";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.White;
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.BorderWidth = 1F;
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel7.KeepTogether = true;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(640.3401F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(50F, 36.46F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorderDashStyle = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseBorderWidth = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "PAY\r\nCODE";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.White;
            this.xrLabel8.BorderColor = System.Drawing.Color.Black;
            this.xrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.BorderWidth = 1F;
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel8.KeepTogether = true;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(690.6732F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(108.1282F, 36.46F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorderDashStyle = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseBorderWidth = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "DESCRIPTION";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.White;
            this.xrLabel9.BorderColor = System.Drawing.Color.Black;
            this.xrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.BorderWidth = 1F;
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel9.KeepTogether = true;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(798.8014F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(68.12567F, 36.46F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorderDashStyle = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseBorderWidth = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "HOURS";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.White;
            this.xrLabel10.BorderColor = System.Drawing.Color.Black;
            this.xrLabel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.BorderWidth = 1F;
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel10.KeepTogether = true;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(866.9268F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(80.62494F, 36.46F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorderDashStyle = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseBorderWidth = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "RATE";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.White;
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(73.89334F, 36.46F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorderDashStyle = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "EMPLOYEE";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
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
            this.plngCompanyID.ValueInfo = "0";
            dynamicListLookUpSettings1.DataMember = "dsLookupCompany";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.ValueMember = "ID";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings1;
            this.plngCompanyID.Visible = false;
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Description = "Show Criteria";
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "True";
            // 
            // XPAYDATE
            // 
            this.XPAYDATE.Description = "XPAYDATE";
            this.XPAYDATE.Name = "XPAYDATE";
            this.XPAYDATE.Type = typeof(System.DateTime);
            dynamicListLookUpSettings2.DataMember = "dsPaymentProcessTracking";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "PeriodEndingDate";
            dynamicListLookUpSettings2.ValueMember = "PeriodEndingDate";
            this.XPAYDATE.ValueSourceSettings = dynamicListLookUpSettings2;
            this.XPAYDATE.Visible = false;
            // 
            // ExcelPR_PreliminaryPaymentTimeRecordRecap
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1,
            this.pageHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "dsUnpaidTime";
            this.DataSource = this.Dynamic;
            this.DisplayName = "PR_PreliminaryPaymentTimeRecordRecap";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(25F, 0F, 0F, 33.33333F);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.Subtitle,
            this.plngCompanyID,
            this.pbooShowCriteria,
            this.XPAYDATE});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1;
        private DevExpress.XtraReports.UI.XRTable Details_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell Number;
        private DevExpress.XtraReports.UI.XRTableCell Name_1;
        private DevExpress.XtraReports.UI.XRTableCell PayFrequencyCode;
        private DevExpress.XtraReports.UI.XRTableCell Textbox2;
        private DevExpress.XtraReports.UI.XRTableCell Textbox4;
        private DevExpress.XtraReports.UI.XRTableCell Textbox35;
        private DevExpress.XtraReports.UI.XRTableCell Textbox40;
        private DevExpress.XtraReports.UI.XRTableCell Textbox45;
        private DevExpress.XtraReports.UI.XRTableCell Textbox50;
        private DevExpress.XtraReports.UI.XRTableCell Textbox55;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.Parameters.Parameter XPAYDATE;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
