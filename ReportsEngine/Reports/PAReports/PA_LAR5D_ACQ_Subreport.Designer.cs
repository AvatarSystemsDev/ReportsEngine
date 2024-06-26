namespace ReportsEngine
{
    partial class PA_LAR5D_ACQ_Subreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PA_LAR5D_ACQ_Subreport));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngDISTNO = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngFIELDCODE = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowBorder = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrCrossBandBox8 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.xrCrossBandBox2 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.xrCrossBandBox3 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.xrCrossBandBox1 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.xrCrossBandBox4 = new DevExpress.XtraReports.UI.XRCrossBandBox();
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
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5});
            this.Tablix1.HeightF = 25F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1.39F;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_CODE]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(60F, 25F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1.39F;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_OPER]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(60F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(70F, 25F);
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
            this.xrLabel3.BorderWidth = 1.39F;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_FPCODE]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(130F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1.39F;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_DESC]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel4.KeepTogether = true;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(230F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(330F, 25F);
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.BorderWidth = 1.39F;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PA_LAR_VOL] + \'   \'"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel5.KeepTogether = true;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(561.4481F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(108.5519F, 25F);
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorderDashStyle = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            customSqlQuery1.Name = "PALAR5DACQ";
            queryParameter1.Name = "plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter2.Name = "plngDISTNO";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngDISTNO", typeof(int));
            queryParameter3.Name = "plngFIELDCODE";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?plngFIELDCODE", typeof(string));
            customSqlQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3});
            customSqlQuery1.Sql = "SELECT\r\n*\r\nFROM PALAR5DACQ\r\nWHERE CompanyID = @plngCompanyID AND PA_LAR_DISTNO = " +
    "@plngDISTNO AND PA_LAR_FIELDCODE = @plngFIELDCODE";
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
            this.plngCompanyID.ValueInfo = "0";
            this.plngCompanyID.Visible = false;
            // 
            // plngDISTNO
            // 
            this.plngDISTNO.Description = "plngDISTNO";
            this.plngDISTNO.Name = "plngDISTNO";
            this.plngDISTNO.Type = typeof(int);
            this.plngDISTNO.ValueInfo = "0";
            this.plngDISTNO.Visible = false;
            // 
            // plngFIELDCODE
            // 
            this.plngFIELDCODE.Description = "plngFIELDCODE";
            this.plngFIELDCODE.Name = "plngFIELDCODE";
            this.plngFIELDCODE.Visible = false;
            // 
            // pbooShowBorder
            // 
            this.pbooShowBorder.Description = "Show Border of ACQ";
            this.pbooShowBorder.Name = "pbooShowBorder";
            this.pbooShowBorder.Type = typeof(bool);
            this.pbooShowBorder.ValueInfo = "True";
            this.pbooShowBorder.Visible = false;
            // 
            // xrCrossBandBox8
            // 
            this.xrCrossBandBox8.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.None;
            this.xrCrossBandBox8.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrCrossBandBox8.BorderWidth = 1.39F;
            this.xrCrossBandBox8.EndBand = this.Tablix1;
            this.xrCrossBandBox8.EndPointFloat = new DevExpress.Utils.PointFloat(230F, 25F);
            this.xrCrossBandBox8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrCrossBandBox8.Name = "xrCrossBandBox8";
            this.xrCrossBandBox8.StartBand = this.Tablix1;
            this.xrCrossBandBox8.StartPointFloat = new DevExpress.Utils.PointFloat(230F, 0F);
            this.xrCrossBandBox8.WidthF = 330.0001F;
            // 
            // xrCrossBandBox2
            // 
            this.xrCrossBandBox2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.None;
            this.xrCrossBandBox2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrCrossBandBox2.BorderWidth = 1.39F;
            this.xrCrossBandBox2.EndBand = this.Tablix1;
            this.xrCrossBandBox2.EndPointFloat = new DevExpress.Utils.PointFloat(560.0001F, 25F);
            this.xrCrossBandBox2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrCrossBandBox2.Name = "xrCrossBandBox2";
            this.xrCrossBandBox2.StartBand = this.Tablix1;
            this.xrCrossBandBox2.StartPointFloat = new DevExpress.Utils.PointFloat(560.0001F, 0F);
            this.xrCrossBandBox2.WidthF = 109.9998F;
            // 
            // xrCrossBandBox3
            // 
            this.xrCrossBandBox3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.None;
            this.xrCrossBandBox3.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrCrossBandBox3.BorderWidth = 1.39F;
            this.xrCrossBandBox3.EndBand = this.Tablix1;
            this.xrCrossBandBox3.EndPointFloat = new DevExpress.Utils.PointFloat(130F, 25F);
            this.xrCrossBandBox3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrCrossBandBox3.Name = "xrCrossBandBox3";
            this.xrCrossBandBox3.StartBand = this.Tablix1;
            this.xrCrossBandBox3.StartPointFloat = new DevExpress.Utils.PointFloat(130F, 0F);
            this.xrCrossBandBox3.WidthF = 101.448F;
            // 
            // xrCrossBandBox1
            // 
            this.xrCrossBandBox1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.None;
            this.xrCrossBandBox1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrCrossBandBox1.BorderWidth = 1.39F;
            this.xrCrossBandBox1.EndBand = this.Tablix1;
            this.xrCrossBandBox1.EndPointFloat = new DevExpress.Utils.PointFloat(59.99997F, 25F);
            this.xrCrossBandBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrCrossBandBox1.Name = "xrCrossBandBox1";
            this.xrCrossBandBox1.StartBand = this.Tablix1;
            this.xrCrossBandBox1.StartPointFloat = new DevExpress.Utils.PointFloat(59.99997F, 0F);
            this.xrCrossBandBox1.WidthF = 71.44795F;
            // 
            // xrCrossBandBox4
            // 
            this.xrCrossBandBox4.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.None;
            this.xrCrossBandBox4.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrCrossBandBox4.BorderWidth = 1.39F;
            this.xrCrossBandBox4.EndBand = this.Tablix1;
            this.xrCrossBandBox4.EndPointFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.xrCrossBandBox4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderWidth", "Iif(?pbooShowBorder,1.39 ,0 )\n")});
            this.xrCrossBandBox4.Name = "xrCrossBandBox4";
            this.xrCrossBandBox4.StartBand = this.Tablix1;
            this.xrCrossBandBox4.StartPointFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCrossBandBox4.WidthF = 59.99997F;
            // 
            // PA_LAR5D_ACQ_Subreport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1});
            this.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandBox4,
            this.xrCrossBandBox1,
            this.xrCrossBandBox3,
            this.xrCrossBandBox2,
            this.xrCrossBandBox8});
            this.DataMember = "PALAR5DACQ";
            this.DataSource = this.Dynamic;
            this.DisplayName = "PA_LAR5D_ACQ_Subreport";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 0F, 0F);
            this.PageWidth = 670;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngDISTNO, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngFIELDCODE, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowBorder, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.plngCompanyID,
            this.plngDISTNO,
            this.plngFIELDCODE,
            this.pbooShowBorder});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter plngDISTNO;
        private DevExpress.XtraReports.Parameters.Parameter plngFIELDCODE;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowBorder;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox2;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox3;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox1;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox4;
    }
}
