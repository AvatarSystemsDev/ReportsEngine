namespace ReportsEngine
{
    partial class ManualCheckRemittanceSubreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualCheckRemittanceSubreport));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Textbox7 = new DevExpress.XtraReports.UI.XRLabel();
            this.Line1 = new DevExpress.XtraReports.UI.XRShape();
            this.Tablix1_Details_DetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.RemittanceLine = new DevExpress.XtraReports.UI.XRTableCell();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngImbursementID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormatIsMICR = new DevExpress.XtraReports.Parameters.Parameter();
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
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Textbox7,
            this.Line1});
            this.detailBand1.HeightF = 32.08334F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
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
            // Textbox7
            // 
            this.Textbox7.BorderColor = System.Drawing.Color.Black;
            this.Textbox7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox7.BorderWidth = 1F;
            this.Textbox7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox7.KeepTogether = true;
            this.Textbox7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Textbox7.Multiline = true;
            this.Textbox7.Name = "Textbox7";
            this.Textbox7.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox7.SizeF = new System.Drawing.SizeF(541.67F, 25F);
            this.Textbox7.Text = "REMITTANCE INFORMATION";
            this.Textbox7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Line1
            // 
            this.Line1.Angle = 90;
            this.Line1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Line1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Line1.ForeColor = System.Drawing.Color.Black;
            this.Line1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.04F);
            this.Line1.Name = "Line1";
            this.Line1.Shape = shapeLine1;
            this.Line1.SizeF = new System.Drawing.SizeF(749.48F, 2F);
            this.Line1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Tablix1_Details_DetailBand
            // 
            this.Tablix1_Details_DetailBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details_table});
            this.Tablix1_Details_DetailBand.HeightF = 25F;
            this.Tablix1_Details_DetailBand.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1_Details_DetailBand.Name = "Tablix1_Details_DetailBand";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.Details_table.SizeF = new System.Drawing.SizeF(749.48F, 25F);
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
            queryParameter1.Name = "@plngImbursementID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngImbursementID", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "ManualCheckPrinting_GetCheckRemittanceInformation";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
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
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // plngUserID
            // 
            this.plngUserID.Description = "plngUserID";
            this.plngUserID.Name = "plngUserID";
            this.plngUserID.Type = typeof(int);
            this.plngUserID.Visible = false;
            // 
            // plngImbursementID
            // 
            this.plngImbursementID.Description = "plng Imbursement ID";
            this.plngImbursementID.Name = "plngImbursementID";
            this.plngImbursementID.Type = typeof(int);
            this.plngImbursementID.ValueInfo = "1126";
            // 
            // plngCheckFormatIsMICR
            // 
            this.plngCheckFormatIsMICR.Description = "CheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Name = "plngCheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Type = typeof(bool);
            // 
            // ManualCheckRemittanceSubreport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.Tablix1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DisplayName = "ManualCheckRemittanceSubreport";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 20F, 20F, 20F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.Subtitle,
            this.plngUserID,
            this.plngImbursementID,
            this.plngCheckFormatIsMICR});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRLabel Textbox7;
        private DevExpress.XtraReports.UI.XRShape Line1;
        private DevExpress.XtraReports.UI.DetailReportBand Tablix1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1_Details_DetailBand;
        private DevExpress.XtraReports.UI.XRTable Details_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell RemittanceLine;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngImbursementID;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormatIsMICR;
    }
}
