namespace ReportsEngine.Reports.RDReports
{
    partial class ExcelSuspenseByOwnerSummary
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter11 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter12 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter13 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery5 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter14 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter15 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter16 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter17 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter18 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter19 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter20 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery6 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter21 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelSuspenseByOwnerSummary));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings5 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings6 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngRDProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningPropertyNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingPropertyNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningOwnerNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingOwnerNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngSuspenseCodeID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteBeginningDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteEndingDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngDateToUse = new DevExpress.XtraReports.Parameters.Parameter();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel26,
            this.xrLabel27,
            this.xrLabel29,
            this.xrLabel16,
            this.xrLabel18});
            this.detailBand1.HeightF = 17F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Connection";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "RevenueSuspensebyOwner";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            queryParameter2.Name = "@plngRDProcessTrackingID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngRDProcessTrackingID", typeof(string));
            queryParameter3.Name = "@pstrBeginningOwnerNumber";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?pstrBeginningOwnerNumber", typeof(string));
            queryParameter4.Name = "@pstrEndingOwnerNumber";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?pstrEndingOwnerNumber", typeof(string));
            queryParameter5.Name = "@pstrBeginningPropertyNumber";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?pstrBeginningPropertyNumber", typeof(string));
            queryParameter6.Name = "@pstrEndingPropertyNumber";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?pstrEndingPropertyNumber", typeof(string));
            queryParameter7.Name = "@plngSuspenseCodeID";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?plngSuspenseCodeID", typeof(string));
            queryParameter8.Name = "@plngDateToUse";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("?plngDateToUse", typeof(string));
            queryParameter9.Name = "@pdteBeginningDate";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("?pdteBeginningDate", typeof(string));
            queryParameter10.Name = "@pdteEndingDate";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("?pdteEndingDate", typeof(string));
            queryParameter11.Name = "@plngSortOrder";
            queryParameter11.Type = typeof(string);
            queryParameter11.ValueInfo = "0";
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
            queryParameter10,
            queryParameter11});
            storedProcQuery1.StoredProcName = "Report_SuspenseByOwner";
            storedProcQuery2.Name = "JIBHistoryCompanyLookUp";
            storedProcQuery2.StoredProcName = "Companies_ReportLookup";
            storedProcQuery3.Name = "JIBHistoryOwnerLookUp";
            queryParameter12.Name = "@plngCompanyID";
            queryParameter12.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter12.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            storedProcQuery3.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter12});
            storedProcQuery3.StoredProcName = "Owners_ReportLookup";
            storedProcQuery4.Name = "JIBHistoryPropertyLookUp";
            queryParameter13.Name = "@plngCompanyID";
            queryParameter13.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter13.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            storedProcQuery4.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter13});
            storedProcQuery4.StoredProcName = "Properties_ReportLookup";
            storedProcQuery5.Name = "DSSuspenseByEnding";
            queryParameter14.Name = "@plngCompanyID";
            queryParameter14.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter14.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            queryParameter15.Name = "@plngRDProcessTrackingID";
            queryParameter15.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter15.Value = new DevExpress.DataAccess.Expression("?plngRDProcessTrackingID", typeof(string));
            queryParameter16.Name = "@pstrBeginningOwnerNumber";
            queryParameter16.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter16.Value = new DevExpress.DataAccess.Expression("?pstrBeginningOwnerNumber", typeof(string));
            queryParameter17.Name = "@pstrEndingOwnerNumber";
            queryParameter17.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter17.Value = new DevExpress.DataAccess.Expression("?pstrEndingOwnerNumber", typeof(string));
            queryParameter18.Name = "@pstrBeginningPropertyNumber";
            queryParameter18.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter18.Value = new DevExpress.DataAccess.Expression("?pstrBeginningPropertyNumber", typeof(string));
            queryParameter19.Name = "@pstrEndingPropertyNumber";
            queryParameter19.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter19.Value = new DevExpress.DataAccess.Expression("?pstrEndingPropertyNumber", typeof(string));
            queryParameter20.Name = "@plngSuspenseCodeID";
            queryParameter20.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter20.Value = new DevExpress.DataAccess.Expression("?plngSuspenseCodeID", typeof(string));
            storedProcQuery5.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter14,
            queryParameter15,
            queryParameter16,
            queryParameter17,
            queryParameter18,
            queryParameter19,
            queryParameter20});
            storedProcQuery5.StoredProcName = "Report_SuspenseByEnding";
            storedProcQuery6.Name = "DSRDPayStatusLookup";
            queryParameter21.Name = "@plngCodesToShow";
            queryParameter21.Type = typeof(string);
            queryParameter21.ValueInfo = "0";
            storedProcQuery6.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter21});
            storedProcQuery6.StoredProcName = "ReportWizard_GetRDPayStatus";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3,
            storedProcQuery4,
            storedProcQuery5,
            storedProcQuery6});
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
            dynamicListLookUpSettings1.DataMember = "JIBHistoryCompanyLookUp";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.ValueMember = "ID";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings1;
            this.plngCompanyID.Visible = false;
            // 
            // plngRDProcessTrackingID
            // 
            this.plngRDProcessTrackingID.Description = "plngRDProcessTrackingID";
            this.plngRDProcessTrackingID.Name = "plngRDProcessTrackingID";
            this.plngRDProcessTrackingID.Type = typeof(int);
            this.plngRDProcessTrackingID.ValueInfo = "0";
            this.plngRDProcessTrackingID.Visible = false;
            // 
            // pstrBeginningPropertyNumber
            // 
            this.pstrBeginningPropertyNumber.Description = "From Property:";
            this.pstrBeginningPropertyNumber.Name = "pstrBeginningPropertyNumber";
            this.pstrBeginningPropertyNumber.ValueInfo = "!";
            dynamicListLookUpSettings2.DataMember = "JIBHistoryPropertyLookUp";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "Description";
            dynamicListLookUpSettings2.ValueMember = "PropertyAndWellNumber";
            this.pstrBeginningPropertyNumber.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // pstrEndingPropertyNumber
            // 
            this.pstrEndingPropertyNumber.Description = "To Property:";
            this.pstrEndingPropertyNumber.Name = "pstrEndingPropertyNumber";
            this.pstrEndingPropertyNumber.ValueInfo = "ZZZZZZZZZZ-ZZZZZZZZZZ";
            dynamicListLookUpSettings3.DataMember = "JIBHistoryPropertyLookUp";
            dynamicListLookUpSettings3.DataSource = this.Dynamic;
            dynamicListLookUpSettings3.DisplayMember = "Description";
            dynamicListLookUpSettings3.ValueMember = "PropertyAndWellNumber";
            this.pstrEndingPropertyNumber.ValueSourceSettings = dynamicListLookUpSettings3;
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Description = "Show Criteria";
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "True";
            // 
            // pstrBeginningOwnerNumber
            // 
            this.pstrBeginningOwnerNumber.Description = "From Owner:";
            this.pstrBeginningOwnerNumber.Name = "pstrBeginningOwnerNumber";
            this.pstrBeginningOwnerNumber.ValueInfo = "!";
            dynamicListLookUpSettings4.DataMember = "JIBHistoryOwnerLookUp";
            dynamicListLookUpSettings4.DataSource = this.Dynamic;
            dynamicListLookUpSettings4.DisplayMember = "Description";
            dynamicListLookUpSettings4.ValueMember = "Number";
            this.pstrBeginningOwnerNumber.ValueSourceSettings = dynamicListLookUpSettings4;
            // 
            // pstrEndingOwnerNumber
            // 
            this.pstrEndingOwnerNumber.Description = "To Owner:";
            this.pstrEndingOwnerNumber.Name = "pstrEndingOwnerNumber";
            this.pstrEndingOwnerNumber.ValueInfo = "ZZZZZZZZZZ";
            dynamicListLookUpSettings5.DataMember = "JIBHistoryOwnerLookUp";
            dynamicListLookUpSettings5.DataSource = this.Dynamic;
            dynamicListLookUpSettings5.DisplayMember = "Description";
            dynamicListLookUpSettings5.ValueMember = "Number";
            this.pstrEndingOwnerNumber.ValueSourceSettings = dynamicListLookUpSettings5;
            // 
            // plngSuspenseCodeID
            // 
            this.plngSuspenseCodeID.Description = "Suspense Code";
            this.plngSuspenseCodeID.Name = "plngSuspenseCodeID";
            this.plngSuspenseCodeID.ValueInfo = "0";
            dynamicListLookUpSettings6.DataMember = "DSRDPayStatusLookup";
            dynamicListLookUpSettings6.DataSource = this.Dynamic;
            dynamicListLookUpSettings6.DisplayMember = "Item";
            dynamicListLookUpSettings6.ValueMember = "ItemData";
            this.plngSuspenseCodeID.ValueSourceSettings = dynamicListLookUpSettings6;
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
            // plngDateToUse
            // 
            this.plngDateToUse.Description = "Date to Use";
            this.plngDateToUse.Name = "plngDateToUse";
            this.plngDateToUse.Type = typeof(int);
            this.plngDateToUse.ValueInfo = "2";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(2, "Sale Date"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "Processing Date"));
            this.plngDateToUse.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3});
            this.pageHeaderBand1.HeightF = 38.75002F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.BorderWidth = 1F;
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel7.KeepTogether = true;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(102.3425F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(395.1758F, 38.75001F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Owner Name";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BorderColor = System.Drawing.Color.Black;
            this.xrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.BorderWidth = 1F;
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel6.KeepTogether = true;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(102.3425F, 38.75002F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Owner";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel5.KeepTogether = true;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(497.5183F, 0F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(94.37018F, 38.74998F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Minimum/\r\nForce Pay";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel4.KeepTogether = true;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(591.8885F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(87.74231F, 38.74998F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Legal\r\nSuspense";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(679.6312F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(90.36908F, 38.75002F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Total";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel26.BorderColor = System.Drawing.Color.Black;
            this.xrLabel26.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.BorderWidth = 1F;
            this.xrLabel26.CanGrow = false;
            this.xrLabel26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MinimumForcedPayAmount]")});
            this.xrLabel26.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel26.ForeColor = System.Drawing.Color.Black;
            this.xrLabel26.KeepTogether = true;
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(497.5183F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(94.37018F, 17F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseBorderColor = false;
            this.xrLabel26.StylePriority.UseBorderDashStyle = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseBorderWidth = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseForeColor = false;
            this.xrLabel26.StylePriority.UsePadding = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel26.TextFormatString = "{0:N2}";
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel27.BorderColor = System.Drawing.Color.Black;
            this.xrLabel27.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel27.BorderWidth = 1F;
            this.xrLabel27.CanGrow = false;
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LegalAmount]")});
            this.xrLabel27.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel27.ForeColor = System.Drawing.Color.Black;
            this.xrLabel27.KeepTogether = true;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(591.8885F, 0F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(87.7417F, 17F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseBorderColor = false;
            this.xrLabel27.StylePriority.UseBorderDashStyle = false;
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseBorderWidth = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UsePadding = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel27.TextFormatString = "{0:N2}";
            // 
            // xrLabel29
            // 
            this.xrLabel29.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel29.BorderColor = System.Drawing.Color.Black;
            this.xrLabel29.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel29.BorderWidth = 1F;
            this.xrLabel29.CanGrow = false;
            this.xrLabel29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerNet]")});
            this.xrLabel29.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel29.ForeColor = System.Drawing.Color.Black;
            this.xrLabel29.KeepTogether = true;
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(679.6307F, 0F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(90.36951F, 17F);
            this.xrLabel29.StylePriority.UseBackColor = false;
            this.xrLabel29.StylePriority.UseBorderColor = false;
            this.xrLabel29.StylePriority.UseBorderDashStyle = false;
            this.xrLabel29.StylePriority.UseBorders = false;
            this.xrLabel29.StylePriority.UseBorderWidth = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseForeColor = false;
            this.xrLabel29.StylePriority.UsePadding = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel29.TextFormatString = "{0:N2}";
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel16.BorderColor = System.Drawing.Color.Black;
            this.xrLabel16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.BorderWidth = 1F;
            this.xrLabel16.CanGrow = false;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerNumber] ")});
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel16.ForeColor = System.Drawing.Color.Black;
            this.xrLabel16.KeepTogether = true;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(0.0002724784F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(102.3423F, 17F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorderDashStyle = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseBorderWidth = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UsePadding = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel18.BorderColor = System.Drawing.Color.Black;
            this.xrLabel18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel18.BorderWidth = 1F;
            this.xrLabel18.CanGrow = false;
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerName]")});
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel18.ForeColor = System.Drawing.Color.Black;
            this.xrLabel18.KeepTogether = true;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(102.3425F, 0F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(395.1758F, 17F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorderDashStyle = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseBorderWidth = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UsePadding = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ExcelSuspenseByOwnerSummary
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.pageHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DisplayName = "SuspenseByOwner";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 20F, 20F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.plngCompanyID,
            this.plngRDProcessTrackingID,
            this.pstrBeginningPropertyNumber,
            this.pstrEndingPropertyNumber,
            this.pbooShowCriteria,
            this.pstrBeginningOwnerNumber,
            this.pstrEndingOwnerNumber,
            this.plngSuspenseCodeID,
            this.pdteBeginningDate,
            this.pdteEndingDate,
            this.plngDateToUse});
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
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter plngRDProcessTrackingID;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningPropertyNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingPropertyNumber;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningOwnerNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingOwnerNumber;
        private DevExpress.XtraReports.Parameters.Parameter plngSuspenseCodeID;
        private DevExpress.XtraReports.Parameters.Parameter pdteBeginningDate;
        private DevExpress.XtraReports.Parameters.Parameter pdteEndingDate;
        private DevExpress.XtraReports.Parameters.Parameter plngDateToUse;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
    }
}
