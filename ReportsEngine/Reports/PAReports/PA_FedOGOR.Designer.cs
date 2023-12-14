namespace ReportsEngine.Reports.PAReports
{
    partial class PA_FedOGOR
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PA_FedOGOR));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BandPartA = new DevExpress.XtraReports.UI.SubBand();
            this.BandPartB = new DevExpress.XtraReports.UI.SubBand();
            this.BandPartC = new DevExpress.XtraReports.UI.SubBand();
            this.NextWellBand = new DevExpress.XtraReports.UI.SubBand();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngWellIDB = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngWellIDA = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngWellIDC = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.PartA = new DevExpress.XtraReports.UI.XRSubreport();
            this.PartB = new DevExpress.XtraReports.UI.XRSubreport();
            this.PartC = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "Companies";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "Companies_ReportLookup";
            customSqlQuery1.Name = "OGOR_H1";
            queryParameter2.Name = "plngCompanyID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            customSqlQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter2});
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            customSqlQuery2.Name = "OGOR_B";
            queryParameter3.Name = "plngCompanyID";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            customSqlQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter3});
            customSqlQuery2.Sql = "SELECT\nWellID as WellID_B\nFROM PAOGORLB\nWHERE CompanyID = @plngCompanyID";
            customSqlQuery3.Name = "OGOR_A";
            queryParameter4.Name = "plngCompanyID";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            customSqlQuery3.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter4});
            customSqlQuery3.Sql = "SELECT\nWellID as WellID_A\nFROM PAOGORLA\nWHERE CompanyID = @plngCompanyID";
            customSqlQuery4.Name = "OGOR_C";
            queryParameter5.Name = "plngCompanyID";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            customSqlQuery4.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter5});
            customSqlQuery4.Sql = "SELECT\nWellID as WellID_C\nFROM PAOGORLC\nWHERE CompanyID = @plngCompanyID";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3,
            customSqlQuery4});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 25F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 25F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // Tablix1
            // 
            this.Tablix1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.PartA,
            this.Details_table});
            this.Tablix1.HeightF = 25F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            this.Tablix1.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Tablix1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.BandPartA,
            this.BandPartB,
            this.BandPartC,
            this.NextWellBand});
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
            dynamicListLookUpSettings1.DataMember = "Companies";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.ValueMember = "ID";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings1;
            this.plngCompanyID.Visible = false;
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(2700F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.Details_table.SizeF = new System.Drawing.SizeF(1350F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Tablix control \'Subreport\' is not supported inside the table cell.";
            this.xrTableCell3.Weight = 1D;
            // 
            // BandPartA
            // 
            this.BandPartA.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WellID_H] in (?plngWellIDA)")});
            this.BandPartA.HeightF = 0F;
            this.BandPartA.Name = "BandPartA";
            // 
            // BandPartB
            // 
            this.BandPartB.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.PartB});
            this.BandPartB.HeightF = 24.61065F;
            this.BandPartB.Name = "BandPartB";
            // 
            // BandPartC
            // 
            this.BandPartC.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.PartC});
            this.BandPartC.HeightF = 24.61065F;
            this.BandPartC.Name = "BandPartC";
            // 
            // NextWellBand
            // 
            this.NextWellBand.HeightF = 0F;
            this.NextWellBand.Name = "NextWellBand";
            this.NextWellBand.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            // 
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // plngWellIDB
            // 
            this.plngWellIDB.MultiValue = true;
            this.plngWellIDB.Name = "plngWellIDB";
            this.plngWellIDB.SelectAllValues = true;
            this.plngWellIDB.Type = typeof(int);
            dynamicListLookUpSettings2.DataMember = "OGOR_B";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "WellID_B";
            dynamicListLookUpSettings2.FilterString = null;
            dynamicListLookUpSettings2.SortMember = null;
            dynamicListLookUpSettings2.ValueMember = "WellID_B";
            this.plngWellIDB.ValueSourceSettings = dynamicListLookUpSettings2;
            this.plngWellIDB.Visible = false;
            // 
            // plngWellIDA
            // 
            this.plngWellIDA.MultiValue = true;
            this.plngWellIDA.Name = "plngWellIDA";
            this.plngWellIDA.SelectAllValues = true;
            this.plngWellIDA.Type = typeof(int);
            dynamicListLookUpSettings3.DataMember = "OGOR_A";
            dynamicListLookUpSettings3.DataSource = this.Dynamic;
            dynamicListLookUpSettings3.DisplayMember = "WellID_A";
            dynamicListLookUpSettings3.FilterString = null;
            dynamicListLookUpSettings3.SortMember = null;
            dynamicListLookUpSettings3.ValueMember = "WellID_A";
            this.plngWellIDA.ValueSourceSettings = dynamicListLookUpSettings3;
            this.plngWellIDA.Visible = false;
            // 
            // plngWellIDC
            // 
            this.plngWellIDC.MultiValue = true;
            this.plngWellIDC.Name = "plngWellIDC";
            this.plngWellIDC.SelectAllValues = true;
            this.plngWellIDC.Type = typeof(int);
            dynamicListLookUpSettings4.DataMember = "OGOR_C";
            dynamicListLookUpSettings4.DataSource = this.Dynamic;
            dynamicListLookUpSettings4.DisplayMember = "WellID_C";
            dynamicListLookUpSettings4.FilterString = null;
            dynamicListLookUpSettings4.SortMember = null;
            dynamicListLookUpSettings4.ValueMember = "WellID_C";
            this.plngWellIDC.ValueSourceSettings = dynamicListLookUpSettings4;
            this.plngWellIDC.Visible = false;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
            this.PageFooter.HeightF = 18.00566F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.BackColor = System.Drawing.Color.Transparent;
            this.xrPageInfo1.BorderColor = System.Drawing.Color.Transparent;
            this.xrPageInfo1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(1229.9F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(120.1F, 18.00566F);
            this.xrPageInfo1.StylePriority.UseBackColor = false;
            this.xrPageInfo1.StylePriority.UseBorderColor = false;
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UsePadding = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrPageInfo1.TextFormatString = "Page {0} of {1}";
            // 
            // PartA
            // 
            this.PartA.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.PartA.Name = "PartA";
            this.PartA.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.PartA.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.PartA.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.PartA.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCompanyID", this.plngCompanyID));
            this.PartA.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngWellID", null, "OGOR_H1.WellID_H"));
            this.PartA.ReportSource = new ReportsEngine.Reports.PAReports.PA_FedOGOR_PartA_Subreport();
            this.PartA.SizeF = new System.Drawing.SizeF(1350F, 24.61065F);
            // 
            // PartB
            // 
            this.PartB.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.PartB.Name = "PartB";
            this.PartB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.PartB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.PartB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.PartB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCompanyID", this.plngCompanyID));
            this.PartB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngWellID", null, "OGOR_H1.WellID_H"));
            this.PartB.ReportSource = new ReportsEngine.Reports.PAReports.PA_FedOGOR_PartB_Subreport();
            this.PartB.SizeF = new System.Drawing.SizeF(1350F, 24.61065F);
            // 
            // PartC
            // 
            this.PartC.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.PartC.Name = "PartC";
            this.PartC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.PartC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.PartC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.PartC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCompanyID", this.plngCompanyID));
            this.PartC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngWellID", null, "OGOR_H1.WellID_H"));
            this.PartC.ReportSource = new ReportsEngine.Reports.PAReports.PA_FedOGOR_PartC_Subreport();
            this.PartC.SizeF = new System.Drawing.SizeF(1350F, 24.61065F);
            // 
            // PA_FedOGOR
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "OGOR_H1";
            this.DataSource = this.Dynamic;
            this.DisplayName = "PA_FedOGOR";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(25F, 25F, 25F, 25F);
            this.PageHeight = 850;
            this.PageWidth = 1400;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngWellIDA, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngWellIDB, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngWellIDC, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.plngCompanyID,
            this.Subtitle,
            this.plngWellIDA,
            this.plngWellIDB,
            this.plngWellIDC});
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
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngWellIDB;
        private DevExpress.XtraReports.Parameters.Parameter plngWellIDA;
        private DevExpress.XtraReports.Parameters.Parameter plngWellIDC;
        private DevExpress.XtraReports.UI.XRSubreport PartA;
        private DevExpress.XtraReports.UI.SubBand BandPartA;
        private DevExpress.XtraReports.UI.SubBand BandPartB;
        private DevExpress.XtraReports.UI.XRSubreport PartB;
        private DevExpress.XtraReports.UI.SubBand BandPartC;
        private DevExpress.XtraReports.UI.XRSubreport PartC;
        private DevExpress.XtraReports.UI.SubBand NextWellBand;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    }
}
