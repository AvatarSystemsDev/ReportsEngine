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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualCheckRemittanceSubreport));
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine1 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngImbursementID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormatIsMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.pdteCheckDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEntity = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdblCheckAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrCheckNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooRunningAtEnd = new DevExpress.XtraReports.Parameters.Parameter();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.Textbox7 = new DevExpress.XtraReports.UI.XRLabel();
            this.Line1 = new DevExpress.XtraReports.UI.XRShape();
            this.xrPages = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCompanyHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
            this.plngOverflowOptionCodeID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrCompanyAddressBlockLong = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrHeaderBand = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
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
            this.xrLabel1});
            this.detailBand1.HeightF = 17F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RemittanceLine]")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(749.48F, 17F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.plngUserID.ValueInfo = "0";
            this.plngUserID.Visible = false;
            // 
            // plngImbursementID
            // 
            this.plngImbursementID.Description = "plng Imbursement ID";
            this.plngImbursementID.Name = "plngImbursementID";
            this.plngImbursementID.Type = typeof(int);
            this.plngImbursementID.ValueInfo = "1126";
            this.plngImbursementID.Visible = false;
            // 
            // plngCheckFormatIsMICR
            // 
            this.plngCheckFormatIsMICR.Description = "CheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Name = "plngCheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Type = typeof(bool);
            this.plngCheckFormatIsMICR.ValueInfo = "False";
            this.plngCheckFormatIsMICR.Visible = false;
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand2});
            // 
            // pdteCheckDate
            // 
            this.pdteCheckDate.Description = "Check Date";
            this.pdteCheckDate.Name = "pdteCheckDate";
            this.pdteCheckDate.Type = typeof(System.DateTime);
            this.pdteCheckDate.ValueInfo = "2024-02-28";
            this.pdteCheckDate.Visible = false;
            // 
            // pstrEntity
            // 
            this.pstrEntity.Description = "Entity";
            this.pstrEntity.Name = "pstrEntity";
            this.pstrEntity.Visible = false;
            // 
            // pdblCheckAmount
            // 
            this.pdblCheckAmount.Description = "Check Amount";
            this.pdblCheckAmount.Name = "pdblCheckAmount";
            this.pdblCheckAmount.Type = typeof(decimal);
            this.pdblCheckAmount.ValueInfo = "0";
            this.pdblCheckAmount.Visible = false;
            // 
            // pstrCheckNumber
            // 
            this.pstrCheckNumber.Description = "Check Number";
            this.pstrCheckNumber.Name = "pstrCheckNumber";
            this.pstrCheckNumber.Visible = false;
            // 
            // pbooRunningAtEnd
            // 
            this.pbooRunningAtEnd.Description = "Running At End";
            this.pbooRunningAtEnd.Name = "pbooRunningAtEnd";
            this.pbooRunningAtEnd.Type = typeof(bool);
            this.pbooRunningAtEnd.ValueInfo = "False";
            this.pbooRunningAtEnd.Visible = false;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPages,
            this.xrCompanyHeader,
            this.xrPanel2});
            this.SubBand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?pbooRunningAtEnd")});
            this.SubBand1.HeightF = 79.29214F;
            this.SubBand1.Name = "SubBand1";
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Line1,
            this.Textbox7});
            this.SubBand2.HeightF = 27F;
            this.SubBand2.Name = "SubBand2";
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
            this.Textbox7.SizeF = new System.Drawing.SizeF(541.67F, 20F);
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
            this.Line1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.Line1.Name = "Line1";
            this.Line1.Shape = shapeLine1;
            this.Line1.SizeF = new System.Drawing.SizeF(793.0002F, 2F);
            this.Line1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPages
            // 
            this.xrPages.BorderColor = System.Drawing.Color.Black;
            this.xrPages.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPages.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPages.BorderWidth = 1F;
            this.xrPages.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrPages.KeepTogether = true;
            this.xrPages.LocationFloat = new DevExpress.Utils.PointFloat(716.9999F, 0F);
            this.xrPages.Multiline = true;
            this.xrPages.Name = "xrPages";
            this.xrPages.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrPages.SizeF = new System.Drawing.SizeF(75.99994F, 18F);
            this.xrPages.StylePriority.UseBorderColor = false;
            this.xrPages.StylePriority.UseBorderDashStyle = false;
            this.xrPages.StylePriority.UseBorders = false;
            this.xrPages.StylePriority.UseBorderWidth = false;
            this.xrPages.StylePriority.UseFont = false;
            this.xrPages.StylePriority.UsePadding = false;
            this.xrPages.StylePriority.UseTextAlignment = false;
            this.xrPages.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrCompanyHeader
            // 
            this.xrCompanyHeader.BorderColor = System.Drawing.Color.Black;
            this.xrCompanyHeader.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrCompanyHeader.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCompanyHeader.BorderWidth = 1F;
            this.xrCompanyHeader.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pstrCompanyAddressBlockLong"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?pbooWillPrintCompanyAddressOnStub")});
            this.xrCompanyHeader.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrCompanyHeader.KeepTogether = true;
            this.xrCompanyHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCompanyHeader.Multiline = true;
            this.xrCompanyHeader.Name = "xrCompanyHeader";
            this.xrCompanyHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrCompanyHeader.SizeF = new System.Drawing.SizeF(794.0001F, 46.82214F);
            this.xrCompanyHeader.StylePriority.UseBorderColor = false;
            this.xrCompanyHeader.StylePriority.UseBorderDashStyle = false;
            this.xrCompanyHeader.StylePriority.UseBorders = false;
            this.xrCompanyHeader.StylePriority.UseBorderWidth = false;
            this.xrCompanyHeader.StylePriority.UseFont = false;
            this.xrCompanyHeader.StylePriority.UsePadding = false;
            this.xrCompanyHeader.StylePriority.UseTextAlignment = false;
            this.xrCompanyHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPanel2
            // 
            this.xrPanel2.BorderColor = System.Drawing.Color.Black;
            this.xrPanel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPanel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel2.BorderWidth = 1F;
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1,
            this.xrRichText2,
            this.xrRichText4,
            this.xrRichText5});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46.82214F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(794.1F, 32.47F);
            this.xrPanel2.StylePriority.UseBorders = false;
            // 
            // xrRichText1
            // 
            this.xrRichText1.BorderColor = System.Drawing.Color.Black;
            this.xrRichText1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText1.BorderWidth = 1F;
            this.xrRichText1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>CHECK " +
                    "NUMBER:</b><br>\' + ?pstrCheckNumber + \'</span>\'")});
            this.xrRichText1.KeepTogether = true;
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(202.73F, 3.490003F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(219.1F, 26.22F);
            // 
            // xrRichText2
            // 
            this.xrRichText2.BorderColor = System.Drawing.Color.Black;
            this.xrRichText2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText2.BorderWidth = 1F;
            this.xrRichText2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>DATE:<" +
                    "/b><br>\' + FormatString(\'{0:MM/dd/yyyy}\', ?pdteCheckDate) + \'</span>\'")});
            this.xrRichText2.KeepTogether = true;
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(431.8034F, 3.490067F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(132.29F, 26.21997F);
            // 
            // xrRichText4
            // 
            this.xrRichText4.BorderColor = System.Drawing.Color.Black;
            this.xrRichText4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText4.BorderWidth = 1F;
            this.xrRichText4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>AMOUNT" +
                    ":</b><br>\' + FormatString(\'{0:c2}\', ?pdblCheckAmount) + \'</span>\'")});
            this.xrRichText4.KeepTogether = true;
            this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(572.91F, 3.489939F);
            this.xrRichText4.Name = "xrRichText4";
            this.xrRichText4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
            this.xrRichText4.SizeF = new System.Drawing.SizeF(216.67F, 26.2201F);
            // 
            // xrRichText5
            // 
            this.xrRichText5.BorderColor = System.Drawing.Color.Black;
            this.xrRichText5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText5.BorderWidth = 1F;
            this.xrRichText5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>VENDOR" +
                    ": </b><br>\' + ?pstrEntity+ \'</span>\'")});
            this.xrRichText5.KeepTogether = true;
            this.xrRichText5.LocationFloat = new DevExpress.Utils.PointFloat(1.390012F, 3.489939F);
            this.xrRichText5.Name = "xrRichText5";
            this.xrRichText5.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
            this.xrRichText5.SizeF = new System.Drawing.SizeF(199.65F, 26.22007F);
            // 
            // plngOverflowOptionCodeID
            // 
            this.plngOverflowOptionCodeID.Description = "Overflow Option Code ID";
            this.plngOverflowOptionCodeID.Name = "plngOverflowOptionCodeID";
            this.plngOverflowOptionCodeID.Type = typeof(int);
            this.plngOverflowOptionCodeID.ValueInfo = "0";
            this.plngOverflowOptionCodeID.Visible = false;
            // 
            // pstrCompanyAddressBlockLong
            // 
            this.pstrCompanyAddressBlockLong.Description = "pstrCompanyAddressBlockLong";
            this.pstrCompanyAddressBlockLong.Name = "pstrCompanyAddressBlockLong";
            this.pstrCompanyAddressBlockLong.Visible = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrHeaderBand});
            this.ReportHeader.HeightF = 2.000002F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrHeaderBand
            // 
            this.xrHeaderBand.BorderColor = System.Drawing.Color.Black;
            this.xrHeaderBand.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrHeaderBand.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrHeaderBand.BorderWidth = 1F;
            this.xrHeaderBand.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrHeaderBand.KeepTogether = true;
            this.xrHeaderBand.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrHeaderBand.Multiline = true;
            this.xrHeaderBand.Name = "xrHeaderBand";
            this.xrHeaderBand.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrHeaderBand.SizeF = new System.Drawing.SizeF(794.0001F, 2.000002F);
            this.xrHeaderBand.StylePriority.UseBorderColor = false;
            this.xrHeaderBand.StylePriority.UseBorderDashStyle = false;
            this.xrHeaderBand.StylePriority.UseBorders = false;
            this.xrHeaderBand.StylePriority.UseBorderWidth = false;
            this.xrHeaderBand.StylePriority.UseFont = false;
            this.xrHeaderBand.StylePriority.UsePadding = false;
            this.xrHeaderBand.StylePriority.UseTextAlignment = false;
            this.xrHeaderBand.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ManualCheckRemittanceSubreport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.PageHeader,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "DSCheckRemittanceInformation";
            this.DataSource = this.Dynamic;
            this.DisplayName = "ManualCheckRemittanceSubreport";
            this.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "(?pbooRunningAtEnd And ([DataSource.RowCount]) > 32) Or (Not ?pbooRunningAtEnd An" +
                    "d ([DataSource.RowCount]) <= 32) Or ?plngOverflowOptionCodeID In (1, 2)\n")});
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 20F, 20F, 20F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngImbursementID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCheckFormatIsMICR, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteCheckDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEntity, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdblCheckAmount, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrCheckNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooRunningAtEnd, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngOverflowOptionCodeID, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.Subtitle,
            this.plngUserID,
            this.plngImbursementID,
            this.plngCheckFormatIsMICR,
            this.pdteCheckDate,
            this.pstrEntity,
            this.pdblCheckAmount,
            this.pstrCheckNumber,
            this.pbooRunningAtEnd,
            this.plngOverflowOptionCodeID,
            this.pstrCompanyAddressBlockLong});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngImbursementID;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormatIsMICR;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter pdteCheckDate;
        private DevExpress.XtraReports.Parameters.Parameter pstrEntity;
        private DevExpress.XtraReports.Parameters.Parameter pdblCheckAmount;
        private DevExpress.XtraReports.Parameters.Parameter pstrCheckNumber;
        private DevExpress.XtraReports.Parameters.Parameter pbooRunningAtEnd;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRLabel Textbox7;
        private DevExpress.XtraReports.UI.XRShape Line1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.XRLabel xrPages;
        private DevExpress.XtraReports.UI.XRLabel xrCompanyHeader;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText2;
        private DevExpress.XtraReports.UI.XRRichText xrRichText4;
        private DevExpress.XtraReports.UI.XRRichText xrRichText5;
        private DevExpress.XtraReports.Parameters.Parameter plngOverflowOptionCodeID;
        private DevExpress.XtraReports.Parameters.Parameter pstrCompanyAddressBlockLong;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrHeaderBand;
    }
}
