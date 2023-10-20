﻿namespace ReportsEngine.Reports.APReports
{
    partial class ExcelAPPaymentsHistoryRecap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelAPPaymentsHistoryRecap));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.APPaymentHistoryDataSource = new DevExpress.XtraReports.UI.DetailBand();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.Textbox37 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox41 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox50 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox47 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox45 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox38 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox31 = new DevExpress.XtraReports.UI.XRLabel();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteBeginningDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteEndingDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningVendorNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingVendorNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooInclude1099Exempt = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.pstrSelectVendor = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "APPaymentHistoryDatasource";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter2.Name = "@pdteBeginningDate";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?pdteBeginningDate", typeof(System.DateTime));
            queryParameter3.Name = "@pdteEndingDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?pdteEndingDate", typeof(System.DateTime));
            queryParameter4.Name = "@pstrBeginningVendorNumber";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?pstrBeginningVendorNumber", typeof(string));
            queryParameter5.Name = "@pstrEndingVendorNumber";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?pstrEndingVendorNumber", typeof(string));
            queryParameter6.Name = "@pbooInclude1099Exempt";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?pbooInclude1099Exempt", typeof(bool));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5,
            queryParameter6});
            storedProcQuery1.StoredProcName = "Report_APPaymentHistoryRecap";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 0F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 20F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // APPaymentHistoryDataSource
            // 
            this.APPaymentHistoryDataSource.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11});
            this.APPaymentHistoryDataSource.HeightF = 16F;
            this.APPaymentHistoryDataSource.MultiColumn.ColumnSpacing = 50F;
            this.APPaymentHistoryDataSource.Name = "APPaymentHistoryDataSource";
            this.APPaymentHistoryDataSource.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("VoucherNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel1,
            this.Textbox37,
            this.Textbox41,
            this.Textbox50,
            this.Textbox47,
            this.Textbox45,
            this.Textbox38,
            this.Textbox31});
            this.pageHeaderBand1.HeightF = 35.00004F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox37
            // 
            this.Textbox37.BorderColor = System.Drawing.Color.Black;
            this.Textbox37.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox37.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox37.BorderWidth = 1F;
            this.Textbox37.CanGrow = false;
            this.Textbox37.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox37.KeepTogether = true;
            this.Textbox37.LocationFloat = new DevExpress.Utils.PointFloat(434.3951F, 0F);
            this.Textbox37.Multiline = true;
            this.Textbox37.Name = "Textbox37";
            this.Textbox37.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox37.SizeF = new System.Drawing.SizeF(140.8923F, 35.00004F);
            this.Textbox37.StylePriority.UseFont = false;
            this.Textbox37.StylePriority.UsePadding = false;
            this.Textbox37.Text = "Invoice";
            this.Textbox37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox41
            // 
            this.Textbox41.BorderColor = System.Drawing.Color.Black;
            this.Textbox41.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox41.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox41.BorderWidth = 1F;
            this.Textbox41.CanGrow = false;
            this.Textbox41.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox41.KeepTogether = true;
            this.Textbox41.LocationFloat = new DevExpress.Utils.PointFloat(664.0187F, 0F);
            this.Textbox41.Multiline = true;
            this.Textbox41.Name = "Textbox41";
            this.Textbox41.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox41.SizeF = new System.Drawing.SizeF(69.98093F, 35.00004F);
            this.Textbox41.StylePriority.UseFont = false;
            this.Textbox41.StylePriority.UsePadding = false;
            this.Textbox41.Text = "1099 Type";
            this.Textbox41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox50
            // 
            this.Textbox50.BorderColor = System.Drawing.Color.Black;
            this.Textbox50.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox50.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox50.BorderWidth = 1F;
            this.Textbox50.CanGrow = false;
            this.Textbox50.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox50.KeepTogether = true;
            this.Textbox50.LocationFloat = new DevExpress.Utils.PointFloat(961.0352F, 0F);
            this.Textbox50.Multiline = true;
            this.Textbox50.Name = "Textbox50";
            this.Textbox50.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox50.SizeF = new System.Drawing.SizeF(69.52002F, 35.00004F);
            this.Textbox50.StylePriority.UseFont = false;
            this.Textbox50.StylePriority.UsePadding = false;
            this.Textbox50.Text = "1099 Req";
            this.Textbox50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox47
            // 
            this.Textbox47.BorderColor = System.Drawing.Color.Black;
            this.Textbox47.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox47.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox47.BorderWidth = 1F;
            this.Textbox47.CanGrow = false;
            this.Textbox47.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox47.KeepTogether = true;
            this.Textbox47.LocationFloat = new DevExpress.Utils.PointFloat(847.5151F, 0F);
            this.Textbox47.Multiline = true;
            this.Textbox47.Name = "Textbox47";
            this.Textbox47.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox47.SizeF = new System.Drawing.SizeF(113.52F, 35.00004F);
            this.Textbox47.StylePriority.UseFont = false;
            this.Textbox47.StylePriority.UsePadding = false;
            this.Textbox47.StylePriority.UseTextAlignment = false;
            this.Textbox47.Text = "Discount Amount";
            this.Textbox47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Textbox45
            // 
            this.Textbox45.BorderColor = System.Drawing.Color.Black;
            this.Textbox45.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox45.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox45.BorderWidth = 1F;
            this.Textbox45.CanGrow = false;
            this.Textbox45.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox45.KeepTogether = true;
            this.Textbox45.LocationFloat = new DevExpress.Utils.PointFloat(733.9996F, 0F);
            this.Textbox45.Multiline = true;
            this.Textbox45.Name = "Textbox45";
            this.Textbox45.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox45.SizeF = new System.Drawing.SizeF(113.5155F, 35.00004F);
            this.Textbox45.StylePriority.UseFont = false;
            this.Textbox45.StylePriority.UsePadding = false;
            this.Textbox45.StylePriority.UseTextAlignment = false;
            this.Textbox45.Text = "Payment Amount";
            this.Textbox45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Textbox38
            // 
            this.Textbox38.BorderColor = System.Drawing.Color.Black;
            this.Textbox38.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox38.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox38.BorderWidth = 1F;
            this.Textbox38.CanGrow = false;
            this.Textbox38.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox38.KeepTogether = true;
            this.Textbox38.LocationFloat = new DevExpress.Utils.PointFloat(575.2876F, 0F);
            this.Textbox38.Multiline = true;
            this.Textbox38.Name = "Textbox38";
            this.Textbox38.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox38.SizeF = new System.Drawing.SizeF(88.73114F, 35.00004F);
            this.Textbox38.StylePriority.UseFont = false;
            this.Textbox38.StylePriority.UsePadding = false;
            this.Textbox38.Text = "Check Number";
            this.Textbox38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox31
            // 
            this.Textbox31.BorderColor = System.Drawing.Color.Black;
            this.Textbox31.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox31.BorderWidth = 1F;
            this.Textbox31.CanGrow = false;
            this.Textbox31.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox31.KeepTogether = true;
            this.Textbox31.LocationFloat = new DevExpress.Utils.PointFloat(370.0385F, 0F);
            this.Textbox31.Multiline = true;
            this.Textbox31.Name = "Textbox31";
            this.Textbox31.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox31.SizeF = new System.Drawing.SizeF(64.35666F, 35.00001F);
            this.Textbox31.StylePriority.UseFont = false;
            this.Textbox31.StylePriority.UsePadding = false;
            this.Textbox31.Text = "Check Date";
            this.Textbox31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            dynamicListLookUpSettings1.DataMember = "DSCompaniesLookup";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.ValueMember = "ID";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings1;
            this.plngCompanyID.Visible = false;
            // 
            // pdteBeginningDate
            // 
            this.pdteBeginningDate.Description = "From Check Date";
            this.pdteBeginningDate.Name = "pdteBeginningDate";
            this.pdteBeginningDate.Type = typeof(System.DateTime);
            this.pdteBeginningDate.ValueInfo = "2023-09-22";
            // 
            // pdteEndingDate
            // 
            this.pdteEndingDate.Description = "To Check Date";
            this.pdteEndingDate.Name = "pdteEndingDate";
            this.pdteEndingDate.Type = typeof(System.DateTime);
            this.pdteEndingDate.ValueInfo = "2023-09-22";
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Description = "Show Criteria";
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "True";
            // 
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // pstrBeginningVendorNumber
            // 
            this.pstrBeginningVendorNumber.Description = "From Vendor";
            this.pstrBeginningVendorNumber.Name = "pstrBeginningVendorNumber";
            this.pstrBeginningVendorNumber.ValueInfo = "!";
            dynamicListLookUpSettings2.DataMember = "VendorLookup";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "Description";
            dynamicListLookUpSettings2.ValueMember = "Number";
            this.pstrBeginningVendorNumber.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // pstrEndingVendorNumber
            // 
            this.pstrEndingVendorNumber.Description = "To Vendor";
            this.pstrEndingVendorNumber.Name = "pstrEndingVendorNumber";
            this.pstrEndingVendorNumber.ValueInfo = "ZZZZZZZZZZ";
            dynamicListLookUpSettings3.DataMember = "VendorLookup";
            dynamicListLookUpSettings3.DataSource = this.Dynamic;
            dynamicListLookUpSettings3.DisplayMember = "Description";
            dynamicListLookUpSettings3.ValueMember = "Number";
            this.pstrEndingVendorNumber.ValueSourceSettings = dynamicListLookUpSettings3;
            // 
            // pbooInclude1099Exempt
            // 
            this.pbooInclude1099Exempt.Description = "Include 1099 Exempt";
            this.pbooInclude1099Exempt.Name = "pbooInclude1099Exempt";
            this.pbooInclude1099Exempt.Type = typeof(bool);
            this.pbooInclude1099Exempt.ValueInfo = "True";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(107.0662F, 35.00001F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Vendor";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VendorNumber]")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(107.0662F, 16F);
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorderDashStyle = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VendorName]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(107.0662F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(262.9724F, 16F);
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckDate]")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel5.KeepTogether = true;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(370.0385F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(64.35666F, 16F);
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorderDashStyle = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel5.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel7
            // 
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.BorderWidth = 1F;
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceNumber]")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel7.KeepTogether = true;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(434.3951F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(140.8924F, 15.99998F);
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorderDashStyle = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseBorderWidth = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BorderColor = System.Drawing.Color.Black;
            this.xrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.BorderWidth = 1F;
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckNumber]")});
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel8.KeepTogether = true;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(575.2876F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(88.73114F, 15.99998F);
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorderDashStyle = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseBorderWidth = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BorderColor = System.Drawing.Color.Black;
            this.xrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.BorderWidth = 1F;
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[The1099ReturnTypeDescription]")});
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel9.KeepTogether = true;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(664.0187F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(69.9809F, 15.99998F);
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorderDashStyle = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseBorderWidth = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BorderColor = System.Drawing.Color.Black;
            this.xrLabel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.BorderWidth = 1F;
            this.xrLabel10.CanGrow = false;
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmount]")});
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel10.KeepTogether = true;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(733.9996F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(113.5155F, 15.99998F);
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorderDashStyle = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseBorderWidth = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel10.TextFormatString = "{0:0.00;(0.00)}";
            // 
            // xrLabel11
            // 
            this.xrLabel11.BorderColor = System.Drawing.Color.Black;
            this.xrLabel11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.BorderWidth = 1F;
            this.xrLabel11.CanGrow = false;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DiscountAmount]")});
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel11.KeepTogether = true;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(847.5151F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(113.52F, 15.99998F);
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorderDashStyle = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseBorderWidth = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UsePadding = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel11.TextFormatString = "{0:0.00;(0.00)}";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Is1099Required]")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel4.KeepTogether = true;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(961.0352F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(69.52014F, 15.99998F);
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel4.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel6
            // 
            this.xrLabel6.BorderColor = System.Drawing.Color.Black;
            this.xrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.BorderWidth = 1F;
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.xrLabel6.KeepTogether = true;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(107.0662F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(262.9723F, 35.00001F);
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorderDashStyle = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Vendor Name";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pstrSelectVendor
            // 
            this.pstrSelectVendor.Description = "Parameter1";
            this.pstrSelectVendor.MultiValue = true;
            this.pstrSelectVendor.Name = "pstrSelectVendor";
            // 
            // ExcelAPPaymentsHistoryRecap
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.APPaymentHistoryDataSource,
            this.pageHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "APPaymentHistoryDatasource";
            this.DataSource = this.Dynamic;
            this.DisplayName = "APPaymentsHistoryRecap";
            this.FilterString = "[VendorNumber] In (?pstrSelectVendor) Or IsNullOrEmpty([VendorNumber]) And \'!\' In" +
    " (?pstrSelectVendor)";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 0F, 20F);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteBeginningDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteEndingDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowCriteria, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningVendorNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingVendorNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooInclude1099Exempt, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.plngCompanyID,
            this.pdteBeginningDate,
            this.pdteEndingDate,
            this.pbooShowCriteria,
            this.Subtitle,
            this.pstrBeginningVendorNumber,
            this.pstrEndingVendorNumber,
            this.pbooInclude1099Exempt,
            this.pstrSelectVendor});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand APPaymentHistoryDataSource;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel Textbox31;
        private DevExpress.XtraReports.UI.XRLabel Textbox38;
        private DevExpress.XtraReports.UI.XRLabel Textbox45;
        private DevExpress.XtraReports.UI.XRLabel Textbox47;
        private DevExpress.XtraReports.UI.XRLabel Textbox50;
        private DevExpress.XtraReports.UI.XRLabel Textbox41;
        private DevExpress.XtraReports.UI.XRLabel Textbox37;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter pdteBeginningDate;
        private DevExpress.XtraReports.Parameters.Parameter pdteEndingDate;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningVendorNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingVendorNumber;
        private DevExpress.XtraReports.Parameters.Parameter pbooInclude1099Exempt;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectVendor;
    }
}