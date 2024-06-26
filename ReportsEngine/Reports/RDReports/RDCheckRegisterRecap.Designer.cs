namespace ReportsEngine
{
    partial class RDCheckRegisterRecap
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter11 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter12 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDCheckRegisterRecap));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckPrintingProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectCashAccountID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteBeginningCheckDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdteEndingCheckDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngBeginningCheckSortNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectRDCheckID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooIncludeVoidChecks = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngEndingCheckSortNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrBeginningOwnerNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrEndingOwnerNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectOwner = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 40F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 40F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // Tablix1
            // 
            this.Tablix1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel3});
            this.Tablix1.HeightF = 17F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            this.Tablix1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ItemType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Italic))));
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(152.4399F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(360.8408F, 16.99999F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorderDashStyle = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Amount]")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(513.2806F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(170.0001F, 17F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel3.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "RegisterRecap";
            queryParameter1.Name = "@plngCheckPrintingProcessTrackingID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCheckPrintingProcessTrackingID", typeof(int));
            queryParameter2.Name = "@plngCompanyID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter3.Name = "@pstrBeginningOwnerNumber";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?pstrBeginningOwnerNumber", typeof(string));
            queryParameter4.Name = "@pstrEndingOwnerNumber";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("?pstrEndingOwnerNumber", typeof(string));
            queryParameter5.Name = "@pstrSelectOwner";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("JOIN(?pstrSelectOwner,\',\')", typeof(string));
            queryParameter6.Name = "@pstrSelectCashAccountID";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("JOIN(?pstrSelectCashAccountID,\',\' )", typeof(string));
            queryParameter7.Name = "@pdteBeginningCheckDate";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("?pdteBeginningCheckDate", typeof(System.DateTime));
            queryParameter8.Name = "@pdteEndingCheckDate";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("?pdteEndingCheckDate", typeof(System.DateTime));
            queryParameter9.Name = "@plngBegininningCheckSortNumber";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("?plngBeginningCheckSortNumber", typeof(int));
            queryParameter10.Name = "@plngEndingCheckSortNumber";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("?plngEndingCheckSortNumber", typeof(int));
            queryParameter11.Name = "@pstrSelectRDCheckID";
            queryParameter11.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter11.Value = new DevExpress.DataAccess.Expression("JOIN(?pstrSelectRDCheckID,\',\' )", typeof(string));
            queryParameter12.Name = "@pbooIncludeVoidChecks";
            queryParameter12.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter12.Value = new DevExpress.DataAccess.Expression("?pbooIncludeVoidChecks", typeof(bool));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5,
            queryParameter6,
            queryParameter7,
            queryParameter8,
            queryParameter9,
            queryParameter10,
            queryParameter11,
            queryParameter12});
            storedProcQuery1.StoredProcName = "Report_RDCheckRegisterRecap";
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
            // plngCheckPrintingProcessTrackingID
            // 
            this.plngCheckPrintingProcessTrackingID.Description = "plngCheckPrintingProcessTrackingID";
            this.plngCheckPrintingProcessTrackingID.Name = "plngCheckPrintingProcessTrackingID";
            this.plngCheckPrintingProcessTrackingID.Type = typeof(int);
            this.plngCheckPrintingProcessTrackingID.ValueInfo = "0";
            this.plngCheckPrintingProcessTrackingID.Visible = false;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "Company ID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            this.plngCompanyID.Visible = false;
            // 
            // pstrSelectCashAccountID
            // 
            this.pstrSelectCashAccountID.Description = "Select Cash Account";
            this.pstrSelectCashAccountID.MultiValue = true;
            this.pstrSelectCashAccountID.Name = "pstrSelectCashAccountID";
            this.pstrSelectCashAccountID.Type = typeof(int);
            this.pstrSelectCashAccountID.Visible = false;
            // 
            // pdteBeginningCheckDate
            // 
            this.pdteBeginningCheckDate.Description = "Beginning Check Date";
            this.pdteBeginningCheckDate.Name = "pdteBeginningCheckDate";
            this.pdteBeginningCheckDate.Type = typeof(System.DateTime);
            this.pdteBeginningCheckDate.ValueInfo = "2024-04-22";
            this.pdteBeginningCheckDate.Visible = false;
            // 
            // pdteEndingCheckDate
            // 
            this.pdteEndingCheckDate.Description = "Ending Check Date";
            this.pdteEndingCheckDate.Name = "pdteEndingCheckDate";
            this.pdteEndingCheckDate.Type = typeof(System.DateTime);
            this.pdteEndingCheckDate.ValueInfo = "2024-04-22";
            this.pdteEndingCheckDate.Visible = false;
            // 
            // plngBeginningCheckSortNumber
            // 
            this.plngBeginningCheckSortNumber.Description = "Beginning Check Number";
            this.plngBeginningCheckSortNumber.Name = "plngBeginningCheckSortNumber";
            this.plngBeginningCheckSortNumber.Type = typeof(int);
            this.plngBeginningCheckSortNumber.ValueInfo = "0";
            this.plngBeginningCheckSortNumber.Visible = false;
            // 
            // pstrSelectRDCheckID
            // 
            this.pstrSelectRDCheckID.Description = "Select Check";
            this.pstrSelectRDCheckID.MultiValue = true;
            this.pstrSelectRDCheckID.Name = "pstrSelectRDCheckID";
            this.pstrSelectRDCheckID.Type = typeof(int);
            this.pstrSelectRDCheckID.Visible = false;
            // 
            // pbooIncludeVoidChecks
            // 
            this.pbooIncludeVoidChecks.Description = "Include Void Checks";
            this.pbooIncludeVoidChecks.Name = "pbooIncludeVoidChecks";
            this.pbooIncludeVoidChecks.Type = typeof(bool);
            this.pbooIncludeVoidChecks.ValueInfo = "False";
            this.pbooIncludeVoidChecks.Visible = false;
            // 
            // plngEndingCheckSortNumber
            // 
            this.plngEndingCheckSortNumber.Description = "Ending Check Number";
            this.plngEndingCheckSortNumber.Name = "plngEndingCheckSortNumber";
            this.plngEndingCheckSortNumber.Type = typeof(int);
            this.plngEndingCheckSortNumber.ValueInfo = "999999999";
            this.plngEndingCheckSortNumber.Visible = false;
            // 
            // pstrBeginningOwnerNumber
            // 
            this.pstrBeginningOwnerNumber.Description = "Parameter1";
            this.pstrBeginningOwnerNumber.Name = "pstrBeginningOwnerNumber";
            this.pstrBeginningOwnerNumber.ValueInfo = "!";
            this.pstrBeginningOwnerNumber.Visible = false;
            // 
            // pstrEndingOwnerNumber
            // 
            this.pstrEndingOwnerNumber.Description = "Parameter1";
            this.pstrEndingOwnerNumber.Name = "pstrEndingOwnerNumber";
            this.pstrEndingOwnerNumber.ValueInfo = "ZZZZZZZZZZ";
            this.pstrEndingOwnerNumber.Visible = false;
            // 
            // pstrSelectOwner
            // 
            this.pstrSelectOwner.Description = "Select Owner";
            this.pstrSelectOwner.MultiValue = true;
            this.pstrSelectOwner.Name = "pstrSelectOwner";
            this.pstrSelectOwner.Type = typeof(int);
            this.pstrSelectOwner.Visible = false;
            // 
            // RDCheckRegisterRecap
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "RegisterRecap";
            this.DataSource = this.Dynamic;
            this.DisplayName = "RDCheckRegisterRecap";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(40F, 40F, 40F, 40F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCheckPrintingProcessTrackingID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectCashAccountID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteBeginningCheckDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pdteEndingCheckDate, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngBeginningCheckSortNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngEndingCheckSortNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectRDCheckID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooIncludeVoidChecks, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrBeginningOwnerNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrEndingOwnerNumber, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSelectOwner, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.plngCheckPrintingProcessTrackingID,
            this.plngCompanyID,
            this.pstrSelectCashAccountID,
            this.pdteBeginningCheckDate,
            this.pdteEndingCheckDate,
            this.plngBeginningCheckSortNumber,
            this.plngEndingCheckSortNumber,
            this.pstrSelectRDCheckID,
            this.pbooIncludeVoidChecks,
            this.pstrBeginningOwnerNumber,
            this.pstrEndingOwnerNumber,
            this.pstrSelectOwner});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckPrintingProcessTrackingID;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectCashAccountID;
        private DevExpress.XtraReports.Parameters.Parameter pdteBeginningCheckDate;
        private DevExpress.XtraReports.Parameters.Parameter pdteEndingCheckDate;
        private DevExpress.XtraReports.Parameters.Parameter plngBeginningCheckSortNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectRDCheckID;
        private DevExpress.XtraReports.Parameters.Parameter pbooIncludeVoidChecks;
        private DevExpress.XtraReports.Parameters.Parameter plngEndingCheckSortNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrBeginningOwnerNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrEndingOwnerNumber;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectOwner;
    }
}
