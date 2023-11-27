namespace ReportsEngine.Reports.MDReports
{
    partial class OwnerLabelsByProperty
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter11 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter12 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerLabelsByProperty));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings5 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings2 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningPropertyNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingPropertyNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteDateToUse = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngAddressToPrint = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowInactives = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngInterestTypesToShow = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooUseGroupTypes = new DevExpress.XtraReports.Parameters.Parameter();
            this.VerticalDetail = new DevExpress.XtraReports.UI.VerticalDetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pstrSelectProperty = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngPrintLabel = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "OwnerLabelsByProperty";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            queryParameter2.Name = "@pdteDateToUse";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?pdteDateToUse", typeof(string));
            queryParameter3.Name = "@pstrBeginningPropertyNumber";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?pstrBeginningPropertyNumber", typeof(string));
            queryParameter4.Name = "@pstrEndingPropertyNumber";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?pstrEndingPropertyNumber", typeof(string));
            queryParameter5.Name = "@pbooShowInactives";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("?pbooShowInactives", typeof(string));
            queryParameter6.Name = "@plngInterestTypesToShow";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("?plngInterestTypesToShow", typeof(string));
            queryParameter7.Name = "@plngAddressToPrint";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?plngAddressToPrint", typeof(string));
            queryParameter8.Name = "@pbooUseGroupTypes";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("?pbooUseGroupTypes", typeof(string));
            queryParameter9.Name = "@plngUserID";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("?plngUserID", typeof(string));
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
            storedProcQuery1.StoredProcName = "Report_OwnerLabelsByProperty";
            storedProcQuery2.Name = "LookupCompanies";
            queryParameter10.Name = "@plngCompanyID";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter10});
            storedProcQuery2.StoredProcName = "Companies_ReportLookup";
            storedProcQuery3.Name = "LookupProperties";
            queryParameter11.Name = "@pbooIncludeFirstLast";
            queryParameter11.Type = typeof(bool);
            queryParameter11.ValueInfo = "True";
            queryParameter12.Name = "@plngCompanyID";
            queryParameter12.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter12.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            storedProcQuery3.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter11,
            queryParameter12});
            storedProcQuery3.StoredProcName = "Properties_ReportLookup";
            storedProcQuery4.Name = "LookupInterestTypes";
            storedProcQuery4.StoredProcName = "ReportWizard_PopulateInterestTypesForDOIReports";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3,
            storedProcQuery4});
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
            // pstrBeginningPropertyNumber
            // 
            this.pstrBeginningPropertyNumber.Description = "Beginning Property";
            this.pstrBeginningPropertyNumber.Name = "pstrBeginningPropertyNumber";
            this.pstrBeginningPropertyNumber.ValueInfo = "!";
            dynamicListLookUpSettings1.DataMember = "LookupProperties";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.ValueMember = "PropertyAndWellNumber";
            this.pstrBeginningPropertyNumber.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // pstrEndingPropertyNumber
            // 
            this.pstrEndingPropertyNumber.Description = "Ending Property";
            this.pstrEndingPropertyNumber.Name = "pstrEndingPropertyNumber";
            this.pstrEndingPropertyNumber.ValueInfo = "ZZZZZZZZZZ-ZZZZZZZZZZ";
            dynamicListLookUpSettings2.DataMember = "LookupProperties";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "Description";
            dynamicListLookUpSettings2.ValueMember = "PropertyAndWellNumber";
            this.pstrEndingPropertyNumber.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // pdteDateToUse
            // 
            this.pdteDateToUse.Description = "Date to Use";
            this.pdteDateToUse.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Today()")});
            this.pdteDateToUse.Name = "pdteDateToUse";
            this.pdteDateToUse.Type = typeof(System.DateTime);
            this.pdteDateToUse.ValueInfo = "2023-10-16";
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "1";
            dynamicListLookUpSettings3.DataMember = "LookupCompanies";
            dynamicListLookUpSettings3.DataSource = this.Dynamic;
            dynamicListLookUpSettings3.DisplayMember = "Description";
            dynamicListLookUpSettings3.ValueMember = "ID";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings3;
            this.plngCompanyID.Visible = false;
            // 
            // plngAddressToPrint
            // 
            this.plngAddressToPrint.Description = "Address To Print";
            this.plngAddressToPrint.Name = "plngAddressToPrint";
            this.plngAddressToPrint.Type = typeof(int);
            this.plngAddressToPrint.ValueInfo = "0";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(0, "JIB Address"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(1, "RD Address"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(2, "No Address"));
            this.plngAddressToPrint.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // pbooShowInactives
            // 
            this.pbooShowInactives.Description = "Report Inactives";
            this.pbooShowInactives.Name = "pbooShowInactives";
            this.pbooShowInactives.Type = typeof(bool);
            this.pbooShowInactives.ValueInfo = "False";
            // 
            // plngInterestTypesToShow
            // 
            this.plngInterestTypesToShow.Description = "Interest Types To Show";
            this.plngInterestTypesToShow.Name = "plngInterestTypesToShow";
            this.plngInterestTypesToShow.Type = typeof(int);
            this.plngInterestTypesToShow.ValueInfo = "0";
            dynamicListLookUpSettings4.DataMember = "LookupInterestTypes";
            dynamicListLookUpSettings4.DataSource = this.Dynamic;
            dynamicListLookUpSettings4.DisplayMember = "Item";
            dynamicListLookUpSettings4.ValueMember = "ItemData";
            this.plngInterestTypesToShow.ValueSourceSettings = dynamicListLookUpSettings4;
            // 
            // pbooUseGroupTypes
            // 
            this.pbooUseGroupTypes.Description = "pbooUseGroupTypes";
            this.pbooUseGroupTypes.Name = "pbooUseGroupTypes";
            this.pbooUseGroupTypes.Type = typeof(bool);
            this.pbooUseGroupTypes.ValueInfo = "False";
            this.pbooUseGroupTypes.Visible = false;
            // 
            // VerticalDetail
            // 
            this.VerticalDetail.BandLayout = DevExpress.XtraReports.UI.VerticalBandLayout.AcrossThenDown;
            this.VerticalDetail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.VerticalDetail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "WidthF", "Iif(?plngPrintLabel = 5160, 283.33, 425)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "HeightF", "iif(?plngPrintLabel = 5164,350, Iif(?plngPrintLabel = 5163,210,105 ))\n")});
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "LeftF", "Iif(?plngPrintLabel<> 5160, 5F, 33F)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "WidthF", "Iif(?plngPrintLabel = 5160,250, 420)\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Padding.Left", "Iif(?plngPrintLabel<>5160,15 ,3 )"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OwnerAddressBlock]"),
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
            // pstrSelectProperty
            // 
            this.pstrSelectProperty.Description = "Select Property";
            this.pstrSelectProperty.MultiValue = true;
            this.pstrSelectProperty.Name = "pstrSelectProperty";
            this.pstrSelectProperty.SelectAllValues = true;
            dynamicListLookUpSettings5.DataMember = "LookupProperties";
            dynamicListLookUpSettings5.DataSource = this.Dynamic;
            dynamicListLookUpSettings5.DisplayMember = "Description";
            dynamicListLookUpSettings5.FilterString = null;
            dynamicListLookUpSettings5.SortMember = null;
            dynamicListLookUpSettings5.ValueMember = "PropertyAndWellNumber";
            this.pstrSelectProperty.ValueSourceSettings = dynamicListLookUpSettings5;
            // 
            // plngPrintLabel
            // 
            this.plngPrintLabel.Description = "Print Label";
            this.plngPrintLabel.Name = "plngPrintLabel";
            this.plngPrintLabel.Type = typeof(int);
            this.plngPrintLabel.ValueInfo = "5160";
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(5160, "Avery 5160 1\" X 2 5/8"));
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(5161, "Avery 5161 1\" X 4\""));
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(5163, "Avery 5163 2\" X 4\""));
            staticListLookUpSettings2.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(5164, "Avery 5164 3 1/3\" X 4\""));
            this.plngPrintLabel.ValueSourceSettings = staticListLookUpSettings2;
            // 
            // OwnerLabelsByProperty
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.VerticalDetail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "OwnerLabelsByProperty";
            this.DataSource = this.Dynamic;
            this.DisplayName = "OwnerLabelsByProperty";
            this.FilterString = "[PhaseWellNumber] In (?pstrSelectProperty)";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 30F, 0F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningPropertyNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingPropertyNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectProperty, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteDateToUse, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngAddressToPrint, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowInactives, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngInterestTypesToShow, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooUseGroupTypes, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngPrintLabel, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.Subtitle,
            this.plngUserID,
            this.pstrBeginningPropertyNumber,
            this.pstrEndingPropertyNumber,
            this.pstrSelectProperty,
            this.pdteDateToUse,
            this.plngCompanyID,
            this.plngAddressToPrint,
            this.pbooShowInactives,
            this.plngInterestTypesToShow,
            this.pbooUseGroupTypes,
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
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningPropertyNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingPropertyNumber;
        private DevExpress.XtraReports.Parameters.Parameter pdteDateToUse;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter plngAddressToPrint;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowInactives;
        private DevExpress.XtraReports.Parameters.Parameter plngInterestTypesToShow;
        private DevExpress.XtraReports.Parameters.Parameter pbooUseGroupTypes;
        private DevExpress.XtraReports.UI.VerticalDetailBand VerticalDetail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectProperty;
        private DevExpress.XtraReports.Parameters.Parameter plngPrintLabel;
    }
}
