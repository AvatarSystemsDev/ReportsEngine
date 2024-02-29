namespace ReportsEngine.Reports.APReports
{
    partial class APChecks
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APChecks));
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine1 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine2 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine3 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.XtraPrinting.Shape.ShapeLine shapeLine4 = new DevExpress.XtraPrinting.Shape.ShapeLine();
            DevExpress.DataAccess.DataFederation.SelectNode selectNode1 = new DevExpress.DataAccess.DataFederation.SelectNode();
            DevExpress.DataAccess.DataFederation.SourceNode sourceNode1 = new DevExpress.DataAccess.DataFederation.SourceNode();
            DevExpress.DataAccess.DataFederation.Source source1 = new DevExpress.DataAccess.DataFederation.Source();
            DevExpress.DataAccess.DataFederation.SourceNode sourceNode2 = new DevExpress.DataAccess.DataFederation.SourceNode();
            DevExpress.DataAccess.DataFederation.Source source2 = new DevExpress.DataAccess.DataFederation.Source();
            DevExpress.DataAccess.DataFederation.JoinElement joinElement1 = new DevExpress.DataAccess.DataFederation.JoinElement();
            DevExpress.DataAccess.DataFederation.SelectNode selectNode2 = new DevExpress.DataAccess.DataFederation.SelectNode();
            DevExpress.DataAccess.DataFederation.SourceNode sourceNode3 = new DevExpress.DataAccess.DataFederation.SourceNode();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.RemittanceDetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormatIsMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.booFalse = new DevExpress.XtraReports.Parameters.Parameter();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.xrSEEATTACHEDSTATEMENT = new DevExpress.XtraReports.UI.XRLabel();
            this.pbooMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormat = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSignaturePath = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooReturnElectronicPayments = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooReturnChecks = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooReturnACH = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningVendorNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingVendorNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngIsTwoSignaturesRequired = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrTwoSignaturesRequiredAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.CheckBeginningHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.CheckTopBand = new DevExpress.XtraReports.UI.SubBand();
            this.xrTopCheckPanel = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrVoidAfterMessageCheckBottomTwo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrShape3 = new DevExpress.XtraReports.UI.XRShape();
            this.xrShape4 = new DevExpress.XtraReports.UI.XRShape();
            this.SignatureLineCommentBottomCheckTwo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBoxBottomSignatureTwo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBoxTopSignatureTwo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTransitTopCheck = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMICRTransitNumberTwo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCheckNumberTwo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBoxLogoTwo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMICRAccountNumberTwo = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrNonNegotiablePictureTwo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.PleaseDetachThisRemittanceAdviceBeforeDepositingCheck = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.CompanyAddressBandAboveRemittance = new DevExpress.XtraReports.UI.SubBand();
            this.xrPages = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCompanyHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckInformationPart = new DevExpress.XtraReports.UI.SubBand();
            this.xrPanel4 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText6 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText7 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText8 = new DevExpress.XtraReports.UI.XRRichText();
            this.CheckStubBandTopCheck = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckGroupBottom = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.CheckStubBandBottomCheck = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.CheckBottomBand = new DevExpress.XtraReports.UI.SubBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrTransitBottomCheck = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMICRTransitNumber = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText5 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrNonNegotiablePicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.StubEnd = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.xrCheckEnderLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.plngDatabaseID = new DevExpress.XtraReports.Parameters.Parameter();
            this.federationDataSource1 = new DevExpress.DataAccess.DataFederation.FederationDataSource();
            this.BeginningRemittance = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.EndRemittance = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.CheckBegin = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.CheckCoverPage = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrCheckCoverPage = new DevExpress.XtraReports.UI.XRSubreport();
            this.EndCoverPageBand = new DevExpress.XtraReports.UI.SubBand();
            this.xrEndCoverPage = new DevExpress.XtraReports.UI.XRLabel();
            this.EntryBegin = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.EntryRowEndBand = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.CheckRemittanceOverflowOption4 = new DevExpress.XtraReports.UI.XRSubreport();
            this.booTrue = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngPrintRemittance = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.APChecksRemittanceOnly = new DevExpress.XtraReports.UI.XRSubreport();
            this.CheckEnd = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.SubBand5 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand6 = new DevExpress.XtraReports.UI.SubBand();
            this.pbooHideCheckPart = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageBeginningLabel = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.federationDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSAPCheckHeader";
            queryParameter1.Name = "@plngProcessTrackingID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngProcessTrackingID", typeof(string));
            queryParameter2.Name = "@pstrBeginningVendorNumber";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?pstrBeginningVendorNumber", typeof(string));
            queryParameter3.Name = "@pstrEndingVendorNumber";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?pstrEndingVendorNumber", typeof(string));
            queryParameter4.Name = "@pbooReturnElectronicPayments";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?pbooReturnElectronicPayments", typeof(string));
            queryParameter5.Name = "@pbooReturnChecks";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?pbooReturnChecks", typeof(string));
            queryParameter6.Name = "@pbooReturnACH";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?pbooReturnACH", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5,
            queryParameter6});
            storedProcQuery1.StoredProcName = "APCheckPrinting_GetChecksToPayHeaders";
            storedProcQuery2.Name = "CheckFormattingOptions";
            queryParameter7.Name = "@plngCompanyID";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter8.Name = "@plngCheckTypeCode";
            queryParameter8.Type = typeof(int);
            queryParameter8.ValueInfo = "1";
            queryParameter9.Name = "@plngDatabaseID";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("?plngDatabaseID", typeof(int));
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter7,
            queryParameter8,
            queryParameter9});
            storedProcQuery2.StoredProcName = "CheckFormattingOptions_ReportLookup";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
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
            // RemittanceDetailBand
            // 
            this.RemittanceDetailBand.HeightF = 0F;
            this.RemittanceDetailBand.MultiColumn.ColumnSpacing = 50F;
            this.RemittanceDetailBand.Name = "RemittanceDetailBand";
            this.RemittanceDetailBand.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand3,
            this.SubBand4});
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20});
            this.SubBand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] in (2) AND [IsCheckOnTopOfForm]")});
            this.SubBand1.HeightF = 16.5833F;
            this.SubBand1.Name = "SubBand1";
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
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2});
            this.SubBand3.HeightF = 24.61065F;
            this.SubBand3.Name = "SubBand3";
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 2 AND [OverflowOptionCodeID] <> 2")});
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngID", null, "Dynamic_DSAPCheckHeader.CheckID"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Subtitle", this.Subtitle));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCheckFormatIsMICR", this.plngCheckFormatIsMICR));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooRunningAtEnd", this.booFalse));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngOverflowOptionCode", null, "Dynamic_DSAPCheckHeader.OverflowOptionCodeID"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", null, "Dynamic_DSAPCheckHeader.CompanyAddressBlockLong"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooWillPrintCompanyAddressOnStub", null, "Dynamic_DSAPCheckHeader.WillCenterCompanyNameOnStub"));
            this.xrSubreport2.ReportSource = new ReportsEngine.Reports.APReports.APCheckRemittanceSubreport();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(794.0999F, 24.61065F);
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
            this.plngCheckFormatIsMICR.ValueInfo = "False";
            this.plngCheckFormatIsMICR.Visible = false;
            // 
            // booFalse
            // 
            this.booFalse.Description = "False";
            this.booFalse.Name = "booFalse";
            this.booFalse.Type = typeof(bool);
            this.booFalse.ValueInfo = "False";
            this.booFalse.Visible = false;
            // 
            // SubBand4
            // 
            this.SubBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSEEATTACHEDSTATEMENT});
            this.SubBand4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] in (2) AND not [IsCheckOnTopOfForm]")});
            this.SubBand4.HeightF = 16.5833F;
            this.SubBand4.Name = "SubBand4";
            // 
            // xrSEEATTACHEDSTATEMENT
            // 
            this.xrSEEATTACHEDSTATEMENT.BorderColor = System.Drawing.Color.Black;
            this.xrSEEATTACHEDSTATEMENT.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrSEEATTACHEDSTATEMENT.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrSEEATTACHEDSTATEMENT.BorderWidth = 1F;
            this.xrSEEATTACHEDSTATEMENT.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrSEEATTACHEDSTATEMENT.KeepTogether = true;
            this.xrSEEATTACHEDSTATEMENT.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSEEATTACHEDSTATEMENT.Multiline = true;
            this.xrSEEATTACHEDSTATEMENT.Name = "xrSEEATTACHEDSTATEMENT";
            this.xrSEEATTACHEDSTATEMENT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrSEEATTACHEDSTATEMENT.SizeF = new System.Drawing.SizeF(789.58F, 16.5833F);
            this.xrSEEATTACHEDSTATEMENT.StylePriority.UseBorderColor = false;
            this.xrSEEATTACHEDSTATEMENT.StylePriority.UseBorderDashStyle = false;
            this.xrSEEATTACHEDSTATEMENT.StylePriority.UseBorders = false;
            this.xrSEEATTACHEDSTATEMENT.StylePriority.UseBorderWidth = false;
            this.xrSEEATTACHEDSTATEMENT.StylePriority.UseFont = false;
            this.xrSEEATTACHEDSTATEMENT.StylePriority.UsePadding = false;
            this.xrSEEATTACHEDSTATEMENT.StylePriority.UseTextAlignment = false;
            this.xrSEEATTACHEDSTATEMENT.Text = "SEE ATTACHED STATEMENT";
            this.xrSEEATTACHEDSTATEMENT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
            this.plngCheckFormat.ValueInfo = "0";
            this.plngCheckFormat.Visible = false;
            // 
            // pbooSignature
            // 
            this.pbooSignature.Description = "pbooSignature";
            this.pbooSignature.Name = "pbooSignature";
            this.pbooSignature.Type = typeof(bool);
            this.pbooSignature.Visible = false;
            // 
            // pstrSignaturePath
            // 
            this.pstrSignaturePath.Description = "pstrSignaturePath";
            this.pstrSignaturePath.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Iif(?pbooSignature = True, \'/ProvidenceReports/Signatures/TestSig.png\', \'\')")});
            this.pstrSignaturePath.Name = "pstrSignaturePath";
            this.pstrSignaturePath.ValueInfo = "0";
            this.pstrSignaturePath.Visible = false;
            // 
            // pbooReturnElectronicPayments
            // 
            this.pbooReturnElectronicPayments.Description = "pbooReturnElectronicPayments";
            this.pbooReturnElectronicPayments.Name = "pbooReturnElectronicPayments";
            this.pbooReturnElectronicPayments.Type = typeof(bool);
            this.pbooReturnElectronicPayments.ValueInfo = "False";
            this.pbooReturnElectronicPayments.Visible = false;
            // 
            // pbooReturnChecks
            // 
            this.pbooReturnChecks.Description = "pbooReturnChecks";
            this.pbooReturnChecks.Name = "pbooReturnChecks";
            this.pbooReturnChecks.Type = typeof(bool);
            this.pbooReturnChecks.ValueInfo = "True";
            this.pbooReturnChecks.Visible = false;
            // 
            // pbooReturnACH
            // 
            this.pbooReturnACH.Description = "pbooReturnACH";
            this.pbooReturnACH.Name = "pbooReturnACH";
            this.pbooReturnACH.Type = typeof(bool);
            this.pbooReturnACH.ValueInfo = "False";
            this.pbooReturnACH.Visible = false;
            // 
            // plngProcessTrackingID
            // 
            this.plngProcessTrackingID.Description = "plngProcessTrackingID";
            this.plngProcessTrackingID.Name = "plngProcessTrackingID";
            this.plngProcessTrackingID.Type = typeof(int);
            this.plngProcessTrackingID.ValueInfo = "3159";
            this.plngProcessTrackingID.Visible = false;
            // 
            // pstrBeginningVendorNumber
            // 
            this.pstrBeginningVendorNumber.Description = "pstrBeginningVendorNumber";
            this.pstrBeginningVendorNumber.Name = "pstrBeginningVendorNumber";
            this.pstrBeginningVendorNumber.Visible = false;
            // 
            // pstrEndingVendorNumber
            // 
            this.pstrEndingVendorNumber.Description = "pstrEndingVendorNumber";
            this.pstrEndingVendorNumber.Name = "pstrEndingVendorNumber";
            this.pstrEndingVendorNumber.ValueInfo = "ZZZZZZ";
            this.pstrEndingVendorNumber.Visible = false;
            // 
            // plngIsTwoSignaturesRequired
            // 
            this.plngIsTwoSignaturesRequired.Description = "plngIsTwoSignaturesRequired";
            this.plngIsTwoSignaturesRequired.Name = "plngIsTwoSignaturesRequired";
            this.plngIsTwoSignaturesRequired.Type = typeof(bool);
            this.plngIsTwoSignaturesRequired.ValueInfo = "False";
            this.plngIsTwoSignaturesRequired.Visible = false;
            // 
            // pstrTwoSignaturesRequiredAmount
            // 
            this.pstrTwoSignaturesRequiredAmount.Description = "pstrTwoSignaturesRequiredAmount";
            this.pstrTwoSignaturesRequiredAmount.Name = "pstrTwoSignaturesRequiredAmount";
            this.pstrTwoSignaturesRequiredAmount.Visible = false;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            this.plngCompanyID.Visible = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            // 
            // CheckBeginningHeader
            // 
            this.CheckBeginningHeader.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "not ?pbooHideCheckPart")});
            this.CheckBeginningHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CheckNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending),
            new DevExpress.XtraReports.UI.GroupField("CheckID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CheckBeginningHeader.HeightF = 0F;
            this.CheckBeginningHeader.KeepTogether = true;
            this.CheckBeginningHeader.Level = 1;
            this.CheckBeginningHeader.Name = "CheckBeginningHeader";
            this.CheckBeginningHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.CheckTopBand,
            this.PleaseDetachThisRemittanceAdviceBeforeDepositingCheck,
            this.CompanyAddressBandAboveRemittance,
            this.CheckInformationPart,
            this.CheckStubBandTopCheck});
            // 
            // CheckTopBand
            // 
            this.CheckTopBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTopCheckPanel});
            this.CheckTopBand.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND [IsCheckOnTopOfForm]\n")});
            this.CheckTopBand.HeightF = 280.6049F;
            this.CheckTopBand.Name = "CheckTopBand";
            // 
            // xrTopCheckPanel
            // 
            this.xrTopCheckPanel.BorderColor = System.Drawing.Color.Black;
            this.xrTopCheckPanel.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTopCheckPanel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTopCheckPanel.BorderWidth = 1F;
            this.xrTopCheckPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3,
            this.xrTransitTopCheck,
            this.xrMICRTransitNumberTwo,
            this.xrCheckNumberTwo,
            this.xrPictureBoxLogoTwo,
            this.xrLabel21,
            this.xrMICRAccountNumberTwo,
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintSignature] AND [CheckAmount] >= [TwoSignaturesRequiredAmount]")});
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
            this.xrPictureBoxTopSignatureTwo.LocationFloat = new DevExpress.Utils.PointFloat(12.87985F, 25.8055F);
            this.xrPictureBoxTopSignatureTwo.Name = "xrPictureBoxTopSignatureTwo";
            this.xrPictureBoxTopSignatureTwo.SizeF = new System.Drawing.SizeF(316.1502F, 36.99998F);
            this.xrPictureBoxTopSignatureTwo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'⑆\'")});
            this.xrTransitTopCheck.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
            this.xrTransitTopCheck.KeepTogether = true;
            this.xrTransitTopCheck.LocationFloat = new DevExpress.Utils.PointFloat(228.08F, 254.2717F);
            this.xrTransitTopCheck.Multiline = true;
            this.xrTransitTopCheck.Name = "xrTransitTopCheck";
            this.xrTransitTopCheck.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrTransitTopCheck.SizeF = new System.Drawing.SizeF(18.44336F, 26.32999F);
            this.xrTransitTopCheck.StylePriority.UseFont = false;
            this.xrTransitTopCheck.StylePriority.UsePadding = false;
            this.xrTransitTopCheck.StylePriority.UseTextAlignment = false;
            this.xrTransitTopCheck.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrMICRTransitNumberTwo
            // 
            this.xrMICRTransitNumberTwo.BorderColor = System.Drawing.Color.Black;
            this.xrMICRTransitNumberTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMICRTransitNumberTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMICRTransitNumberTwo.BorderWidth = 1F;
            this.xrMICRTransitNumberTwo.CanGrow = false;
            this.xrMICRTransitNumberTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintMICRInformation]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TransitNumber] + \'⑆\'")});
            this.xrMICRTransitNumberTwo.Font = new DevExpress.Drawing.DXFont("MICR Encoding", 12F);
            this.xrMICRTransitNumberTwo.KeepTogether = true;
            this.xrMICRTransitNumberTwo.LocationFloat = new DevExpress.Utils.PointFloat(246.5233F, 254.2717F);
            this.xrMICRTransitNumberTwo.Multiline = true;
            this.xrMICRTransitNumberTwo.Name = "xrMICRTransitNumberTwo";
            this.xrMICRTransitNumberTwo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrMICRTransitNumberTwo.SizeF = new System.Drawing.SizeF(125.3067F, 26.32999F);
            this.xrMICRTransitNumberTwo.StylePriority.UseFont = false;
            this.xrMICRTransitNumberTwo.StylePriority.UsePadding = false;
            this.xrMICRTransitNumberTwo.StylePriority.UseTextAlignment = false;
            this.xrMICRTransitNumberTwo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'/\'+[SerialNumber]+\'/\'")});
            this.xrCheckNumberTwo.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
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
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
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
            // xrMICRAccountNumberTwo
            // 
            this.xrMICRAccountNumberTwo.BorderColor = System.Drawing.Color.Black;
            this.xrMICRAccountNumberTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMICRAccountNumberTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMICRAccountNumberTwo.BorderWidth = 1F;
            this.xrMICRAccountNumberTwo.CanGrow = false;
            this.xrMICRAccountNumberTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintMICRInformation]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountNumber]+\'/\'")});
            this.xrMICRAccountNumberTwo.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
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
            // xrNonNegotiablePictureTwo
            // 
            this.xrNonNegotiablePictureTwo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(((System.Drawing.Image)(resources.GetObject("xrNonNegotiablePictureTwo.ImageSource"))), true);
            this.xrNonNegotiablePictureTwo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4.391734F);
            this.xrNonNegotiablePictureTwo.Name = "xrNonNegotiablePictureTwo";
            this.xrNonNegotiablePictureTwo.SizeF = new System.Drawing.SizeF(792.9999F, 249.88F);
            this.xrNonNegotiablePictureTwo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
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
            // CompanyAddressBandAboveRemittance
            // 
            this.CompanyAddressBandAboveRemittance.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPages,
            this.xrCompanyHeader});
            this.CompanyAddressBandAboveRemittance.HeightF = 46.82214F;
            this.CompanyAddressBandAboveRemittance.Name = "CompanyAddressBandAboveRemittance";
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
            // CheckInformationPart
            // 
            this.CheckInformationPart.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel4});
            this.CheckInformationPart.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND [IsCheckOnTopOfForm]\n")});
            this.CheckInformationPart.HeightF = 32.47F;
            this.CheckInformationPart.Name = "CheckInformationPart";
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
            this.xrRichText3,
            this.xrRichText6,
            this.xrRichText7,
            this.xrRichText8});
            this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel4.Name = "xrPanel4";
            this.xrPanel4.SizeF = new System.Drawing.SizeF(794.1F, 32.47F);
            this.xrPanel4.StylePriority.UseBorders = false;
            // 
            // xrRichText3
            // 
            this.xrRichText3.BorderColor = System.Drawing.Color.Black;
            this.xrRichText3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText3.BorderWidth = 1F;
            this.xrRichText3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>CHECK " +
                    "NUMBER:</b><br>\' + [CheckNumber] + \'</span>\'")});
            this.xrRichText3.KeepTogether = true;
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(202.73F, 3.490003F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(219.1F, 26.22F);
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
            this.xrRichText6.LocationFloat = new DevExpress.Utils.PointFloat(431.8034F, 3.490067F);
            this.xrRichText6.Name = "xrRichText6";
            this.xrRichText6.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText6.SerializableRtfString = resources.GetString("xrRichText6.SerializableRtfString");
            this.xrRichText6.SizeF = new System.Drawing.SizeF(132.29F, 26.21997F);
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
            this.xrRichText7.LocationFloat = new DevExpress.Utils.PointFloat(572.91F, 3.489939F);
            this.xrRichText7.Name = "xrRichText7";
            this.xrRichText7.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText7.SerializableRtfString = resources.GetString("xrRichText7.SerializableRtfString");
            this.xrRichText7.SizeF = new System.Drawing.SizeF(216.67F, 26.2201F);
            // 
            // xrRichText8
            // 
            this.xrRichText8.BorderColor = System.Drawing.Color.Black;
            this.xrRichText8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrRichText8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrRichText8.BorderWidth = 1F;
            this.xrRichText8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<span style=\"font-family: \'\'Segoe UI\'\'; font-size: 9pt; color: black;\"><b>VENDOR" +
                    ": </b><br>\' + [VendorNumber] + \'</span>\'")});
            this.xrRichText8.KeepTogether = true;
            this.xrRichText8.LocationFloat = new DevExpress.Utils.PointFloat(1.390012F, 3.489939F);
            this.xrRichText8.Name = "xrRichText8";
            this.xrRichText8.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText8.SerializableRtfString = resources.GetString("xrRichText8.SerializableRtfString");
            this.xrRichText8.SizeF = new System.Drawing.SizeF(199.65F, 26.22007F);
            // 
            // CheckStubBandTopCheck
            // 
            this.CheckStubBandTopCheck.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel33});
            this.CheckStubBandTopCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND [IsCheckOnTopOfForm]\n AN" +
                    "D not IsNullOrEmpty([CheckStubMessage])\n")});
            this.CheckStubBandTopCheck.HeightF = 11.40547F;
            this.CheckStubBandTopCheck.Name = "CheckStubBandTopCheck";
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
            // CheckGroupBottom
            // 
            this.CheckGroupBottom.HeightF = 0F;
            this.CheckGroupBottom.Level = 1;
            this.CheckGroupBottom.Name = "CheckGroupBottom";
            this.CheckGroupBottom.PrintAtBottom = true;
            this.CheckGroupBottom.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.CheckStubBandBottomCheck,
            this.CheckBottomBand,
            this.StubEnd,
            this.SubBand2});
            // 
            // CheckStubBandBottomCheck
            // 
            this.CheckStubBandBottomCheck.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel19});
            this.CheckStubBandBottomCheck.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 1 AND not ?pbooHideCheckPart AND not [IsCheckOnTopOfForm]" +
                    "\n AND not IsNullOrEmpty([CheckStubMessage])\n")});
            this.CheckStubBandBottomCheck.HeightF = 11.40547F;
            this.CheckStubBandBottomCheck.Name = "CheckStubBandBottomCheck";
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
            // xrPanel1
            // 
            this.xrPanel1.BorderColor = System.Drawing.Color.Black;
            this.xrPanel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel1.BorderWidth = 1F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTransitBottomCheck,
            this.xrMICRTransitNumber,
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
            this.xrPanel2,
            this.xrLabel2,
            this.xrNonNegotiablePicture});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(794.0999F, 345.1883F);
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'⑆\'")});
            this.xrTransitBottomCheck.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
            this.xrTransitBottomCheck.KeepTogether = true;
            this.xrTransitBottomCheck.LocationFloat = new DevExpress.Utils.PointFloat(228.08F, 318.2301F);
            this.xrTransitBottomCheck.Multiline = true;
            this.xrTransitBottomCheck.Name = "xrTransitBottomCheck";
            this.xrTransitBottomCheck.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrTransitBottomCheck.SizeF = new System.Drawing.SizeF(18.44336F, 26.32999F);
            this.xrTransitBottomCheck.StylePriority.UseFont = false;
            this.xrTransitBottomCheck.StylePriority.UsePadding = false;
            this.xrTransitBottomCheck.StylePriority.UseTextAlignment = false;
            this.xrTransitBottomCheck.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrMICRTransitNumber
            // 
            this.xrMICRTransitNumber.BorderColor = System.Drawing.Color.Black;
            this.xrMICRTransitNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMICRTransitNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMICRTransitNumber.BorderWidth = 1F;
            this.xrMICRTransitNumber.CanGrow = false;
            this.xrMICRTransitNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[WillPrintMICRInformation]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TransitNumber] + \'⑆\'")});
            this.xrMICRTransitNumber.Font = new DevExpress.Drawing.DXFont("MICR Encoding", 12F);
            this.xrMICRTransitNumber.KeepTogether = true;
            this.xrMICRTransitNumber.LocationFloat = new DevExpress.Utils.PointFloat(246.5233F, 318.2301F);
            this.xrMICRTransitNumber.Multiline = true;
            this.xrMICRTransitNumber.Name = "xrMICRTransitNumber";
            this.xrMICRTransitNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrMICRTransitNumber.SizeF = new System.Drawing.SizeF(125.3067F, 26.32999F);
            this.xrMICRTransitNumber.StylePriority.UseFont = false;
            this.xrMICRTransitNumber.StylePriority.UsePadding = false;
            this.xrMICRTransitNumber.StylePriority.UseTextAlignment = false;
            this.xrMICRTransitNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'/\'+[SerialNumber]+\'/\'")});
            this.xrCheckNumber.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
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
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountNumber]+\'/\'")});
            this.xrMICRAccountNumber.Font = new DevExpress.Drawing.DXFont("MICRE13B", 12F);
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
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
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
                    "NUMBER:</b><br>\' + [CheckNumber] + \'</span>\'")});
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
                    "/b><br>\' + FormatString(\'{0:d}\', [CheckDate]) + \'</span>\'")});
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
                    ":</b><br>\' + FormatString(\'{0:c2}\', [CheckAmount]) + \'</span>\'")});
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
                    ": </b><br>\' + [VendorNumber] + \'</span>\'")});
            this.xrRichText5.KeepTogether = true;
            this.xrRichText5.LocationFloat = new DevExpress.Utils.PointFloat(1.390012F, 3.489939F);
            this.xrRichText5.Name = "xrRichText5";
            this.xrRichText5.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrRichText5.SerializableRtfString = resources.GetString("xrRichText5.SerializableRtfString");
            this.xrRichText5.SizeF = new System.Drawing.SizeF(199.65F, 26.22007F);
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
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(5.35F, 39.41F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(780.21F, 20.83F);
            this.xrLabel2.Text = "PLEASE DETACH THIS REMITTANCE ADVICE BEFORE DEPOSITING CHECK";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrNonNegotiablePicture
            // 
            this.xrNonNegotiablePicture.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrNonNegotiablePicture.ImageSource"));
            this.xrNonNegotiablePicture.LocationFloat = new DevExpress.Utils.PointFloat(0F, 68.35001F);
            this.xrNonNegotiablePicture.Name = "xrNonNegotiablePicture";
            this.xrNonNegotiablePicture.SizeF = new System.Drawing.SizeF(794.0999F, 249.88F);
            this.xrNonNegotiablePicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // StubEnd
            // 
            this.StubEnd.HeightF = 0F;
            this.StubEnd.Name = "StubEnd";
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckEnderLabel});
            this.SubBand2.HeightF = 2F;
            this.SubBand2.Name = "SubBand2";
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
            // plngDatabaseID
            // 
            this.plngDatabaseID.Description = "Database";
            this.plngDatabaseID.Name = "plngDatabaseID";
            this.plngDatabaseID.Type = typeof(int);
            this.plngDatabaseID.ValueInfo = "1";
            this.plngDatabaseID.Visible = false;
            // 
            // federationDataSource1
            // 
            this.federationDataSource1.Name = "federationDataSource1";
            selectNode1.Alias = "Dynamic_DSAPCheckHeader";
            sourceNode1.Alias = null;
            sourceNode1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"657\" />";
            source1.DataMember = "DSAPCheckHeader";
            source1.DataSource = this.Dynamic;
            source1.Name = "Dynamic_DSAPCheckHeader";
            sourceNode1.Source = source1;
            sourceNode2.Alias = "CheckFormattingOptions";
            sourceNode2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"557\" />";
            source2.DataMember = "CheckFormattingOptions";
            source2.DataSource = this.Dynamic;
            source2.Name = "Dynamic_CheckFormattingOptions";
            sourceNode2.Source = source2;
            selectNode1.Expressions.AddRange(new DevExpress.DataAccess.DataFederation.ISelectExpression[] {
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "EntryRow"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "SortCheckNumber"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "ProcessTrackingID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CheckDate"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CompanyID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CompanyName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CompanyAddressBlockLong"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CompanyAddressBlockShort"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CheckNumber"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CheckID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CheckAmount"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CheckAmountShortString"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CheckAmountLongString"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "BankID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "AccountNumber"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "TransitNumber"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "SerialNumber"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "BankName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "BankNumber"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "VendorID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "VendorName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "VendorNumber"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "EntityNumberName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "VendorAddressBlock"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "EMailAddress"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "IsCheck"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "WillEMailCheckDetail"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "BankAddressBlock"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "CheckPrintingSortMethodTypeCodeID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "CheckLogoDisplayOptionCodeID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "OverflowOptionCodeID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "CheckStubMessage"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "TwoSignaturesRequiredAmount"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "SignatureLineComment"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "IsCheckOnTopOfForm"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "WillCenterCompanyNameOnStub"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "WillPrintBankAccountName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "WillPrintCompanyAddressOnStub"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "WillPrintDetailOnStub"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "WillPrintMICRInformation"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "WillPrintSecondDescriptionLine"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "WillPrintSignature"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "WillPrintTwoSignatureLines"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "WillPrintCoverSheet"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "VoidAfterMessage"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "LogoPath"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "SignaturePath"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "SecondSignaturePath"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "FileExtensionOriginalLogo"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "FileExtensionOriginalSignature"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode2, "FileExtensionOriginalSecondarySignature"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode1, "CompanyAddressBlockCoverSheet")});
            selectNode1.Root = sourceNode1;
            joinElement1.Condition = "[[CheckFormattingOptions\\].[EntryRow\\]] = [[Dynamic_DSAPCheckHeader\\].[EntryRow\\]" +
    "]";
            joinElement1.Node = sourceNode2;
            selectNode1.SubNodes.AddRange(new DevExpress.DataAccess.DataFederation.JoinElement[] {
            joinElement1});
            selectNode2.Alias = "Dynamic_CheckFormattingOptions";
            sourceNode3.Alias = null;
            sourceNode3.Source = source2;
            selectNode2.Expressions.AddRange(new DevExpress.DataAccess.DataFederation.ISelectExpression[] {
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "EntryRow"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "CheckPrintingSortMethodTypeCodeID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "CheckLogoDisplayOptionCodeID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "OverflowOptionCodeID"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "CheckStubMessage"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "SignatureLineComment"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "TwoSignaturesRequiredAmount"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "IsCheckOnTopOfForm"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "WillCenterCompanyNameOnStub"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "WillPrintBankAccountName"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "WillPrintCompanyAddressOnStub"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "WillPrintDetailOnStub"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "WillPrintMICRInformation"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "WillPrintSecondDescriptionLine"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "WillPrintSignature"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "WillPrintTwoSignatureLines"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "WillPrintCoverSheet"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "VoidAfterMessage"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "LogoPath"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "SignaturePath"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "SecondSignaturePath"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "FileExtensionOriginalLogo"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "FileExtensionOriginalSignature"),
            new DevExpress.DataAccess.DataFederation.SelectColumnExpression(sourceNode3, "FileExtensionOriginalSecondarySignature")});
            selectNode2.Root = sourceNode3;
            this.federationDataSource1.Queries.AddRange(new DevExpress.DataAccess.DataFederation.QueryNode[] {
            selectNode1,
            selectNode2});
            // 
            // BeginningRemittance
            // 
            this.BeginningRemittance.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CheckID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.BeginningRemittance.HeightF = 0F;
            this.BeginningRemittance.Name = "BeginningRemittance";
            // 
            // EndRemittance
            // 
            this.EndRemittance.HeightF = 2.561251F;
            this.EndRemittance.Name = "EndRemittance";
            // 
            // CheckBegin
            // 
            this.CheckBegin.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "not ?pbooHideCheckPart")});
            this.CheckBegin.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SortCheckNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CheckBegin.HeightF = 0F;
            this.CheckBegin.Level = 2;
            this.CheckBegin.Name = "CheckBegin";
            // 
            // CheckCoverPage
            // 
            this.CheckCoverPage.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckCoverPage});
            this.CheckCoverPage.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] in (1, 4)\n")});
            this.CheckCoverPage.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SortCheckNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.CheckCoverPage.HeightF = 0F;
            this.CheckCoverPage.Level = 3;
            this.CheckCoverPage.Name = "CheckCoverPage";
            this.CheckCoverPage.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.EndCoverPageBand});
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
            this.xrCheckCoverPage.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", this.Dynamic, "DSAPCheckHeader.CompanyAddressBlockCoverSheet"));
            this.xrCheckCoverPage.ReportSource = new ReportsEngine.Reports.RDReports.CheckCoverPage();
            this.xrCheckCoverPage.SizeF = new System.Drawing.SizeF(809F, 0F);
            // 
            // EndCoverPageBand
            // 
            this.EndCoverPageBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrEndCoverPage});
            this.EndCoverPageBand.HeightF = 2F;
            this.EndCoverPageBand.Name = "EndCoverPageBand";
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
            // EntryBegin
            // 
            this.EntryBegin.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("EntryRow", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.EntryBegin.HeightF = 0F;
            this.EntryBegin.Level = 4;
            this.EntryBegin.Name = "EntryBegin";
            // 
            // EntryRowEndBand
            // 
            this.EntryRowEndBand.HeightF = 0F;
            this.EntryRowEndBand.Level = 4;
            this.EntryRowEndBand.Name = "EntryRowEndBand";
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.CheckRemittanceOverflowOption4});
            this.groupFooterBand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] = 4 AND not ?pbooHideCheckPart")});
            this.groupFooterBand1.HeightF = 19.40232F;
            this.groupFooterBand1.Level = 3;
            this.groupFooterBand1.Name = "groupFooterBand1";
            this.groupFooterBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            // 
            // CheckRemittanceOverflowOption4
            // 
            this.CheckRemittanceOverflowOption4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 2 AND [OverflowOptionCodeID] <> 2")});
            this.CheckRemittanceOverflowOption4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.CheckRemittanceOverflowOption4.Name = "CheckRemittanceOverflowOption4";
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngID", null, "Dynamic_DSAPCheckHeader.CheckID"));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngOverflowOptionCode", null, "Dynamic_DSAPCheckHeader.OverflowOptionCodeID"));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooRunningAtEnd", this.booTrue));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Subtitle", this.Subtitle));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCheckFormatIsMICR", this.plngCheckFormatIsMICR));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", null, "Dynamic_DSAPCheckHeader.CompanyAddressBlockLong"));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooWillPrintCompanyAddressOnStub", null, "Dynamic_CheckFormattingOptions.WillPrintCompanyAddressOnStub"));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdblCheckAmount", null, "Dynamic_DSAPCheckHeader.CheckAmount"));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdteCheckDate", null, "Dynamic_DSAPCheckHeader.CheckDate"));
            this.CheckRemittanceOverflowOption4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCheckNumber", null, "Dynamic_DSAPCheckHeader.CheckNumber"));
            this.CheckRemittanceOverflowOption4.ReportSource = new ReportsEngine.Reports.APReports.APCheckRemittanceSubreport();
            this.CheckRemittanceOverflowOption4.SizeF = new System.Drawing.SizeF(799F, 19.40232F);
            // 
            // booTrue
            // 
            this.booTrue.Description = "True";
            this.booTrue.Name = "booTrue";
            this.booTrue.Type = typeof(bool);
            this.booTrue.ValueInfo = "True";
            this.booTrue.Visible = false;
            // 
            // plngPrintRemittance
            // 
            this.plngPrintRemittance.Description = "Print Remittance";
            this.plngPrintRemittance.Name = "plngPrintRemittance";
            this.plngPrintRemittance.Type = typeof(int);
            this.plngPrintRemittance.ValueInfo = "0";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(0, "Print Check with Remit"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "Print Remit"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(2, "Print Check Only"));
            this.plngPrintRemittance.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.APChecksRemittanceOnly});
            this.ReportFooter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "not ?pbooHideCheckPart AND ?plngPrintRemittance = 0 AND [OverflowOptionCodeID] in" +
                    " (2,3)\n")});
            this.ReportFooter.HeightF = 2F;
            this.ReportFooter.Name = "ReportFooter";
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
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCheckFormatIsMICR", this.plngCheckFormatIsMICR));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngOverflowOptionCode", null, "Dynamic_DSAPCheckHeader.OverflowOptionCodeID"));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooWillPrintCompanyAddressOnStub", null, "Dynamic_DSAPCheckHeader.WillPrintCompanyAddressOnStub"));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", null, "Dynamic_DSAPCheckHeader.CompanyAddressBlockLong"));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngProcessTrackingID", this.plngProcessTrackingID));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrBeginningVendor", this.pstrBeginningVendorNumber));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrEndingVendor", this.pstrEndingVendorNumber));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooReturnElectronicPayments", this.pbooReturnElectronicPayments));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooReturnChecks", this.pbooReturnChecks));
            this.APChecksRemittanceOnly.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooReturnACH", this.pbooReturnACH));
            this.APChecksRemittanceOnly.ReportSource = new ReportsEngine.Reports.APReports.APChecksRemittanceOnly();
            this.APChecksRemittanceOnly.SizeF = new System.Drawing.SizeF(809F, 2F);
            // 
            // CheckEnd
            // 
            this.CheckEnd.HeightF = 0F;
            this.CheckEnd.Level = 2;
            this.CheckEnd.Name = "CheckEnd";
            this.CheckEnd.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.CheckEnd.PrintAtBottom = true;
            this.CheckEnd.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand5,
            this.SubBand6});
            // 
            // SubBand5
            // 
            this.SubBand5.HeightF = 0F;
            this.SubBand5.Name = "SubBand5";
            // 
            // SubBand6
            // 
            this.SubBand6.HeightF = 0F;
            this.SubBand6.Name = "SubBand6";
            // 
            // pbooHideCheckPart
            // 
            this.pbooHideCheckPart.Description = "Hide Check";
            this.pbooHideCheckPart.Name = "pbooHideCheckPart";
            this.pbooHideCheckPart.Type = typeof(bool);
            this.pbooHideCheckPart.ValueInfo = "False";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageBeginningLabel});
            this.PageFooter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[OverflowOptionCodeID] = 1")});
            this.PageFooter.HeightF = 2F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter;
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
            // APChecks
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.RemittanceDetailBand,
            this.ReportHeader,
            this.PageHeader,
            this.CheckBeginningHeader,
            this.CheckGroupBottom,
            this.BeginningRemittance,
            this.EndRemittance,
            this.CheckBegin,
            this.CheckCoverPage,
            this.EntryBegin,
            this.EntryRowEndBand,
            this.groupFooterBand1,
            this.ReportFooter,
            this.CheckEnd,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic,
            this.federationDataSource1});
            this.DataMember = "Dynamic_DSAPCheckHeader";
            this.DataSource = this.federationDataSource1;
            this.DisplayName = "APChecks";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 21F, 12.5F, 12.5F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngDatabaseID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooMICR, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCheckFormat, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooSignature, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSignaturePath, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngPrintRemittance, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooReturnElectronicPayments, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooReturnChecks, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooReturnACH, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngProcessTrackingID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningVendorNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingVendorNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCheckFormatIsMICR, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngIsTwoSignaturesRequired, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrTwoSignaturesRequiredAmount, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooHideCheckPart, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.booFalse, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.booTrue, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.plngDatabaseID,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.pbooMICR,
            this.plngCheckFormat,
            this.pbooSignature,
            this.pstrSignaturePath,
            this.plngPrintRemittance,
            this.pbooReturnElectronicPayments,
            this.pbooReturnChecks,
            this.pbooReturnACH,
            this.plngProcessTrackingID,
            this.pstrBeginningVendorNumber,
            this.pstrEndingVendorNumber,
            this.plngCheckFormatIsMICR,
            this.plngIsTwoSignaturesRequired,
            this.pstrTwoSignaturesRequiredAmount,
            this.plngCompanyID,
            this.pbooHideCheckPart,
            this.booFalse,
            this.booTrue});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.federationDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand RemittanceDetailBand;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pbooMICR;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormat;
        private DevExpress.XtraReports.Parameters.Parameter pbooSignature;
        private DevExpress.XtraReports.Parameters.Parameter pstrSignaturePath;
        private DevExpress.XtraReports.Parameters.Parameter pbooReturnElectronicPayments;
        private DevExpress.XtraReports.Parameters.Parameter pbooReturnChecks;
        private DevExpress.XtraReports.Parameters.Parameter pbooReturnACH;
        private DevExpress.XtraReports.Parameters.Parameter plngProcessTrackingID;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningVendorNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingVendorNumber;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormatIsMICR;
        private DevExpress.XtraReports.Parameters.Parameter plngIsTwoSignaturesRequired;
        private DevExpress.XtraReports.Parameters.Parameter pstrTwoSignaturesRequiredAmount;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.GroupHeaderBand CheckBeginningHeader;
        private DevExpress.XtraReports.UI.GroupFooterBand CheckGroupBottom;
        private DevExpress.XtraReports.Parameters.Parameter plngDatabaseID;
        private DevExpress.XtraReports.UI.SubBand CheckStubBandBottomCheck;
        private DevExpress.DataAccess.DataFederation.FederationDataSource federationDataSource1;
        private DevExpress.XtraReports.UI.SubBand CheckBottomBand;
        private DevExpress.XtraReports.UI.SubBand StubEnd;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.GroupHeaderBand BeginningRemittance;
        private DevExpress.XtraReports.UI.GroupFooterBand EndRemittance;
        private DevExpress.XtraReports.UI.GroupHeaderBand CheckBegin;
        private DevExpress.XtraReports.UI.GroupHeaderBand CheckCoverPage;
        private DevExpress.XtraReports.UI.GroupHeaderBand EntryBegin;
        private DevExpress.XtraReports.UI.GroupFooterBand EntryRowEndBand;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.XRSubreport CheckRemittanceOverflowOption4;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText2;
        private DevExpress.XtraReports.UI.XRRichText xrRichText4;
        private DevExpress.XtraReports.UI.XRRichText xrRichText5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrSEEATTACHEDSTATEMENT;
        private DevExpress.XtraReports.UI.SubBand CheckTopBand;
        private DevExpress.XtraReports.UI.SubBand PleaseDetachThisRemittanceAdviceBeforeDepositingCheck;
        private DevExpress.XtraReports.UI.SubBand CompanyAddressBandAboveRemittance;
        private DevExpress.XtraReports.UI.SubBand CheckInformationPart;
        private DevExpress.XtraReports.UI.SubBand CheckStubBandTopCheck;
        private DevExpress.XtraReports.UI.XRPanel xrTopCheckPanel;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRLabel xrVoidAfterMessageCheckBottomTwo;
        private DevExpress.XtraReports.UI.XRShape xrShape3;
        private DevExpress.XtraReports.UI.XRShape xrShape4;
        private DevExpress.XtraReports.UI.XRLabel SignatureLineCommentBottomCheckTwo;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxBottomSignatureTwo;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxTopSignatureTwo;
        private DevExpress.XtraReports.UI.XRLabel xrTransitTopCheck;
        private DevExpress.XtraReports.UI.XRLabel xrMICRTransitNumberTwo;
        private DevExpress.XtraReports.UI.XRLabel xrCheckNumberTwo;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxLogoTwo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrMICRAccountNumberTwo;
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
        private DevExpress.XtraReports.Parameters.Parameter plngPrintRemittance;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.GroupFooterBand CheckEnd;
        private DevExpress.XtraReports.UI.SubBand SubBand5;
        private DevExpress.XtraReports.UI.SubBand SubBand6;
        private DevExpress.XtraReports.UI.XRLabel xrCheckEnderLabel;
        private DevExpress.XtraReports.UI.SubBand EndCoverPageBand;
        private DevExpress.XtraReports.UI.XRSubreport xrCheckCoverPage;
        private DevExpress.XtraReports.UI.XRPanel xrPanel4;
        private DevExpress.XtraReports.UI.XRRichText xrRichText3;
        private DevExpress.XtraReports.UI.XRRichText xrRichText6;
        private DevExpress.XtraReports.UI.XRRichText xrRichText7;
        private DevExpress.XtraReports.UI.XRRichText xrRichText8;
        private DevExpress.XtraReports.UI.XRLabel xrTransitBottomCheck;
        private DevExpress.XtraReports.UI.XRLabel xrMICRTransitNumber;
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
        private DevExpress.XtraReports.UI.XRPictureBox xrNonNegotiablePicture;
        private DevExpress.XtraReports.Parameters.Parameter pbooHideCheckPart;
        private DevExpress.XtraReports.UI.XRSubreport APChecksRemittanceOnly;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xrPageBeginningLabel;
        private DevExpress.XtraReports.Parameters.Parameter booFalse;
        private DevExpress.XtraReports.Parameters.Parameter booTrue;
        private DevExpress.XtraReports.UI.XRLabel xrEndCoverPage;
    }
}
