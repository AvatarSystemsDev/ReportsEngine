namespace ReportsEngine
{
    partial class ManualChecks
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
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine2 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualChecks));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.RemittanceDetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormatIsMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.CheckBeginningHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.Rectangle5 = new DevExpress.XtraReports.UI.XRPanel();
            this.Textbox24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCheckNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMICRAccountNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMICRTransitNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountLongString15 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountLongString14 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox18 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountShortString4 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox14 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox16 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckDate2 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountLongString11 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountShortString3 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox23 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox20 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountLongString12 = new DevExpress.XtraReports.UI.XRLabel();
            this.Line3 = new DevExpress.XtraReports.UI.XRShape();
            this.Image2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.Line2 = new DevExpress.XtraReports.UI.XRShape();
            this.Textbox22 = new DevExpress.XtraReports.UI.XRLabel();
            this.Rectangle3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText6 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText7 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText8 = new DevExpress.XtraReports.UI.XRRichText();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pbooMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormat = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSignaturePath = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrTwoSignaturesRequiredAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngIsTwoSignaturesRequired = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.CheckBegin = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.CheckEnd = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPages = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrNonNegotiablePicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 18F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 18F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.HeightF = 0F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            // 
            // Tablix1
            // 
            this.Tablix1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.RemittanceDetailBand,
            this.CheckBeginningHeader,
            this.groupFooterBand1,
            this.CheckBegin,
            this.CheckEnd});
            this.Tablix1.DataMember = "DSCheckHeader";
            this.Tablix1.DataSource = this.Dynamic;
            this.Tablix1.Level = 0;
            this.Tablix1.Name = "Tablix1";
            // 
            // RemittanceDetailBand
            // 
            this.RemittanceDetailBand.HeightF = 0F;
            this.RemittanceDetailBand.MultiColumn.ColumnSpacing = 50F;
            this.RemittanceDetailBand.Name = "RemittanceDetailBand";
            this.RemittanceDetailBand.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1});
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2});
            this.SubBand1.HeightF = 24.61065F;
            this.SubBand1.Name = "SubBand1";
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
            this.plngUserID.Visible = false;
            // 
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // plngCheckFormatIsMICR
            // 
            this.plngCheckFormatIsMICR.Description = "plngCheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Name = "plngCheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Type = typeof(bool);
            this.plngCheckFormatIsMICR.ValueInfo = "True";
            this.plngCheckFormatIsMICR.Visible = false;
            // 
            // CheckBeginningHeader
            // 
            this.CheckBeginningHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrPages});
            this.CheckBeginningHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CheckNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("CheckID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CheckBeginningHeader.HeightF = 46.82214F;
            this.CheckBeginningHeader.Name = "CheckBeginningHeader";
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Rectangle5});
            this.groupFooterBand1.HeightF = 352.9583F;
            this.groupFooterBand1.Name = "groupFooterBand1";
            this.groupFooterBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.groupFooterBand1.PrintAtBottom = true;
            // 
            // Rectangle5
            // 
            this.Rectangle5.BorderColor = System.Drawing.Color.Black;
            this.Rectangle5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Rectangle5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Rectangle5.BorderWidth = 1F;
            this.Rectangle5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.Textbox24,
            this.xrCheckNumber,
            this.xrMICRAccountNumber,
            this.xrMICRTransitNumber,
            this.CheckAmountLongString15,
            this.CheckAmountLongString14,
            this.Textbox18,
            this.CheckAmountShortString4,
            this.Textbox14,
            this.Textbox16,
            this.CheckDate2,
            this.CheckAmountLongString11,
            this.CheckAmountShortString3,
            this.Textbox23,
            this.Textbox20,
            this.CheckAmountLongString12,
            this.Line3,
            this.Image2,
            this.Line2,
            this.Textbox22,
            this.Rectangle3,
            this.xrNonNegotiablePicture});
            this.Rectangle5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Rectangle5.Name = "Rectangle5";
            this.Rectangle5.SizeF = new System.Drawing.SizeF(794.0999F, 352.9583F);
            // 
            // Textbox24
            // 
            this.Textbox24.BorderColor = System.Drawing.Color.Black;
            this.Textbox24.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox24.BorderWidth = 1F;
            this.Textbox24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.Textbox24.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox24.KeepTogether = true;
            this.Textbox24.LocationFloat = new DevExpress.Utils.PointFloat(5.35F, 39.41F);
            this.Textbox24.Multiline = true;
            this.Textbox24.Name = "Textbox24";
            this.Textbox24.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox24.SizeF = new System.Drawing.SizeF(780.21F, 20.83F);
            this.Textbox24.Text = "PLEASE DETACH THIS REMITTANCE ADVICE BEFORE DEPOSITING CHECK";
            this.Textbox24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrCheckNumber
            // 
            this.xrCheckNumber.BorderColor = System.Drawing.Color.Black;
            this.xrCheckNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrCheckNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCheckNumber.BorderWidth = 1F;
            this.xrCheckNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Name", "Iif(?pbitMICR = True, \'MICRE13B\', \'Segoe UI\')"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'⑈\'+[SerialNumber]+\'⑈\'")});
            this.xrCheckNumber.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
            this.xrCheckNumber.KeepTogether = true;
            this.xrCheckNumber.LocationFloat = new DevExpress.Utils.PointFloat(27.43F, 327.67F);
            this.xrCheckNumber.Multiline = true;
            this.xrCheckNumber.Name = "xrCheckNumber";
            this.xrCheckNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrCheckNumber.SizeF = new System.Drawing.SizeF(185.42F, 25F);
            this.xrCheckNumber.StylePriority.UseFont = false;
            this.xrCheckNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMICRAccountNumber
            // 
            this.xrMICRAccountNumber.BorderColor = System.Drawing.Color.Black;
            this.xrMICRAccountNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMICRAccountNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMICRAccountNumber.BorderWidth = 1F;
            this.xrMICRAccountNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Name", "Iif(?pbitMICR = True, \'MICRE13B\', \'Segoe UI\')"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountNumber]+\'⑈\'")});
            this.xrMICRAccountNumber.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
            this.xrMICRAccountNumber.KeepTogether = true;
            this.xrMICRAccountNumber.LocationFloat = new DevExpress.Utils.PointFloat(388.49F, 327.67F);
            this.xrMICRAccountNumber.Multiline = true;
            this.xrMICRAccountNumber.Name = "xrMICRAccountNumber";
            this.xrMICRAccountNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrMICRAccountNumber.SizeF = new System.Drawing.SizeF(202.48F, 25F);
            this.xrMICRAccountNumber.StylePriority.UseFont = false;
            this.xrMICRAccountNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrMICRTransitNumber
            // 
            this.xrMICRTransitNumber.BorderColor = System.Drawing.Color.Black;
            this.xrMICRTransitNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMICRTransitNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMICRTransitNumber.BorderWidth = 1F;
            this.xrMICRTransitNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Name", "Iif(?pbitMICR = True, \'MICRE13B\', \'Segoe UI\')"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'⑆\'+[TransitNumber]+\'⑆\'")});
            this.xrMICRTransitNumber.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
            this.xrMICRTransitNumber.KeepTogether = true;
            this.xrMICRTransitNumber.LocationFloat = new DevExpress.Utils.PointFloat(228.08F, 327.67F);
            this.xrMICRTransitNumber.Multiline = true;
            this.xrMICRTransitNumber.Name = "xrMICRTransitNumber";
            this.xrMICRTransitNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrMICRTransitNumber.SizeF = new System.Drawing.SizeF(143.75F, 25F);
            this.xrMICRTransitNumber.StylePriority.UseFont = false;
            this.xrMICRTransitNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CheckAmountLongString15
            // 
            this.CheckAmountLongString15.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountLongString15.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountLongString15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountLongString15.BorderWidth = 1F;
            this.CheckAmountLongString15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BankAddressBlock]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.CheckAmountLongString15.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountLongString15.KeepTogether = true;
            this.CheckAmountLongString15.LocationFloat = new DevExpress.Utils.PointFloat(344.4399F, 78.35001F);
            this.CheckAmountLongString15.Multiline = true;
            this.CheckAmountLongString15.Name = "CheckAmountLongString15";
            this.CheckAmountLongString15.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountLongString15.SizeF = new System.Drawing.SizeF(171.88F, 89.10997F);
            this.CheckAmountLongString15.StylePriority.UseFont = false;
            this.CheckAmountLongString15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CheckAmountLongString14
            // 
            this.CheckAmountLongString14.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountLongString14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountLongString14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountLongString14.BorderWidth = 1F;
            this.CheckAmountLongString14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyAddressBlockLong]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.CheckAmountLongString14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountLongString14.KeepTogether = true;
            this.CheckAmountLongString14.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 82.35001F);
            this.CheckAmountLongString14.Multiline = true;
            this.CheckAmountLongString14.Name = "CheckAmountLongString14";
            this.CheckAmountLongString14.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountLongString14.SizeF = new System.Drawing.SizeF(178.1284F, 65.62002F);
            this.CheckAmountLongString14.StylePriority.UseFont = false;
            this.CheckAmountLongString14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox18
            // 
            this.Textbox18.BorderColor = System.Drawing.Color.Black;
            this.Textbox18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox18.BorderWidth = 1F;
            this.Textbox18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.Textbox18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox18.KeepTogether = true;
            this.Textbox18.LocationFloat = new DevExpress.Utils.PointFloat(625.3499F, 78.35001F);
            this.Textbox18.Multiline = true;
            this.Textbox18.Name = "Textbox18";
            this.Textbox18.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox18.SizeF = new System.Drawing.SizeF(156.2401F, 20.82999F);
            this.Textbox18.StylePriority.UseFont = false;
            this.Textbox18.Text = "CHECK NUMBER";
            this.Textbox18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // CheckAmountShortString4
            // 
            this.CheckAmountShortString4.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountShortString4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountShortString4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountShortString4.BorderWidth = 1F;
            this.CheckAmountShortString4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckNumber]")});
            this.CheckAmountShortString4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountShortString4.KeepTogether = true;
            this.CheckAmountShortString4.LocationFloat = new DevExpress.Utils.PointFloat(625.35F, 106.13F);
            this.CheckAmountShortString4.Multiline = true;
            this.CheckAmountShortString4.Name = "CheckAmountShortString4";
            this.CheckAmountShortString4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountShortString4.SizeF = new System.Drawing.SizeF(156.25F, 25F);
            this.CheckAmountShortString4.StylePriority.UseFont = false;
            this.CheckAmountShortString4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Textbox14
            // 
            this.Textbox14.BorderColor = System.Drawing.Color.Black;
            this.Textbox14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox14.BorderWidth = 1F;
            this.Textbox14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.Textbox14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox14.KeepTogether = true;
            this.Textbox14.LocationFloat = new DevExpress.Utils.PointFloat(524.4901F, 78.35001F);
            this.Textbox14.Multiline = true;
            this.Textbox14.Name = "Textbox14";
            this.Textbox14.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox14.SizeF = new System.Drawing.SizeF(83.33997F, 20.83F);
            this.Textbox14.StylePriority.UseFont = false;
            this.Textbox14.StylePriority.UseTextAlignment = false;
            this.Textbox14.Text = "DATE";
            this.Textbox14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox16
            // 
            this.Textbox16.BorderColor = System.Drawing.Color.Black;
            this.Textbox16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox16.BorderWidth = 1F;
            this.Textbox16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.Textbox16.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox16.KeepTogether = true;
            this.Textbox16.LocationFloat = new DevExpress.Utils.PointFloat(696.1799F, 146.63F);
            this.Textbox16.Multiline = true;
            this.Textbox16.Name = "Textbox16";
            this.Textbox16.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox16.SizeF = new System.Drawing.SizeF(85.41016F, 20.83F);
            this.Textbox16.StylePriority.UseFont = false;
            this.Textbox16.Text = "AMOUNT";
            this.Textbox16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // CheckDate2
            // 
            this.CheckDate2.BorderColor = System.Drawing.Color.Black;
            this.CheckDate2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckDate2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckDate2.BorderWidth = 1F;
            this.CheckDate2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckDate]")});
            this.CheckDate2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckDate2.KeepTogether = true;
            this.CheckDate2.LocationFloat = new DevExpress.Utils.PointFloat(524.4901F, 106.13F);
            this.CheckDate2.Multiline = true;
            this.CheckDate2.Name = "CheckDate2";
            this.CheckDate2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckDate2.SizeF = new System.Drawing.SizeF(83.33F, 25F);
            this.CheckDate2.StylePriority.UseFont = false;
            this.CheckDate2.StylePriority.UseTextAlignment = false;
            this.CheckDate2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.CheckDate2.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // CheckAmountLongString11
            // 
            this.CheckAmountLongString11.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountLongString11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountLongString11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountLongString11.BorderWidth = 1F;
            this.CheckAmountLongString11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckAmountLongString]")});
            this.CheckAmountLongString11.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountLongString11.KeepTogether = true;
            this.CheckAmountLongString11.LocationFloat = new DevExpress.Utils.PointFloat(11.80999F, 174.4F);
            this.CheckAmountLongString11.Multiline = true;
            this.CheckAmountLongString11.Name = "CheckAmountLongString11";
            this.CheckAmountLongString11.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountLongString11.SizeF = new System.Drawing.SizeF(590.6183F, 25F);
            this.CheckAmountLongString11.StylePriority.UseFont = false;
            this.CheckAmountLongString11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CheckAmountShortString3
            // 
            this.CheckAmountShortString3.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountShortString3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountShortString3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountShortString3.BorderWidth = 1F;
            this.CheckAmountShortString3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckAmountShortString]")});
            this.CheckAmountShortString3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountShortString3.KeepTogether = true;
            this.CheckAmountShortString3.LocationFloat = new DevExpress.Utils.PointFloat(625.35F, 174.41F);
            this.CheckAmountShortString3.Multiline = true;
            this.CheckAmountShortString3.Name = "CheckAmountShortString3";
            this.CheckAmountShortString3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountShortString3.SizeF = new System.Drawing.SizeF(156.25F, 25F);
            this.CheckAmountShortString3.StylePriority.UseFont = false;
            this.CheckAmountShortString3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Textbox23
            // 
            this.Textbox23.BorderColor = System.Drawing.Color.Black;
            this.Textbox23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox23.BorderWidth = 1F;
            this.Textbox23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\' TWO SIGNATURES REQUIRED OVER \' + ?pstrTwoSignaturesRequiredAmount"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngIsTwoSignaturesRequired = True, True, False)")});
            this.Textbox23.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Textbox23.KeepTogether = true;
            this.Textbox23.LocationFloat = new DevExpress.Utils.PointFloat(418.3983F, 199.41F);
            this.Textbox23.Multiline = true;
            this.Textbox23.Name = "Textbox23";
            this.Textbox23.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox23.SizeF = new System.Drawing.SizeF(363.1917F, 19.28001F);
            this.Textbox23.StylePriority.UseFont = false;
            this.Textbox23.StylePriority.UseTextAlignment = false;
            this.Textbox23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Textbox20
            // 
            this.Textbox20.BorderColor = System.Drawing.Color.Black;
            this.Textbox20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox20.BorderWidth = 1F;
            this.Textbox20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.Textbox20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox20.KeepTogether = true;
            this.Textbox20.LocationFloat = new DevExpress.Utils.PointFloat(1.390012F, 223.14F);
            this.Textbox20.Multiline = true;
            this.Textbox20.Name = "Textbox20";
            this.Textbox20.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox20.SizeF = new System.Drawing.SizeF(83.33F, 72.92004F);
            this.Textbox20.StylePriority.UseFont = false;
            this.Textbox20.Text = "PAY\r\nTO THE\r\nORDER OF";
            this.Textbox20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CheckAmountLongString12
            // 
            this.CheckAmountLongString12.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountLongString12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountLongString12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountLongString12.BorderWidth = 1F;
            this.CheckAmountLongString12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerAddressBlock]")});
            this.CheckAmountLongString12.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountLongString12.KeepTogether = true;
            this.CheckAmountLongString12.LocationFloat = new DevExpress.Utils.PointFloat(98.91F, 223.14F);
            this.CheckAmountLongString12.Multiline = true;
            this.CheckAmountLongString12.Name = "CheckAmountLongString12";
            this.CheckAmountLongString12.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountLongString12.SizeF = new System.Drawing.SizeF(322.92F, 87.5F);
            this.CheckAmountLongString12.StylePriority.UseFont = false;
            this.CheckAmountLongString12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Line3
            // 
            this.Line3.Angle = 270;
            this.Line3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Line3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Line3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngIsTwoSignaturesRequired = True, True, False)")});
            this.Line3.ForeColor = System.Drawing.Color.Black;
            this.Line3.LocationFloat = new DevExpress.Utils.PointFloat(529.51F, 254.09F);
            this.Line3.Name = "Line3";
            this.Line3.Shape = shapeLine1;
            this.Line3.SizeF = new System.Drawing.SizeF(257.29F, 2F);
            this.Line3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Image2
            // 
            this.Image2.BorderColor = System.Drawing.Color.Black;
            this.Image2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Image2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Image2.BorderWidth = 1F;
            this.Image2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageUrl", "?pstrSignPath")});
            this.Image2.LocationFloat = new DevExpress.Utils.PointFloat(534.91F, 259.65F);
            this.Image2.Name = "Image2";
            this.Image2.SizeF = new System.Drawing.SizeF(250.64F, 36.41F);
            this.Image2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // Line2
            // 
            this.Line2.Angle = 270;
            this.Line2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Line2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Line2.ForeColor = System.Drawing.Color.Black;
            this.Line2.LocationFloat = new DevExpress.Utils.PointFloat(529.51F, 300.19F);
            this.Line2.Name = "Line2";
            this.Line2.Shape = shapeLine2;
            this.Line2.SizeF = new System.Drawing.SizeF(257.29F, 2F);
            this.Line2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox22
            // 
            this.Textbox22.BorderColor = System.Drawing.Color.Black;
            this.Textbox22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox22.BorderWidth = 1F;
            this.Textbox22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.Textbox22.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox22.KeepTogether = true;
            this.Textbox22.LocationFloat = new DevExpress.Utils.PointFloat(529.51F, 303F);
            this.Textbox22.Multiline = true;
            this.Textbox22.Name = "Textbox22";
            this.Textbox22.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 1, 3, 1, 100F);
            this.Textbox22.SizeF = new System.Drawing.SizeF(252.08F, 19.11F);
            this.Textbox22.StylePriority.UseFont = false;
            this.Textbox22.Text = "VOID IF NOT CASHED WITHIN 60 DAYS";
            this.Textbox22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Rectangle3
            // 
            this.Rectangle3.BorderColor = System.Drawing.Color.Black;
            this.Rectangle3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Rectangle3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Rectangle3.BorderWidth = 1F;
            this.Rectangle3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText3,
            this.xrRichText6,
            this.xrRichText7,
            this.xrRichText8});
            this.Rectangle3.LocationFloat = new DevExpress.Utils.PointFloat(1.25F, 0F);
            this.Rectangle3.Name = "Rectangle3";
            this.Rectangle3.SizeF = new System.Drawing.SizeF(781.6F, 32.47F);
            // 
            // xrRichText3
            // 
            this.xrRichText3.BorderColor = System.Drawing.Color.Black;
            this.xrRichText3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText3.BorderWidth = 1F;
            this.xrRichText3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>CHECK:" +
                    "</b><br>\' + [CheckNumber] + \'</span>\'")});
            this.xrRichText3.KeepTogether = true;
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(210.0698F, 3.490003F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(219.0999F, 26.22F);
            // 
            // xrRichText6
            // 
            this.xrRichText6.BorderColor = System.Drawing.Color.Black;
            this.xrRichText6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText6.BorderWidth = 1F;
            this.xrRichText6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>DATE:<" +
                    "/b><br>\' + FormatString(\'{0:d}\', [CheckDate]) + \'</span>\'")});
            this.xrRichText6.KeepTogether = true;
            this.xrRichText6.LocationFloat = new DevExpress.Utils.PointFloat(434.7199F, 3.490098F);
            this.xrRichText6.Name = "xrRichText6";
            this.xrRichText6.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString");
            this.xrRichText6.SizeF = new System.Drawing.SizeF(126.0399F, 26.21997F);
            // 
            // xrRichText7
            // 
            this.xrRichText7.BorderColor = System.Drawing.Color.Black;
            this.xrRichText7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText7.BorderWidth = 1F;
            this.xrRichText7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>AMOUNT" +
                    ":</b><br>\' + FormatString(\'{0:c2}\', [CheckAmount]) + \'</span>\'")});
            this.xrRichText7.KeepTogether = true;
            this.xrRichText7.LocationFloat = new DevExpress.Utils.PointFloat(567.7099F, 3.489939F);
            this.xrRichText7.Name = "xrRichText7";
            this.xrRichText7.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText7.SerializableRtfString = resources.GetString("xrRichText7.SerializableRtfString");
            this.xrRichText7.SizeF = new System.Drawing.SizeF(213.8901F, 26.2201F);
            // 
            // xrRichText8
            // 
            this.xrRichText8.BorderColor = System.Drawing.Color.Black;
            this.xrRichText8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText8.BorderWidth = 1F;
            this.xrRichText8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>ENTITY" +
                    ":</b><br>\' + [EntityNumber] + \'</span>\'")});
            this.xrRichText8.KeepTogether = true;
            this.xrRichText8.LocationFloat = new DevExpress.Utils.PointFloat(1.389842F, 3.489939F);
            this.xrRichText8.Name = "xrRichText8";
            this.xrRichText8.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString");
            this.xrRichText8.SizeF = new System.Drawing.SizeF(201.73F, 26.22007F);
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSCheckHeader";
            queryParameter1.Name = "@plngProcessTrackingID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngProcessTrackingID", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "ManualCheckPrinting_GetCheckHeader";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // pbooMICR
            // 
            this.pbooMICR.Description = "pbooMICR";
            this.pbooMICR.Name = "pbooMICR";
            this.pbooMICR.Type = typeof(bool);
            this.pbooMICR.ValueInfo = "True";
            this.pbooMICR.Visible = false;
            // 
            // plngCheckFormat
            // 
            this.plngCheckFormat.Description = "plngCheckFormat";
            this.plngCheckFormat.Name = "plngCheckFormat";
            this.plngCheckFormat.Type = typeof(int);
            this.plngCheckFormat.Visible = false;
            // 
            // pbooSignature
            // 
            this.pbooSignature.Description = "pbooSignature";
            this.pbooSignature.Name = "pbooSignature";
            this.pbooSignature.Type = typeof(bool);
            this.pbooSignature.ValueInfo = "True";
            this.pbooSignature.Visible = false;
            // 
            // pstrSignaturePath
            // 
            this.pstrSignaturePath.Description = "pstrSignaturePath";
            this.pstrSignaturePath.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Iif(?pbooSignature = True, \'/ProvidenceReports/Signatures/TestSig.png\', \'\')")});
            this.pstrSignaturePath.Name = "pstrSignaturePath";
            this.pstrSignaturePath.Visible = false;
            // 
            // pstrTwoSignaturesRequiredAmount
            // 
            this.pstrTwoSignaturesRequiredAmount.Description = "pstrTwoSignaturesRequiredAmount";
            this.pstrTwoSignaturesRequiredAmount.Name = "pstrTwoSignaturesRequiredAmount";
            this.pstrTwoSignaturesRequiredAmount.ValueInfo = "0";
            this.pstrTwoSignaturesRequiredAmount.Visible = false;
            // 
            // plngIsTwoSignaturesRequired
            // 
            this.plngIsTwoSignaturesRequired.Description = "plngIsTwoSignaturesRequired";
            this.plngIsTwoSignaturesRequired.Name = "plngIsTwoSignaturesRequired";
            this.plngIsTwoSignaturesRequired.Type = typeof(bool);
            this.plngIsTwoSignaturesRequired.ValueInfo = "False";
            this.plngIsTwoSignaturesRequired.Visible = false;
            // 
            // plngProcessTrackingID
            // 
            this.plngProcessTrackingID.Description = "plngProcessTrackingID";
            this.plngProcessTrackingID.Name = "plngProcessTrackingID";
            this.plngProcessTrackingID.Type = typeof(int);
            this.plngProcessTrackingID.ValueInfo = "3159";
            this.plngProcessTrackingID.Visible = false;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            this.plngCompanyID.Visible = false;
            // 
            // CheckBegin
            // 
            this.CheckBegin.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SortFieldCheckNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CheckBegin.HeightF = 0F;
            this.CheckBegin.Level = 1;
            this.CheckBegin.Name = "CheckBegin";
            // 
            // CheckEnd
            // 
            this.CheckEnd.HeightF = 0F;
            this.CheckEnd.Level = 1;
            this.CheckEnd.Name = "CheckEnd";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyAddressBlockLong]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(84.99998F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(629.9999F, 46.82214F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPages
            // 
            this.xrPages.BorderColor = System.Drawing.Color.Black;
            this.xrPages.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPages.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPages.BorderWidth = 1F;
            this.xrPages.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrPages.KeepTogether = true;
            this.xrPages.LocationFloat = new DevExpress.Utils.PointFloat(714.9999F, 0F);
            this.xrPages.Multiline = true;
            this.xrPages.Name = "xrPages";
            this.xrPages.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrPages.SizeF = new System.Drawing.SizeF(85F, 15F);
            this.xrPages.StylePriority.UseBorderColor = false;
            this.xrPages.StylePriority.UseBorderDashStyle = false;
            this.xrPages.StylePriority.UseBorders = false;
            this.xrPages.StylePriority.UseBorderWidth = false;
            this.xrPages.StylePriority.UseFont = false;
            this.xrPages.StylePriority.UsePadding = false;
            this.xrPages.StylePriority.UseTextAlignment = false;
            this.xrPages.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\' \'")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(625.35F, 326.3368F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(161.45F, 26.33322F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrNonNegotiablePicture
            // 
            this.xrNonNegotiablePicture.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(((System.Drawing.Image)(resources.GetObject("xrNonNegotiablePicture.ImageSource"))), true);
            this.xrNonNegotiablePicture.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrNonNegotiablePicture.Name = "xrNonNegotiablePicture";
            this.xrNonNegotiablePicture.SizeF = new System.Drawing.SizeF(798.25F, 358.1306F);
            this.xrNonNegotiablePicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngImbursementID", null, "DSCheckHeader.CheckID"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Subtitle", this.Subtitle));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCheckFormatIsMICR", this.plngCheckFormatIsMICR));
            this.xrSubreport2.ReportSource = new ReportsEngine.ManualCheckRemittanceSubreport();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(800F, 24.61065F);
            // 
            // ManualChecks
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.Tablix1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DisplayName = "ManualChecks";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(25F, 25F, 18F, 18F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.pbooMICR,
            this.plngCheckFormat,
            this.pbooSignature,
            this.pstrSignaturePath,
            this.pstrTwoSignaturesRequiredAmount,
            this.plngCheckFormatIsMICR,
            this.plngIsTwoSignaturesRequired,
            this.plngProcessTrackingID,
            this.plngCompanyID});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.DetailReportBand Tablix1;
        private DevExpress.XtraReports.UI.DetailBand RemittanceDetailBand;
        private DevExpress.XtraReports.UI.XRPanel Rectangle5;
        private DevExpress.XtraReports.UI.XRPanel Rectangle3;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pbooMICR;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormat;
        private DevExpress.XtraReports.Parameters.Parameter pbooSignature;
        private DevExpress.XtraReports.Parameters.Parameter pstrSignaturePath;
        private DevExpress.XtraReports.Parameters.Parameter pstrTwoSignaturesRequiredAmount;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormatIsMICR;
        private DevExpress.XtraReports.Parameters.Parameter plngIsTwoSignaturesRequired;
        private DevExpress.XtraReports.Parameters.Parameter plngProcessTrackingID;
        private DevExpress.XtraReports.UI.GroupHeaderBand CheckBeginningHeader;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.XRRichText xrRichText3;
        private DevExpress.XtraReports.UI.XRRichText xrRichText6;
        private DevExpress.XtraReports.UI.XRRichText xrRichText7;
        private DevExpress.XtraReports.UI.XRRichText xrRichText8;
        private DevExpress.XtraReports.UI.XRLabel xrCheckNumber;
        private DevExpress.XtraReports.UI.XRLabel xrMICRAccountNumber;
        private DevExpress.XtraReports.UI.XRLabel xrMICRTransitNumber;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountLongString15;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountLongString14;
        private DevExpress.XtraReports.UI.XRLabel Textbox18;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountShortString4;
        private DevExpress.XtraReports.UI.XRLabel Textbox14;
        private DevExpress.XtraReports.UI.XRLabel Textbox16;
        private DevExpress.XtraReports.UI.XRLabel CheckDate2;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountLongString11;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountShortString3;
        private DevExpress.XtraReports.UI.XRLabel Textbox23;
        private DevExpress.XtraReports.UI.XRLabel Textbox20;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountLongString12;
        private DevExpress.XtraReports.UI.XRShape Line3;
        private DevExpress.XtraReports.UI.XRPictureBox Image2;
        private DevExpress.XtraReports.UI.XRShape Line2;
        private DevExpress.XtraReports.UI.XRLabel Textbox22;
        private DevExpress.XtraReports.UI.XRLabel Textbox24;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.UI.GroupHeaderBand CheckBegin;
        private DevExpress.XtraReports.UI.GroupFooterBand CheckEnd;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrPages;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPictureBox xrNonNegotiablePicture;
    }
}
