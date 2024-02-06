namespace ReportsEngine
{
    partial class ExcelJIBSuspenseAction
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelJIBSuspenseAction));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.InvoiceNumber = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PhaseWellShortRecordType = new DevExpress.XtraReports.UI.XRTableCell();
            this.PropertyNumber = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.JIBDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.WriteOffAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox7 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox46 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox9 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox10 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox20 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox21 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox23 = new DevExpress.XtraReports.UI.XRLabel();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdtePostDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngAccountID = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
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
            // Tablix1
            // 
            this.Tablix1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details_table});
            this.Tablix1.HeightF = 20F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            this.Tablix1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Number", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Textbox7,
            this.Textbox46,
            this.Textbox9,
            this.Textbox10,
            this.Textbox20,
            this.Textbox21,
            this.Textbox23});
            this.pageHeaderBand1.HeightF = 142.97F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.Details_table.SizeF = new System.Drawing.SizeF(797.92F, 20F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.InvoiceNumber,
            this.Textbox15,
            this.PhaseWellShortRecordType,
            this.PropertyNumber,
            this.Textbox3,
            this.JIBDate,
            this.WriteOffAmount});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.BorderColor = System.Drawing.Color.Black;
            this.InvoiceNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.InvoiceNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.InvoiceNumber.BorderWidth = 1F;
            this.InvoiceNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Number]")});
            this.InvoiceNumber.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.InvoiceNumber.KeepTogether = true;
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.InvoiceNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.InvoiceNumber.Weight = 0.10907108562676043D;
            // 
            // Textbox15
            // 
            this.Textbox15.BorderColor = System.Drawing.Color.Black;
            this.Textbox15.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox15.BorderWidth = 1F;
            this.Textbox15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[JIBInvoiceTypeCodeDescription]")});
            this.Textbox15.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox15.KeepTogether = true;
            this.Textbox15.Name = "Textbox15";
            this.Textbox15.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox15.Weight = 0.1012131590459539D;
            // 
            // PhaseWellShortRecordType
            // 
            this.PhaseWellShortRecordType.BorderColor = System.Drawing.Color.Black;
            this.PhaseWellShortRecordType.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PhaseWellShortRecordType.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PhaseWellShortRecordType.BorderWidth = 1F;
            this.PhaseWellShortRecordType.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PhaseWellShortRecordType]")});
            this.PhaseWellShortRecordType.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PhaseWellShortRecordType.KeepTogether = true;
            this.PhaseWellShortRecordType.Name = "PhaseWellShortRecordType";
            this.PhaseWellShortRecordType.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.PhaseWellShortRecordType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.PhaseWellShortRecordType.Weight = 0.081374074714064076D;
            // 
            // PropertyNumber
            // 
            this.PropertyNumber.BorderColor = System.Drawing.Color.Black;
            this.PropertyNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PropertyNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PropertyNumber.BorderWidth = 1F;
            this.PropertyNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PropertyAndWellNumber]")});
            this.PropertyNumber.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PropertyNumber.KeepTogether = true;
            this.PropertyNumber.Name = "PropertyNumber";
            this.PropertyNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.PropertyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.PropertyNumber.Weight = 0.13838480115039095D;
            // 
            // Textbox3
            // 
            this.Textbox3.BorderColor = System.Drawing.Color.Black;
            this.Textbox3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox3.BorderWidth = 1F;
            this.Textbox3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PhaseWellDescription]")});
            this.Textbox3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox3.KeepTogether = true;
            this.Textbox3.Name = "Textbox3";
            this.Textbox3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox3.Weight = 0.19277623147525369D;
            // 
            // JIBDate
            // 
            this.JIBDate.BorderColor = System.Drawing.Color.Black;
            this.JIBDate.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.JIBDate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.JIBDate.BorderWidth = 1F;
            this.JIBDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceDate]")});
            this.JIBDate.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.JIBDate.KeepTogether = true;
            this.JIBDate.Name = "JIBDate";
            this.JIBDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.JIBDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.JIBDate.TextFormatString = "{0:d}";
            this.JIBDate.Weight = 0.12532584988695508D;
            // 
            // WriteOffAmount
            // 
            this.WriteOffAmount.BorderColor = System.Drawing.Color.Black;
            this.WriteOffAmount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.WriteOffAmount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.WriteOffAmount.BorderWidth = 1F;
            this.WriteOffAmount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WriteOffAmount]")});
            this.WriteOffAmount.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.WriteOffAmount.KeepTogether = true;
            this.WriteOffAmount.Name = "WriteOffAmount";
            this.WriteOffAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.WriteOffAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.WriteOffAmount.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.WriteOffAmount.Weight = 0.25185483634703604D;
            // 
            // Textbox7
            // 
            this.Textbox7.BorderColor = System.Drawing.Color.Black;
            this.Textbox7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox7.BorderWidth = 1F;
            this.Textbox7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox7.KeepTogether = true;
            this.Textbox7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 97.49F);
            this.Textbox7.Multiline = true;
            this.Textbox7.Name = "Textbox7";
            this.Textbox7.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox7.SizeF = new System.Drawing.SizeF(87.03F, 20F);
            this.Textbox7.Text = "Invoice #";
            this.Textbox7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox46
            // 
            this.Textbox46.BorderColor = System.Drawing.Color.Black;
            this.Textbox46.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox46.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox46.BorderWidth = 1F;
            this.Textbox46.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox46.KeepTogether = true;
            this.Textbox46.LocationFloat = new DevExpress.Utils.PointFloat(596.96F, 97.49F);
            this.Textbox46.Multiline = true;
            this.Textbox46.Name = "Textbox46";
            this.Textbox46.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox46.SizeF = new System.Drawing.SizeF(200.96F, 20F);
            this.Textbox46.Text = "Write-Off Amount";
            this.Textbox46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox9
            // 
            this.Textbox9.BorderColor = System.Drawing.Color.Black;
            this.Textbox9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox9.BorderWidth = 1F;
            this.Textbox9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox9.KeepTogether = true;
            this.Textbox9.LocationFloat = new DevExpress.Utils.PointFloat(231.33F, 97.49F);
            this.Textbox9.Multiline = true;
            this.Textbox9.Name = "Textbox9";
            this.Textbox9.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox9.SizeF = new System.Drawing.SizeF(111.81F, 20F);
            this.Textbox9.Text = "Property/Well #";
            this.Textbox9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox10
            // 
            this.Textbox10.BorderColor = System.Drawing.Color.Black;
            this.Textbox10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox10.BorderWidth = 1F;
            this.Textbox10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox10.KeepTogether = true;
            this.Textbox10.LocationFloat = new DevExpress.Utils.PointFloat(496.96F, 97.58F);
            this.Textbox10.Multiline = true;
            this.Textbox10.Name = "Textbox10";
            this.Textbox10.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox10.SizeF = new System.Drawing.SizeF(100F, 20F);
            this.Textbox10.Text = "Invoice Date";
            this.Textbox10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox20
            // 
            this.Textbox20.BorderColor = System.Drawing.Color.Black;
            this.Textbox20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox20.BorderWidth = 1F;
            this.Textbox20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox20.KeepTogether = true;
            this.Textbox20.LocationFloat = new DevExpress.Utils.PointFloat(343.14F, 97.58F);
            this.Textbox20.Multiline = true;
            this.Textbox20.Name = "Textbox20";
            this.Textbox20.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox20.SizeF = new System.Drawing.SizeF(152.43F, 20F);
            this.Textbox20.Text = "Property/Well Desc";
            this.Textbox20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox21
            // 
            this.Textbox21.BorderColor = System.Drawing.Color.Black;
            this.Textbox21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox21.BorderWidth = 1F;
            this.Textbox21.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox21.KeepTogether = true;
            this.Textbox21.LocationFloat = new DevExpress.Utils.PointFloat(87.03F, 97.58F);
            this.Textbox21.Multiline = true;
            this.Textbox21.Name = "Textbox21";
            this.Textbox21.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox21.SizeF = new System.Drawing.SizeF(80.76F, 20F);
            this.Textbox21.Text = "Type";
            this.Textbox21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox23
            // 
            this.Textbox23.BorderColor = System.Drawing.Color.Black;
            this.Textbox23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox23.BorderWidth = 1F;
            this.Textbox23.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox23.KeepTogether = true;
            this.Textbox23.LocationFloat = new DevExpress.Utils.PointFloat(169.18F, 97.58F);
            this.Textbox23.Multiline = true;
            this.Textbox23.Name = "Textbox23";
            this.Textbox23.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox23.SizeF = new System.Drawing.SizeF(63.54F, 20F);
            this.Textbox23.Text = "P/W Type";
            this.Textbox23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Connection";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSCompaniesLookup";
            storedProcQuery1.StoredProcName = "Companies_ReportLookup";
            storedProcQuery2.Name = "JIBWriteOffMultipick";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            queryParameter2.Name = "@plngCreateUser";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngUserID", typeof(string));
            queryParameter3.Name = "@plngID";
            queryParameter3.Type = typeof(string);
            queryParameter3.ValueInfo = "-1";
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3});
            storedProcQuery2.StoredProcName = "JIB_WriteOff_Multipick_Select";
            storedProcQuery3.Name = "Accounts";
            queryParameter4.Name = "@plngCompanyID";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            storedProcQuery3.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter4});
            storedProcQuery3.StoredProcName = "Accounts_ReportLookup";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
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
            dynamicListLookUpSettings1.DataMember = "DSCompaniesLookup";
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
            // pdtePostDate
            // 
            this.pdtePostDate.Description = "pdtePostDate";
            this.pdtePostDate.Name = "pdtePostDate";
            this.pdtePostDate.Type = typeof(System.DateTime);
            this.pdtePostDate.Visible = false;
            // 
            // plngAccountID
            // 
            this.plngAccountID.Description = "plngAccountID";
            this.plngAccountID.Name = "plngAccountID";
            this.plngAccountID.Type = typeof(int);
            this.plngAccountID.Visible = false;
            // 
            // ExcelJIBSuspenseAction
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1,
            this.pageHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "JIBWriteOffMultipick";
            this.DataSource = this.Dynamic;
            this.DisplayName = "JIBWriteOffSelection";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 20F, 20F, 20F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.Subtitle,
            this.plngCompanyID,
            this.pbooShowCriteria,
            this.pdtePostDate,
            this.plngAccountID});
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
        private DevExpress.XtraReports.UI.XRTableCell InvoiceNumber;
        private DevExpress.XtraReports.UI.XRTableCell Textbox15;
        private DevExpress.XtraReports.UI.XRTableCell PhaseWellShortRecordType;
        private DevExpress.XtraReports.UI.XRTableCell PropertyNumber;
        private DevExpress.XtraReports.UI.XRTableCell Textbox3;
        private DevExpress.XtraReports.UI.XRTableCell JIBDate;
        private DevExpress.XtraReports.UI.XRTableCell WriteOffAmount;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel Textbox7;
        private DevExpress.XtraReports.UI.XRLabel Textbox46;
        private DevExpress.XtraReports.UI.XRLabel Textbox9;
        private DevExpress.XtraReports.UI.XRLabel Textbox10;
        private DevExpress.XtraReports.UI.XRLabel Textbox20;
        private DevExpress.XtraReports.UI.XRLabel Textbox21;
        private DevExpress.XtraReports.UI.XRLabel Textbox23;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.Parameters.Parameter pdtePostDate;
        private DevExpress.XtraReports.Parameters.Parameter plngAccountID;
    }
}
