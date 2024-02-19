namespace ReportsEngine.Reports.MDReports
{
    partial class VendorLabels
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter11 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter12 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter13 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter14 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorLabels));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings2 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings5 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningVendorNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingVendorNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngShowActive = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngAddressToReturn = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooReturnNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.VerticalDetail = new DevExpress.XtraReports.UI.VerticalDetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.plngPrintLabel = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.pstrSelectVendor = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowLabelWithoutAddress = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooIncludeCompanyOwner = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrRoleIDs = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "VendorLabels";
            queryParameter1.Name = "@pstrBeginningVendorNumber";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?pstrBeginningVendorNumber", typeof(string));
            queryParameter2.Name = "@pstrEndingVendorNumber";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?pstrEndingVendorNumber", typeof(string));
            queryParameter3.Name = "@plngShowActive";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?plngShowActive", typeof(bool));
            queryParameter4.Name = "@pbooReturnNumber";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?pbooReturnNumber", typeof(bool));
            queryParameter5.Name = "@pbooShowLabelWithoutAddress";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?pbooShowLabelWithoutAddress", typeof(bool));
            queryParameter6.Name = "@pbooIncludeCompanyOwner";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?pbooIncludeCompanyOwner", typeof(bool));
            queryParameter7.Name = "@pstrRoleIDs";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("Join(?pstrRoleIDs)", typeof(string));
            queryParameter8.Name = "@plngAddressToReturn";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("?plngAddressToReturn", typeof(int));
            queryParameter9.Name = "@plngCompanyID";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5,
            queryParameter6,
            queryParameter7,
            queryParameter8,
            queryParameter9});
            storedProcQuery1.StoredProcName = "Report_VendorLabels";
            storedProcQuery2.Name = "LookupVendors";
            queryParameter10.Name = "@plngVendorsToShow";
            queryParameter10.Type = typeof(int);
            queryParameter10.ValueInfo = "8";
            queryParameter11.Name = "@plngCompanyID";
            queryParameter11.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter11.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter10,
            queryParameter11});
            storedProcQuery2.StoredProcName = "Vendors_ReportLookup";
            customSqlQuery1.Name = "LookupAddressTypeCode";
            customSqlQuery1.Sql = "Select\r\n\t0 AS ID,\r\n\t\'No Address\' AS Description\r\n\r\nUNION ALL \r\n\r\nSelect \r\n\tID,\r\n\t" +
    "Description\r\nfrom AddressTypeCode\r\nWHERE IsValidForEntities = 1";
            storedProcQuery3.Name = "EntityRoleTypeLookup";
            queryParameter12.Name = "@pbooIncludeOwner";
            queryParameter12.Type = typeof(bool);
            queryParameter12.ValueInfo = "True";
            queryParameter13.Name = "@pbooWillUseVendorOptionsOnly";
            queryParameter13.Type = typeof(bool);
            queryParameter13.ValueInfo = "False";
            queryParameter14.Name = "@pbooIncludeAll";
            queryParameter14.Type = typeof(bool);
            queryParameter14.ValueInfo = "False";
            storedProcQuery3.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter12,
            queryParameter13,
            queryParameter14});
            storedProcQuery3.StoredProcName = "EntityRoles_ReportLookup";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            customSqlQuery1,
            storedProcQuery3});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 30F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 0F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
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
            // pstrBeginningVendorNumber
            // 
            this.pstrBeginningVendorNumber.Description = "Beginning Entity";
            this.pstrBeginningVendorNumber.Name = "pstrBeginningVendorNumber";
            this.pstrBeginningVendorNumber.ValueInfo = "!";
            dynamicListLookUpSettings1.DataMember = "LookupVendors";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.FilterString = "[RoleType] = 0 OR [RoleTypeID] In (?pstrRoleIDs)";
            dynamicListLookUpSettings1.ValueMember = "Number";
            this.pstrBeginningVendorNumber.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // pstrEndingVendorNumber
            // 
            this.pstrEndingVendorNumber.Description = "Ending Entity";
            this.pstrEndingVendorNumber.Name = "pstrEndingVendorNumber";
            this.pstrEndingVendorNumber.ValueInfo = "ZZZZZZZZZZ";
            dynamicListLookUpSettings2.DataMember = "LookupVendors";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "Description";
            dynamicListLookUpSettings2.FilterString = "[RoleType] = 0 OR [RoleTypeID] In (?pstrRoleIDs)";
            dynamicListLookUpSettings2.ValueMember = "Number";
            this.pstrEndingVendorNumber.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // plngShowActive
            // 
            this.plngShowActive.Description = "Show Active";
            this.plngShowActive.Name = "plngShowActive";
            this.plngShowActive.Type = typeof(int);
            this.plngShowActive.ValueInfo = "0";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(0, "All"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "Show Active Only"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(2, "Show Inactive Only"));
            this.plngShowActive.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // plngAddressToReturn
            // 
            this.plngAddressToReturn.Description = "Select the Address To Print";
            this.plngAddressToReturn.Name = "plngAddressToReturn";
            this.plngAddressToReturn.Type = typeof(int);
            this.plngAddressToReturn.ValueInfo = "1";
            dynamicListLookUpSettings3.DataMember = "LookupAddressTypeCode";
            dynamicListLookUpSettings3.DataSource = this.Dynamic;
            dynamicListLookUpSettings3.DisplayMember = "Description";
            dynamicListLookUpSettings3.FilterString = null;
            dynamicListLookUpSettings3.SortMember = null;
            dynamicListLookUpSettings3.ValueMember = "ID";
            this.plngAddressToReturn.ValueSourceSettings = dynamicListLookUpSettings3;
            // 
            // pbooReturnNumber
            // 
            this.pbooReturnNumber.Description = "Show Entity Code";
            this.pbooReturnNumber.Name = "pbooReturnNumber";
            this.pbooReturnNumber.Type = typeof(bool);
            this.pbooReturnNumber.ValueInfo = "False";
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            this.plngCompanyID.Visible = false;
            // 
            // VerticalDetail
            // 
            this.VerticalDetail.BandLayout = DevExpress.XtraReports.UI.VerticalBandLayout.AcrossThenDown;
            this.VerticalDetail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.VerticalDetail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "WidthF", "Iif(?plngPrintLabel = 5160, 283.33, 425)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "HeightF", "iif(?plngPrintLabel = 5164,350, Iif(?plngPrintLabel = 5163,210,105 ))\n")});
            this.VerticalDetail.HeightF = 95F;
            this.VerticalDetail.Name = "VerticalDetail";
            this.VerticalDetail.WidthF = 283F;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VendorAddressBlock]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "LeftF", "Iif(?plngPrintLabel<> 5160, 5F, 33F)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "WidthF", "Iif(?plngPrintLabel = 5160,250, 420)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Padding.Left", "Iif(?plngPrintLabel<>5160,15 ,3 )"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "HeightF", "iif(?plngPrintLabel = 5164,350, Iif(?plngPrintLabel = 5163,210,105 ))\n")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(33.33003F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(239.67F, 95F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // plngPrintLabel
            // 
            this.plngPrintLabel.Description = "Avery Label";
            this.plngPrintLabel.Name = "plngPrintLabel";
            this.plngPrintLabel.Type = typeof(int);
            this.plngPrintLabel.ValueInfo = "5160";
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(5160, "Avery 5160 1\" X 2 5/8\""));
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(5161, "Avery 5161 1\" X 4\""));
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(5163, "Avery 5163 2\" X 4\""));
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(5164, "Avery 5164 3 1/3\" X 4\""));
            this.plngPrintLabel.ValueSourceSettings = staticListLookUpSettings2;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.PageHeader.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?plngPrintLabel = 5165")});
            this.PageHeader.HeightF = 25F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "WidthF", "Iif(?plngPrintLabel = 5160,250, 380)\n")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(65.6217F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(148.96F, 25F);
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorderDashStyle = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "                            ";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pstrSelectVendor
            // 
            this.pstrSelectVendor.Description = "Select Entity List";
            this.pstrSelectVendor.MultiValue = true;
            this.pstrSelectVendor.Name = "pstrSelectVendor";
            this.pstrSelectVendor.SelectAllValues = true;
            dynamicListLookUpSettings4.DataMember = "LookupVendors";
            dynamicListLookUpSettings4.DataSource = this.Dynamic;
            dynamicListLookUpSettings4.DisplayMember = "Description";
            dynamicListLookUpSettings4.FilterString = "[RoleType] = 0 OR [RoleTypeID] In (?pstrRoleIDs)";
            dynamicListLookUpSettings4.SortMember = null;
            dynamicListLookUpSettings4.ValueMember = "Number";
            this.pstrSelectVendor.ValueSourceSettings = dynamicListLookUpSettings4;
            // 
            // pbooShowLabelWithoutAddress
            // 
            this.pbooShowLabelWithoutAddress.Description = "Show Entities Without Address";
            this.pbooShowLabelWithoutAddress.Name = "pbooShowLabelWithoutAddress";
            this.pbooShowLabelWithoutAddress.Type = typeof(bool);
            this.pbooShowLabelWithoutAddress.ValueInfo = "True";
            // 
            // pbooIncludeCompanyOwner
            // 
            this.pbooIncludeCompanyOwner.Description = "Include Company Owner";
            this.pbooIncludeCompanyOwner.Name = "pbooIncludeCompanyOwner";
            this.pbooIncludeCompanyOwner.Type = typeof(bool);
            this.pbooIncludeCompanyOwner.ValueInfo = "False";
            // 
            // pstrRoleIDs
            // 
            this.pstrRoleIDs.AllowNull = true;
            this.pstrRoleIDs.Description = "Entity Role";
            this.pstrRoleIDs.MultiValue = true;
            this.pstrRoleIDs.Name = "pstrRoleIDs";
            this.pstrRoleIDs.SelectAllValues = true;
            this.pstrRoleIDs.Type = typeof(int);
            dynamicListLookUpSettings5.DataMember = "EntityRoleTypeLookup";
            dynamicListLookUpSettings5.DataSource = this.Dynamic;
            dynamicListLookUpSettings5.DisplayMember = "Description";
            dynamicListLookUpSettings5.FilterString = null;
            dynamicListLookUpSettings5.SortMember = null;
            dynamicListLookUpSettings5.ValueMember = "ID";
            this.pstrRoleIDs.ValueSourceSettings = dynamicListLookUpSettings5;
            // 
            // VendorLabels
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.VerticalDetail,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "VendorLabels";
            this.DataSource = this.Dynamic;
            this.DisplayName = "VendorLabels";
            this.FilterString = "[VendorNumber] In (?pstrSelectVendor) Or IsNullOrEmpty([VendorNumber]) And \'!\' In" +
    " (?pstrSelectVendor)";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 30F, 0F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrRoleIDs, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningVendorNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingVendorNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectVendor, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngShowActive, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowLabelWithoutAddress, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngAddressToReturn, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooReturnNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooIncludeCompanyOwner, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngPrintLabel, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.pstrRoleIDs,
            this.pstrBeginningVendorNumber,
            this.pstrEndingVendorNumber,
            this.pstrSelectVendor,
            this.plngShowActive,
            this.pbooShowLabelWithoutAddress,
            this.plngAddressToReturn,
            this.pbooReturnNumber,
            this.pbooIncludeCompanyOwner,
            this.plngCompanyID,
            this.plngPrintLabel});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningVendorNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingVendorNumber;
        private DevExpress.XtraReports.Parameters.Parameter plngShowActive;
        private DevExpress.XtraReports.Parameters.Parameter plngAddressToReturn;
        private DevExpress.XtraReports.Parameters.Parameter pbooReturnNumber;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.UI.VerticalDetailBand VerticalDetail;
        private DevExpress.XtraReports.Parameters.Parameter plngPrintLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectVendor;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowLabelWithoutAddress;
        private DevExpress.XtraReports.Parameters.Parameter pbooIncludeCompanyOwner;
        private DevExpress.XtraReports.Parameters.Parameter pstrRoleIDs;
    }
}
