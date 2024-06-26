namespace ReportsEngine.Reports.PRReports
{
    partial class ExcelPR_WorkersCompGenLiabilityTableListing
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelPR_WorkersCompGenLiabilityTableListing));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.StateAbbrev = new DevExpress.XtraReports.UI.XRTableCell();
            this.WorkersCompCode = new DevExpress.XtraReports.UI.XRTableCell();
            this.WorkersCompDesc = new DevExpress.XtraReports.UI.XRTableCell();
            this.WorkersCompShortDesc = new DevExpress.XtraReports.UI.XRTableCell();
            this.WorkersCompRate = new DevExpress.XtraReports.UI.XRTableCell();
            this.WorkersCompWageBase = new DevExpress.XtraReports.UI.XRTableCell();
            this.GeneralLiabilityCode = new DevExpress.XtraReports.UI.XRTableCell();
            this.GeneralLiabilityRate = new DevExpress.XtraReports.UI.XRTableCell();
            this.GeneralLiabilityWageBase = new DevExpress.XtraReports.UI.XRTableCell();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrStateToPrint = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.Tablix1.HeightF = 20F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.Details_table.SizeF = new System.Drawing.SizeF(839.9998F, 20F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.StateAbbrev,
            this.WorkersCompCode,
            this.WorkersCompDesc,
            this.WorkersCompShortDesc,
            this.WorkersCompRate,
            this.WorkersCompWageBase,
            this.GeneralLiabilityCode,
            this.GeneralLiabilityRate,
            this.GeneralLiabilityWageBase});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 0.70596540959621912D;
            // 
            // StateAbbrev
            // 
            this.StateAbbrev.BorderColor = System.Drawing.Color.LightGray;
            this.StateAbbrev.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.StateAbbrev.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.StateAbbrev.BorderWidth = 1F;
            this.StateAbbrev.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StateAbbrev]")});
            this.StateAbbrev.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.StateAbbrev.KeepTogether = true;
            this.StateAbbrev.Name = "StateAbbrev";
            this.StateAbbrev.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.StateAbbrev.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.StateAbbrev.Weight = 0.065745836766491192D;
            // 
            // WorkersCompCode
            // 
            this.WorkersCompCode.BorderColor = System.Drawing.Color.LightGray;
            this.WorkersCompCode.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.WorkersCompCode.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.WorkersCompCode.BorderWidth = 1F;
            this.WorkersCompCode.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WorkersCompCode]")});
            this.WorkersCompCode.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.WorkersCompCode.KeepTogether = true;
            this.WorkersCompCode.Name = "WorkersCompCode";
            this.WorkersCompCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.WorkersCompCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.WorkersCompCode.Weight = 0.060366601721134693D;
            // 
            // WorkersCompDesc
            // 
            this.WorkersCompDesc.BorderColor = System.Drawing.Color.LightGray;
            this.WorkersCompDesc.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.WorkersCompDesc.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.WorkersCompDesc.BorderWidth = 1F;
            this.WorkersCompDesc.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WorkersCompDesc]")});
            this.WorkersCompDesc.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.WorkersCompDesc.KeepTogether = true;
            this.WorkersCompDesc.Name = "WorkersCompDesc";
            this.WorkersCompDesc.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.WorkersCompDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.WorkersCompDesc.Weight = 0.27205294339992064D;
            // 
            // WorkersCompShortDesc
            // 
            this.WorkersCompShortDesc.BorderColor = System.Drawing.Color.LightGray;
            this.WorkersCompShortDesc.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.WorkersCompShortDesc.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.WorkersCompShortDesc.BorderWidth = 1F;
            this.WorkersCompShortDesc.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WorkersCompShortDesc]")});
            this.WorkersCompShortDesc.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.WorkersCompShortDesc.KeepTogether = true;
            this.WorkersCompShortDesc.Name = "WorkersCompShortDesc";
            this.WorkersCompShortDesc.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.WorkersCompShortDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.WorkersCompShortDesc.Weight = 0.17692368044934817D;
            // 
            // WorkersCompRate
            // 
            this.WorkersCompRate.BorderColor = System.Drawing.Color.LightGray;
            this.WorkersCompRate.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.WorkersCompRate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.WorkersCompRate.BorderWidth = 1F;
            this.WorkersCompRate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WorkersCompRate]")});
            this.WorkersCompRate.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.WorkersCompRate.KeepTogether = true;
            this.WorkersCompRate.Name = "WorkersCompRate";
            this.WorkersCompRate.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.WorkersCompRate.Summary = xrSummary1;
            this.WorkersCompRate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.WorkersCompRate.Weight = 0.08210228535895589D;
            // 
            // WorkersCompWageBase
            // 
            this.WorkersCompWageBase.BorderColor = System.Drawing.Color.LightGray;
            this.WorkersCompWageBase.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.WorkersCompWageBase.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.WorkersCompWageBase.BorderWidth = 1F;
            this.WorkersCompWageBase.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WorkersCompWageBase]")});
            this.WorkersCompWageBase.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.WorkersCompWageBase.KeepTogether = true;
            this.WorkersCompWageBase.Name = "WorkersCompWageBase";
            this.WorkersCompWageBase.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.WorkersCompWageBase.Summary = xrSummary2;
            this.WorkersCompWageBase.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.WorkersCompWageBase.Weight = 0.10931777086326766D;
            // 
            // GeneralLiabilityCode
            // 
            this.GeneralLiabilityCode.BorderColor = System.Drawing.Color.Black;
            this.GeneralLiabilityCode.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.GeneralLiabilityCode.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GeneralLiabilityCode.BorderWidth = 1F;
            this.GeneralLiabilityCode.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GeneralLiabilityCode]")});
            this.GeneralLiabilityCode.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.GeneralLiabilityCode.KeepTogether = true;
            this.GeneralLiabilityCode.Name = "GeneralLiabilityCode";
            this.GeneralLiabilityCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.GeneralLiabilityCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.GeneralLiabilityCode.Weight = 0.10721173945626107D;
            // 
            // GeneralLiabilityRate
            // 
            this.GeneralLiabilityRate.BorderColor = System.Drawing.Color.Black;
            this.GeneralLiabilityRate.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.GeneralLiabilityRate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GeneralLiabilityRate.BorderWidth = 1F;
            this.GeneralLiabilityRate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GeneralLiabilityRate]")});
            this.GeneralLiabilityRate.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.GeneralLiabilityRate.KeepTogether = true;
            this.GeneralLiabilityRate.Name = "GeneralLiabilityRate";
            this.GeneralLiabilityRate.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.GeneralLiabilityRate.StylePriority.UseTextAlignment = false;
            this.GeneralLiabilityRate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.GeneralLiabilityRate.Weight = 0.11230613485535079D;
            // 
            // GeneralLiabilityWageBase
            // 
            this.GeneralLiabilityWageBase.BorderColor = System.Drawing.Color.Black;
            this.GeneralLiabilityWageBase.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.GeneralLiabilityWageBase.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GeneralLiabilityWageBase.BorderWidth = 1F;
            this.GeneralLiabilityWageBase.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GeneralLiabilityWageBase]")});
            this.GeneralLiabilityWageBase.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.GeneralLiabilityWageBase.KeepTogether = true;
            this.GeneralLiabilityWageBase.Name = "GeneralLiabilityWageBase";
            this.GeneralLiabilityWageBase.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.GeneralLiabilityWageBase.StylePriority.UseTextAlignment = false;
            this.GeneralLiabilityWageBase.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.GeneralLiabilityWageBase.Weight = 0.11806736423368311D;
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
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            dynamicListLookUpSettings1.DataMember = "dsLookupCompany";
            dynamicListLookUpSettings1.DataSource = null;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.ValueMember = "ID";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings1;
            this.plngCompanyID.Visible = false;
            // 
            // pstrStateToPrint
            // 
            this.pstrStateToPrint.Description = "State to Print";
            this.pstrStateToPrint.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "99")});
            this.pstrStateToPrint.Name = "pstrStateToPrint";
            this.pstrStateToPrint.Type = typeof(int);
            this.pstrStateToPrint.ValueInfo = "0";
            dynamicListLookUpSettings2.DataMember = "dsPRStateList";
            dynamicListLookUpSettings2.DataSource = null;
            dynamicListLookUpSettings2.DisplayMember = "StateAbbrevAndName";
            dynamicListLookUpSettings2.ValueMember = "PRStateID";
            this.pstrStateToPrint.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Description = "Show Criteria";
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "True";
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel1,
            this.xrLabel14,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel22});
            this.pageHeaderBand1.HeightF = 40.62341F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel12.BorderColor = System.Drawing.Color.Black;
            this.xrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.BorderWidth = 1F;
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel12.ForeColor = System.Drawing.Color.Black;
            this.xrLabel12.KeepTogether = true;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(50.01966F, 40.62334F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorderDashStyle = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseBorderWidth = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "State";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(50.01971F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(45.92713F, 40.62334F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "WCMP Code";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel14.BorderColor = System.Drawing.Color.Black;
            this.xrLabel14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.BorderWidth = 1F;
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel14.ForeColor = System.Drawing.Color.Black;
            this.xrLabel14.KeepTogether = true;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(95.94688F, 0F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(206.9791F, 40.62334F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorderDashStyle = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseBorderWidth = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UsePadding = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Description";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel16.BorderColor = System.Drawing.Color.Black;
            this.xrLabel16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.BorderWidth = 1F;
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel16.ForeColor = System.Drawing.Color.Black;
            this.xrLabel16.KeepTogether = true;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(302.926F, 0F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(134.6043F, 40.62334F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorderDashStyle = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseBorderWidth = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UsePadding = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Alpha Name";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel17.BorderColor = System.Drawing.Color.Black;
            this.xrLabel17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.BorderWidth = 1F;
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel17.ForeColor = System.Drawing.Color.Black;
            this.xrLabel17.KeepTogether = true;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(437.5303F, 6.357829E-05F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(62.46375F, 40.62334F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorderDashStyle = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseBorderWidth = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "WCMP Rate";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel18.BorderColor = System.Drawing.Color.Black;
            this.xrLabel18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel18.BorderWidth = 1F;
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel18.ForeColor = System.Drawing.Color.Black;
            this.xrLabel18.KeepTogether = true;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(499.994F, 0F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(83.16943F, 40.62336F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorderDashStyle = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseBorderWidth = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UsePadding = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "WCMP \r\nWage Base";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel20.BorderColor = System.Drawing.Color.Black;
            this.xrLabel20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.BorderWidth = 1F;
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel20.ForeColor = System.Drawing.Color.Black;
            this.xrLabel20.KeepTogether = true;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(583.1635F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(81.56714F, 40.62331F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorderDashStyle = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseBorderWidth = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Gen Liability Code";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel21.BorderColor = System.Drawing.Color.Black;
            this.xrLabel21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.BorderWidth = 1F;
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel21.ForeColor = System.Drawing.Color.Black;
            this.xrLabel21.KeepTogether = true;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(664.7306F, 0F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(85.44312F, 40.6233F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorderColor = false;
            this.xrLabel21.StylePriority.UseBorderDashStyle = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseBorderWidth = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseForeColor = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Gen Liability\r\nRate";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel22.BorderColor = System.Drawing.Color.Black;
            this.xrLabel22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.BorderWidth = 1F;
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel22.ForeColor = System.Drawing.Color.Black;
            this.xrLabel22.KeepTogether = true;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(750.1737F, 0F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(89.82617F, 40.62333F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseBorderColor = false;
            this.xrLabel22.StylePriority.UseBorderDashStyle = false;
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseBorderWidth = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UsePadding = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Gen Liability  \r\nWage Base";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "Report_PR_StateList";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "Report_PR_StateList";
            storedProcQuery2.Name = "Report_PR_WorkersCompGenLiabilityTableListing";
            queryParameter2.Name = "@plngCompanyID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            queryParameter3.Name = "@pstrStateToPrint";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?pstrStateToPrint", typeof(int));
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter2,
            queryParameter3});
            storedProcQuery2.StoredProcName = "Report_PR_WorkersCompGenLiabilityTableListing";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // ExcelPR_WorkersCompGenLiabilityTableListing
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1,
            this.pageHeaderBand1});
            this.BorderColor = System.Drawing.Color.White;
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "Report_PR_WorkersCompGenLiabilityTableListing";
            this.DataSource = this.Dynamic;
            this.DisplayName = "PR_WorkersCompGenLiabilityTableListing";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 0F, 0F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.Subtitle,
            this.plngCompanyID,
            this.pstrStateToPrint,
            this.pbooShowCriteria});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1;
        private DevExpress.XtraReports.UI.XRTable Details_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell WorkersCompCode;
        private DevExpress.XtraReports.UI.XRTableCell WorkersCompDesc;
        private DevExpress.XtraReports.UI.XRTableCell WorkersCompShortDesc;
        private DevExpress.XtraReports.UI.XRTableCell WorkersCompRate;
        private DevExpress.XtraReports.UI.XRTableCell WorkersCompWageBase;
        private DevExpress.XtraReports.UI.XRTableCell GeneralLiabilityCode;
        private DevExpress.XtraReports.UI.XRTableCell GeneralLiabilityRate;
        private DevExpress.XtraReports.UI.XRTableCell GeneralLiabilityWageBase;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter pstrStateToPrint;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.UI.XRTableCell StateAbbrev;
    }
}
