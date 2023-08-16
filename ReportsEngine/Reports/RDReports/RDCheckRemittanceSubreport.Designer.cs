namespace ReportsEngine.Reports.RDReports
{
    partial class RDCheckRemittanceSubreport
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
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine1 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDCheckRemittanceSubreport));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Textbox7 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox8 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox9 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox10 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox11 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox12 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox13 = new DevExpress.XtraReports.UI.XRLabel();
            this.Line1 = new DevExpress.XtraReports.UI.XRShape();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Tablix1_Details_DetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.RemittanceLine = new DevExpress.XtraReports.UI.XRTableCell();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngRDCheckStubCodeID = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            this.Textbox7,
            this.Textbox8,
            this.Textbox9,
            this.Textbox10,
            this.Textbox11,
            this.Textbox12,
            this.Textbox13,
            this.Line1});
            this.detailBand1.HeightF = 29.16667F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            // 
            // Textbox7
            // 
            this.Textbox7.BorderColor = System.Drawing.Color.Black;
            this.Textbox7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox7.BorderWidth = 1F;
            this.Textbox7.CanGrow = false;
            this.Textbox7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox7.KeepTogether = true;
            this.Textbox7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Textbox7.Multiline = true;
            this.Textbox7.Name = "Textbox7";
            this.Textbox7.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox7.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.Textbox7.Text = "Property";
            this.Textbox7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox8
            // 
            this.Textbox8.BorderColor = System.Drawing.Color.Black;
            this.Textbox8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox8.BorderWidth = 1F;
            this.Textbox8.CanGrow = false;
            this.Textbox8.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox8.KeepTogether = true;
            this.Textbox8.LocationFloat = new DevExpress.Utils.PointFloat(163.02F, 0F);
            this.Textbox8.Multiline = true;
            this.Textbox8.Name = "Textbox8";
            this.Textbox8.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox8.SizeF = new System.Drawing.SizeF(74.31F, 25F);
            this.Textbox8.Text = "Prod/Date";
            this.Textbox8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox9
            // 
            this.Textbox9.BorderColor = System.Drawing.Color.Black;
            this.Textbox9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox9.BorderWidth = 1F;
            this.Textbox9.CanGrow = false;
            this.Textbox9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox9.KeepTogether = true;
            this.Textbox9.LocationFloat = new DevExpress.Utils.PointFloat(256.77F, 0F);
            this.Textbox9.Multiline = true;
            this.Textbox9.Name = "Textbox9";
            this.Textbox9.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox9.SizeF = new System.Drawing.SizeF(83.33F, 25F);
            this.Textbox9.Text = "Vol/Unt Prc";
            this.Textbox9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox10
            // 
            this.Textbox10.BorderColor = System.Drawing.Color.Black;
            this.Textbox10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox10.BorderWidth = 1F;
            this.Textbox10.CanGrow = false;
            this.Textbox10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox10.KeepTogether = true;
            this.Textbox10.LocationFloat = new DevExpress.Utils.PointFloat(391.15F, 0F);
            this.Textbox10.Multiline = true;
            this.Textbox10.Name = "Textbox10";
            this.Textbox10.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox10.SizeF = new System.Drawing.SizeF(56.25F, 25F);
            this.Textbox10.Text = "Gross";
            this.Textbox10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox11
            // 
            this.Textbox11.BorderColor = System.Drawing.Color.Black;
            this.Textbox11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox11.BorderWidth = 1F;
            this.Textbox11.CanGrow = false;
            this.Textbox11.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox11.KeepTogether = true;
            this.Textbox11.LocationFloat = new DevExpress.Utils.PointFloat(485.94F, 0F);
            this.Textbox11.Multiline = true;
            this.Textbox11.Name = "Textbox11";
            this.Textbox11.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox11.SizeF = new System.Drawing.SizeF(62.5F, 25F);
            this.Textbox11.Text = "Deducts";
            this.Textbox11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox12
            // 
            this.Textbox12.BorderColor = System.Drawing.Color.Black;
            this.Textbox12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox12.BorderWidth = 1F;
            this.Textbox12.CanGrow = false;
            this.Textbox12.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox12.KeepTogether = true;
            this.Textbox12.LocationFloat = new DevExpress.Utils.PointFloat(611.98F, 0F);
            this.Textbox12.Multiline = true;
            this.Textbox12.Name = "Textbox12";
            this.Textbox12.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox12.SizeF = new System.Drawing.SizeF(53.12F, 25F);
            this.Textbox12.Text = "Taxes";
            this.Textbox12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox13
            // 
            this.Textbox13.BorderColor = System.Drawing.Color.Black;
            this.Textbox13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox13.BorderWidth = 1F;
            this.Textbox13.CanGrow = false;
            this.Textbox13.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox13.KeepTogether = true;
            this.Textbox13.LocationFloat = new DevExpress.Utils.PointFloat(684.5499F, 0F);
            this.Textbox13.Multiline = true;
            this.Textbox13.Name = "Textbox13";
            this.Textbox13.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox13.SizeF = new System.Drawing.SizeF(85.42F, 25F);
            this.Textbox13.Text = "Owner Net";
            this.Textbox13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Line1
            // 
            this.Line1.Angle = 90;
            this.Line1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Line1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Line1.ForeColor = System.Drawing.Color.Black;
            this.Line1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.Line1.Name = "Line1";
            this.Line1.Shape = shapeLine1;
            this.Line1.SizeF = new System.Drawing.SizeF(784.9F, 2F);
            this.Line1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Tablix1
            // 
            this.Tablix1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Tablix1_Details_DetailBand});
            this.Tablix1.DataMember = "DSCheckRemittanceInformation";
            this.Tablix1.DataSource = this.Dynamic;
            this.Tablix1.Level = 0;
            this.Tablix1.Name = "Tablix1";
            // 
            // Tablix1_Details_DetailBand
            // 
            this.Tablix1_Details_DetailBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details_table});
            this.Tablix1_Details_DetailBand.HeightF = 19.79167F;
            this.Tablix1_Details_DetailBand.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1_Details_DetailBand.Name = "Tablix1_Details_DetailBand";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.Details_table.SizeF = new System.Drawing.SizeF(784.9F, 19.79167F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.RemittanceLine});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // RemittanceLine
            // 
            this.RemittanceLine.BorderColor = System.Drawing.Color.Black;
            this.RemittanceLine.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.RemittanceLine.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.RemittanceLine.BorderWidth = 1F;
            this.RemittanceLine.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RemittanceLine]")});
            this.RemittanceLine.Font = new DevExpress.Drawing.DXFont("Courier New", 9F);
            this.RemittanceLine.KeepTogether = true;
            this.RemittanceLine.Name = "RemittanceLine";
            this.RemittanceLine.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.RemittanceLine.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.RemittanceLine.Weight = 1D;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSCheckRemittanceInformation";
            queryParameter1.Name = "@plngID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngID", typeof(string));
            queryParameter2.Name = "@plngRDCheckStubCodeID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngRDCheckStubCodeID", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            storedProcQuery1.StoredProcName = "RDSuspenseRelease_GetCheckRemittanceInformation";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.BorderColor = System.Drawing.Color.Black;
            this.pageFooterBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageFooterBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageFooterBand1.BorderWidth = 1F;
            this.pageFooterBand1.HeightF = 1.04F;
            this.pageFooterBand1.Name = "pageFooterBand1";
            this.pageFooterBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.plngUserID.ValueInfo = "1";
            this.plngUserID.Visible = false;
            // 
            // plngID
            // 
            this.plngID.Description = "ID";
            this.plngID.Name = "plngID";
            this.plngID.Type = typeof(int);
            this.plngID.ValueInfo = "1095";
            // 
            // plngRDCheckStubCodeID
            // 
            this.plngRDCheckStubCodeID.Description = "RDCheck Stub Code";
            this.plngRDCheckStubCodeID.Name = "plngRDCheckStubCodeID";
            this.plngRDCheckStubCodeID.Type = typeof(int);
            this.plngRDCheckStubCodeID.ValueInfo = "1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(100F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(63.02F, 25F);
            this.xrLabel1.Text = "Decimal\r\n";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // RDCheckRemittanceSubreport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.Tablix1,
            this.pageFooterBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "DSCheckRemittanceInformation";
            this.DataSource = this.Dynamic;
            this.DisplayName = "RDCheckRemittanceSubreport";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(25F, 25F, 25F, 25F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngRDCheckStubCodeID, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.plngID,
            this.plngRDCheckStubCodeID});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRLabel Textbox7;
        private DevExpress.XtraReports.UI.XRLabel Textbox8;
        private DevExpress.XtraReports.UI.XRLabel Textbox9;
        private DevExpress.XtraReports.UI.XRLabel Textbox10;
        private DevExpress.XtraReports.UI.XRLabel Textbox11;
        private DevExpress.XtraReports.UI.XRLabel Textbox12;
        private DevExpress.XtraReports.UI.XRLabel Textbox13;
        private DevExpress.XtraReports.UI.XRShape Line1;
        private DevExpress.XtraReports.UI.DetailReportBand Tablix1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1_Details_DetailBand;
        private DevExpress.XtraReports.UI.XRTable Details_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell RemittanceLine;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngID;
        private DevExpress.XtraReports.Parameters.Parameter plngRDCheckStubCodeID;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
