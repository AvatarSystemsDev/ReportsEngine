namespace ReportsEngine
{
    partial class PA_LAR5D_DSP_Subreport
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PA_LAR5D_DSP_Subreport));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.PA_LAR_CODE = new DevExpress.XtraReports.UI.XRTableCell();
            this.PA_LAR_OPER = new DevExpress.XtraReports.UI.XRTableCell();
            this.PA_LAR_FPCODE = new DevExpress.XtraReports.UI.XRTableCell();
            this.PA_LAR_DESC = new DevExpress.XtraReports.UI.XRTableCell();
            this.PA_LAR_VOL = new DevExpress.XtraReports.UI.XRTableCell();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngDISTNO = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngFIELDCODE = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            // Tablix1
            // 
            this.Tablix1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details_table});
            this.Tablix1.HeightF = 25F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.Details_table.SizeF = new System.Drawing.SizeF(670F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.PA_LAR_CODE,
            this.PA_LAR_OPER,
            this.PA_LAR_FPCODE,
            this.PA_LAR_DESC,
            this.PA_LAR_VOL});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // PA_LAR_CODE
            // 
            this.PA_LAR_CODE.BorderColor = System.Drawing.Color.Black;
            this.PA_LAR_CODE.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PA_LAR_CODE.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PA_LAR_CODE.BorderWidth = 1F;
            this.PA_LAR_CODE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_CODE]")});
            this.PA_LAR_CODE.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.PA_LAR_CODE.KeepTogether = true;
            this.PA_LAR_CODE.Name = "PA_LAR_CODE";
            this.PA_LAR_CODE.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.PA_LAR_CODE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.PA_LAR_CODE.Weight = 0.089552238805970144D;
            // 
            // PA_LAR_OPER
            // 
            this.PA_LAR_OPER.BorderColor = System.Drawing.Color.Black;
            this.PA_LAR_OPER.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PA_LAR_OPER.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.PA_LAR_OPER.BorderWidth = 1.39F;
            this.PA_LAR_OPER.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_OPER]")});
            this.PA_LAR_OPER.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.PA_LAR_OPER.KeepTogether = true;
            this.PA_LAR_OPER.Name = "PA_LAR_OPER";
            this.PA_LAR_OPER.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.PA_LAR_OPER.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.PA_LAR_OPER.Weight = 0.1044776119402985D;
            // 
            // PA_LAR_FPCODE
            // 
            this.PA_LAR_FPCODE.BorderColor = System.Drawing.Color.Black;
            this.PA_LAR_FPCODE.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PA_LAR_FPCODE.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.PA_LAR_FPCODE.BorderWidth = 1.39F;
            this.PA_LAR_FPCODE.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_FPCODE]")});
            this.PA_LAR_FPCODE.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.PA_LAR_FPCODE.KeepTogether = true;
            this.PA_LAR_FPCODE.Name = "PA_LAR_FPCODE";
            this.PA_LAR_FPCODE.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.PA_LAR_FPCODE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.PA_LAR_FPCODE.Weight = 0.14925373134328357D;
            // 
            // PA_LAR_DESC
            // 
            this.PA_LAR_DESC.BorderColor = System.Drawing.Color.Black;
            this.PA_LAR_DESC.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PA_LAR_DESC.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.PA_LAR_DESC.BorderWidth = 1.39F;
            this.PA_LAR_DESC.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_DESC]")});
            this.PA_LAR_DESC.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.PA_LAR_DESC.KeepTogether = true;
            this.PA_LAR_DESC.Name = "PA_LAR_DESC";
            this.PA_LAR_DESC.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.PA_LAR_DESC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.PA_LAR_DESC.Weight = 0.4925373134328358D;
            // 
            // PA_LAR_VOL
            // 
            this.PA_LAR_VOL.BorderColor = System.Drawing.Color.Black;
            this.PA_LAR_VOL.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PA_LAR_VOL.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.PA_LAR_VOL.BorderWidth = 1.39F;
            this.PA_LAR_VOL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_VOL] + \'   \'")});
            this.PA_LAR_VOL.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.PA_LAR_VOL.KeepTogether = true;
            this.PA_LAR_VOL.Name = "PA_LAR_VOL";
            this.PA_LAR_VOL.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.PA_LAR_VOL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.PA_LAR_VOL.Weight = 0.16417910447761194D;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            customSqlQuery1.Name = "PALAR5DDSP";
            queryParameter1.Name = "plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            queryParameter2.Name = "plngDISTNO";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngDISTNO", typeof(string));
            queryParameter3.Name = "plngFIELDCODE";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?plngFIELDCODE", typeof(string));
            customSqlQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3});
            customSqlQuery1.Sql = "SELECT\n*\nFROM PALAR5DDSP\nWHERE CompanyID = @plngCompanyID AND PA_LAR_DISTNO = @pl" +
    "ngDISTNO AND PA_LAR_FIELDCODE = @plngFIELDCODE";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
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
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.Visible = false;
            // 
            // plngDISTNO
            // 
            this.plngDISTNO.Description = "plngDISTNO";
            this.plngDISTNO.Name = "plngDISTNO";
            this.plngDISTNO.Type = typeof(int);
            this.plngDISTNO.Visible = false;
            // 
            // plngFIELDCODE
            // 
            this.plngFIELDCODE.Description = "plngFIELDCODE";
            this.plngFIELDCODE.Name = "plngFIELDCODE";
            this.plngFIELDCODE.Type = typeof(int);
            this.plngFIELDCODE.Visible = false;
            // 
            // PA_LAR5D_DSP_Subreport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "PALAR5DDSP";
            this.DataSource = this.Dynamic;
            this.DisplayName = "PA_LAR5D_DSP_Subreport";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 0F, 0F);
            this.PageWidth = 670;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.plngCompanyID,
            this.plngDISTNO,
            this.plngFIELDCODE});
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
        private DevExpress.XtraReports.UI.XRTableCell PA_LAR_CODE;
        private DevExpress.XtraReports.UI.XRTableCell PA_LAR_OPER;
        private DevExpress.XtraReports.UI.XRTableCell PA_LAR_FPCODE;
        private DevExpress.XtraReports.UI.XRTableCell PA_LAR_DESC;
        private DevExpress.XtraReports.UI.XRTableCell PA_LAR_VOL;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter plngDISTNO;
        private DevExpress.XtraReports.Parameters.Parameter plngFIELDCODE;
    }
}
