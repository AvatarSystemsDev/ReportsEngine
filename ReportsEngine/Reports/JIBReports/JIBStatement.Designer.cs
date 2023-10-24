namespace ReportsEngine.Reports.JIBReports
{
    partial class JIBStatement
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JIBStatement));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix12 = new DevExpress.XtraReports.UI.DetailBand();
            this.JIBStatementID_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Rectangle5 = new DevExpress.XtraReports.UI.XRPanel();
            this.OwnerNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox116 = new DevExpress.XtraReports.UI.XRLabel();
            this.OwnerName4 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox112 = new DevExpress.XtraReports.UI.XRLabel();
            this.OwnerName = new DevExpress.XtraReports.UI.XRLabel();
            this.OwnerName3 = new DevExpress.XtraReports.UI.XRLabel();
            this.OwnerName2 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngJIBPrintingProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdtePaymentDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrStatementMessage = new DevExpress.XtraReports.Parameters.Parameter();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.CompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox11 = new DevExpress.XtraReports.UI.XRRichText();
            this.CompanyName2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Details2_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.CurrentBalance = new DevExpress.XtraReports.UI.XRTableCell();
            this.The30DayBalance = new DevExpress.XtraReports.UI.XRTableCell();
            this.The60DayBalance = new DevExpress.XtraReports.UI.XRTableCell();
            this.The90DayBalance = new DevExpress.XtraReports.UI.XRTableCell();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngJIBProcessingPrint = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteBeginningDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteEndingDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrInvoiceNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningOwnerNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingOwnerNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.boolPrintRemit = new DevExpress.XtraReports.Parameters.Parameter();
            this.Tablix11_Details2_DetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.Tablix11_GroupHeaderBand = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Tablix11 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.JIBStatementID_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Textbox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details2_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSJIB_StatementHeader";
            queryParameter1.Name = "@plngJIBPrintingProcessTrackingID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngJIBPrintingProcessTrackingID", typeof(int));
            queryParameter2.Name = "@pstrBeginningOwnerNumber";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?pstrBeginningOwnerNumber", typeof(string));
            queryParameter3.Name = "@pstrEndingOwnerNumber";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?pstrEndingOwnerNumber", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3});
            storedProcQuery1.StoredProcName = "Report_JIBStatementHeader";
            storedProcQuery2.Name = "DSJIBProcessDatesLookup";
            queryParameter4.Name = "@plngCompanyID";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter5.Name = "@plngReportEnum";
            queryParameter5.Type = typeof(int);
            queryParameter5.ValueInfo = "4";
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter4,
            queryParameter5});
            storedProcQuery2.StoredProcName = "JIBReprint_GetProcessDates";
            storedProcQuery3.Name = "DSCompaniesLookup";
            queryParameter6.Name = "@plngCompanyID";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            storedProcQuery3.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter6});
            storedProcQuery3.StoredProcName = "Companies_ReportLookup";
            storedProcQuery4.Name = "DSOwnersLookup";
            queryParameter7.Name = "@plngCompanyID";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            storedProcQuery4.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter7});
            storedProcQuery4.StoredProcName = "Owners_ReportLookup";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3,
            storedProcQuery4});
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
            // Tablix12
            // 
            this.Tablix12.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.JIBStatementID_table});
            this.Tablix12.HeightF = 125.3534F;
            this.Tablix12.MultiColumn.ColumnSpacing = 50F;
            this.Tablix12.Name = "Tablix12";
            this.Tablix12.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("JIBStatementID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Tablix12.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand2});
            // 
            // JIBStatementID_table
            // 
            this.JIBStatementID_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.JIBStatementID_table.Name = "JIBStatementID_table";
            this.JIBStatementID_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.JIBStatementID_table.SizeF = new System.Drawing.SizeF(743.66F, 125.3534F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Rectangle5});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Weight = 1D;
            // 
            // Rectangle5
            // 
            this.Rectangle5.BorderColor = System.Drawing.Color.Black;
            this.Rectangle5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Rectangle5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Rectangle5.BorderWidth = 1F;
            this.Rectangle5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText3,
            this.xrRichText2,
            this.xrRichText1,
            this.OwnerNumber,
            this.Textbox116,
            this.OwnerName4,
            this.Textbox112,
            this.OwnerName,
            this.OwnerName3,
            this.OwnerName2});
            this.Rectangle5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Rectangle5.Name = "Rectangle5";
            this.Rectangle5.SizeF = new System.Drawing.SizeF(743.66F, 124.3117F);
            // 
            // OwnerNumber
            // 
            this.OwnerNumber.BorderColor = System.Drawing.Color.Black;
            this.OwnerNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.OwnerNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.OwnerNumber.BorderWidth = 1F;
            this.OwnerNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerNumber]")});
            this.OwnerNumber.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.OwnerNumber.KeepTogether = true;
            this.OwnerNumber.LocationFloat = new DevExpress.Utils.PointFloat(527.35F, 2.36F);
            this.OwnerNumber.Multiline = true;
            this.OwnerNumber.Name = "OwnerNumber";
            this.OwnerNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 0, 100F);
            this.OwnerNumber.SizeF = new System.Drawing.SizeF(154.96F, 20F);
            this.OwnerNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Textbox116
            // 
            this.Textbox116.BorderColor = System.Drawing.Color.Black;
            this.Textbox116.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox116.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox116.BorderWidth = 1F;
            this.Textbox116.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox116.KeepTogether = true;
            this.Textbox116.LocationFloat = new DevExpress.Utils.PointFloat(465.87F, 2.36F);
            this.Textbox116.Multiline = true;
            this.Textbox116.Name = "Textbox116";
            this.Textbox116.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.Textbox116.SizeF = new System.Drawing.SizeF(60.09F, 20F);
            this.Textbox116.Text = "Owner:";
            this.Textbox116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // OwnerName4
            // 
            this.OwnerName4.BorderColor = System.Drawing.Color.Black;
            this.OwnerName4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.OwnerName4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.OwnerName4.BorderWidth = 1F;
            this.OwnerName4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?boolPrintRemit = True, True, False)")});
            this.OwnerName4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.OwnerName4.KeepTogether = true;
            this.OwnerName4.LocationFloat = new DevExpress.Utils.PointFloat(525.96F, 26.53F);
            this.OwnerName4.Multiline = true;
            this.OwnerName4.Name = "OwnerName4";
            this.OwnerName4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 0, 100F);
            this.OwnerName4.SizeF = new System.Drawing.SizeF(205.93F, 20F);
            this.OwnerName4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // Textbox112
            // 
            this.Textbox112.BorderColor = System.Drawing.Color.Black;
            this.Textbox112.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox112.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox112.BorderWidth = 1F;
            this.Textbox112.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?boolPrintRemit = True, True, False)")});
            this.Textbox112.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox112.KeepTogether = true;
            this.Textbox112.LocationFloat = new DevExpress.Utils.PointFloat(463.1F, 26.53F);
            this.Textbox112.Multiline = true;
            this.Textbox112.Name = "Textbox112";
            this.Textbox112.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.Textbox112.SizeF = new System.Drawing.SizeF(60.09F, 20F);
            this.Textbox112.Text = "Remit To:";
            this.Textbox112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // OwnerName
            // 
            this.OwnerName.BorderColor = System.Drawing.Color.Black;
            this.OwnerName.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.OwnerName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.OwnerName.BorderWidth = 1F;
            this.OwnerName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerName]")});
            this.OwnerName.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.OwnerName.KeepTogether = true;
            this.OwnerName.LocationFloat = new DevExpress.Utils.PointFloat(16.79F, 47.92F);
            this.OwnerName.Multiline = true;
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 0, 100F);
            this.OwnerName.SizeF = new System.Drawing.SizeF(197.1F, 20F);
            this.OwnerName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // OwnerName3
            // 
            this.OwnerName3.BorderColor = System.Drawing.Color.Black;
            this.OwnerName3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.OwnerName3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.OwnerName3.BorderWidth = 1F;
            this.OwnerName3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PrimaryAddress]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?boolPrintRemit = True, True, False)")});
            this.OwnerName3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.OwnerName3.KeepTogether = true;
            this.OwnerName3.LocationFloat = new DevExpress.Utils.PointFloat(527.35F, 47.92F);
            this.OwnerName3.Multiline = true;
            this.OwnerName3.Name = "OwnerName3";
            this.OwnerName3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 0, 3, 100F);
            this.OwnerName3.SizeF = new System.Drawing.SizeF(205.93F, 25F);
            this.OwnerName3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // OwnerName2
            // 
            this.OwnerName2.BorderColor = System.Drawing.Color.Black;
            this.OwnerName2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.OwnerName2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.OwnerName2.BorderWidth = 1F;
            this.OwnerName2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerAddress]")});
            this.OwnerName2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.OwnerName2.KeepTogether = true;
            this.OwnerName2.LocationFloat = new DevExpress.Utils.PointFloat(16.79F, 72.08F);
            this.OwnerName2.Multiline = true;
            this.OwnerName2.Name = "OwnerName2";
            this.OwnerName2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 0, 3, 100F);
            this.OwnerName2.SizeF = new System.Drawing.SizeF(197.1F, 25F);
            this.OwnerName2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2});
            this.SubBand1.HeightF = 24.61065F;
            this.SubBand1.Name = "SubBand1";
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
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // plngJIBPrintingProcessTrackingID
            // 
            this.plngJIBPrintingProcessTrackingID.Description = "Processing Date";
            this.plngJIBPrintingProcessTrackingID.Name = "plngJIBPrintingProcessTrackingID";
            this.plngJIBPrintingProcessTrackingID.Type = typeof(int);
            this.plngJIBPrintingProcessTrackingID.ValueInfo = "0";
            dynamicListLookUpSettings1.DataMember = "DSJIBProcessDatesLookup";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "ProcessingDate";
            dynamicListLookUpSettings1.ValueMember = "ID";
            this.plngJIBPrintingProcessTrackingID.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // pdtePaymentDate
            // 
            this.pdtePaymentDate.Description = "Payment Date";
            this.pdtePaymentDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Today()")});
            this.pdtePaymentDate.Name = "pdtePaymentDate";
            this.pdtePaymentDate.Type = typeof(System.DateTime);
            this.pdtePaymentDate.ValueInfo = "2023-10-24";
            // 
            // pstrStatementMessage
            // 
            this.pstrStatementMessage.Description = "Statement Message";
            this.pstrStatementMessage.Name = "pstrStatementMessage";
            // 
            // SubBand2
            // 
            this.SubBand2.HeightF = 0F;
            this.SubBand2.Name = "SubBand2";
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.CompanyName,
            this.Textbox11,
            this.CompanyName2});
            this.pageHeaderBand1.HeightF = 130.21F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.BackColor = System.Drawing.Color.Transparent;
            this.xrPageInfo1.BorderColor = System.Drawing.Color.Transparent;
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(631.89F, 101.04F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(100.0001F, 25F);
            this.xrPageInfo1.StylePriority.UseBackColor = false;
            this.xrPageInfo1.StylePriority.UseBorderColor = false;
            this.xrPageInfo1.StylePriority.UsePadding = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrPageInfo1.TextFormatString = "Page {0} of {1}";
            // 
            // CompanyName
            // 
            this.CompanyName.BorderColor = System.Drawing.Color.Black;
            this.CompanyName.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CompanyName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CompanyName.BorderWidth = 1F;
            this.CompanyName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DSCompaniesLookup].[Description]")});
            this.CompanyName.Font = new DevExpress.Drawing.DXFont("Segoe UI", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CompanyName.KeepTogether = true;
            this.CompanyName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 20.83F);
            this.CompanyName.Multiline = true;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 3, 3, 3, 100F);
            this.CompanyName.SizeF = new System.Drawing.SizeF(395.01F, 25F);
            this.CompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox11
            // 
            this.Textbox11.BorderColor = System.Drawing.Color.Black;
            this.Textbox11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox11.BorderWidth = 1F;
            this.Textbox11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Rtf", "\'Operating Statement for \'+ FormatString(\'{0:MM/dd/yyyy}\',[ProcessingDate])")});
            this.Textbox11.KeepTogether = true;
            this.Textbox11.LocationFloat = new DevExpress.Utils.PointFloat(419.32F, 21.53F);
            this.Textbox11.Name = "Textbox11";
            this.Textbox11.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 3, 0, 0, 100F);
            this.Textbox11.SerializableRtfString = resources.GetString("Textbox11.SerializableRtfString");
            this.Textbox11.SizeF = new System.Drawing.SizeF(324.34F, 24.31F);
            // 
            // CompanyName2
            // 
            this.CompanyName2.BorderColor = System.Drawing.Color.Black;
            this.CompanyName2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CompanyName2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CompanyName2.BorderWidth = 1F;
            this.CompanyName2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PrimaryAddress]")});
            this.CompanyName2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CompanyName2.KeepTogether = true;
            this.CompanyName2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50F);
            this.CompanyName2.Multiline = true;
            this.CompanyName2.Name = "CompanyName2";
            this.CompanyName2.Padding = new DevExpress.XtraPrinting.PaddingInfo(7, 3, 0, 0, 100F);
            this.CompanyName2.SizeF = new System.Drawing.SizeF(395.01F, 63.89F);
            this.CompanyName2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(768.75F, 23.44F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox95,
            this.Textbox97,
            this.Textbox99,
            this.Textbox101,
            this.xrTableCell2,
            this.xrTableCell4});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // Textbox95
            // 
            this.Textbox95.BorderColor = System.Drawing.Color.Black;
            this.Textbox95.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox95.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox95.BorderWidth = 1.39F;
            this.Textbox95.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox95.KeepTogether = true;
            this.Textbox95.Name = "Textbox95";
            this.Textbox95.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox95.StylePriority.UseFont = false;
            this.Textbox95.Text = "0 – 30 Days";
            this.Textbox95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox95.Weight = 6399.75D;
            // 
            // Textbox97
            // 
            this.Textbox97.BorderColor = System.Drawing.Color.Black;
            this.Textbox97.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox97.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox97.BorderWidth = 1.39F;
            this.Textbox97.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox97.KeepTogether = true;
            this.Textbox97.Name = "Textbox97";
            this.Textbox97.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox97.StylePriority.UseFont = false;
            this.Textbox97.Text = "30-60 Days";
            this.Textbox97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox97.Weight = 6399.75D;
            // 
            // Textbox99
            // 
            this.Textbox99.BorderColor = System.Drawing.Color.Black;
            this.Textbox99.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox99.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox99.BorderWidth = 1.39F;
            this.Textbox99.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox99.KeepTogether = true;
            this.Textbox99.Name = "Textbox99";
            this.Textbox99.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox99.StylePriority.UseFont = false;
            this.Textbox99.Text = "60-90 Days";
            this.Textbox99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox99.Weight = 6399.75D;
            // 
            // Textbox101
            // 
            this.Textbox101.BorderColor = System.Drawing.Color.Black;
            this.Textbox101.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox101.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox101.BorderWidth = 1.39F;
            this.Textbox101.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox101.KeepTogether = true;
            this.Textbox101.Name = "Textbox101";
            this.Textbox101.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox101.StylePriority.UseFont = false;
            this.Textbox101.Text = "90-120 Days";
            this.Textbox101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox101.Weight = 6399.75D;
            // 
            // Details2_table
            // 
            this.Details2_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Details2_table.Name = "Details2_table";
            this.Details2_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.Details2_table.SizeF = new System.Drawing.SizeF(768.75F, 23.44F);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.CurrentBalance,
            this.The30DayBalance,
            this.The60DayBalance,
            this.The90DayBalance,
            this.xrTableCell3,
            this.xrTableCell5});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // CurrentBalance
            // 
            this.CurrentBalance.BorderColor = System.Drawing.Color.Black;
            this.CurrentBalance.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CurrentBalance.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.CurrentBalance.BorderWidth = 1.39F;
            this.CurrentBalance.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CurrentBalance]")});
            this.CurrentBalance.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.CurrentBalance.KeepTogether = true;
            this.CurrentBalance.Name = "CurrentBalance";
            this.CurrentBalance.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CurrentBalance.StylePriority.UseFont = false;
            this.CurrentBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.CurrentBalance.TextFormatString = "{0:n2}";
            this.CurrentBalance.Weight = 6399.75D;
            // 
            // The30DayBalance
            // 
            this.The30DayBalance.BorderColor = System.Drawing.Color.Black;
            this.The30DayBalance.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.The30DayBalance.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.The30DayBalance.BorderWidth = 1.39F;
            this.The30DayBalance.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[The30DayBalance]")});
            this.The30DayBalance.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.The30DayBalance.KeepTogether = true;
            this.The30DayBalance.Name = "The30DayBalance";
            this.The30DayBalance.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.The30DayBalance.StylePriority.UseFont = false;
            this.The30DayBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.The30DayBalance.TextFormatString = "{0:n2}";
            this.The30DayBalance.Weight = 6399.75D;
            // 
            // The60DayBalance
            // 
            this.The60DayBalance.BorderColor = System.Drawing.Color.Black;
            this.The60DayBalance.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.The60DayBalance.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.The60DayBalance.BorderWidth = 1.39F;
            this.The60DayBalance.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[The60DayBalance]")});
            this.The60DayBalance.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.The60DayBalance.KeepTogether = true;
            this.The60DayBalance.Name = "The60DayBalance";
            this.The60DayBalance.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.The60DayBalance.StylePriority.UseFont = false;
            this.The60DayBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.The60DayBalance.TextFormatString = "{0:n2}";
            this.The60DayBalance.Weight = 6399.75D;
            // 
            // The90DayBalance
            // 
            this.The90DayBalance.BorderColor = System.Drawing.Color.Black;
            this.The90DayBalance.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.The90DayBalance.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.The90DayBalance.BorderWidth = 1.39F;
            this.The90DayBalance.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[The90DayBalance]")});
            this.The90DayBalance.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.The90DayBalance.KeepTogether = true;
            this.The90DayBalance.Name = "The90DayBalance";
            this.The90DayBalance.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.The90DayBalance.StylePriority.UseFont = false;
            this.The90DayBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.The90DayBalance.TextFormatString = "{0:n2}";
            this.The90DayBalance.Weight = 6399.75D;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            dynamicListLookUpSettings2.DataMember = "DSCompaniesLookup";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "Description";
            dynamicListLookUpSettings2.ValueMember = "ID";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings2;
            this.plngCompanyID.Visible = false;
            // 
            // plngJIBProcessingPrint
            // 
            this.plngJIBProcessingPrint.Description = "plngJIBProcessingPrint";
            this.plngJIBProcessingPrint.Name = "plngJIBProcessingPrint";
            this.plngJIBProcessingPrint.Type = typeof(int);
            this.plngJIBProcessingPrint.ValueInfo = "0";
            this.plngJIBProcessingPrint.Visible = false;
            // 
            // pdteBeginningDate
            // 
            this.pdteBeginningDate.Description = "Beginning Date";
            this.pdteBeginningDate.Name = "pdteBeginningDate";
            this.pdteBeginningDate.Type = typeof(System.DateTime);
            this.pdteBeginningDate.ValueInfo = "1900-01-01";
            // 
            // pdteEndingDate
            // 
            this.pdteEndingDate.Description = "Ending Date";
            this.pdteEndingDate.Name = "pdteEndingDate";
            this.pdteEndingDate.Type = typeof(System.DateTime);
            this.pdteEndingDate.ValueInfo = "9999-12-31";
            // 
            // pstrInvoiceNumber
            // 
            this.pstrInvoiceNumber.Description = "Invoice Number";
            this.pstrInvoiceNumber.Name = "pstrInvoiceNumber";
            this.pstrInvoiceNumber.ValueInfo = " ";
            this.pstrInvoiceNumber.Visible = false;
            // 
            // pstrBeginningOwnerNumber
            // 
            this.pstrBeginningOwnerNumber.Description = "Beginning Owner";
            this.pstrBeginningOwnerNumber.Name = "pstrBeginningOwnerNumber";
            this.pstrBeginningOwnerNumber.ValueInfo = "!";
            dynamicListLookUpSettings3.DataMember = "DSOwnersLookup";
            dynamicListLookUpSettings3.DataSource = this.Dynamic;
            dynamicListLookUpSettings3.DisplayMember = "Description";
            dynamicListLookUpSettings3.ValueMember = "Number";
            this.pstrBeginningOwnerNumber.ValueSourceSettings = dynamicListLookUpSettings3;
            // 
            // pstrEndingOwnerNumber
            // 
            this.pstrEndingOwnerNumber.Description = "Ending Owner";
            this.pstrEndingOwnerNumber.Name = "pstrEndingOwnerNumber";
            this.pstrEndingOwnerNumber.ValueInfo = "ZZZZZZZZZZ";
            dynamicListLookUpSettings4.DataMember = "DSOwnersLookup";
            dynamicListLookUpSettings4.DataSource = this.Dynamic;
            dynamicListLookUpSettings4.DisplayMember = "Description";
            dynamicListLookUpSettings4.ValueMember = "Number";
            this.pstrEndingOwnerNumber.ValueSourceSettings = dynamicListLookUpSettings4;
            // 
            // boolPrintRemit
            // 
            this.boolPrintRemit.Description = "Print Remit";
            this.boolPrintRemit.Name = "boolPrintRemit";
            this.boolPrintRemit.Type = typeof(bool);
            this.boolPrintRemit.ValueInfo = "True";
            // 
            // Tablix11_Details2_DetailBand
            // 
            this.Tablix11_Details2_DetailBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details2_table});
            this.Tablix11_Details2_DetailBand.HeightF = 23.44F;
            this.Tablix11_Details2_DetailBand.MultiColumn.ColumnSpacing = 50F;
            this.Tablix11_Details2_DetailBand.Name = "Tablix11_Details2_DetailBand";
            // 
            // Tablix11_GroupHeaderBand
            // 
            this.Tablix11_GroupHeaderBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Tablix11_GroupHeaderBand.HeightF = 23.44F;
            this.Tablix11_GroupHeaderBand.Name = "Tablix11_GroupHeaderBand";
            this.Tablix11_GroupHeaderBand.Visible = false;
            // 
            // Tablix11
            // 
            this.Tablix11.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Tablix11_GroupHeaderBand,
            this.Tablix11_Details2_DetailBand});
            this.Tablix11.DataMember = "DSJIB_StatementHeader";
            this.Tablix11.DataSource = this.Dynamic;
            this.Tablix11.FilterString = "[JIBStatementID] = [JIBStatementID]";
            this.Tablix11.Level = 0;
            this.Tablix11.Name = "Tablix11";
            this.Tablix11.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.BorderWidth = 1.39F;
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = "120 Days and Over";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell2.Weight = 6399.75D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.BorderWidth = 1.39F;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[The120DayBalance]")});
            this.xrTableCell3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell3.Weight = 6399.75D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.BorderWidth = 1.39F;
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.Text = "Total Balance";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell4.Weight = 6399.75D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.BorderWidth = 1.39F;
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BalanceDue]")});
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell5.Weight = 6399.75D;
            // 
            // xrRichText3
            // 
            this.xrRichText3.BorderColor = System.Drawing.Color.Black;
            this.xrRichText3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText3.BorderWidth = 1F;
            this.xrRichText3.CanGrow = false;
            this.xrRichText3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 8pt; color: black;\"><b>Fax: <" +
                    "/b>\' + [RemitToFax] + \'</span>\'")});
            this.xrRichText3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrRichText3.KeepTogether = true;
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(599.9099F, 97.92001F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(143.75F, 24.99997F);
            this.xrRichText3.StylePriority.UseFont = false;
            this.xrRichText3.StylePriority.UsePadding = false;
            // 
            // xrRichText2
            // 
            this.xrRichText2.BorderColor = System.Drawing.Color.Black;
            this.xrRichText2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText2.BorderWidth = 1F;
            this.xrRichText2.CanGrow = false;
            this.xrRichText2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 8pt; color: black;\"><b>Phone:" +
                    " </b>\' + [RemitToPhone] + \'</span>\'")});
            this.xrRichText2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrRichText2.KeepTogether = true;
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(432.9499F, 97.92001F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(154.3333F, 24.99997F);
            this.xrRichText2.StylePriority.UseFont = false;
            this.xrRichText2.StylePriority.UsePadding = false;
            // 
            // xrRichText1
            // 
            this.xrRichText1.BorderColor = System.Drawing.Color.Black;
            this.xrRichText1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText1.BorderWidth = 1F;
            this.xrRichText1.CanGrow = false;
            this.xrRichText1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 8pt; color: black;\"><b>Email:" +
                    " </b>\' + [RemitToEmail] + \'</span>\'")});
            this.xrRichText1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrRichText1.KeepTogether = true;
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(432.9499F, 72.92001F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(310.7101F, 25F);
            this.xrRichText1.StylePriority.UseFont = false;
            this.xrRichText1.StylePriority.UsePadding = false;
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Subtitle", this.Subtitle));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngJIBProcessTrackingID", this.plngJIBPrintingProcessTrackingID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngJIBStatementID", null, "DSJIB_StatementHeader.JIBStatementID"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngOwnerID", null, "DSJIB_StatementHeader.OwnerID"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdtePaymentDate", this.pdtePaymentDate));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrStatementMessage", this.pstrStatementMessage));
            this.xrSubreport2.ReportSource = new ReportsEngine.Reports.JIBReports.JIBStatementDetail();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(809.9999F, 24.61065F);
            // 
            // JIBStatement
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix12,
            this.Tablix11,
            this.pageHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "DSJIB_StatementHeader";
            this.DataSource = this.Dynamic;
            this.DisplayName = "JIBStatement";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 20F, 20F, 20F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngJIBProcessingPrint, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngJIBPrintingProcessTrackingID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteBeginningDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteEndingDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrInvoiceNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningOwnerNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingOwnerNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdtePaymentDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrStatementMessage, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.boolPrintRemit, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.Subtitle,
            this.plngCompanyID,
            this.plngJIBProcessingPrint,
            this.plngJIBPrintingProcessTrackingID,
            this.pdteBeginningDate,
            this.pdteEndingDate,
            this.pstrInvoiceNumber,
            this.pstrBeginningOwnerNumber,
            this.pstrEndingOwnerNumber,
            this.pdtePaymentDate,
            this.pstrStatementMessage,
            this.boolPrintRemit});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.JIBStatementID_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Textbox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details2_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix12;
        private DevExpress.XtraReports.UI.XRTable JIBStatementID_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRPanel Rectangle5;
        private DevExpress.XtraReports.UI.XRLabel OwnerNumber;
        private DevExpress.XtraReports.UI.XRLabel Textbox116;
        private DevExpress.XtraReports.UI.XRLabel OwnerName4;
        private DevExpress.XtraReports.UI.XRLabel Textbox112;
        private DevExpress.XtraReports.UI.XRLabel OwnerName;
        private DevExpress.XtraReports.UI.XRLabel OwnerName3;
        private DevExpress.XtraReports.UI.XRLabel OwnerName2;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell Textbox95;
        private DevExpress.XtraReports.UI.XRTableCell Textbox97;
        private DevExpress.XtraReports.UI.XRTableCell Textbox99;
        private DevExpress.XtraReports.UI.XRTableCell Textbox101;
        private DevExpress.XtraReports.UI.XRTable Details2_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell CurrentBalance;
        private DevExpress.XtraReports.UI.XRTableCell The30DayBalance;
        private DevExpress.XtraReports.UI.XRTableCell The60DayBalance;
        private DevExpress.XtraReports.UI.XRTableCell The90DayBalance;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel CompanyName;
        private DevExpress.XtraReports.UI.XRRichText Textbox11;
        private DevExpress.XtraReports.UI.XRLabel CompanyName2;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter plngJIBProcessingPrint;
        private DevExpress.XtraReports.Parameters.Parameter plngJIBPrintingProcessTrackingID;
        private DevExpress.XtraReports.Parameters.Parameter pdteBeginningDate;
        private DevExpress.XtraReports.Parameters.Parameter pdteEndingDate;
        private DevExpress.XtraReports.Parameters.Parameter pstrInvoiceNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningOwnerNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingOwnerNumber;
        private DevExpress.XtraReports.Parameters.Parameter pdtePaymentDate;
        private DevExpress.XtraReports.Parameters.Parameter pstrStatementMessage;
        private DevExpress.XtraReports.Parameters.Parameter boolPrintRemit;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.DetailBand Tablix11_Details2_DetailBand;
        private DevExpress.XtraReports.UI.GroupHeaderBand Tablix11_GroupHeaderBand;
        private DevExpress.XtraReports.UI.DetailReportBand Tablix11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRRichText xrRichText3;
        private DevExpress.XtraReports.UI.XRRichText xrRichText2;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
    }
}
