namespace ReportsEngine.Reports.JIBReports
{
    partial class TestCheckReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCheckReport));
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine1 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine2 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine3 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine4 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngDatabaseID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckType = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrPageBeginningLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.APChecksRemittanceOnly = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.EntryBegin = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.CheckCoverPage = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.CheckBegin = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.CheckBeginningHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.BeginningRemittance = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.EntryRowEndBand = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.groupFooterBand2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.CheckEnd = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.CheckGroupBottom = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.EndRemittance = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.EndCoverPageBand = new DevExpress.XtraReports.UI.SubBand();
            this.CheckTopBand = new DevExpress.XtraReports.UI.SubBand();
            this.PleaseDetachThisRemittanceAdviceBeforeDepositingCheck = new DevExpress.XtraReports.UI.SubBand();
            this.CompanyAddressBandAboveRemittance = new DevExpress.XtraReports.UI.SubBand();
            this.CheckInformationPart = new DevExpress.XtraReports.UI.SubBand();
            this.CheckStubBandTopCheck = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckStubBottomBandCheck = new DevExpress.XtraReports.UI.SubBand();
            this.CheckBottomBand = new DevExpress.XtraReports.UI.SubBand();
            this.StubEnd = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand5 = new DevExpress.XtraReports.UI.SubBand();
            this.xrEndCoverPage = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTopCheckPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrCheckNumberTwo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMICRAccountNumberTwo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTransitTopCheck = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrVoidAfterMessageCheckBottomTwo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape3 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape4 = new DevExpress.XtraReports.UI.XRShape();
            this.SignatureLineCommentBottomCheckTwo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBoxBottomSignatureTwo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBoxTopSignatureTwo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBoxLogoTwo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCompanyAddressBlockTopCheck = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCompanyHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPages = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel4 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCheckNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.Rectangle4 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPictureBoxTopSignature = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrVoidAfterMessageCheckBottom = new DevExpress.XtraReports.UI.XRLabel();
            this.Line3 = new DevExpress.XtraReports.UI.XRShape();
            this.Line2 = new DevExpress.XtraReports.UI.XRShape();
            this.SignatureLineCommentBottomCheck = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBoxBottomSignature = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBoxLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMICRAccountNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountLongString15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCompanyAddressBlockBottomCheck = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox18 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountShortString4 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox14 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox16 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckDate2 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountLongString11 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckAmountShortString3 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox20 = new DevExpress.XtraReports.UI.XRLabel();
            this.OwnerAddressBlock = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTransitBottomCheck = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCheckEnderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand6 = new DevExpress.XtraReports.UI.SubBand();
            this.xrCheckCoverPage = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrNonNegotiablePictureTwo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrNonNegotiablePicture = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 12.5F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 12.5F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "not ?pbooHideCheckPart")});
            this.detailBand1.HeightF = 0F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand2,
            this.SubBand3});
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "CheckFormattingOptions";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter2.Name = "@plngCheckTypeCode";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngCheckType", typeof(int));
            queryParameter3.Name = "@plngDatabaseID";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?plngDatabaseID", typeof(int));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3});
            storedProcQuery1.StoredProcName = "CheckFormattingOptions_ReportLookup";
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
            this.plngCompanyID.Description = "Company ID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            this.plngCompanyID.Visible = false;
            // 
            // plngDatabaseID
            // 
            this.plngDatabaseID.Description = "Database ID";
            this.plngDatabaseID.Name = "plngDatabaseID";
            this.plngDatabaseID.Type = typeof(int);
            this.plngDatabaseID.ValueInfo = "0";
            this.plngDatabaseID.Visible = false;
            // 
            // plngCheckType
            // 
            this.plngCheckType.Description = "Check Type";
            this.plngCheckType.Name = "plngCheckType";
            this.plngCheckType.Type = typeof(int);
            this.plngCheckType.ValueInfo = "1";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "AP"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(2, "RD"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(3, "MC"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(4, "Land"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(5, "Payroll"));
            this.plngCheckType.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1});
            this.ReportHeader.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] in (2,3)")});
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageBeginningLabel});
            this.PageFooter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] = 1")});
            this.PageFooter.HeightF = 2F;
            this.PageFooter.Name = "PageFooter";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.APChecksRemittanceOnly});
            this.ReportFooter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "not ?pbooHideCheckPart AND ?plngPrintRemittance = 0 AND [OverflowOptionCodeID] in" +
                    " (2,3)")});
            this.ReportFooter.HeightF = 2F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrPageBeginningLabel
            // 
            this.xrPageBeginningLabel.BorderColor = System.Drawing.Color.Black;
            this.xrPageBeginningLabel.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPageBeginningLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPageBeginningLabel.BorderWidth = 1F;
            this.xrPageBeginningLabel.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrPageBeginningLabel.KeepTogether = true;
            this.xrPageBeginningLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageBeginningLabel.Multiline = true;
            this.xrPageBeginningLabel.Name = "xrPageBeginningLabel";
            this.xrPageBeginningLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrPageBeginningLabel.SizeF = new System.Drawing.SizeF(12.63346F, 2F);
            this.xrPageBeginningLabel.StylePriority.UseBorderColor = false;
            this.xrPageBeginningLabel.StylePriority.UseBorderDashStyle = false;
            this.xrPageBeginningLabel.StylePriority.UseBorders = false;
            this.xrPageBeginningLabel.StylePriority.UseBorderWidth = false;
            this.xrPageBeginningLabel.StylePriority.UseFont = false;
            this.xrPageBeginningLabel.StylePriority.UsePadding = false;
            this.xrPageBeginningLabel.StylePriority.UseTextAlignment = false;
            this.xrPageBeginningLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // APChecksRemittanceOnly
            // 
            this.APChecksRemittanceOnly.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance = 0 AND [OverflowOptionCodeID] in (2,3)")});
            this.APChecksRemittanceOnly.GenerateOwnPages = true;
            this.APChecksRemittanceOnly.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.APChecksRemittanceOnly.Name = "APChecksRemittanceOnly";
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Subtitle", this.Subtitle));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngID", null, "Dynamic_DSAPCheckHeader.CheckID"));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngOverflowOptionCode", null, "Dynamic_DSAPCheckHeader.OverflowOptionCodeID"));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooWillPrintCompanyAddressOnStub", null, "Dynamic_DSAPCheckHeader.WillPrintCompanyAddressOnStub"));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", null, "Dynamic_DSAPCheckHeader.CompanyAddressBlockLong"));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("booTrue", null, null));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooShowDetailOnChecks", null, "Dynamic_DSAPCheckHeader.WillPrintDetailOnStub"));
            this.APChecksRemittanceOnly.ReportSource = new ReportsEngine.Reports.APReports.APChecksRemittanceOnly();
            this.APChecksRemittanceOnly.SizeF = new System.Drawing.SizeF(809F, 2F);
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintCoverSheet] OR ?pbooHideCheckPart")});
            this.xrSubreport1.GenerateOwnPages = true;
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Subtitle", this.Subtitle));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", null, "Dynamic_DSAPCheckHeader.CompanyAddressBlockCoverSheet"));
            this.xrSubreport1.ReportSource = new ReportsEngine.Reports.RDReports.CheckCoverPageAllRDChecks();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(809F, 0F);
            // 
            // EntryBegin
            // 
            this.EntryBegin.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("EntryRow", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.EntryBegin.HeightF = 0F;
            this.EntryBegin.Level = 4;
            this.EntryBegin.Name = "EntryBegin";
            // 
            // CheckCoverPage
            // 
            this.CheckCoverPage.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckCoverPage});
            this.CheckCoverPage.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] in (1, 4)")});
            this.CheckCoverPage.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("EntryRow", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CheckCoverPage.HeightF = 0F;
            this.CheckCoverPage.Level = 3;
            this.CheckCoverPage.Name = "CheckCoverPage";
            this.CheckCoverPage.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.EndCoverPageBand});
            // 
            // CheckBegin
            // 
            this.CheckBegin.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "not ?pbooHideCheckPart")});
            this.CheckBegin.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("EntryRow", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CheckBegin.HeightF = 0F;
            this.CheckBegin.Level = 2;
            this.CheckBegin.Name = "CheckBegin";
            // 
            // CheckBeginningHeader
            // 
            this.CheckBeginningHeader.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "not ?pbooHideCheckPart")});
            this.CheckBeginningHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("EntryRow", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CheckBeginningHeader.HeightF = 0F;
            this.CheckBeginningHeader.Level = 1;
            this.CheckBeginningHeader.Name = "CheckBeginningHeader";
            this.CheckBeginningHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.CheckTopBand,
            this.PleaseDetachThisRemittanceAdviceBeforeDepositingCheck,
            this.CompanyAddressBandAboveRemittance,
            this.CheckInformationPart,
            this.CheckStubBandTopCheck});
            // 
            // BeginningRemittance
            // 
            this.BeginningRemittance.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("EntryRow", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.BeginningRemittance.HeightF = 0F;
            this.BeginningRemittance.Name = "BeginningRemittance";
            // 
            // EntryRowEndBand
            // 
            this.EntryRowEndBand.HeightF = 0F;
            this.EntryRowEndBand.Level = 4;
            this.EntryRowEndBand.Name = "EntryRowEndBand";
            // 
            // groupFooterBand2
            // 
            this.groupFooterBand2.HeightF = 0F;
            this.groupFooterBand2.Level = 3;
            this.groupFooterBand2.Name = "groupFooterBand2";
            // 
            // CheckEnd
            // 
            this.CheckEnd.HeightF = 0F;
            this.CheckEnd.Level = 2;
            this.CheckEnd.Name = "CheckEnd";
            this.CheckEnd.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand4,
            this.SubBand6});
            // 
            // CheckGroupBottom
            // 
            this.CheckGroupBottom.HeightF = 0F;
            this.CheckGroupBottom.Level = 1;
            this.CheckGroupBottom.Name = "CheckGroupBottom";
            this.CheckGroupBottom.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.CheckStubBottomBandCheck,
            this.CheckBottomBand,
            this.StubEnd,
            this.SubBand5});
            // 
            // EndRemittance
            // 
            this.EndRemittance.HeightF = 0F;
            this.EndRemittance.Name = "EndRemittance";
            // 
            // EndCoverPageBand
            // 
            this.EndCoverPageBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrEndCoverPage});
            this.EndCoverPageBand.HeightF = 2F;
            this.EndCoverPageBand.Name = "EndCoverPageBand";
            // 
            // CheckTopBand
            // 
            this.CheckTopBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTopCheckPanel});
            this.CheckTopBand.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND [IsCheckOnTopOfForm]")});
            this.CheckTopBand.HeightF = 280.6049F;
            this.CheckTopBand.Name = "CheckTopBand";
            // 
            // PleaseDetachThisRemittanceAdviceBeforeDepositingCheck
            // 
            this.PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel32});
            this.PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND [IsCheckOnTopOfForm]")});
            this.PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.HeightF = 47.34857F;
            this.PleaseDetachThisRemittanceAdviceBeforeDepositingCheck.Name = "PleaseDetachThisRemittanceAdviceBeforeDepositingCheck";
            // 
            // CompanyAddressBandAboveRemittance
            // 
            this.CompanyAddressBandAboveRemittance.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCompanyHeader,
            this.xrPages});
            this.CompanyAddressBandAboveRemittance.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] IN (2,4)")});
            this.CompanyAddressBandAboveRemittance.HeightF = 46.82214F;
            this.CompanyAddressBandAboveRemittance.Name = "CompanyAddressBandAboveRemittance";
            // 
            // CheckInformationPart
            // 
            this.CheckInformationPart.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel4});
            this.CheckInformationPart.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND [IsCheckOnTopOfForm]")});
            this.CheckInformationPart.HeightF = 42.15266F;
            this.CheckInformationPart.Name = "CheckInformationPart";
            // 
            // CheckStubBandTopCheck
            // 
            this.CheckStubBandTopCheck.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel33});
            this.CheckStubBandTopCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND [IsCheckOnTopOfForm]\n AN" +
                    "D not IsNullOrEmpty([CheckStubMessage])")});
            this.CheckStubBandTopCheck.HeightF = 11.40547F;
            this.CheckStubBandTopCheck.Name = "CheckStubBandTopCheck";
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20});
            this.SubBand1.HeightF = 16.5833F;
            this.SubBand1.Name = "SubBand1";
            // 
            // SubBand2
            // 
            this.SubBand2.HeightF = 23.73568F;
            this.SubBand2.Name = "SubBand2";
            // 
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.SubBand3.HeightF = 16.5833F;
            this.SubBand3.Name = "SubBand3";
            // 
            // xrLabel20
            // 
            this.xrLabel20.BorderColor = System.Drawing.Color.Black;
            this.xrLabel20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.BorderWidth = 1F;
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel20.KeepTogether = true;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(789.58F, 16.5833F);
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorderDashStyle = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseBorderWidth = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "SEE ATTACHED STATEMENT";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(789.58F, 16.5833F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "SEE ATTACHED STATEMENT";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CheckStubBottomBandCheck
            // 
            this.CheckStubBottomBandCheck.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel19});
            this.CheckStubBottomBandCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND not [IsCheckOnTopOfForm]" +
                    "\n AND not IsNullOrEmpty([CheckStubMessage])")});
            this.CheckStubBottomBandCheck.HeightF = 11.40547F;
            this.CheckStubBottomBandCheck.Name = "CheckStubBottomBandCheck";
            // 
            // CheckBottomBand
            // 
            this.CheckBottomBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.CheckBottomBand.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND not [IsCheckOnTopOfForm]" +
                    "")});
            this.CheckBottomBand.HeightF = 345.1883F;
            this.CheckBottomBand.Name = "CheckBottomBand";
            // 
            // StubEnd
            // 
            this.StubEnd.HeightF = 0F;
            this.StubEnd.Name = "StubEnd";
            // 
            // SubBand5
            // 
            this.SubBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckEnderLabel});
            this.SubBand5.HeightF = 2F;
            this.SubBand5.Name = "SubBand5";
            // 
            // xrEndCoverPage
            // 
            this.xrEndCoverPage.BorderColor = System.Drawing.Color.Black;
            this.xrEndCoverPage.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrEndCoverPage.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrEndCoverPage.BorderWidth = 1F;
            this.xrEndCoverPage.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrEndCoverPage.KeepTogether = true;
            this.xrEndCoverPage.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrEndCoverPage.Multiline = true;
            this.xrEndCoverPage.Name = "xrEndCoverPage";
            this.xrEndCoverPage.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrEndCoverPage.SizeF = new System.Drawing.SizeF(12.63346F, 2F);
            this.xrEndCoverPage.StylePriority.UseBorderColor = false;
            this.xrEndCoverPage.StylePriority.UseBorderDashStyle = false;
            this.xrEndCoverPage.StylePriority.UseBorders = false;
            this.xrEndCoverPage.StylePriority.UseBorderWidth = false;
            this.xrEndCoverPage.StylePriority.UseFont = false;
            this.xrEndCoverPage.StylePriority.UsePadding = false;
            this.xrEndCoverPage.StylePriority.UseTextAlignment = false;
            this.xrEndCoverPage.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTopCheckPanel
            // 
            this.xrTopCheckPanel.BorderColor = System.Drawing.Color.Black;
            this.xrTopCheckPanel.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTopCheckPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTopCheckPanel.BorderWidth = 1F;
            this.xrTopCheckPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckNumberTwo,
            this.xrMICRAccountNumberTwo,
            this.xrTransitTopCheck,
            this.xrPanel3,
            this.xrPictureBoxLogoTwo,
            this.xrLabel21,
            this.xrLabel22,
            this.xrCompanyAddressBlockTopCheck,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel25,
            this.xrLabel26,
            this.xrLabel27,
            this.xrLabel28,
            this.xrLabel29,
            this.xrLabel30,
            this.xrLabel31,
            this.xrNonNegotiablePictureTwo});
            this.xrTopCheckPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTopCheckPanel.Name = "xrTopCheckPanel";
            this.xrTopCheckPanel.SizeF = new System.Drawing.SizeF(794.0999F, 280.6049F);
            // 
            // xrCheckNumberTwo
            // 
            this.xrCheckNumberTwo.BorderColor = System.Drawing.Color.Black;
            this.xrCheckNumberTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrCheckNumberTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCheckNumberTwo.BorderWidth = 1F;
            this.xrCheckNumberTwo.CanGrow = false;
            this.xrCheckNumberTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintMICRInformation]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'c\'+[SerialNumber]+\'c\'\n")});
            this.xrCheckNumberTwo.Font = new DevExpress.Drawing.DXFont("IDAutomationMICRB10", 12F);
            this.xrCheckNumberTwo.KeepTogether = true;
            this.xrCheckNumberTwo.LocationFloat = new DevExpress.Utils.PointFloat(27.43F, 254.2717F);
            this.xrCheckNumberTwo.Multiline = true;
            this.xrCheckNumberTwo.Name = "xrCheckNumberTwo";
            this.xrCheckNumberTwo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrCheckNumberTwo.SizeF = new System.Drawing.SizeF(185.42F, 26.33F);
            this.xrCheckNumberTwo.StylePriority.UseFont = false;
            this.xrCheckNumberTwo.StylePriority.UsePadding = false;
            this.xrCheckNumberTwo.StylePriority.UseTextAlignment = false;
            this.xrCheckNumberTwo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrMICRAccountNumberTwo
            // 
            this.xrMICRAccountNumberTwo.BorderColor = System.Drawing.Color.Black;
            this.xrMICRAccountNumberTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMICRAccountNumberTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMICRAccountNumberTwo.BorderWidth = 1F;
            this.xrMICRAccountNumberTwo.CanGrow = false;
            this.xrMICRAccountNumberTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintMICRInformation]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountNumber]+\'c\'\n")});
            this.xrMICRAccountNumberTwo.Font = new DevExpress.Drawing.DXFont("IDAutomationMICRB10", 12F);
            this.xrMICRAccountNumberTwo.KeepTogether = true;
            this.xrMICRAccountNumberTwo.LocationFloat = new DevExpress.Utils.PointFloat(388.4901F, 254.2717F);
            this.xrMICRAccountNumberTwo.Multiline = true;
            this.xrMICRAccountNumberTwo.Name = "xrMICRAccountNumberTwo";
            this.xrMICRAccountNumberTwo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrMICRAccountNumberTwo.SizeF = new System.Drawing.SizeF(202.48F, 26.33322F);
            this.xrMICRAccountNumberTwo.StylePriority.UseFont = false;
            this.xrMICRAccountNumberTwo.StylePriority.UsePadding = false;
            this.xrMICRAccountNumberTwo.StylePriority.UseTextAlignment = false;
            this.xrMICRAccountNumberTwo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrTransitTopCheck
            // 
            this.xrTransitTopCheck.BorderColor = System.Drawing.Color.Black;
            this.xrTransitTopCheck.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTransitTopCheck.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTransitTopCheck.BorderWidth = 1F;
            this.xrTransitTopCheck.CanGrow = false;
            this.xrTransitTopCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintMICRInformation]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'a\'+[TransitNumber] + \'a\'")});
            this.xrTransitTopCheck.Font = new DevExpress.Drawing.DXFont("IDAutomationMICRB10", 12F);
            this.xrTransitTopCheck.KeepTogether = true;
            this.xrTransitTopCheck.LocationFloat = new DevExpress.Utils.PointFloat(228.08F, 254.2717F);
            this.xrTransitTopCheck.Multiline = true;
            this.xrTransitTopCheck.Name = "xrTransitTopCheck";
            this.xrTransitTopCheck.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrTransitTopCheck.SizeF = new System.Drawing.SizeF(143.75F, 26.32999F);
            this.xrTransitTopCheck.StylePriority.UseFont = false;
            this.xrTransitTopCheck.StylePriority.UsePadding = false;
            this.xrTransitTopCheck.StylePriority.UseTextAlignment = false;
            this.xrTransitTopCheck.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrPanel3
            // 
            this.xrPanel3.BorderColor = System.Drawing.Color.Black;
            this.xrPanel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPanel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel3.BorderWidth = 1F;
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrVoidAfterMessageCheckBottomTwo,
            this.xrShape3,
            this.xrShape4,
            this.SignatureLineCommentBottomCheckTwo,
            this.xrPictureBoxBottomSignatureTwo,
            this.xrPictureBoxTopSignatureTwo});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(452.5598F, 125.1189F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(329.0305F, 127.1528F);
            // 
            // xrVoidAfterMessageCheckBottomTwo
            // 
            this.xrVoidAfterMessageCheckBottomTwo.BorderColor = System.Drawing.Color.Black;
            this.xrVoidAfterMessageCheckBottomTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrVoidAfterMessageCheckBottomTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrVoidAfterMessageCheckBottomTwo.BorderWidth = 1F;
            this.xrVoidAfterMessageCheckBottomTwo.CanGrow = false;
            this.xrVoidAfterMessageCheckBottomTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VoidAfterMessage]")});
            this.xrVoidAfterMessageCheckBottomTwo.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrVoidAfterMessageCheckBottomTwo.KeepTogether = true;
            this.xrVoidAfterMessageCheckBottomTwo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 6.525497F);
            this.xrVoidAfterMessageCheckBottomTwo.Multiline = true;
            this.xrVoidAfterMessageCheckBottomTwo.Name = "xrVoidAfterMessageCheckBottomTwo";
            this.xrVoidAfterMessageCheckBottomTwo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrVoidAfterMessageCheckBottomTwo.SizeF = new System.Drawing.SizeF(329.0301F, 19.28001F);
            this.xrVoidAfterMessageCheckBottomTwo.StylePriority.UseFont = false;
            this.xrVoidAfterMessageCheckBottomTwo.StylePriority.UsePadding = false;
            this.xrVoidAfterMessageCheckBottomTwo.StylePriority.UseTextAlignment = false;
            this.xrVoidAfterMessageCheckBottomTwo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrShape3
            // 
            this.xrShape3.Angle = 270;
            this.xrShape3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrShape3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrShape3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintTwoSignatureLines] AND [CheckAmount] >= [TwoSignaturesRequiredAmount]\n")});
            this.xrShape3.ForeColor = System.Drawing.Color.Black;
            this.xrShape3.LocationFloat = new DevExpress.Utils.PointFloat(11.43994F, 63.80551F);
            this.xrShape3.Name = "xrShape3";
            this.xrShape3.Shape = shapeLine1;
            this.xrShape3.SizeF = new System.Drawing.SizeF(317.5902F, 2F);
            this.xrShape3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrShape4
            // 
            this.xrShape4.Angle = 270;
            this.xrShape4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrShape4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrShape4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintSignature]\n")});
            this.xrShape4.ForeColor = System.Drawing.Color.Black;
            this.xrShape4.LocationFloat = new DevExpress.Utils.PointFloat(11.43994F, 104.8705F);
            this.xrShape4.Name = "xrShape4";
            this.xrShape4.Shape = shapeLine2;
            this.xrShape4.SizeF = new System.Drawing.SizeF(317.5902F, 2F);
            this.xrShape4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SignatureLineCommentBottomCheckTwo
            // 
            this.SignatureLineCommentBottomCheckTwo.BorderColor = System.Drawing.Color.Black;
            this.SignatureLineCommentBottomCheckTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.SignatureLineCommentBottomCheckTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SignatureLineCommentBottomCheckTwo.BorderWidth = 1F;
            this.SignatureLineCommentBottomCheckTwo.CanGrow = false;
            this.SignatureLineCommentBottomCheckTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SignatureLineComment]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintSignature]")});
            this.SignatureLineCommentBottomCheckTwo.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SignatureLineCommentBottomCheckTwo.KeepTogether = true;
            this.SignatureLineCommentBottomCheckTwo.LocationFloat = new DevExpress.Utils.PointFloat(11.43994F, 107.0706F);
            this.SignatureLineCommentBottomCheckTwo.Multiline = true;
            this.SignatureLineCommentBottomCheckTwo.Name = "SignatureLineCommentBottomCheckTwo";
            this.SignatureLineCommentBottomCheckTwo.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 1, 3, 1, 100F);
            this.SignatureLineCommentBottomCheckTwo.SizeF = new System.Drawing.SizeF(317.5902F, 20.08228F);
            this.SignatureLineCommentBottomCheckTwo.StylePriority.UseFont = false;
            this.SignatureLineCommentBottomCheckTwo.Text = "VOID IF NOT CASHED WITHIN 60 DAYS";
            this.SignatureLineCommentBottomCheckTwo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPictureBoxBottomSignatureTwo
            // 
            this.xrPictureBoxBottomSignatureTwo.BorderColor = System.Drawing.Color.Black;
            this.xrPictureBoxBottomSignatureTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPictureBoxBottomSignatureTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBoxBottomSignatureTwo.BorderWidth = 1F;
            this.xrPictureBoxBottomSignatureTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageUrl", "[SignaturePath]\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintSignature]")});
            this.xrPictureBoxBottomSignatureTwo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.BottomCenter;
            this.xrPictureBoxBottomSignatureTwo.LocationFloat = new DevExpress.Utils.PointFloat(12.87985F, 66.87056F);
            this.xrPictureBoxBottomSignatureTwo.Name = "xrPictureBoxBottomSignatureTwo";
            this.xrPictureBoxBottomSignatureTwo.SizeF = new System.Drawing.SizeF(316.1502F, 37F);
            this.xrPictureBoxBottomSignatureTwo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // xrPictureBoxTopSignatureTwo
            // 
            this.xrPictureBoxTopSignatureTwo.BorderColor = System.Drawing.Color.Black;
            this.xrPictureBoxTopSignatureTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPictureBoxTopSignatureTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBoxTopSignatureTwo.BorderWidth = 1F;
            this.xrPictureBoxTopSignatureTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageUrl", "[SecondSignaturePath]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintTwoSignatureLines] AND [CheckAmount] >= [TwoSignaturesRequiredAmount]\n")});
            this.xrPictureBoxTopSignatureTwo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.BottomCenter;
            this.xrPictureBoxTopSignatureTwo.LocationFloat = new DevExpress.Utils.PointFloat(12.87985F, 25.8055F);
            this.xrPictureBoxTopSignatureTwo.Name = "xrPictureBoxTopSignatureTwo";
            this.xrPictureBoxTopSignatureTwo.SizeF = new System.Drawing.SizeF(316.1502F, 36.99998F);
            this.xrPictureBoxTopSignatureTwo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // xrPictureBoxLogoTwo
            // 
            this.xrPictureBoxLogoTwo.BorderColor = System.Drawing.Color.Black;
            this.xrPictureBoxLogoTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPictureBoxLogoTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBoxLogoTwo.BorderWidth = 1F;
            this.xrPictureBoxLogoTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[CheckLogoDisplayOptionCodeID] in (1,2)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageUrl", "[LogoPath]")});
            this.xrPictureBoxLogoTwo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4.391731F);
            this.xrPictureBoxLogoTwo.Name = "xrPictureBoxLogoTwo";
            this.xrPictureBoxLogoTwo.SizeF = new System.Drawing.SizeF(115.6199F, 89.10999F);
            this.xrPictureBoxLogoTwo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BorderColor = System.Drawing.Color.Black;
            this.xrLabel21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.BorderWidth = 1F;
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\' \'")});
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("IDAutomationMICRB10", 12F);
            this.xrLabel21.KeepTogether = true;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(625.3499F, 254.2717F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(168.7501F, 26.33322F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BorderColor = System.Drawing.Color.Black;
            this.xrLabel22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.BorderWidth = 1F;
            this.xrLabel22.CanGrow = false;
            this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BankAddressBlock]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintBankAccountName]")});
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrLabel22.KeepTogether = true;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(344.4399F, 4.391731F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(171.88F, 89.10997F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrCompanyAddressBlockTopCheck
            // 
            this.xrCompanyAddressBlockTopCheck.BorderColor = System.Drawing.Color.Black;
            this.xrCompanyAddressBlockTopCheck.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrCompanyAddressBlockTopCheck.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCompanyAddressBlockTopCheck.BorderWidth = 1F;
            this.xrCompanyAddressBlockTopCheck.CanGrow = false;
            this.xrCompanyAddressBlockTopCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyAddressBlockLong]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "LeftF", "Iif([CheckLogoDisplayOptionCodeID] in (3,4), 0, 115.62)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif([CheckLogoDisplayOptionCodeID] in (2,3), \'TopCenter\', \'TopLeft\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[CheckLogoDisplayOptionCodeID] <> 5")});
            this.xrCompanyAddressBlockTopCheck.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrCompanyAddressBlockTopCheck.KeepTogether = true;
            this.xrCompanyAddressBlockTopCheck.LocationFloat = new DevExpress.Utils.PointFloat(115.6199F, 4.391731F);
            this.xrCompanyAddressBlockTopCheck.Multiline = true;
            this.xrCompanyAddressBlockTopCheck.Name = "xrCompanyAddressBlockTopCheck";
            this.xrCompanyAddressBlockTopCheck.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrCompanyAddressBlockTopCheck.SizeF = new System.Drawing.SizeF(228.82F, 89.10995F);
            this.xrCompanyAddressBlockTopCheck.StylePriority.UseFont = false;
            this.xrCompanyAddressBlockTopCheck.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BorderColor = System.Drawing.Color.Black;
            this.xrLabel23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel23.BorderWidth = 1F;
            this.xrLabel23.CanGrow = false;
            this.xrLabel23.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel23.KeepTogether = true;
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(625.3499F, 4.391731F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(156.2401F, 20.82999F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.Text = "CHECK NUMBER";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel24
            // 
            this.xrLabel24.BorderColor = System.Drawing.Color.Black;
            this.xrLabel24.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel24.BorderWidth = 1F;
            this.xrLabel24.CanGrow = false;
            this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckNumber]")});
            this.xrLabel24.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrLabel24.KeepTogether = true;
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(625.35F, 32.17171F);
            this.xrLabel24.Multiline = true;
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(156.25F, 25F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel25
            // 
            this.xrLabel25.BorderColor = System.Drawing.Color.Black;
            this.xrLabel25.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel25.BorderWidth = 1F;
            this.xrLabel25.CanGrow = false;
            this.xrLabel25.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel25.KeepTogether = true;
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(524.4901F, 4.391731F);
            this.xrLabel25.Multiline = true;
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(83.33997F, 20.83F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "DATE";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel26
            // 
            this.xrLabel26.BorderColor = System.Drawing.Color.Black;
            this.xrLabel26.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.BorderWidth = 1F;
            this.xrLabel26.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel26.KeepTogether = true;
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(696.18F, 67.67172F);
            this.xrLabel26.Multiline = true;
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(85.41016F, 20.83F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "AMOUNT";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel27
            // 
            this.xrLabel27.BorderColor = System.Drawing.Color.Black;
            this.xrLabel27.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel27.BorderWidth = 1F;
            this.xrLabel27.CanGrow = false;
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckDate]")});
            this.xrLabel27.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrLabel27.KeepTogether = true;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(524.4901F, 32.17171F);
            this.xrLabel27.Multiline = true;
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(83.33F, 25F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel27.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel28
            // 
            this.xrLabel28.BorderColor = System.Drawing.Color.Black;
            this.xrLabel28.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel28.BorderWidth = 1F;
            this.xrLabel28.CanGrow = false;
            this.xrLabel28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckAmountLongString]")});
            this.xrLabel28.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrLabel28.KeepTogether = true;
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(11.80999F, 93.50172F);
            this.xrLabel28.Multiline = true;
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(596.0201F, 25F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel29
            // 
            this.xrLabel29.BorderColor = System.Drawing.Color.Black;
            this.xrLabel29.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel29.BorderWidth = 1F;
            this.xrLabel29.CanGrow = false;
            this.xrLabel29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckAmountShortString]")});
            this.xrLabel29.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrLabel29.KeepTogether = true;
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(625.35F, 93.50172F);
            this.xrLabel29.Multiline = true;
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(156.25F, 25F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel30
            // 
            this.xrLabel30.BorderColor = System.Drawing.Color.Black;
            this.xrLabel30.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel30.BorderWidth = 1F;
            this.xrLabel30.CanGrow = false;
            this.xrLabel30.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel30.KeepTogether = true;
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(1.390012F, 155.2717F);
            this.xrLabel30.Multiline = true;
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(83.33F, 72.92004F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.Text = "PAY\r\nTO THE\r\nORDER OF";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel31
            // 
            this.xrLabel31.BorderColor = System.Drawing.Color.Black;
            this.xrLabel31.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel31.BorderWidth = 1F;
            this.xrLabel31.CanGrow = false;
            this.xrLabel31.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VendorAddressBlock]")});
            this.xrLabel31.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrLabel31.KeepTogether = true;
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(86.72002F, 155.2717F);
            this.xrLabel31.Multiline = true;
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(322.92F, 87.5F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel32
            // 
            this.xrLabel32.BorderColor = System.Drawing.Color.Black;
            this.xrLabel32.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel32.BorderWidth = 1F;
            this.xrLabel32.CanGrow = false;
            this.xrLabel32.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel32.KeepTogether = true;
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.51857F);
            this.xrLabel32.Multiline = true;
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(794.0999F, 20.83F);
            this.xrLabel32.Text = "PLEASE DETACH THIS REMITTANCE ADVICE BEFORE DEPOSITING CHECK";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrCompanyHeader
            // 
            this.xrCompanyHeader.BorderColor = System.Drawing.Color.Black;
            this.xrCompanyHeader.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrCompanyHeader.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCompanyHeader.BorderWidth = 1F;
            this.xrCompanyHeader.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyAddressBlockLong]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif([WillCenterCompanyNameOnStub], \'TopCenter\', \'TopLeft\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintCompanyAddressOnStub]")});
            this.xrCompanyHeader.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrCompanyHeader.KeepTogether = true;
            this.xrCompanyHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCompanyHeader.Multiline = true;
            this.xrCompanyHeader.Name = "xrCompanyHeader";
            this.xrCompanyHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrCompanyHeader.SizeF = new System.Drawing.SizeF(803.0001F, 46.82214F);
            this.xrCompanyHeader.StylePriority.UseBorderColor = false;
            this.xrCompanyHeader.StylePriority.UseBorderDashStyle = false;
            this.xrCompanyHeader.StylePriority.UseBorders = false;
            this.xrCompanyHeader.StylePriority.UseBorderWidth = false;
            this.xrCompanyHeader.StylePriority.UseFont = false;
            this.xrCompanyHeader.StylePriority.UsePadding = false;
            this.xrCompanyHeader.StylePriority.UseTextAlignment = false;
            this.xrCompanyHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
            this.xrPages.SizeF = new System.Drawing.SizeF(85F, 18F);
            this.xrPages.StylePriority.UseBorderColor = false;
            this.xrPages.StylePriority.UseBorderDashStyle = false;
            this.xrPages.StylePriority.UseBorders = false;
            this.xrPages.StylePriority.UseBorderWidth = false;
            this.xrPages.StylePriority.UseFont = false;
            this.xrPages.StylePriority.UsePadding = false;
            this.xrPages.StylePriority.UseTextAlignment = false;
            this.xrPages.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPanel4
            // 
            this.xrPanel4.BorderColor = System.Drawing.Color.Black;
            this.xrPanel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPanel4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel4.BorderWidth = 1F;
            this.xrPanel4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel17});
            this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel4.Name = "xrPanel4";
            this.xrPanel4.SizeF = new System.Drawing.SizeF(794.1F, 42.15266F);
            this.xrPanel4.StylePriority.UseBorders = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.KeepTogether = true;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(572.91F, 5.418459F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(216.6697F, 17.00001F);
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "AMOUNT";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel5.KeepTogether = true;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(431.8033F, 5.418459F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(132.29F, 17.00001F);
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorderDashStyle = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "DATE";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BorderColor = System.Drawing.Color.Black;
            this.xrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.BorderWidth = 1F;
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel6.KeepTogether = true;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(204.12F, 5.418333F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(217.71F, 17.00001F);
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorderDashStyle = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "CHECK #";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.BorderWidth = 1F;
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel7.KeepTogether = true;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(1.390012F, 5.418333F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(199.65F, 17.00001F);
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorderDashStyle = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseBorderWidth = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "VENDOR";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BorderColor = System.Drawing.Color.Black;
            this.xrLabel14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.BorderWidth = 1F;
            this.xrLabel14.CanGrow = false;
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VendorNumber]")});
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel14.KeepTogether = true;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.41834F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(201.04F, 17.00001F);
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorderDashStyle = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseBorderWidth = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UsePadding = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BorderColor = System.Drawing.Color.Black;
            this.xrLabel15.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel15.BorderWidth = 1F;
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckNumber]")});
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel15.KeepTogether = true;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(204.12F, 22.41853F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(217.7099F, 17.00001F);
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorderDashStyle = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseBorderWidth = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UsePadding = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BorderColor = System.Drawing.Color.Black;
            this.xrLabel16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.BorderWidth = 1F;
            this.xrLabel16.CanGrow = false;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckDate]")});
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel16.KeepTogether = true;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(431.8033F, 22.41853F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(132.2899F, 17.00001F);
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorderDashStyle = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseBorderWidth = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UsePadding = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel16.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel17
            // 
            this.xrLabel17.BorderColor = System.Drawing.Color.Black;
            this.xrLabel17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.BorderWidth = 1F;
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckAmount]")});
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel17.KeepTogether = true;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(572.91F, 22.41853F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(216.67F, 17F);
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorderDashStyle = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseBorderWidth = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel17.TextFormatString = "{0:c2}";
            // 
            // xrLabel33
            // 
            this.xrLabel33.BorderColor = System.Drawing.Color.Black;
            this.xrLabel33.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel33.BorderWidth = 1F;
            this.xrLabel33.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckStubMessage]")});
            this.xrLabel33.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel33.KeepTogether = true;
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel33.Multiline = true;
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(789.58F, 11.40547F);
            this.xrLabel33.StylePriority.UseBorderColor = false;
            this.xrLabel33.StylePriority.UseBorderDashStyle = false;
            this.xrLabel33.StylePriority.UseBorders = false;
            this.xrLabel33.StylePriority.UseBorderWidth = false;
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UsePadding = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BorderColor = System.Drawing.Color.Black;
            this.xrLabel19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.BorderWidth = 1F;
            this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckStubMessage]")});
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel19.KeepTogether = true;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(789.58F, 11.40547F);
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorderDashStyle = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseBorderWidth = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UsePadding = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPanel1
            // 
            this.xrPanel1.BorderColor = System.Drawing.Color.Black;
            this.xrPanel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel1.BorderWidth = 1F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2,
            this.xrCheckNumber,
            this.Rectangle4,
            this.xrPictureBoxLogo,
            this.xrLabel3,
            this.xrMICRAccountNumber,
            this.CheckAmountLongString15,
            this.xrCompanyAddressBlockBottomCheck,
            this.Textbox18,
            this.CheckAmountShortString4,
            this.Textbox14,
            this.Textbox16,
            this.CheckDate2,
            this.CheckAmountLongString11,
            this.CheckAmountShortString3,
            this.Textbox20,
            this.OwnerAddressBlock,
            this.xrLabel2,
            this.xrNonNegotiablePicture,
            this.xrTransitBottomCheck});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(794.0999F, 345.1883F);
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
            this.xrLabel34,
            this.xrLabel35,
            this.xrLabel36,
            this.xrLabel37,
            this.xrLabel38,
            this.xrLabel39,
            this.xrLabel40,
            this.xrLabel41});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(794.1F, 42.15266F);
            this.xrPanel2.StylePriority.UseBorders = false;
            // 
            // xrLabel34
            // 
            this.xrLabel34.BorderColor = System.Drawing.Color.Black;
            this.xrLabel34.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel34.BorderWidth = 1F;
            this.xrLabel34.CanGrow = false;
            this.xrLabel34.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel34.KeepTogether = true;
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(572.91F, 5.418459F);
            this.xrLabel34.Multiline = true;
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(216.6697F, 17.00001F);
            this.xrLabel34.StylePriority.UseBorderColor = false;
            this.xrLabel34.StylePriority.UseBorderDashStyle = false;
            this.xrLabel34.StylePriority.UseBorders = false;
            this.xrLabel34.StylePriority.UseBorderWidth = false;
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UsePadding = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.Text = "AMOUNT";
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel35
            // 
            this.xrLabel35.BorderColor = System.Drawing.Color.Black;
            this.xrLabel35.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel35.BorderWidth = 1F;
            this.xrLabel35.CanGrow = false;
            this.xrLabel35.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel35.KeepTogether = true;
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(431.8033F, 5.418459F);
            this.xrLabel35.Multiline = true;
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(132.29F, 17.00001F);
            this.xrLabel35.StylePriority.UseBorderColor = false;
            this.xrLabel35.StylePriority.UseBorderDashStyle = false;
            this.xrLabel35.StylePriority.UseBorders = false;
            this.xrLabel35.StylePriority.UseBorderWidth = false;
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UsePadding = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = "DATE";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel36
            // 
            this.xrLabel36.BorderColor = System.Drawing.Color.Black;
            this.xrLabel36.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel36.BorderWidth = 1F;
            this.xrLabel36.CanGrow = false;
            this.xrLabel36.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel36.KeepTogether = true;
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(204.12F, 5.418333F);
            this.xrLabel36.Multiline = true;
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(217.71F, 17.00001F);
            this.xrLabel36.StylePriority.UseBorderColor = false;
            this.xrLabel36.StylePriority.UseBorderDashStyle = false;
            this.xrLabel36.StylePriority.UseBorders = false;
            this.xrLabel36.StylePriority.UseBorderWidth = false;
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UsePadding = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.Text = "CHECK #";
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel37
            // 
            this.xrLabel37.BorderColor = System.Drawing.Color.Black;
            this.xrLabel37.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel37.BorderWidth = 1F;
            this.xrLabel37.CanGrow = false;
            this.xrLabel37.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel37.KeepTogether = true;
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(1.390012F, 5.418333F);
            this.xrLabel37.Multiline = true;
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(199.65F, 17.00001F);
            this.xrLabel37.StylePriority.UseBorderColor = false;
            this.xrLabel37.StylePriority.UseBorderDashStyle = false;
            this.xrLabel37.StylePriority.UseBorders = false;
            this.xrLabel37.StylePriority.UseBorderWidth = false;
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UsePadding = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            this.xrLabel37.Text = "VENDOR";
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel38
            // 
            this.xrLabel38.BorderColor = System.Drawing.Color.Black;
            this.xrLabel38.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel38.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel38.BorderWidth = 1F;
            this.xrLabel38.CanGrow = false;
            this.xrLabel38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VendorNumber]")});
            this.xrLabel38.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel38.KeepTogether = true;
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.41834F);
            this.xrLabel38.Multiline = true;
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(201.04F, 17.00001F);
            this.xrLabel38.StylePriority.UseBorderColor = false;
            this.xrLabel38.StylePriority.UseBorderDashStyle = false;
            this.xrLabel38.StylePriority.UseBorders = false;
            this.xrLabel38.StylePriority.UseBorderWidth = false;
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UsePadding = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel39
            // 
            this.xrLabel39.BorderColor = System.Drawing.Color.Black;
            this.xrLabel39.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel39.BorderWidth = 1F;
            this.xrLabel39.CanGrow = false;
            this.xrLabel39.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckNumber]")});
            this.xrLabel39.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel39.KeepTogether = true;
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(204.12F, 22.41853F);
            this.xrLabel39.Multiline = true;
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(217.7099F, 17.00001F);
            this.xrLabel39.StylePriority.UseBorderColor = false;
            this.xrLabel39.StylePriority.UseBorderDashStyle = false;
            this.xrLabel39.StylePriority.UseBorders = false;
            this.xrLabel39.StylePriority.UseBorderWidth = false;
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UsePadding = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel40
            // 
            this.xrLabel40.BorderColor = System.Drawing.Color.Black;
            this.xrLabel40.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel40.BorderWidth = 1F;
            this.xrLabel40.CanGrow = false;
            this.xrLabel40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckDate]")});
            this.xrLabel40.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel40.KeepTogether = true;
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(431.8033F, 22.41853F);
            this.xrLabel40.Multiline = true;
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(132.2899F, 17.00001F);
            this.xrLabel40.StylePriority.UseBorderColor = false;
            this.xrLabel40.StylePriority.UseBorderDashStyle = false;
            this.xrLabel40.StylePriority.UseBorders = false;
            this.xrLabel40.StylePriority.UseBorderWidth = false;
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UsePadding = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel40.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel41
            // 
            this.xrLabel41.BorderColor = System.Drawing.Color.Black;
            this.xrLabel41.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel41.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel41.BorderWidth = 1F;
            this.xrLabel41.CanGrow = false;
            this.xrLabel41.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckAmount]")});
            this.xrLabel41.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel41.KeepTogether = true;
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(572.91F, 22.41853F);
            this.xrLabel41.Multiline = true;
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(216.67F, 17F);
            this.xrLabel41.StylePriority.UseBorderColor = false;
            this.xrLabel41.StylePriority.UseBorderDashStyle = false;
            this.xrLabel41.StylePriority.UseBorders = false;
            this.xrLabel41.StylePriority.UseBorderWidth = false;
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UsePadding = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel41.TextFormatString = "{0:c2}";
            // 
            // xrCheckNumber
            // 
            this.xrCheckNumber.BorderColor = System.Drawing.Color.Black;
            this.xrCheckNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrCheckNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCheckNumber.BorderWidth = 1F;
            this.xrCheckNumber.CanGrow = false;
            this.xrCheckNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintMICRInformation]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'c\'+[SerialNumber]+\'c\'\n")});
            this.xrCheckNumber.Font = new DevExpress.Drawing.DXFont("IDAutomationMICRB10", 12F);
            this.xrCheckNumber.KeepTogether = true;
            this.xrCheckNumber.LocationFloat = new DevExpress.Utils.PointFloat(27.43F, 318.2301F);
            this.xrCheckNumber.Multiline = true;
            this.xrCheckNumber.Name = "xrCheckNumber";
            this.xrCheckNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrCheckNumber.SizeF = new System.Drawing.SizeF(185.42F, 26.33F);
            this.xrCheckNumber.StylePriority.UseFont = false;
            this.xrCheckNumber.StylePriority.UsePadding = false;
            this.xrCheckNumber.StylePriority.UseTextAlignment = false;
            this.xrCheckNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // Rectangle4
            // 
            this.Rectangle4.BorderColor = System.Drawing.Color.Black;
            this.Rectangle4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Rectangle4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Rectangle4.BorderWidth = 1F;
            this.Rectangle4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBoxTopSignature,
            this.xrVoidAfterMessageCheckBottom,
            this.Line3,
            this.Line2,
            this.SignatureLineCommentBottomCheck,
            this.xrPictureBoxBottomSignature});
            this.Rectangle4.LocationFloat = new DevExpress.Utils.PointFloat(452.5598F, 189.0773F);
            this.Rectangle4.Name = "Rectangle4";
            this.Rectangle4.SizeF = new System.Drawing.SizeF(329.0305F, 127.1528F);
            // 
            // xrPictureBoxTopSignature
            // 
            this.xrPictureBoxTopSignature.BorderColor = System.Drawing.Color.Black;
            this.xrPictureBoxTopSignature.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPictureBoxTopSignature.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBoxTopSignature.BorderWidth = 1F;
            this.xrPictureBoxTopSignature.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageUrl", "[SecondSignaturePath]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintTwoSignatureLines] AND [CheckAmount] >= [TwoSignaturesRequiredAmount]")});
            this.xrPictureBoxTopSignature.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.BottomCenter;
            this.xrPictureBoxTopSignature.LocationFloat = new DevExpress.Utils.PointFloat(11.4404F, 25.80551F);
            this.xrPictureBoxTopSignature.Name = "xrPictureBoxTopSignature";
            this.xrPictureBoxTopSignature.SizeF = new System.Drawing.SizeF(317.5901F, 37F);
            this.xrPictureBoxTopSignature.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // xrVoidAfterMessageCheckBottom
            // 
            this.xrVoidAfterMessageCheckBottom.BorderColor = System.Drawing.Color.Black;
            this.xrVoidAfterMessageCheckBottom.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrVoidAfterMessageCheckBottom.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrVoidAfterMessageCheckBottom.BorderWidth = 1F;
            this.xrVoidAfterMessageCheckBottom.CanGrow = false;
            this.xrVoidAfterMessageCheckBottom.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VoidAfterMessage]")});
            this.xrVoidAfterMessageCheckBottom.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrVoidAfterMessageCheckBottom.KeepTogether = true;
            this.xrVoidAfterMessageCheckBottom.LocationFloat = new DevExpress.Utils.PointFloat(0F, 6.525497F);
            this.xrVoidAfterMessageCheckBottom.Multiline = true;
            this.xrVoidAfterMessageCheckBottom.Name = "xrVoidAfterMessageCheckBottom";
            this.xrVoidAfterMessageCheckBottom.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrVoidAfterMessageCheckBottom.SizeF = new System.Drawing.SizeF(329.0301F, 19.28001F);
            this.xrVoidAfterMessageCheckBottom.StylePriority.UseFont = false;
            this.xrVoidAfterMessageCheckBottom.StylePriority.UsePadding = false;
            this.xrVoidAfterMessageCheckBottom.StylePriority.UseTextAlignment = false;
            this.xrVoidAfterMessageCheckBottom.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Line3
            // 
            this.Line3.Angle = 270;
            this.Line3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Line3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Line3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintTwoSignatureLines] AND [CheckAmount] >= [TwoSignaturesRequiredAmount]\n")});
            this.Line3.ForeColor = System.Drawing.Color.Black;
            this.Line3.LocationFloat = new DevExpress.Utils.PointFloat(10F, 63.8055F);
            this.Line3.Name = "Line3";
            this.Line3.Shape = shapeLine3;
            this.Line3.SizeF = new System.Drawing.SizeF(319.0302F, 2F);
            this.Line3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Line2
            // 
            this.Line2.Angle = 270;
            this.Line2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Line2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Line2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintSignature]\n")});
            this.Line2.ForeColor = System.Drawing.Color.Black;
            this.Line2.LocationFloat = new DevExpress.Utils.PointFloat(10F, 104.8704F);
            this.Line2.Name = "Line2";
            this.Line2.Shape = shapeLine4;
            this.Line2.SizeF = new System.Drawing.SizeF(319.0302F, 2.000031F);
            this.Line2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SignatureLineCommentBottomCheck
            // 
            this.SignatureLineCommentBottomCheck.BorderColor = System.Drawing.Color.Black;
            this.SignatureLineCommentBottomCheck.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.SignatureLineCommentBottomCheck.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SignatureLineCommentBottomCheck.BorderWidth = 1F;
            this.SignatureLineCommentBottomCheck.CanGrow = false;
            this.SignatureLineCommentBottomCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SignatureLineComment]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintSignature]\n")});
            this.SignatureLineCommentBottomCheck.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SignatureLineCommentBottomCheck.KeepTogether = true;
            this.SignatureLineCommentBottomCheck.LocationFloat = new DevExpress.Utils.PointFloat(10F, 107.0706F);
            this.SignatureLineCommentBottomCheck.Multiline = true;
            this.SignatureLineCommentBottomCheck.Name = "SignatureLineCommentBottomCheck";
            this.SignatureLineCommentBottomCheck.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 1, 3, 1, 100F);
            this.SignatureLineCommentBottomCheck.SizeF = new System.Drawing.SizeF(319.0302F, 20.08228F);
            this.SignatureLineCommentBottomCheck.StylePriority.UseFont = false;
            this.SignatureLineCommentBottomCheck.Text = "VOID IF NOT CASHED WITHIN 60 DAYS";
            this.SignatureLineCommentBottomCheck.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPictureBoxBottomSignature
            // 
            this.xrPictureBoxBottomSignature.BorderColor = System.Drawing.Color.Black;
            this.xrPictureBoxBottomSignature.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPictureBoxBottomSignature.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBoxBottomSignature.BorderWidth = 1F;
            this.xrPictureBoxBottomSignature.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintSignature]")});
            this.xrPictureBoxBottomSignature.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.BottomCenter;
            this.xrPictureBoxBottomSignature.LocationFloat = new DevExpress.Utils.PointFloat(11.43994F, 66.87059F);
            this.xrPictureBoxBottomSignature.Name = "xrPictureBoxBottomSignature";
            this.xrPictureBoxBottomSignature.SizeF = new System.Drawing.SizeF(317.5901F, 37F);
            this.xrPictureBoxBottomSignature.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // xrPictureBoxLogo
            // 
            this.xrPictureBoxLogo.BorderColor = System.Drawing.Color.Black;
            this.xrPictureBoxLogo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPictureBoxLogo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPictureBoxLogo.BorderWidth = 1F;
            this.xrPictureBoxLogo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[CheckLogoDisplayOptionCodeID] in (1,2)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageUrl", "[LogoPath]")});
            this.xrPictureBoxLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 68.35008F);
            this.xrPictureBoxLogo.Name = "xrPictureBoxLogo";
            this.xrPictureBoxLogo.SizeF = new System.Drawing.SizeF(115.6199F, 89.10999F);
            this.xrPictureBoxLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\' \'")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("IDAutomationMICRB10", 12F);
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(625.35F, 318.2301F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(161.45F, 26.33322F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrMICRAccountNumber
            // 
            this.xrMICRAccountNumber.BorderColor = System.Drawing.Color.Black;
            this.xrMICRAccountNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMICRAccountNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMICRAccountNumber.BorderWidth = 1F;
            this.xrMICRAccountNumber.CanGrow = false;
            this.xrMICRAccountNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintMICRInformation]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountNumber]+\'c\'\n")});
            this.xrMICRAccountNumber.Font = new DevExpress.Drawing.DXFont("IDAutomationMICRB10", 12F);
            this.xrMICRAccountNumber.KeepTogether = true;
            this.xrMICRAccountNumber.LocationFloat = new DevExpress.Utils.PointFloat(388.4901F, 318.2301F);
            this.xrMICRAccountNumber.Multiline = true;
            this.xrMICRAccountNumber.Name = "xrMICRAccountNumber";
            this.xrMICRAccountNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrMICRAccountNumber.SizeF = new System.Drawing.SizeF(202.48F, 26.33322F);
            this.xrMICRAccountNumber.StylePriority.UseFont = false;
            this.xrMICRAccountNumber.StylePriority.UsePadding = false;
            this.xrMICRAccountNumber.StylePriority.UseTextAlignment = false;
            this.xrMICRAccountNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // CheckAmountLongString15
            // 
            this.CheckAmountLongString15.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountLongString15.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountLongString15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountLongString15.BorderWidth = 1F;
            this.CheckAmountLongString15.CanGrow = false;
            this.CheckAmountLongString15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BankAddressBlock]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintBankAccountName]")});
            this.CheckAmountLongString15.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountLongString15.KeepTogether = true;
            this.CheckAmountLongString15.LocationFloat = new DevExpress.Utils.PointFloat(344.4399F, 68.35008F);
            this.CheckAmountLongString15.Multiline = true;
            this.CheckAmountLongString15.Name = "CheckAmountLongString15";
            this.CheckAmountLongString15.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountLongString15.SizeF = new System.Drawing.SizeF(171.88F, 89.10997F);
            this.CheckAmountLongString15.StylePriority.UseFont = false;
            this.CheckAmountLongString15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrCompanyAddressBlockBottomCheck
            // 
            this.xrCompanyAddressBlockBottomCheck.BorderColor = System.Drawing.Color.Black;
            this.xrCompanyAddressBlockBottomCheck.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrCompanyAddressBlockBottomCheck.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCompanyAddressBlockBottomCheck.BorderWidth = 1F;
            this.xrCompanyAddressBlockBottomCheck.CanGrow = false;
            this.xrCompanyAddressBlockBottomCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyAddressBlockLong]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "LeftF", "Iif([CheckLogoDisplayOptionCodeID] in (3,4), 0, 115.62)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif([CheckLogoDisplayOptionCodeID] in (2,3), \'TopCenter\', \'TopLeft\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[CheckLogoDisplayOptionCodeID] <> 5")});
            this.xrCompanyAddressBlockBottomCheck.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrCompanyAddressBlockBottomCheck.KeepTogether = true;
            this.xrCompanyAddressBlockBottomCheck.LocationFloat = new DevExpress.Utils.PointFloat(115.6199F, 68.35008F);
            this.xrCompanyAddressBlockBottomCheck.Multiline = true;
            this.xrCompanyAddressBlockBottomCheck.Name = "xrCompanyAddressBlockBottomCheck";
            this.xrCompanyAddressBlockBottomCheck.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrCompanyAddressBlockBottomCheck.SizeF = new System.Drawing.SizeF(228.82F, 89.10995F);
            this.xrCompanyAddressBlockBottomCheck.StylePriority.UseFont = false;
            this.xrCompanyAddressBlockBottomCheck.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Textbox18
            // 
            this.Textbox18.BorderColor = System.Drawing.Color.Black;
            this.Textbox18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox18.BorderWidth = 1F;
            this.Textbox18.CanGrow = false;
            this.Textbox18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox18.KeepTogether = true;
            this.Textbox18.LocationFloat = new DevExpress.Utils.PointFloat(625.3499F, 68.35008F);
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
            this.CheckAmountShortString4.CanGrow = false;
            this.CheckAmountShortString4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckNumber]")});
            this.CheckAmountShortString4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountShortString4.KeepTogether = true;
            this.CheckAmountShortString4.LocationFloat = new DevExpress.Utils.PointFloat(625.35F, 96.13007F);
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
            this.Textbox14.CanGrow = false;
            this.Textbox14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox14.KeepTogether = true;
            this.Textbox14.LocationFloat = new DevExpress.Utils.PointFloat(524.4901F, 68.35008F);
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
            this.Textbox16.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox16.KeepTogether = true;
            this.Textbox16.LocationFloat = new DevExpress.Utils.PointFloat(696.1799F, 131.6301F);
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
            this.CheckDate2.CanGrow = false;
            this.CheckDate2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckDate]")});
            this.CheckDate2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckDate2.KeepTogether = true;
            this.CheckDate2.LocationFloat = new DevExpress.Utils.PointFloat(524.4901F, 96.13007F);
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
            this.CheckAmountLongString11.CanGrow = false;
            this.CheckAmountLongString11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckAmountLongString]")});
            this.CheckAmountLongString11.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountLongString11.KeepTogether = true;
            this.CheckAmountLongString11.LocationFloat = new DevExpress.Utils.PointFloat(11.80999F, 157.4602F);
            this.CheckAmountLongString11.Multiline = true;
            this.CheckAmountLongString11.Name = "CheckAmountLongString11";
            this.CheckAmountLongString11.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountLongString11.SizeF = new System.Drawing.SizeF(596.0201F, 25F);
            this.CheckAmountLongString11.StylePriority.UseFont = false;
            this.CheckAmountLongString11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CheckAmountShortString3
            // 
            this.CheckAmountShortString3.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountShortString3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountShortString3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountShortString3.BorderWidth = 1F;
            this.CheckAmountShortString3.CanGrow = false;
            this.CheckAmountShortString3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CheckAmountShortString]")});
            this.CheckAmountShortString3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.CheckAmountShortString3.KeepTogether = true;
            this.CheckAmountShortString3.LocationFloat = new DevExpress.Utils.PointFloat(625.35F, 157.4601F);
            this.CheckAmountShortString3.Multiline = true;
            this.CheckAmountShortString3.Name = "CheckAmountShortString3";
            this.CheckAmountShortString3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountShortString3.SizeF = new System.Drawing.SizeF(156.25F, 25F);
            this.CheckAmountShortString3.StylePriority.UseFont = false;
            this.CheckAmountShortString3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Textbox20
            // 
            this.Textbox20.BorderColor = System.Drawing.Color.Black;
            this.Textbox20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox20.BorderWidth = 1F;
            this.Textbox20.CanGrow = false;
            this.Textbox20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox20.KeepTogether = true;
            this.Textbox20.LocationFloat = new DevExpress.Utils.PointFloat(1.390012F, 219.2301F);
            this.Textbox20.Multiline = true;
            this.Textbox20.Name = "Textbox20";
            this.Textbox20.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox20.SizeF = new System.Drawing.SizeF(83.33F, 72.92004F);
            this.Textbox20.StylePriority.UseFont = false;
            this.Textbox20.Text = "PAY\r\nTO THE\r\nORDER OF";
            this.Textbox20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // OwnerAddressBlock
            // 
            this.OwnerAddressBlock.BorderColor = System.Drawing.Color.Black;
            this.OwnerAddressBlock.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.OwnerAddressBlock.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.OwnerAddressBlock.BorderWidth = 1F;
            this.OwnerAddressBlock.CanGrow = false;
            this.OwnerAddressBlock.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VendorAddressBlock]")});
            this.OwnerAddressBlock.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.OwnerAddressBlock.KeepTogether = true;
            this.OwnerAddressBlock.LocationFloat = new DevExpress.Utils.PointFloat(86.72002F, 219.2301F);
            this.OwnerAddressBlock.Multiline = true;
            this.OwnerAddressBlock.Name = "OwnerAddressBlock";
            this.OwnerAddressBlock.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.OwnerAddressBlock.SizeF = new System.Drawing.SizeF(322.92F, 87.5F);
            this.OwnerAddressBlock.StylePriority.UseFont = false;
            this.OwnerAddressBlock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(5.35F, 42.15266F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(780.21F, 20.83F);
            this.xrLabel2.Text = "PLEASE DETACH THIS REMITTANCE ADVICE BEFORE DEPOSITING CHECK";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTransitBottomCheck
            // 
            this.xrTransitBottomCheck.BorderColor = System.Drawing.Color.Black;
            this.xrTransitBottomCheck.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTransitBottomCheck.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTransitBottomCheck.BorderWidth = 1F;
            this.xrTransitBottomCheck.CanGrow = false;
            this.xrTransitBottomCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintMICRInformation]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'a\'+[TransitNumber] + \'a\'\n")});
            this.xrTransitBottomCheck.Font = new DevExpress.Drawing.DXFont("IDAutomationMICRB10", 12F);
            this.xrTransitBottomCheck.KeepTogether = true;
            this.xrTransitBottomCheck.LocationFloat = new DevExpress.Utils.PointFloat(228.08F, 318.23F);
            this.xrTransitBottomCheck.Multiline = true;
            this.xrTransitBottomCheck.Name = "xrTransitBottomCheck";
            this.xrTransitBottomCheck.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrTransitBottomCheck.SizeF = new System.Drawing.SizeF(143.75F, 26.33002F);
            this.xrTransitBottomCheck.StylePriority.UseFont = false;
            this.xrTransitBottomCheck.StylePriority.UsePadding = false;
            this.xrTransitBottomCheck.StylePriority.UseTextAlignment = false;
            this.xrTransitBottomCheck.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrCheckEnderLabel
            // 
            this.xrCheckEnderLabel.BorderColor = System.Drawing.Color.Black;
            this.xrCheckEnderLabel.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrCheckEnderLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCheckEnderLabel.BorderWidth = 1F;
            this.xrCheckEnderLabel.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] = 1")});
            this.xrCheckEnderLabel.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrCheckEnderLabel.KeepTogether = true;
            this.xrCheckEnderLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCheckEnderLabel.Multiline = true;
            this.xrCheckEnderLabel.Name = "xrCheckEnderLabel";
            this.xrCheckEnderLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrCheckEnderLabel.SizeF = new System.Drawing.SizeF(2F, 2F);
            this.xrCheckEnderLabel.StylePriority.UseBorderColor = false;
            this.xrCheckEnderLabel.StylePriority.UseBorderDashStyle = false;
            this.xrCheckEnderLabel.StylePriority.UseBorders = false;
            this.xrCheckEnderLabel.StylePriority.UseBorderWidth = false;
            this.xrCheckEnderLabel.StylePriority.UseFont = false;
            this.xrCheckEnderLabel.StylePriority.UsePadding = false;
            this.xrCheckEnderLabel.StylePriority.UseTextAlignment = false;
            this.xrCheckEnderLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // SubBand4
            // 
            this.SubBand4.HeightF = 0F;
            this.SubBand4.Name = "SubBand4";
            // 
            // SubBand6
            // 
            this.SubBand6.HeightF = 0F;
            this.SubBand6.Name = "SubBand6";
            // 
            // xrCheckCoverPage
            // 
            this.xrCheckCoverPage.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] in (1, 4) AND ([WillPrintCoverSheet] OR ?pbooHideCheckPart" +
                    ")")});
            this.xrCheckCoverPage.GenerateOwnPages = true;
            this.xrCheckCoverPage.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCheckCoverPage.Name = "xrCheckCoverPage";
            this.xrCheckCoverPage.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCoverPageAddress", null, "Dynamic_DSAPCheckHeader.VendorAddressBlock"));
            this.xrCheckCoverPage.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.xrCheckCoverPage.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.xrCheckCoverPage.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.xrCheckCoverPage.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", null, "DSAPCheckHeader.CompanyAddressBlockCoverSheet"));
            this.xrCheckCoverPage.ReportSource = new ReportsEngine.Reports.RDReports.CheckCoverPage();
            this.xrCheckCoverPage.SizeF = new System.Drawing.SizeF(809F, 0F);
            // 
            // xrNonNegotiablePictureTwo
            // 
            this.xrNonNegotiablePictureTwo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(((System.Drawing.Image)(resources.GetObject("xrNonNegotiablePictureTwo.ImageSource"))), true);
            this.xrNonNegotiablePictureTwo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4.391734F);
            this.xrNonNegotiablePictureTwo.Name = "xrNonNegotiablePictureTwo";
            this.xrNonNegotiablePictureTwo.SizeF = new System.Drawing.SizeF(792.9999F, 249.88F);
            this.xrNonNegotiablePictureTwo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrNonNegotiablePicture
            // 
            this.xrNonNegotiablePicture.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrNonNegotiablePicture.ImageSource"));
            this.xrNonNegotiablePicture.LocationFloat = new DevExpress.Utils.PointFloat(0F, 68.35001F);
            this.xrNonNegotiablePicture.Name = "xrNonNegotiablePicture";
            this.xrNonNegotiablePicture.SizeF = new System.Drawing.SizeF(794.0999F, 249.88F);
            this.xrNonNegotiablePicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // TestCheckReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter,
            this.EntryBegin,
            this.CheckCoverPage,
            this.CheckBegin,
            this.CheckBeginningHeader,
            this.BeginningRemittance,
            this.EntryRowEndBand,
            this.groupFooterBand2,
            this.CheckEnd,
            this.CheckGroupBottom,
            this.EndRemittance});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "CheckFormattingOptions";
            this.DataSource = this.Dynamic;
            this.DisplayName = "RDChecks";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 21F, 12.5F, 12.5F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngDatabaseID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCheckType, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.plngCompanyID,
            this.plngDatabaseID,
            this.plngCheckType});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter plngDatabaseID;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckType;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrPageBeginningLabel;
        private DevExpress.XtraReports.UI.XRSubreport APChecksRemittanceOnly;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.GroupHeaderBand EntryBegin;
        private DevExpress.XtraReports.UI.GroupHeaderBand CheckCoverPage;
        private DevExpress.XtraReports.UI.GroupHeaderBand CheckBegin;
        private DevExpress.XtraReports.UI.GroupHeaderBand CheckBeginningHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand BeginningRemittance;
        private DevExpress.XtraReports.UI.GroupFooterBand EntryRowEndBand;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand2;
        private DevExpress.XtraReports.UI.GroupFooterBand CheckEnd;
        private DevExpress.XtraReports.UI.GroupFooterBand CheckGroupBottom;
        private DevExpress.XtraReports.UI.GroupFooterBand EndRemittance;
        private DevExpress.XtraReports.UI.SubBand EndCoverPageBand;
        private DevExpress.XtraReports.UI.SubBand CheckTopBand;
        private DevExpress.XtraReports.UI.SubBand PleaseDetachThisRemittanceAdviceBeforeDepositingCheck;
        private DevExpress.XtraReports.UI.SubBand CompanyAddressBandAboveRemittance;
        private DevExpress.XtraReports.UI.SubBand CheckInformationPart;
        private DevExpress.XtraReports.UI.SubBand CheckStubBandTopCheck;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.SubBand CheckStubBottomBandCheck;
        private DevExpress.XtraReports.UI.SubBand CheckBottomBand;
        private DevExpress.XtraReports.UI.SubBand StubEnd;
        private DevExpress.XtraReports.UI.SubBand SubBand5;
        private DevExpress.XtraReports.UI.XRLabel xrEndCoverPage;
        private DevExpress.XtraReports.UI.XRPanel xrTopCheckPanel;
        private DevExpress.XtraReports.UI.XRLabel xrCheckNumberTwo;
        private DevExpress.XtraReports.UI.XRLabel xrMICRAccountNumberTwo;
        private DevExpress.XtraReports.UI.XRLabel xrTransitTopCheck;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRLabel xrVoidAfterMessageCheckBottomTwo;
        private DevExpress.XtraReports.UI.XRShape xrShape3;
        private DevExpress.XtraReports.UI.XRShape xrShape4;
        private DevExpress.XtraReports.UI.XRLabel SignatureLineCommentBottomCheckTwo;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxBottomSignatureTwo;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxTopSignatureTwo;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxLogoTwo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrCompanyAddressBlockTopCheck;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRPictureBox xrNonNegotiablePictureTwo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrCompanyHeader;
        private DevExpress.XtraReports.UI.XRLabel xrPages;
        private DevExpress.XtraReports.UI.XRPanel xrPanel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel34;
        private DevExpress.XtraReports.UI.XRLabel xrLabel35;
        private DevExpress.XtraReports.UI.XRLabel xrLabel36;
        private DevExpress.XtraReports.UI.XRLabel xrLabel37;
        private DevExpress.XtraReports.UI.XRLabel xrLabel38;
        private DevExpress.XtraReports.UI.XRLabel xrLabel39;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel xrLabel41;
        private DevExpress.XtraReports.UI.XRLabel xrCheckNumber;
        private DevExpress.XtraReports.UI.XRPanel Rectangle4;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxTopSignature;
        private DevExpress.XtraReports.UI.XRLabel xrVoidAfterMessageCheckBottom;
        private DevExpress.XtraReports.UI.XRShape Line3;
        private DevExpress.XtraReports.UI.XRShape Line2;
        private DevExpress.XtraReports.UI.XRLabel SignatureLineCommentBottomCheck;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxBottomSignature;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxLogo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrMICRAccountNumber;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountLongString15;
        private DevExpress.XtraReports.UI.XRLabel xrCompanyAddressBlockBottomCheck;
        private DevExpress.XtraReports.UI.XRLabel Textbox18;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountShortString4;
        private DevExpress.XtraReports.UI.XRLabel Textbox14;
        private DevExpress.XtraReports.UI.XRLabel Textbox16;
        private DevExpress.XtraReports.UI.XRLabel CheckDate2;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountLongString11;
        private DevExpress.XtraReports.UI.XRLabel CheckAmountShortString3;
        private DevExpress.XtraReports.UI.XRLabel Textbox20;
        private DevExpress.XtraReports.UI.XRLabel OwnerAddressBlock;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPictureBox xrNonNegotiablePicture;
        private DevExpress.XtraReports.UI.XRLabel xrTransitBottomCheck;
        private DevExpress.XtraReports.UI.XRLabel xrCheckEnderLabel;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.SubBand SubBand6;
        private DevExpress.XtraReports.UI.XRSubreport xrCheckCoverPage;
    }
}
