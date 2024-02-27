namespace ReportsEngine.Reports.RDReports
{
    partial class RDChecksRemittanceOnly
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDChecksRemittanceOnly));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrCheckRemittance = new DevExpress.XtraReports.UI.XRSubreport();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngOverflowOptionCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooWillPrintCompanyAddressOnStub = new DevExpress.XtraReports.Parameters.Parameter();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbitMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbitSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckPrintingProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrStartingOwnerNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingOwnerNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSignPath = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormat = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooReturnElectronicPayments = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooReturnPrintedChecks = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrTwoSignaturesRequiredAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngIsTwoSignaturesRequired = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormatIsMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingCheckNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningCheckNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectCheckNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.groupHeaderBand2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.groupHeaderBand3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.EndOfRemittanceOfCheck = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrEndOfRemittanceLabel = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrCheckRemittance});
            this.detailBand1.HeightF = 1F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
            // 
            // xrCheckRemittance
            // 
            this.xrCheckRemittance.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintRemittance <> 2 AND [OverflowOptionCodeID] <> 2")});
            this.xrCheckRemittance.GenerateOwnPages = true;
            this.xrCheckRemittance.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCheckRemittance.Name = "xrCheckRemittance";
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngID", null, "RDCheckHeader.CheckID"));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngImbursementID", null, "RDCheckHeader.ImbursementID"));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngRDCheckStubCodeID", null, null));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooPrintSecondLine", null, null));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngOverflowOptionCode", this.plngOverflowOptionCode));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooRunningAtEnd", null, null));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdblAmount", null, "RDCheckHeader.CheckAmount"));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdblOther", null, "RDCheckHeader.WithholdingAmount"));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdblDeducts", null, "RDCheckHeader.DeductionAmount"));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdblGross", null, "RDCheckHeader.OwnerGross"));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdblTax", null, "RDCheckHeader.TaxAmount"));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", null, "RDCheckHeader.CompanyAddressBlockLong"));
            this.xrCheckRemittance.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooWillPrintCompanyAddressOnStub", this.pbooWillPrintCompanyAddressOnStub));
            this.xrCheckRemittance.ReportSource = new ReportsEngine.Reports.RDReports.RDCheckRemittanceSubreport();
            this.xrCheckRemittance.SizeF = new System.Drawing.SizeF(810F, 1F);
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
            this.plngUserID.Visible = false;
            // 
            // plngOverflowOptionCode
            // 
            this.plngOverflowOptionCode.Description = "Overflow Option Code";
            this.plngOverflowOptionCode.Name = "plngOverflowOptionCode";
            this.plngOverflowOptionCode.Type = typeof(int);
            this.plngOverflowOptionCode.ValueInfo = "0";
            this.plngOverflowOptionCode.Visible = false;
            // 
            // pbooWillPrintCompanyAddressOnStub
            // 
            this.pbooWillPrintCompanyAddressOnStub.Description = "Will Print Company Address On Stub";
            this.pbooWillPrintCompanyAddressOnStub.Name = "pbooWillPrintCompanyAddressOnStub";
            this.pbooWillPrintCompanyAddressOnStub.Type = typeof(bool);
            this.pbooWillPrintCompanyAddressOnStub.ValueInfo = "True";
            this.pbooWillPrintCompanyAddressOnStub.Visible = false;
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.HeightF = 0F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand2});
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SubBand1
            // 
            this.SubBand1.HeightF = 0F;
            this.SubBand1.Name = "SubBand1";
            // 
            // SubBand2
            // 
            this.SubBand2.HeightF = 0F;
            this.SubBand2.Name = "SubBand2";
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "RDCheckHeader";
            queryParameter1.Name = "@plngCheckPrintingProcessTrackingID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCheckPrintingProcessTrackingID", typeof(int));
            queryParameter2.Name = "@pstrStartingOwnerNumber";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?pstrStartingOwnerNumber", typeof(string));
            queryParameter3.Name = "@pstrEndingOwnerNumber";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?pstrEndingOwnerNumber", typeof(string));
            queryParameter4.Name = "@pstrBeginningCheckNumber";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?pstrBeginningCheckNumber", typeof(string));
            queryParameter5.Name = "@pstrEndingCheckNumber";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?pstrBeginningCheckNumber", typeof(string));
            queryParameter6.Name = "@plngCheckFormat";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?plngCheckFormat", typeof(int));
            queryParameter7.Name = "@pbooReturnElectronicPayments";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?pbooReturnElectronicPayments", typeof(bool));
            queryParameter8.Name = "@pbooReturnPrintedChecks";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("?pbooReturnPrintedChecks", typeof(bool));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5,
            queryParameter6,
            queryParameter7,
            queryParameter8});
            storedProcQuery1.StoredProcName = "RDProcessing_CheckPrintingGetChecksToPayHeaders";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // pbitMICR
            // 
            this.pbitMICR.Description = "pbitMICR";
            this.pbitMICR.Name = "pbitMICR";
            this.pbitMICR.Type = typeof(bool);
            this.pbitMICR.ValueInfo = "False";
            this.pbitMICR.Visible = false;
            // 
            // pbitSignature
            // 
            this.pbitSignature.Description = "pbitSignature";
            this.pbitSignature.Name = "pbitSignature";
            this.pbitSignature.Type = typeof(bool);
            this.pbitSignature.Visible = false;
            // 
            // plngCheckPrintingProcessTrackingID
            // 
            this.plngCheckPrintingProcessTrackingID.Description = "plngCheckPrintingProcessTrackingID";
            this.plngCheckPrintingProcessTrackingID.Name = "plngCheckPrintingProcessTrackingID";
            this.plngCheckPrintingProcessTrackingID.Type = typeof(int);
            this.plngCheckPrintingProcessTrackingID.Visible = false;
            // 
            // pstrStartingOwnerNumber
            // 
            this.pstrStartingOwnerNumber.Description = "pstrStartingOwnerNumber";
            this.pstrStartingOwnerNumber.Name = "pstrStartingOwnerNumber";
            this.pstrStartingOwnerNumber.ValueInfo = "1";
            this.pstrStartingOwnerNumber.Visible = false;
            // 
            // pstrEndingOwnerNumber
            // 
            this.pstrEndingOwnerNumber.Description = "pstrEndingOwnerNumber";
            this.pstrEndingOwnerNumber.Name = "pstrEndingOwnerNumber";
            this.pstrEndingOwnerNumber.ValueInfo = "ZZZZZ";
            this.pstrEndingOwnerNumber.Visible = false;
            // 
            // pstrSignPath
            // 
            this.pstrSignPath.Description = "pstrSignPath";
            this.pstrSignPath.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Iif(?pbitSignature = True, \'/ProvidenceReports/Signatures/TestSig.png\', \'\')")});
            this.pstrSignPath.Name = "pstrSignPath";
            this.pstrSignPath.Visible = false;
            // 
            // plngCheckFormat
            // 
            this.plngCheckFormat.Description = "plngCheckFormat";
            this.plngCheckFormat.Name = "plngCheckFormat";
            this.plngCheckFormat.Type = typeof(int);
            this.plngCheckFormat.ValueInfo = "1";
            this.plngCheckFormat.Visible = false;
            // 
            // pbooReturnElectronicPayments
            // 
            this.pbooReturnElectronicPayments.Description = "pbooReturnElectronicPayments";
            this.pbooReturnElectronicPayments.Name = "pbooReturnElectronicPayments";
            this.pbooReturnElectronicPayments.Type = typeof(bool);
            this.pbooReturnElectronicPayments.ValueInfo = "False";
            this.pbooReturnElectronicPayments.Visible = false;
            // 
            // pbooReturnPrintedChecks
            // 
            this.pbooReturnPrintedChecks.Description = "pbooReturnPrintedChecks";
            this.pbooReturnPrintedChecks.Name = "pbooReturnPrintedChecks";
            this.pbooReturnPrintedChecks.Type = typeof(bool);
            this.pbooReturnPrintedChecks.ValueInfo = "True";
            this.pbooReturnPrintedChecks.Visible = false;
            // 
            // pstrTwoSignaturesRequiredAmount
            // 
            this.pstrTwoSignaturesRequiredAmount.Description = "pstrTwoSignaturesRequiredAmount";
            this.pstrTwoSignaturesRequiredAmount.Name = "pstrTwoSignaturesRequiredAmount";
            this.pstrTwoSignaturesRequiredAmount.Visible = false;
            // 
            // plngIsTwoSignaturesRequired
            // 
            this.plngIsTwoSignaturesRequired.Description = "plngIsTwoSignaturesRequired";
            this.plngIsTwoSignaturesRequired.Name = "plngIsTwoSignaturesRequired";
            this.plngIsTwoSignaturesRequired.Type = typeof(bool);
            this.plngIsTwoSignaturesRequired.Visible = false;
            // 
            // plngCheckFormatIsMICR
            // 
            this.plngCheckFormatIsMICR.Description = "plngCheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Name = "plngCheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Type = typeof(bool);
            this.plngCheckFormatIsMICR.Visible = false;
            // 
            // pstrEndingCheckNumber
            // 
            this.pstrEndingCheckNumber.Description = "Ending Check Number";
            this.pstrEndingCheckNumber.Name = "pstrEndingCheckNumber";
            // 
            // pstrBeginningCheckNumber
            // 
            this.pstrBeginningCheckNumber.Description = "Beginning Check Number";
            this.pstrBeginningCheckNumber.Name = "pstrBeginningCheckNumber";
            // 
            // pstrSelectCheckNumber
            // 
            this.pstrSelectCheckNumber.Description = "Select Check";
            this.pstrSelectCheckNumber.MultiValue = true;
            this.pstrSelectCheckNumber.Name = "pstrSelectCheckNumber";
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SortFieldCheckNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.HeightF = 0F;
            this.groupHeaderBand1.Level = 2;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            this.groupHeaderBand1.RepeatEveryPage = true;
            // 
            // groupHeaderBand2
            // 
            this.groupHeaderBand2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CheckNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand2.HeightF = 0F;
            this.groupHeaderBand2.Level = 1;
            this.groupHeaderBand2.Name = "groupHeaderBand2";
            // 
            // groupHeaderBand3
            // 
            this.groupHeaderBand3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CheckID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand3.HeightF = 0F;
            this.groupHeaderBand3.Name = "groupHeaderBand3";
            // 
            // EndOfRemittanceOfCheck
            // 
            this.EndOfRemittanceOfCheck.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrEndOfRemittanceLabel});
            this.EndOfRemittanceOfCheck.HeightF = 2F;
            this.EndOfRemittanceOfCheck.Level = 2;
            this.EndOfRemittanceOfCheck.Name = "EndOfRemittanceOfCheck";
            this.EndOfRemittanceOfCheck.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.EndOfRemittanceOfCheck.PrintAtBottom = true;
            this.EndOfRemittanceOfCheck.Visible = false;
            // 
            // xrEndOfRemittanceLabel
            // 
            this.xrEndOfRemittanceLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrEndOfRemittanceLabel.Name = "xrEndOfRemittanceLabel";
            this.xrEndOfRemittanceLabel.SizeF = new System.Drawing.SizeF(6.875165F, 2F);
            this.xrEndOfRemittanceLabel.Visible = false;
            // 
            // RDChecksRemittanceOnly
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.pageHeaderBand1,
            this.groupHeaderBand1,
            this.groupHeaderBand2,
            this.groupHeaderBand3,
            this.EndOfRemittanceOfCheck});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "RDCheckHeader";
            this.DataSource = this.Dynamic;
            this.DisplayName = "RDChecksRemittanceOnly";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 20F, 20F, 20F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbitMICR, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbitSignature, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCheckPrintingProcessTrackingID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrStartingOwnerNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingOwnerNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSignPath, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCheckFormat, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooReturnElectronicPayments, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooReturnPrintedChecks, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrTwoSignaturesRequiredAmount, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngIsTwoSignaturesRequired, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCheckFormatIsMICR, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingCheckNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningCheckNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectCheckNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.pbitMICR,
            this.pbitSignature,
            this.plngCheckPrintingProcessTrackingID,
            this.pstrStartingOwnerNumber,
            this.pstrEndingOwnerNumber,
            this.pstrSignPath,
            this.plngCheckFormat,
            this.pbooReturnElectronicPayments,
            this.pbooReturnPrintedChecks,
            this.pstrTwoSignaturesRequiredAmount,
            this.plngIsTwoSignaturesRequired,
            this.plngCheckFormatIsMICR,
            this.pstrEndingCheckNumber,
            this.pstrBeginningCheckNumber,
            this.pstrSelectCheckNumber,
            this.plngOverflowOptionCode,
            this.pbooWillPrintCompanyAddressOnStub});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pbitMICR;
        private DevExpress.XtraReports.Parameters.Parameter pbitSignature;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckPrintingProcessTrackingID;
        private DevExpress.XtraReports.Parameters.Parameter pstrStartingOwnerNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingOwnerNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrSignPath;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormat;
        private DevExpress.XtraReports.Parameters.Parameter pbooReturnElectronicPayments;
        private DevExpress.XtraReports.Parameters.Parameter pbooReturnPrintedChecks;
        private DevExpress.XtraReports.Parameters.Parameter pstrTwoSignaturesRequiredAmount;
        private DevExpress.XtraReports.Parameters.Parameter plngIsTwoSignaturesRequired;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormatIsMICR;
        private DevExpress.XtraReports.UI.XRSubreport xrCheckRemittance;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingCheckNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningCheckNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectCheckNumber;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand2;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand3;
        private DevExpress.XtraReports.UI.GroupFooterBand EndOfRemittanceOfCheck;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.XRLabel xrEndOfRemittanceLabel;
        private DevExpress.XtraReports.Parameters.Parameter plngOverflowOptionCode;
        private DevExpress.XtraReports.Parameters.Parameter pbooWillPrintCompanyAddressOnStub;
    }
}
