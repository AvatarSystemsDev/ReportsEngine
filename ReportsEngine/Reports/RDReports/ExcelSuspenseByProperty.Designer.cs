namespace ReportsEngine.Reports.RDReports
{
    partial class ExcelSuspenseByProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelSuspenseByProperty));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.JIBItems = new DevExpress.XtraReports.UI.DetailReportBand();
            this.JIBItems_Detail_DetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.detailReportBand1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.detailBand2 = new DevExpress.XtraReports.UI.DetailBand();
            this.SuspenseByEndingTable = new DevExpress.XtraReports.UI.DetailReportBand();
            this.SuspenseByEndingTable_GroupHeaderBand = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SuspenseByEndingTable_Details_DetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.SuspenseCodeDescription = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeVolume = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeOwnerGross = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeOwnerTax = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeOwnerDeducts = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeOwnerNet = new DevExpress.XtraReports.UI.XRTableCell();
            this.SuspenseByEndingTable_GroupFooterBand = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeVolume1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeOwnerGross1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeOwnerTax1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeOwnerDeducts1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalForCodeOwnerNet1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel76 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.pstrSelectOwner = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectProperty = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowDetail = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "RevenueSuspensebyOwner";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter2.Name = "@plngRDProcessTrackingID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngRDProcessTrackingID", typeof(int));
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
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?plngSuspenseCodeID", typeof(int));
            queryParameter8.Name = "@plngDateToUse";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("?plngDateToUse", typeof(int));
            queryParameter9.Name = "@pdteBeginningDate";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("?pdteBeginningDate", typeof(System.DateTime));
            queryParameter10.Name = "@pdteEndingDate";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("?pdteEndingDate", typeof(System.DateTime));
            queryParameter11.Name = "@plngSortOrder";
            queryParameter11.Type = typeof(int);
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
            this.bottomMarginBand1.HeightF = 0F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.HeightF = 0F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            // 
            // JIBItems
            // 
            this.JIBItems.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.JIBItems_Detail_DetailBand});
            this.JIBItems.DataMember = "RevenueSuspensebyOwner";
            this.JIBItems.DataSource = this.Dynamic;
            this.JIBItems.FilterString = resources.GetString("JIBItems.FilterString");
            this.JIBItems.Level = 0;
            this.JIBItems.Name = "JIBItems";
            // 
            // JIBItems_Detail_DetailBand
            // 
            this.JIBItems_Detail_DetailBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel12,
            this.xrLabel13});
            this.JIBItems_Detail_DetailBand.HeightF = 17F;
            this.JIBItems_Detail_DetailBand.MultiColumn.ColumnSpacing = 50F;
            this.JIBItems_Detail_DetailBand.Name = "JIBItems_Detail_DetailBand";
            this.JIBItems_Detail_DetailBand.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PropertyNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // xrLabel11
            // 
            this.xrLabel11.BorderColor = System.Drawing.Color.Black;
            this.xrLabel11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.BorderWidth = 1F;
            this.xrLabel11.CanGrow = false;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerNet]")});
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel11.KeepTogether = true;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(1251.037F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(77.53F, 17F);
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorderDashStyle = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseBorderWidth = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UsePadding = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel11.TextFormatString = "{0:N2}";
            // 
            // xrLabel10
            // 
            this.xrLabel10.BorderColor = System.Drawing.Color.Black;
            this.xrLabel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.BorderWidth = 1F;
            this.xrLabel10.CanGrow = false;
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerDeductions]")});
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel10.KeepTogether = true;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(1183.385F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(67.65186F, 17F);
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorderDashStyle = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseBorderWidth = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel10.TextFormatString = "{0:N2}";
            // 
            // xrLabel9
            // 
            this.xrLabel9.BorderColor = System.Drawing.Color.Black;
            this.xrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.BorderWidth = 1F;
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerTax]")});
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel9.KeepTogether = true;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(1112.012F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(71.37305F, 17F);
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorderDashStyle = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseBorderWidth = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel9.TextFormatString = "{0:N2}";
            // 
            // xrLabel8
            // 
            this.xrLabel8.BorderColor = System.Drawing.Color.Black;
            this.xrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.BorderWidth = 1F;
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerGross]")});
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel8.KeepTogether = true;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(1034.485F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(77.52686F, 17F);
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorderDashStyle = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseBorderWidth = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel8.TextFormatString = "{0:N2}";
            // 
            // xrLabel7
            // 
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.BorderWidth = 1F;
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([UseMCFVolume] = False, [OwnerBarrels], [OwnerMCF])")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel7.KeepTogether = true;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(965.9315F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(68.55304F, 17F);
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorderDashStyle = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseBorderWidth = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel7.TextFormatString = "{0:N2}";
            // 
            // xrLabel6
            // 
            this.xrLabel6.BorderColor = System.Drawing.Color.Black;
            this.xrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.BorderWidth = 1F;
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerDOI]")});
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel6.KeepTogether = true;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(891.021F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(74.91046F, 17F);
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorderDashStyle = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel6.TextFormatString = "{0:n10}";
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SuspendedDate]")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel5.KeepTogether = true;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(825.5496F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(65.47144F, 17F);
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorderDashStyle = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel5.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductionDate]")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel4.KeepTogether = true;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(760.9785F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(64.57098F, 17F);
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel4.TextFormatString = "{0:MM/yyyy}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductTypeDescription]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(716.8561F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(44.12244F, 17F);
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SuspenseCode]")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(573.722F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(143.1341F, 17F);
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorderDashStyle = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BorderColor = System.Drawing.Color.Black;
            this.xrLabel20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.BorderWidth = 1F;
            this.xrLabel20.CanGrow = false;
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PropertyName]")});
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel20.KeepTogether = true;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(379.4322F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(194.2899F, 17F);
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorderDashStyle = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseBorderWidth = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BorderColor = System.Drawing.Color.Black;
            this.xrLabel21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.BorderWidth = 1F;
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PhaseWellNumber]")});
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel21.KeepTogether = true;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(286.861F, 0F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(92.57101F, 17F);
            this.xrLabel21.StylePriority.UseBorderColor = false;
            this.xrLabel21.StylePriority.UseBorderDashStyle = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseBorderWidth = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BorderColor = System.Drawing.Color.Black;
            this.xrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.BorderWidth = 1F;
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerName]")});
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel12.KeepTogether = true;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(92.57113F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(194.2899F, 17F);
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorderDashStyle = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseBorderWidth = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.BorderColor = System.Drawing.Color.Black;
            this.xrLabel13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.BorderWidth = 1F;
            this.xrLabel13.CanGrow = false;
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerNumber]")});
            this.xrLabel13.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel13.KeepTogether = true;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(92.57101F, 17F);
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorderDashStyle = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseBorderWidth = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UsePadding = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // detailReportBand1
            // 
            this.detailReportBand1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.detailBand2,
            this.SuspenseByEndingTable});
            this.detailReportBand1.Level = 1;
            this.detailReportBand1.Name = "detailReportBand1";
            this.detailReportBand1.Visible = false;
            // 
            // detailBand2
            // 
            this.detailBand2.HeightF = 0F;
            this.detailBand2.MultiColumn.ColumnSpacing = 50F;
            this.detailBand2.Name = "detailBand2";
            // 
            // SuspenseByEndingTable
            // 
            this.SuspenseByEndingTable.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.SuspenseByEndingTable_GroupHeaderBand,
            this.SuspenseByEndingTable_Details_DetailBand,
            this.SuspenseByEndingTable_GroupFooterBand});
            this.SuspenseByEndingTable.DataMember = "DSSuspenseByEnding";
            this.SuspenseByEndingTable.DataSource = this.Dynamic;
            this.SuspenseByEndingTable.Level = 0;
            this.SuspenseByEndingTable.Name = "SuspenseByEndingTable";
            // 
            // SuspenseByEndingTable_GroupHeaderBand
            // 
            this.SuspenseByEndingTable_GroupHeaderBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5});
            this.SuspenseByEndingTable_GroupHeaderBand.HeightF = 20F;
            this.SuspenseByEndingTable_GroupHeaderBand.Name = "SuspenseByEndingTable_GroupHeaderBand";
            this.SuspenseByEndingTable_GroupHeaderBand.Visible = false;
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(211.2F, 0F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable5.SizeF = new System.Drawing.SizeF(583.73F, 20F);
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox31,
            this.Textbox32,
            this.Textbox33,
            this.Textbox34,
            this.Textbox35,
            this.Textbox36});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // Textbox31
            // 
            this.Textbox31.BorderColor = System.Drawing.Color.Black;
            this.Textbox31.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox31.BorderWidth = 1F;
            this.Textbox31.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox31.KeepTogether = true;
            this.Textbox31.Name = "Textbox31";
            this.Textbox31.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox31.Text = "Totals by Suspense Code";
            this.Textbox31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox31.Weight = 20931.559451219513D;
            // 
            // Textbox32
            // 
            this.Textbox32.BorderColor = System.Drawing.Color.Black;
            this.Textbox32.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox32.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox32.BorderWidth = 1F;
            this.Textbox32.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox32.KeepTogether = true;
            this.Textbox32.Name = "Textbox32";
            this.Textbox32.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox32.Weight = 7067.0983231707314D;
            // 
            // Textbox33
            // 
            this.Textbox33.BorderColor = System.Drawing.Color.Black;
            this.Textbox33.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox33.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox33.BorderWidth = 1F;
            this.Textbox33.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox33.KeepTogether = true;
            this.Textbox33.Name = "Textbox33";
            this.Textbox33.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox33.Weight = 7992.1951219512193D;
            // 
            // Textbox34
            // 
            this.Textbox34.BorderColor = System.Drawing.Color.Black;
            this.Textbox34.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox34.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox34.BorderWidth = 1F;
            this.Textbox34.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox34.KeepTogether = true;
            this.Textbox34.Name = "Textbox34";
            this.Textbox34.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox34.Weight = 7357.8147865853662D;
            // 
            // Textbox35
            // 
            this.Textbox35.BorderColor = System.Drawing.Color.Black;
            this.Textbox35.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox35.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox35.BorderWidth = 1F;
            this.Textbox35.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox35.KeepTogether = true;
            this.Textbox35.Name = "Textbox35";
            this.Textbox35.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox35.Weight = 6974.1890243902435D;
            // 
            // Textbox36
            // 
            this.Textbox36.BorderColor = System.Drawing.Color.Black;
            this.Textbox36.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox36.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox36.BorderWidth = 1F;
            this.Textbox36.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox36.KeepTogether = true;
            this.Textbox36.Name = "Textbox36";
            this.Textbox36.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox36.Weight = 7992.1951219512193D;
            // 
            // SuspenseByEndingTable_Details_DetailBand
            // 
            this.SuspenseByEndingTable_Details_DetailBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details_table});
            this.SuspenseByEndingTable_Details_DetailBand.HeightF = 20F;
            this.SuspenseByEndingTable_Details_DetailBand.MultiColumn.ColumnSpacing = 50F;
            this.SuspenseByEndingTable_Details_DetailBand.Name = "SuspenseByEndingTable_Details_DetailBand";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(211.2F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.Details_table.SizeF = new System.Drawing.SizeF(583.73F, 20F);
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.SuspenseCodeDescription,
            this.TotalForCodeVolume,
            this.TotalForCodeOwnerGross,
            this.TotalForCodeOwnerTax,
            this.TotalForCodeOwnerDeducts,
            this.TotalForCodeOwnerNet});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // SuspenseCodeDescription
            // 
            this.SuspenseCodeDescription.BorderColor = System.Drawing.Color.Black;
            this.SuspenseCodeDescription.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.SuspenseCodeDescription.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SuspenseCodeDescription.BorderWidth = 1F;
            this.SuspenseCodeDescription.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SuspenseCodeDescription]")});
            this.SuspenseCodeDescription.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.SuspenseCodeDescription.KeepTogether = true;
            this.SuspenseCodeDescription.Name = "SuspenseCodeDescription";
            this.SuspenseCodeDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.SuspenseCodeDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.SuspenseCodeDescription.Weight = 20931.559451219513D;
            // 
            // TotalForCodeVolume
            // 
            this.TotalForCodeVolume.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeVolume.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeVolume.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeVolume.BorderWidth = 1F;
            this.TotalForCodeVolume.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalForCodeVolume]")});
            this.TotalForCodeVolume.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeVolume.KeepTogether = true;
            this.TotalForCodeVolume.Name = "TotalForCodeVolume";
            this.TotalForCodeVolume.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.TotalForCodeVolume.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeVolume.TextFormatString = "{0:n2}";
            this.TotalForCodeVolume.Weight = 7067.0983231707314D;
            // 
            // TotalForCodeOwnerGross
            // 
            this.TotalForCodeOwnerGross.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeOwnerGross.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeOwnerGross.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeOwnerGross.BorderWidth = 1F;
            this.TotalForCodeOwnerGross.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalForCodeOwnerGross]")});
            this.TotalForCodeOwnerGross.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeOwnerGross.KeepTogether = true;
            this.TotalForCodeOwnerGross.Name = "TotalForCodeOwnerGross";
            this.TotalForCodeOwnerGross.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.TotalForCodeOwnerGross.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeOwnerGross.TextFormatString = "{0:n2}";
            this.TotalForCodeOwnerGross.Weight = 7992.1951219512193D;
            // 
            // TotalForCodeOwnerTax
            // 
            this.TotalForCodeOwnerTax.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeOwnerTax.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeOwnerTax.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeOwnerTax.BorderWidth = 1F;
            this.TotalForCodeOwnerTax.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalForCodeOwnerTax]")});
            this.TotalForCodeOwnerTax.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeOwnerTax.KeepTogether = true;
            this.TotalForCodeOwnerTax.Name = "TotalForCodeOwnerTax";
            this.TotalForCodeOwnerTax.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.TotalForCodeOwnerTax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeOwnerTax.TextFormatString = "{0:n2}";
            this.TotalForCodeOwnerTax.Weight = 7357.8147865853662D;
            // 
            // TotalForCodeOwnerDeducts
            // 
            this.TotalForCodeOwnerDeducts.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeOwnerDeducts.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeOwnerDeducts.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeOwnerDeducts.BorderWidth = 1F;
            this.TotalForCodeOwnerDeducts.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalForCodeOwnerDeducts]")});
            this.TotalForCodeOwnerDeducts.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeOwnerDeducts.KeepTogether = true;
            this.TotalForCodeOwnerDeducts.Name = "TotalForCodeOwnerDeducts";
            this.TotalForCodeOwnerDeducts.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.TotalForCodeOwnerDeducts.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeOwnerDeducts.TextFormatString = "{0:n2}";
            this.TotalForCodeOwnerDeducts.Weight = 6974.1890243902435D;
            // 
            // TotalForCodeOwnerNet
            // 
            this.TotalForCodeOwnerNet.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeOwnerNet.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeOwnerNet.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeOwnerNet.BorderWidth = 1F;
            this.TotalForCodeOwnerNet.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalForCodeOwnerNet]")});
            this.TotalForCodeOwnerNet.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeOwnerNet.KeepTogether = true;
            this.TotalForCodeOwnerNet.Name = "TotalForCodeOwnerNet";
            this.TotalForCodeOwnerNet.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.TotalForCodeOwnerNet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeOwnerNet.TextFormatString = "{0:n2}";
            this.TotalForCodeOwnerNet.Weight = 7992.1951219512193D;
            // 
            // SuspenseByEndingTable_GroupFooterBand
            // 
            this.SuspenseByEndingTable_GroupFooterBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
            this.SuspenseByEndingTable_GroupFooterBand.HeightF = 25F;
            this.SuspenseByEndingTable_GroupFooterBand.Name = "SuspenseByEndingTable_GroupFooterBand";
            this.SuspenseByEndingTable_GroupFooterBand.Visible = false;
            // 
            // xrTable6
            // 
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(211.2F, 0F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable6.SizeF = new System.Drawing.SizeF(583.73F, 25F);
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox25,
            this.TotalForCodeVolume1,
            this.TotalForCodeOwnerGross1,
            this.TotalForCodeOwnerTax1,
            this.TotalForCodeOwnerDeducts1,
            this.TotalForCodeOwnerNet1});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // Textbox25
            // 
            this.Textbox25.BorderColor = System.Drawing.Color.Black;
            this.Textbox25.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox25.BorderWidth = 1F;
            this.Textbox25.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox25.KeepTogether = true;
            this.Textbox25.Name = "Textbox25";
            this.Textbox25.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox25.Text = "Total for All Codes:";
            this.Textbox25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox25.Weight = 20931.559451219513D;
            // 
            // TotalForCodeVolume1
            // 
            this.TotalForCodeVolume1.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeVolume1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeVolume1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeVolume1.BorderWidth = 1F;
            this.TotalForCodeVolume1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalForCodeVolume])")});
            this.TotalForCodeVolume1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeVolume1.KeepTogether = true;
            this.TotalForCodeVolume1.Name = "TotalForCodeVolume1";
            this.TotalForCodeVolume1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.TotalForCodeVolume1.Summary = xrSummary1;
            this.TotalForCodeVolume1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeVolume1.TextFormatString = "{0:n2}";
            this.TotalForCodeVolume1.Weight = 7067.0983231707314D;
            // 
            // TotalForCodeOwnerGross1
            // 
            this.TotalForCodeOwnerGross1.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeOwnerGross1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeOwnerGross1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeOwnerGross1.BorderWidth = 1F;
            this.TotalForCodeOwnerGross1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalForCodeOwnerGross])")});
            this.TotalForCodeOwnerGross1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeOwnerGross1.KeepTogether = true;
            this.TotalForCodeOwnerGross1.Name = "TotalForCodeOwnerGross1";
            this.TotalForCodeOwnerGross1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.TotalForCodeOwnerGross1.Summary = xrSummary2;
            this.TotalForCodeOwnerGross1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeOwnerGross1.TextFormatString = "{0:n2}";
            this.TotalForCodeOwnerGross1.Weight = 7992.1951219512193D;
            // 
            // TotalForCodeOwnerTax1
            // 
            this.TotalForCodeOwnerTax1.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeOwnerTax1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeOwnerTax1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeOwnerTax1.BorderWidth = 1F;
            this.TotalForCodeOwnerTax1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalForCodeOwnerTax])")});
            this.TotalForCodeOwnerTax1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeOwnerTax1.KeepTogether = true;
            this.TotalForCodeOwnerTax1.Name = "TotalForCodeOwnerTax1";
            this.TotalForCodeOwnerTax1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.TotalForCodeOwnerTax1.Summary = xrSummary3;
            this.TotalForCodeOwnerTax1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeOwnerTax1.TextFormatString = "{0:n2}";
            this.TotalForCodeOwnerTax1.Weight = 7357.8147865853662D;
            // 
            // TotalForCodeOwnerDeducts1
            // 
            this.TotalForCodeOwnerDeducts1.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeOwnerDeducts1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeOwnerDeducts1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeOwnerDeducts1.BorderWidth = 1F;
            this.TotalForCodeOwnerDeducts1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalForCodeOwnerDeducts])")});
            this.TotalForCodeOwnerDeducts1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeOwnerDeducts1.KeepTogether = true;
            this.TotalForCodeOwnerDeducts1.Name = "TotalForCodeOwnerDeducts1";
            this.TotalForCodeOwnerDeducts1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.TotalForCodeOwnerDeducts1.Summary = xrSummary4;
            this.TotalForCodeOwnerDeducts1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeOwnerDeducts1.TextFormatString = "{0:n2}";
            this.TotalForCodeOwnerDeducts1.Weight = 6974.1890243902435D;
            // 
            // TotalForCodeOwnerNet1
            // 
            this.TotalForCodeOwnerNet1.BorderColor = System.Drawing.Color.Black;
            this.TotalForCodeOwnerNet1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalForCodeOwnerNet1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalForCodeOwnerNet1.BorderWidth = 1F;
            this.TotalForCodeOwnerNet1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalForCodeOwnerNet])")});
            this.TotalForCodeOwnerNet1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.TotalForCodeOwnerNet1.KeepTogether = true;
            this.TotalForCodeOwnerNet1.Name = "TotalForCodeOwnerNet1";
            this.TotalForCodeOwnerNet1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.TotalForCodeOwnerNet1.Summary = xrSummary5;
            this.TotalForCodeOwnerNet1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalForCodeOwnerNet1.TextFormatString = "{0:n2}";
            this.TotalForCodeOwnerNet1.Weight = 7992.1951219512193D;
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel68,
            this.xrLabel69,
            this.xrLabel70,
            this.xrLabel71,
            this.xrLabel72,
            this.xrLabel73,
            this.xrLabel74,
            this.xrLabel75,
            this.xrLabel76,
            this.xrLabel77,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel1,
            this.xrLabel22});
            this.pageHeaderBand1.HeightF = 38.75F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel68
            // 
            this.xrLabel68.BorderColor = System.Drawing.Color.Black;
            this.xrLabel68.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel68.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel68.BorderWidth = 1F;
            this.xrLabel68.CanGrow = false;
            this.xrLabel68.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel68.KeepTogether = true;
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(1251.036F, 0F);
            this.xrLabel68.Multiline = true;
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(77.52679F, 38.75F);
            this.xrLabel68.StylePriority.UseFont = false;
            this.xrLabel68.StylePriority.UsePadding = false;
            this.xrLabel68.StylePriority.UseTextAlignment = false;
            this.xrLabel68.Text = "Net\nAmount";
            this.xrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel69
            // 
            this.xrLabel69.BorderColor = System.Drawing.Color.Black;
            this.xrLabel69.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel69.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel69.BorderWidth = 1F;
            this.xrLabel69.CanGrow = false;
            this.xrLabel69.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel69.KeepTogether = true;
            this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(1183.384F, 0F);
            this.xrLabel69.Multiline = true;
            this.xrLabel69.Name = "xrLabel69";
            this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel69.SizeF = new System.Drawing.SizeF(67.65186F, 38.75F);
            this.xrLabel69.StylePriority.UseFont = false;
            this.xrLabel69.StylePriority.UsePadding = false;
            this.xrLabel69.StylePriority.UseTextAlignment = false;
            this.xrLabel69.Text = "Deducts";
            this.xrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel70
            // 
            this.xrLabel70.BorderColor = System.Drawing.Color.Black;
            this.xrLabel70.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel70.BorderWidth = 1F;
            this.xrLabel70.CanGrow = false;
            this.xrLabel70.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel70.KeepTogether = true;
            this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(1112.011F, 0F);
            this.xrLabel70.Multiline = true;
            this.xrLabel70.Name = "xrLabel70";
            this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel70.SizeF = new System.Drawing.SizeF(71.37292F, 38.75F);
            this.xrLabel70.StylePriority.UseFont = false;
            this.xrLabel70.StylePriority.UsePadding = false;
            this.xrLabel70.StylePriority.UseTextAlignment = false;
            this.xrLabel70.Text = "Sev Tax";
            this.xrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel71
            // 
            this.xrLabel71.BorderColor = System.Drawing.Color.Black;
            this.xrLabel71.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel71.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel71.BorderWidth = 1F;
            this.xrLabel71.CanGrow = false;
            this.xrLabel71.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel71.KeepTogether = true;
            this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(1034.485F, 0F);
            this.xrLabel71.Multiline = true;
            this.xrLabel71.Name = "xrLabel71";
            this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel71.SizeF = new System.Drawing.SizeF(77.52692F, 38.75F);
            this.xrLabel71.StylePriority.UseFont = false;
            this.xrLabel71.StylePriority.UsePadding = false;
            this.xrLabel71.StylePriority.UseTextAlignment = false;
            this.xrLabel71.Text = "Gross";
            this.xrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel72
            // 
            this.xrLabel72.BorderColor = System.Drawing.Color.Black;
            this.xrLabel72.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel72.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel72.BorderWidth = 1F;
            this.xrLabel72.CanGrow = false;
            this.xrLabel72.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel72.KeepTogether = true;
            this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(965.9315F, 0F);
            this.xrLabel72.Multiline = true;
            this.xrLabel72.Name = "xrLabel72";
            this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel72.SizeF = new System.Drawing.SizeF(68.55316F, 38.75F);
            this.xrLabel72.StylePriority.UseFont = false;
            this.xrLabel72.StylePriority.UsePadding = false;
            this.xrLabel72.StylePriority.UseTextAlignment = false;
            this.xrLabel72.Text = "Volume";
            this.xrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel73
            // 
            this.xrLabel73.BorderColor = System.Drawing.Color.Black;
            this.xrLabel73.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel73.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel73.BorderWidth = 1F;
            this.xrLabel73.CanGrow = false;
            this.xrLabel73.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel73.KeepTogether = true;
            this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(891.021F, 0F);
            this.xrLabel73.Multiline = true;
            this.xrLabel73.Name = "xrLabel73";
            this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel73.SizeF = new System.Drawing.SizeF(74.91037F, 38.75F);
            this.xrLabel73.StylePriority.UseFont = false;
            this.xrLabel73.StylePriority.UsePadding = false;
            this.xrLabel73.StylePriority.UseTextAlignment = false;
            this.xrLabel73.Text = "DOI";
            this.xrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel74
            // 
            this.xrLabel74.BorderColor = System.Drawing.Color.Black;
            this.xrLabel74.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel74.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel74.BorderWidth = 1F;
            this.xrLabel74.CanGrow = false;
            this.xrLabel74.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel74.KeepTogether = true;
            this.xrLabel74.LocationFloat = new DevExpress.Utils.PointFloat(825.5496F, 0F);
            this.xrLabel74.Multiline = true;
            this.xrLabel74.Name = "xrLabel74";
            this.xrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel74.SizeF = new System.Drawing.SizeF(65.47153F, 38.75F);
            this.xrLabel74.StylePriority.UseFont = false;
            this.xrLabel74.StylePriority.UsePadding = false;
            this.xrLabel74.StylePriority.UseTextAlignment = false;
            this.xrLabel74.Text = "Process\nDate";
            this.xrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel75
            // 
            this.xrLabel75.BorderColor = System.Drawing.Color.Black;
            this.xrLabel75.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel75.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel75.BorderWidth = 1F;
            this.xrLabel75.CanGrow = false;
            this.xrLabel75.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel75.KeepTogether = true;
            this.xrLabel75.LocationFloat = new DevExpress.Utils.PointFloat(760.9786F, 0F);
            this.xrLabel75.Multiline = true;
            this.xrLabel75.Name = "xrLabel75";
            this.xrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel75.SizeF = new System.Drawing.SizeF(64.57111F, 38.75F);
            this.xrLabel75.StylePriority.UseFont = false;
            this.xrLabel75.StylePriority.UsePadding = false;
            this.xrLabel75.StylePriority.UseTextAlignment = false;
            this.xrLabel75.Text = "Prod\r\n\nDate";
            this.xrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel76
            // 
            this.xrLabel76.BorderColor = System.Drawing.Color.Black;
            this.xrLabel76.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel76.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel76.BorderWidth = 1F;
            this.xrLabel76.CanGrow = false;
            this.xrLabel76.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel76.KeepTogether = true;
            this.xrLabel76.LocationFloat = new DevExpress.Utils.PointFloat(716.8561F, 0F);
            this.xrLabel76.Multiline = true;
            this.xrLabel76.Name = "xrLabel76";
            this.xrLabel76.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel76.SizeF = new System.Drawing.SizeF(44.12244F, 38.75F);
            this.xrLabel76.StylePriority.UseFont = false;
            this.xrLabel76.StylePriority.UsePadding = false;
            this.xrLabel76.StylePriority.UseTextAlignment = false;
            this.xrLabel76.Text = "Prod";
            this.xrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel77
            // 
            this.xrLabel77.BorderColor = System.Drawing.Color.Black;
            this.xrLabel77.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel77.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel77.BorderWidth = 1F;
            this.xrLabel77.CanGrow = false;
            this.xrLabel77.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel77.KeepTogether = true;
            this.xrLabel77.LocationFloat = new DevExpress.Utils.PointFloat(573.722F, 0F);
            this.xrLabel77.Multiline = true;
            this.xrLabel77.Name = "xrLabel77";
            this.xrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel77.SizeF = new System.Drawing.SizeF(143.134F, 38.75F);
            this.xrLabel77.StylePriority.UseFont = false;
            this.xrLabel77.StylePriority.UsePadding = false;
            this.xrLabel77.StylePriority.UseTextAlignment = false;
            this.xrLabel77.Text = "Suspense Code";
            this.xrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BorderColor = System.Drawing.Color.Black;
            this.xrLabel18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel18.BorderWidth = 1F;
            this.xrLabel18.CanGrow = false;
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel18.KeepTogether = true;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(379.432F, 0F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(194.29F, 38.75F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UsePadding = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Property/Well Description";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BorderColor = System.Drawing.Color.Black;
            this.xrLabel19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.BorderWidth = 1F;
            this.xrLabel19.CanGrow = false;
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel19.KeepTogether = true;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(92.571F, 38.75F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UsePadding = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Owner";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(286.861F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(92.57101F, 38.75F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Property/Well";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BorderColor = System.Drawing.Color.Black;
            this.xrLabel22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.BorderWidth = 1F;
            this.xrLabel22.CanGrow = false;
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel22.KeepTogether = true;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(92.57101F, 0F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(194.29F, 38.75F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UsePadding = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Owner Name";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.pstrBeginningPropertyNumber.Description = "Beginning Property/Well:";
            this.pstrBeginningPropertyNumber.Name = "pstrBeginningPropertyNumber";
            this.pstrBeginningPropertyNumber.ValueInfo = "!";
            // 
            // pstrEndingPropertyNumber
            // 
            this.pstrEndingPropertyNumber.Description = "Ending Property/Well:";
            this.pstrEndingPropertyNumber.Name = "pstrEndingPropertyNumber";
            this.pstrEndingPropertyNumber.ValueInfo = "ZZZZZZZZZZ-ZZZZZZZZZZ";
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
            this.pstrBeginningOwnerNumber.Description = "Beginning Owner:";
            this.pstrBeginningOwnerNumber.Name = "pstrBeginningOwnerNumber";
            this.pstrBeginningOwnerNumber.ValueInfo = "!";
            // 
            // pstrEndingOwnerNumber
            // 
            this.pstrEndingOwnerNumber.Description = "Ending Owner:";
            this.pstrEndingOwnerNumber.Name = "pstrEndingOwnerNumber";
            this.pstrEndingOwnerNumber.ValueInfo = "ZZZZZZZZZZ";
            // 
            // plngSuspenseCodeID
            // 
            this.plngSuspenseCodeID.Description = "Suspense Code";
            this.plngSuspenseCodeID.Name = "plngSuspenseCodeID";
            this.plngSuspenseCodeID.ValueInfo = "0";
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
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(2, "Production Date"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "Processing Date"));
            this.plngDateToUse.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // pstrSelectOwner
            // 
            this.pstrSelectOwner.Description = "Parameter1";
            this.pstrSelectOwner.MultiValue = true;
            this.pstrSelectOwner.Name = "pstrSelectOwner";
            // 
            // pstrSelectProperty
            // 
            this.pstrSelectProperty.Description = "Parameter1";
            this.pstrSelectProperty.MultiValue = true;
            this.pstrSelectProperty.Name = "pstrSelectProperty";
            // 
            // pbooShowDetail
            // 
            this.pbooShowDetail.Description = "Show Detail";
            this.pbooShowDetail.Name = "pbooShowDetail";
            this.pbooShowDetail.Type = typeof(bool);
            this.pbooShowDetail.ValueInfo = "False";
            // 
            // ExcelSuspenseByProperty
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.JIBItems,
            this.detailReportBand1,
            this.pageHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DisplayName = "SuspenseByProperty";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 0F, 0F);
            this.PageWidth = 1700;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Ledger;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngRDProcessTrackingID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningPropertyNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingPropertyNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowCriteria, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningOwnerNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingOwnerNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngSuspenseCodeID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteBeginningDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteEndingDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngDateToUse, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectOwner, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectProperty, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowDetail, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
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
            this.plngDateToUse,
            this.pstrSelectOwner,
            this.pstrSelectProperty,
            this.pbooShowDetail});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.DetailReportBand JIBItems;
        private DevExpress.XtraReports.UI.DetailBand JIBItems_Detail_DetailBand;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.UI.DetailReportBand detailReportBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand2;
        private DevExpress.XtraReports.UI.DetailReportBand SuspenseByEndingTable;
        private DevExpress.XtraReports.UI.GroupHeaderBand SuspenseByEndingTable_GroupHeaderBand;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell Textbox31;
        private DevExpress.XtraReports.UI.XRTableCell Textbox32;
        private DevExpress.XtraReports.UI.XRTableCell Textbox33;
        private DevExpress.XtraReports.UI.XRTableCell Textbox34;
        private DevExpress.XtraReports.UI.XRTableCell Textbox35;
        private DevExpress.XtraReports.UI.XRTableCell Textbox36;
        private DevExpress.XtraReports.UI.DetailBand SuspenseByEndingTable_Details_DetailBand;
        private DevExpress.XtraReports.UI.XRTable Details_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell SuspenseCodeDescription;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeVolume;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeOwnerGross;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeOwnerTax;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeOwnerDeducts;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeOwnerNet;
        private DevExpress.XtraReports.UI.GroupFooterBand SuspenseByEndingTable_GroupFooterBand;
        private DevExpress.XtraReports.UI.XRTable xrTable6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell Textbox25;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeVolume1;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeOwnerGross1;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeOwnerTax1;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeOwnerDeducts1;
        private DevExpress.XtraReports.UI.XRTableCell TotalForCodeOwnerNet1;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel68;
        private DevExpress.XtraReports.UI.XRLabel xrLabel69;
        private DevExpress.XtraReports.UI.XRLabel xrLabel70;
        private DevExpress.XtraReports.UI.XRLabel xrLabel71;
        private DevExpress.XtraReports.UI.XRLabel xrLabel72;
        private DevExpress.XtraReports.UI.XRLabel xrLabel73;
        private DevExpress.XtraReports.UI.XRLabel xrLabel74;
        private DevExpress.XtraReports.UI.XRLabel xrLabel75;
        private DevExpress.XtraReports.UI.XRLabel xrLabel76;
        private DevExpress.XtraReports.UI.XRLabel xrLabel77;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectOwner;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectProperty;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowDetail;
    }
}
