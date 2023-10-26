namespace ReportsEngine.Reports.RDReports
{
    partial class JIBCompanyRecap
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JIBCompanyRecap));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.CompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Tablix1_Details_DetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.NewCharges = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.NewServiceCharges = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.NetCharges = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.OwnerShareNewCharges = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalNewCharges = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngJIBProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSCompaniesLookup";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "Companies_ReportLookup";
            storedProcQuery2.Name = "DSJIB_CompanyRecapReport";
            queryParameter2.Name = "@plngJIBProcessTrackingID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngJIBProcessTrackingID", typeof(string));
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter2});
            storedProcQuery2.StoredProcName = "Report_JIBCompanyRecap";
            storedProcQuery3.Name = "DSJIBProcessDatesLookup";
            queryParameter3.Name = "@plngCompanyID";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter4.Name = "@plngReportEnum";
            queryParameter4.Type = typeof(int);
            queryParameter4.ValueInfo = "5";
            storedProcQuery3.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter3,
            queryParameter4});
            storedProcQuery3.StoredProcName = "JIBReprint_GetProcessDates";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3});
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
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.CompanyName});
            this.detailBand1.HeightF = 55F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            // 
            // CompanyName
            // 
            this.CompanyName.BorderColor = System.Drawing.Color.Black;
            this.CompanyName.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CompanyName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CompanyName.BorderWidth = 1F;
            this.CompanyName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DSCompaniesLookup].[Description]")});
            this.CompanyName.Font = new DevExpress.Drawing.DXFont("Segoe UI Light", 12F);
            this.CompanyName.KeepTogether = true;
            this.CompanyName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.CompanyName.Multiline = true;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CompanyName.SizeF = new System.Drawing.SizeF(651.04F, 30F);
            this.CompanyName.StylePriority.UseFont = false;
            this.CompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Tablix1
            // 
            this.Tablix1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Tablix1_Details_DetailBand,
            this.ReportHeader});
            this.Tablix1.DataMember = "DSJIB_CompanyRecapReport";
            this.Tablix1.DataSource = this.Dynamic;
            this.Tablix1.Level = 0;
            this.Tablix1.Name = "Tablix1";
            // 
            // Tablix1_Details_DetailBand
            // 
            this.Tablix1_Details_DetailBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details_table});
            this.Tablix1_Details_DetailBand.HeightF = 130F;
            this.Tablix1_Details_DetailBand.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1_Details_DetailBand.Name = "Tablix1_Details_DetailBand";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(161.46F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow5,
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8});
            this.Details_table.SizeF = new System.Drawing.SizeF(313.54F, 130F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox35,
            this.NewCharges});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 0.15384615384615385D;
            // 
            // Textbox35
            // 
            this.Textbox35.BorderColor = System.Drawing.Color.Black;
            this.Textbox35.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox35.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox35.BorderWidth = 1F;
            this.Textbox35.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox35.KeepTogether = true;
            this.Textbox35.Name = "Textbox35";
            this.Textbox35.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox35.Text = "New Charges";
            this.Textbox35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox35.Weight = 5358878.5D;
            // 
            // NewCharges
            // 
            this.NewCharges.BorderColor = System.Drawing.Color.Black;
            this.NewCharges.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.NewCharges.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.NewCharges.BorderWidth = 1F;
            this.NewCharges.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NewCharges]")});
            this.NewCharges.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.NewCharges.KeepTogether = true;
            this.NewCharges.Name = "NewCharges";
            this.NewCharges.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.NewCharges.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.NewCharges.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.NewCharges.Weight = 4915200D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox31,
            this.NewServiceCharges});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 0.15384615384615385D;
            // 
            // Textbox31
            // 
            this.Textbox31.BorderColor = System.Drawing.Color.Black;
            this.Textbox31.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox31.BorderWidth = 1F;
            this.Textbox31.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox31.KeepTogether = true;
            this.Textbox31.Name = "Textbox31";
            this.Textbox31.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox31.Text = "Service Charges";
            this.Textbox31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox31.Weight = 5358878.5D;
            // 
            // NewServiceCharges
            // 
            this.NewServiceCharges.BorderColor = System.Drawing.Color.Black;
            this.NewServiceCharges.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.NewServiceCharges.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.NewServiceCharges.BorderWidth = 1F;
            this.NewServiceCharges.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NewServiceCharges]")});
            this.NewServiceCharges.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.NewServiceCharges.KeepTogether = true;
            this.NewServiceCharges.Name = "NewServiceCharges";
            this.NewServiceCharges.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.NewServiceCharges.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.NewServiceCharges.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.NewServiceCharges.Weight = 4915200D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox17,
            this.NetCharges});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 0.15384615384615385D;
            // 
            // Textbox17
            // 
            this.Textbox17.BorderColor = System.Drawing.Color.Black;
            this.Textbox17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox17.BorderWidth = 1F;
            this.Textbox17.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox17.KeepTogether = true;
            this.Textbox17.Name = "Textbox17";
            this.Textbox17.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox17.Text = "Net Charge A/R";
            this.Textbox17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox17.Weight = 5358878.5D;
            // 
            // NetCharges
            // 
            this.NetCharges.BorderColor = System.Drawing.Color.Black;
            this.NetCharges.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.NetCharges.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.NetCharges.BorderWidth = 1.39F;
            this.NetCharges.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NetCharges]")});
            this.NetCharges.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.NetCharges.KeepTogether = true;
            this.NetCharges.Name = "NetCharges";
            this.NetCharges.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.NetCharges.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.NetCharges.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.NetCharges.Weight = 4915200D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox21,
            this.Textbox22});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 0.076923076923076927D;
            // 
            // Textbox21
            // 
            this.Textbox21.BorderColor = System.Drawing.Color.Black;
            this.Textbox21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox21.BorderWidth = 1F;
            this.Textbox21.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox21.KeepTogether = true;
            this.Textbox21.Name = "Textbox21";
            this.Textbox21.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox21.Weight = 5358878.5D;
            // 
            // Textbox22
            // 
            this.Textbox22.BorderColor = System.Drawing.Color.Black;
            this.Textbox22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox22.BorderWidth = 1F;
            this.Textbox22.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox22.KeepTogether = true;
            this.Textbox22.Name = "Textbox22";
            this.Textbox22.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox22.Weight = 4915200D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox27,
            this.OwnerShareNewCharges});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 0.15384615384615385D;
            // 
            // Textbox27
            // 
            this.Textbox27.BorderColor = System.Drawing.Color.Black;
            this.Textbox27.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox27.BorderWidth = 1F;
            this.Textbox27.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox27.KeepTogether = true;
            this.Textbox27.Name = "Textbox27";
            this.Textbox27.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox27.Text = "Owner\'s Share";
            this.Textbox27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox27.Weight = 5358878.5D;
            // 
            // OwnerShareNewCharges
            // 
            this.OwnerShareNewCharges.BorderColor = System.Drawing.Color.Black;
            this.OwnerShareNewCharges.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.OwnerShareNewCharges.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.OwnerShareNewCharges.BorderWidth = 1F;
            this.OwnerShareNewCharges.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerShareNewCharges]")});
            this.OwnerShareNewCharges.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.OwnerShareNewCharges.KeepTogether = true;
            this.OwnerShareNewCharges.Name = "OwnerShareNewCharges";
            this.OwnerShareNewCharges.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.OwnerShareNewCharges.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.OwnerShareNewCharges.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.OwnerShareNewCharges.Weight = 4915200D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox1,
            this.TotalNewCharges});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 0.15384615384615385D;
            // 
            // Textbox1
            // 
            this.Textbox1.BorderColor = System.Drawing.Color.Black;
            this.Textbox1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox1.BorderWidth = 1F;
            this.Textbox1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox1.KeepTogether = true;
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox1.Text = "Total Charges";
            this.Textbox1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox1.Weight = 5358878.5D;
            // 
            // TotalNewCharges
            // 
            this.TotalNewCharges.BorderColor = System.Drawing.Color.Black;
            this.TotalNewCharges.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalNewCharges.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.TotalNewCharges.BorderWidth = 1.39F;
            this.TotalNewCharges.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalNewCharges]")});
            this.TotalNewCharges.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TotalNewCharges.KeepTogether = true;
            this.TotalNewCharges.Name = "TotalNewCharges";
            this.TotalNewCharges.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.TotalNewCharges.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.TotalNewCharges.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.TotalNewCharges.Weight = 4915200D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox43,
            this.Textbox19});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 0.15384615384615385D;
            // 
            // Textbox43
            // 
            this.Textbox43.BorderColor = System.Drawing.Color.Black;
            this.Textbox43.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox43.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox43.BorderWidth = 1F;
            this.Textbox43.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox43.KeepTogether = true;
            this.Textbox43.Name = "Textbox43";
            this.Textbox43.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox43.Weight = 5358878.5D;
            // 
            // Textbox19
            // 
            this.Textbox19.BorderColor = System.Drawing.Color.Black;
            this.Textbox19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox19.BorderWidth = 1F;
            this.Textbox19.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox19.KeepTogether = true;
            this.Textbox19.Name = "Textbox19";
            this.Textbox19.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox19.Weight = 4915200D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.ReportHeader.HeightF = 20F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(161.46F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(313.54F, 20F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox3,
            this.Textbox5});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // Textbox3
            // 
            this.Textbox3.BorderColor = System.Drawing.Color.Black;
            this.Textbox3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox3.BorderWidth = 1F;
            this.Textbox3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox3.KeepTogether = true;
            this.Textbox3.Name = "Textbox3";
            this.Textbox3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox3.Text = "Description";
            this.Textbox3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox3.Weight = 5358878.5D;
            // 
            // Textbox5
            // 
            this.Textbox5.BorderColor = System.Drawing.Color.Black;
            this.Textbox5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox5.BorderWidth = 1F;
            this.Textbox5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox5.KeepTogether = true;
            this.Textbox5.Name = "Textbox5";
            this.Textbox5.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox5.Text = "Amount";
            this.Textbox5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox5.Weight = 4915200D;
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
            // plngUserID
            // 
            this.plngUserID.Description = "plngUserID";
            this.plngUserID.Name = "plngUserID";
            this.plngUserID.Type = typeof(int);
            this.plngUserID.Visible = false;
            // 
            // plngJIBProcessTrackingID
            // 
            this.plngJIBProcessTrackingID.Description = "Processing Date";
            this.plngJIBProcessTrackingID.Name = "plngJIBProcessTrackingID";
            this.plngJIBProcessTrackingID.Type = typeof(int);
            this.plngJIBProcessTrackingID.ValueInfo = "0";
            dynamicListLookUpSettings2.DataMember = "DSJIBProcessDatesLookup";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "ProcessingDate";
            dynamicListLookUpSettings2.ValueMember = "ID";
            this.plngJIBProcessTrackingID.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Company Recap for \' + FormatString(\'{0:MM/dd/yyyy}\', [DSJIBProcessDatesLookup].[" +
                    "ProcessingDate])")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 30F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(651.04F, 25F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Company Recap for";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // JIBCompanyRecap
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.Tablix1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataSource = this.Dynamic;
            this.DisplayName = "JIBCompanyRecap";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(25F, 25F, 25F, 25F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngJIBProcessTrackingID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngCompanyID,
            this.plngUserID,
            this.plngJIBProcessTrackingID,
            this.Subtitle});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRLabel CompanyName;
        private DevExpress.XtraReports.UI.DetailReportBand Tablix1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell Textbox3;
        private DevExpress.XtraReports.UI.XRTableCell Textbox5;
        private DevExpress.XtraReports.UI.DetailBand Tablix1_Details_DetailBand;
        private DevExpress.XtraReports.UI.XRTable Details_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell Textbox35;
        private DevExpress.XtraReports.UI.XRTableCell NewCharges;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell Textbox31;
        private DevExpress.XtraReports.UI.XRTableCell NewServiceCharges;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell Textbox17;
        private DevExpress.XtraReports.UI.XRTableCell NetCharges;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell Textbox21;
        private DevExpress.XtraReports.UI.XRTableCell Textbox22;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell Textbox27;
        private DevExpress.XtraReports.UI.XRTableCell OwnerShareNewCharges;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell Textbox1;
        private DevExpress.XtraReports.UI.XRTableCell TotalNewCharges;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell Textbox43;
        private DevExpress.XtraReports.UI.XRTableCell Textbox19;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngJIBProcessTrackingID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
