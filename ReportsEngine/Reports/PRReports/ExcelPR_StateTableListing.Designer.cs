﻿namespace ReportsEngine.Reports.RDReports
{
    partial class ExcelPR_StateTableListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelPR_StateTableListing));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.Textbox158 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSortby = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbitMaskTaxID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSelectEmployee = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "dsPRStateTableListing";
            queryParameter1.Name = "@plngCompanyID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            queryParameter2.Name = "@pstrSortby";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?pstrSortby", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2});
            storedProcQuery1.StoredProcName = "Report_PR_StateTableListing";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
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
            this.xrLabel26,
            this.xrLabel27,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel9,
            this.xrLabel11,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel2,
            this.xrLabel3});
            this.Tablix1.HeightF = 17.00001F;
            this.Tablix1.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1.Name = "Tablix1";
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel26.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel26.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.BorderWidth = 1F;
            this.xrLabel26.CanGrow = false;
            this.xrLabel26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'GL 2. \' + [GeneralLiabilityModifierDesc2]")});
            this.xrLabel26.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel26.ForeColor = System.Drawing.Color.Black;
            this.xrLabel26.KeepTogether = true;
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(1499.756F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(160.98F, 17F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseBorderColor = false;
            this.xrLabel26.StylePriority.UseBorderDashStyle = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseBorderWidth = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseForeColor = false;
            this.xrLabel26.StylePriority.UsePadding = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel27.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel27.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel27.BorderWidth = 1F;
            this.xrLabel27.CanGrow = false;
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GeneralLiabilityModifierRate2]")});
            this.xrLabel27.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel27.ForeColor = System.Drawing.Color.Black;
            this.xrLabel27.KeepTogether = true;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(1660.739F, 0F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(86.86737F, 16.99998F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseBorderColor = false;
            this.xrLabel27.StylePriority.UseBorderDashStyle = false;
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseBorderWidth = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UsePadding = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel23.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel23.BorderWidth = 1F;
            this.xrLabel23.CanGrow = false;
            this.xrLabel23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'GL 1. \' + [GeneralLiabilityModifierDesc1]")});
            this.xrLabel23.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel23.ForeColor = System.Drawing.Color.Black;
            this.xrLabel23.KeepTogether = true;
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(1251.906F, 0F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(160.98F, 17F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.StylePriority.UseBorderColor = false;
            this.xrLabel23.StylePriority.UseBorderDashStyle = false;
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseBorderWidth = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseForeColor = false;
            this.xrLabel23.StylePriority.UsePadding = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel24
            // 
            this.xrLabel24.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel24.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel24.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel24.BorderWidth = 1F;
            this.xrLabel24.CanGrow = false;
            this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GeneralLiabilityModifierRate1]")});
            this.xrLabel24.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel24.ForeColor = System.Drawing.Color.Black;
            this.xrLabel24.KeepTogether = true;
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(1412.888F, 0F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(86.86737F, 16.99998F);
            this.xrLabel24.StylePriority.UseBackColor = false;
            this.xrLabel24.StylePriority.UseBorderColor = false;
            this.xrLabel24.StylePriority.UseBorderDashStyle = false;
            this.xrLabel24.StylePriority.UseBorders = false;
            this.xrLabel24.StylePriority.UseBorderWidth = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseForeColor = false;
            this.xrLabel24.StylePriority.UsePadding = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel9.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.BorderWidth = 1F;
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'WC 3. \' + [WorkersCompensationModifierDesc3]")});
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel9.ForeColor = System.Drawing.Color.Black;
            this.xrLabel9.KeepTogether = true;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(1004.056F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(160.98F, 17F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorderDashStyle = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseBorderWidth = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel11.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.BorderWidth = 1F;
            this.xrLabel11.CanGrow = false;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WorkersCompensationModifierRate3]")});
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel11.ForeColor = System.Drawing.Color.Black;
            this.xrLabel11.KeepTogether = true;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(1165.038F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(86.86737F, 16.99998F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorderDashStyle = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseBorderWidth = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UsePadding = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'WC 2. \' + [WorkersCompensationModifierDesc2]")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.KeepTogether = true;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(756.2056F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(160.98F, 17F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorderDashStyle = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel6.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.BorderWidth = 1F;
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WorkersCompensationModifierRate2]")});
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel6.ForeColor = System.Drawing.Color.Black;
            this.xrLabel6.KeepTogether = true;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(917.1883F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(86.86737F, 17.00001F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorderDashStyle = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel20.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel20.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.BorderWidth = 1F;
            this.xrLabel20.CanGrow = false;
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IncomeTaxPayableAccountNumber]")});
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel20.ForeColor = System.Drawing.Color.Black;
            this.xrLabel20.KeepTogether = true;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(437.8656F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(58.1254F, 17F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorderDashStyle = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseBorderWidth = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel19.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.BorderWidth = 1F;
            this.xrLabel19.CanGrow = false;
            this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnemploymentPayableAccountNumber]")});
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel19.ForeColor = System.Drawing.Color.Black;
            this.xrLabel19.KeepTogether = true;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(379.7401F, 0F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(58.12549F, 17.00001F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorderDashStyle = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseBorderWidth = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UsePadding = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel18.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel18.BorderWidth = 1F;
            this.xrLabel18.CanGrow = false;
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnemploymentWageBase]")});
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel18.ForeColor = System.Drawing.Color.Black;
            this.xrLabel18.KeepTogether = true;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(308.2383F, 0F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(71.5018F, 17.00001F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorderDashStyle = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseBorderWidth = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UsePadding = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel17.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel17.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.BorderWidth = 1F;
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnemploymentRate]")});
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel17.ForeColor = System.Drawing.Color.Black;
            this.xrLabel17.KeepTogether = true;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(252.6258F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(55.6125F, 17.00001F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorderDashStyle = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseBorderWidth = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel16.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.BorderWidth = 1F;
            this.xrLabel16.CanGrow = false;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([WorkersCompensationCalcMethodCode] = \'S\', \'Straight\', \'Actual\')")});
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel16.ForeColor = System.Drawing.Color.Black;
            this.xrLabel16.KeepTogether = true;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(197.0134F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(55.6125F, 17.00001F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorderDashStyle = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseBorderWidth = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UsePadding = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel15.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel15.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel15.BorderWidth = 1F;
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(?pbitMaskTaxID = (False And IsNullOrEmpty([TaxID])) = False, [TaxID], \'******" +
                    "\' + Substring(Trim([TaxID]), Len(Trim([TaxID])) - 4, 4))")});
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel15.ForeColor = System.Drawing.Color.Black;
            this.xrLabel15.KeepTogether = true;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(119.882F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(77.13129F, 17.00001F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorderDashStyle = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseBorderWidth = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UsePadding = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel14.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.BorderWidth = 1F;
            this.xrLabel14.CanGrow = false;
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StateName]")});
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel14.ForeColor = System.Drawing.Color.Black;
            this.xrLabel14.KeepTogether = true;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(39.57481F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(80.30717F, 17.00001F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorderDashStyle = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseBorderWidth = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UsePadding = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel13.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.BorderWidth = 1F;
            this.xrLabel13.CanGrow = false;
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StateAbbrev]")});
            this.xrLabel13.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel13.ForeColor = System.Drawing.Color.Black;
            this.xrLabel13.KeepTogether = true;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(39.57481F, 17.00001F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorderDashStyle = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseBorderWidth = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UsePadding = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'WC 1. \' + [WorkersCompensationModifierDesc1]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "not IsNullOrEmpty([WorkersCompensationModifierRate1])")});
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.KeepTogether = true;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(495.991F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(173.3473F, 17.00001F);
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
            this.xrLabel3.BorderColor = System.Drawing.Color.LightGray;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WorkersCompensationModifierRate1]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "not IsNullOrEmpty([WorkersCompensationModifierRate1])\n")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.KeepTogether = true;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(669.3383F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(86.86737F, 17.00001F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.BorderColor = System.Drawing.Color.Black;
            this.pageHeaderBand1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.pageHeaderBand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.pageHeaderBand1.BorderWidth = 1F;
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel34,
            this.xrLabel35,
            this.xrLabel22,
            this.xrLabel33,
            this.xrLabel10,
            this.xrLabel12,
            this.xrLabel7,
            this.xrLabel4,
            this.xrLabel1,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel21,
            this.Textbox158,
            this.xrLabel28,
            this.xrLabel25,
            this.xrLabel8});
            this.pageHeaderBand1.HeightF = 41.8533F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel34
            // 
            this.xrLabel34.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel34.BorderColor = System.Drawing.Color.Black;
            this.xrLabel34.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel34.BorderWidth = 1F;
            this.xrLabel34.CanGrow = false;
            this.xrLabel34.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel34.ForeColor = System.Drawing.Color.Black;
            this.xrLabel34.KeepTogether = true;
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(1499.756F, 0F);
            this.xrLabel34.Multiline = true;
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(160.9799F, 41.8533F);
            this.xrLabel34.StylePriority.UseBackColor = false;
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UseForeColor = false;
            this.xrLabel34.StylePriority.UsePadding = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.Text = "General Liability Modifier\r\nDesc 2";
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel35
            // 
            this.xrLabel35.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel35.BorderColor = System.Drawing.Color.Black;
            this.xrLabel35.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel35.BorderWidth = 1F;
            this.xrLabel35.CanGrow = false;
            this.xrLabel35.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel35.ForeColor = System.Drawing.Color.Black;
            this.xrLabel35.KeepTogether = true;
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(1660.738F, 0F);
            this.xrLabel35.Multiline = true;
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(86.86755F, 41.8533F);
            this.xrLabel35.StylePriority.UseBackColor = false;
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseForeColor = false;
            this.xrLabel35.StylePriority.UsePadding = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = "General Liability Rate 2";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel22.BorderColor = System.Drawing.Color.Black;
            this.xrLabel22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.BorderWidth = 1F;
            this.xrLabel22.CanGrow = false;
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel22.ForeColor = System.Drawing.Color.Black;
            this.xrLabel22.KeepTogether = true;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(1412.888F, 0F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(86.86755F, 41.8533F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UsePadding = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "General Liability Rate 1";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel33
            // 
            this.xrLabel33.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel33.BorderColor = System.Drawing.Color.Black;
            this.xrLabel33.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel33.BorderWidth = 1F;
            this.xrLabel33.CanGrow = false;
            this.xrLabel33.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel33.ForeColor = System.Drawing.Color.Black;
            this.xrLabel33.KeepTogether = true;
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(1251.906F, 0F);
            this.xrLabel33.Multiline = true;
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(160.9827F, 41.8533F);
            this.xrLabel33.StylePriority.UseBackColor = false;
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseForeColor = false;
            this.xrLabel33.StylePriority.UsePadding = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "General Liability Modifier\r\nDesc 1";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel10.BorderColor = System.Drawing.Color.Black;
            this.xrLabel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.BorderWidth = 1F;
            this.xrLabel10.CanGrow = false;
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel10.ForeColor = System.Drawing.Color.Black;
            this.xrLabel10.KeepTogether = true;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(1004.056F, 0F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(160.9799F, 41.8533F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Worker\r\nComp Desc 3";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel12.BorderColor = System.Drawing.Color.Black;
            this.xrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.BorderWidth = 1F;
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel12.ForeColor = System.Drawing.Color.Black;
            this.xrLabel12.KeepTogether = true;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(1165.036F, 0F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(86.86749F, 41.8533F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Worker\r\nComp Rate 3";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel7.BorderColor = System.Drawing.Color.Black;
            this.xrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.BorderWidth = 1F;
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel7.ForeColor = System.Drawing.Color.Black;
            this.xrLabel7.KeepTogether = true;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(917.1856F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(86.86749F, 41.8533F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Worker\r\nComp Rate 2";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.KeepTogether = true;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(669.3383F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(86.86749F, 41.8533F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Worker\r\nComp Rate 1";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.KeepTogether = true;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(756.2057F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(160.9799F, 41.8533F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Worker\r\nComp Desc 2";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel32
            // 
            this.xrLabel32.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel32.BorderColor = System.Drawing.Color.Black;
            this.xrLabel32.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel32.BorderWidth = 1F;
            this.xrLabel32.CanGrow = false;
            this.xrLabel32.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel32.ForeColor = System.Drawing.Color.Black;
            this.xrLabel32.KeepTogether = true;
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(495.991F, 0F);
            this.xrLabel32.Multiline = true;
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(173.3473F, 41.8533F);
            this.xrLabel32.StylePriority.UseBackColor = false;
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseForeColor = false;
            this.xrLabel32.StylePriority.UsePadding = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "Worker\r\nComp Desc 1";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel31
            // 
            this.xrLabel31.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel31.BorderColor = System.Drawing.Color.Black;
            this.xrLabel31.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel31.BorderWidth = 1F;
            this.xrLabel31.CanGrow = false;
            this.xrLabel31.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel31.ForeColor = System.Drawing.Color.Black;
            this.xrLabel31.KeepTogether = true;
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(437.8656F, 0F);
            this.xrLabel31.Multiline = true;
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(58.12546F, 41.8533F);
            this.xrLabel31.StylePriority.UseBackColor = false;
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseForeColor = false;
            this.xrLabel31.StylePriority.UsePadding = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Acct.\r\nNum Inc";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel30
            // 
            this.xrLabel30.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel30.BorderColor = System.Drawing.Color.Black;
            this.xrLabel30.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel30.BorderWidth = 1F;
            this.xrLabel30.CanGrow = false;
            this.xrLabel30.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel30.ForeColor = System.Drawing.Color.Black;
            this.xrLabel30.KeepTogether = true;
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(308.2384F, 0F);
            this.xrLabel30.Multiline = true;
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(71.50171F, 41.8533F);
            this.xrLabel30.StylePriority.UseBackColor = false;
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseForeColor = false;
            this.xrLabel30.StylePriority.UsePadding = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "Unemp\r\nWage Base";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel29
            // 
            this.xrLabel29.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel29.BorderColor = System.Drawing.Color.Black;
            this.xrLabel29.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel29.BorderWidth = 1F;
            this.xrLabel29.CanGrow = false;
            this.xrLabel29.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel29.ForeColor = System.Drawing.Color.Black;
            this.xrLabel29.KeepTogether = true;
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(252.6259F, 0F);
            this.xrLabel29.Multiline = true;
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(55.6125F, 41.8533F);
            this.xrLabel29.StylePriority.UseBackColor = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseForeColor = false;
            this.xrLabel29.StylePriority.UsePadding = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "Unemp\r\nRate";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel21.BorderColor = System.Drawing.Color.Black;
            this.xrLabel21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.BorderWidth = 1F;
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel21.ForeColor = System.Drawing.Color.Black;
            this.xrLabel21.KeepTogether = true;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(119.882F, 0F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(77.13131F, 41.8533F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseForeColor = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Tax\r\nID";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Textbox158
            // 
            this.Textbox158.BackColor = System.Drawing.Color.Transparent;
            this.Textbox158.BorderColor = System.Drawing.Color.Black;
            this.Textbox158.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox158.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox158.BorderWidth = 1F;
            this.Textbox158.CanGrow = false;
            this.Textbox158.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.Textbox158.ForeColor = System.Drawing.Color.Black;
            this.Textbox158.KeepTogether = true;
            this.Textbox158.LocationFloat = new DevExpress.Utils.PointFloat(197.0134F, 0F);
            this.Textbox158.Multiline = true;
            this.Textbox158.Name = "Textbox158";
            this.Textbox158.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Textbox158.SizeF = new System.Drawing.SizeF(55.6125F, 41.8533F);
            this.Textbox158.StylePriority.UseBackColor = false;
            this.Textbox158.StylePriority.UseFont = false;
            this.Textbox158.StylePriority.UseForeColor = false;
            this.Textbox158.StylePriority.UsePadding = false;
            this.Textbox158.StylePriority.UseTextAlignment = false;
            this.Textbox158.Text = "Comp\r\nMeth";
            this.Textbox158.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel28
            // 
            this.xrLabel28.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel28.BorderColor = System.Drawing.Color.Black;
            this.xrLabel28.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel28.BorderWidth = 1F;
            this.xrLabel28.CanGrow = false;
            this.xrLabel28.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel28.ForeColor = System.Drawing.Color.Black;
            this.xrLabel28.KeepTogether = true;
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(379.7401F, 0F);
            this.xrLabel28.Multiline = true;
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(58.12546F, 41.8533F);
            this.xrLabel28.StylePriority.UseBackColor = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseForeColor = false;
            this.xrLabel28.StylePriority.UsePadding = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Acct.\r\nNum Un";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel25
            // 
            this.xrLabel25.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel25.BorderColor = System.Drawing.Color.Black;
            this.xrLabel25.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel25.BorderWidth = 1F;
            this.xrLabel25.CanGrow = false;
            this.xrLabel25.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel25.ForeColor = System.Drawing.Color.Black;
            this.xrLabel25.KeepTogether = true;
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(39.57481F, 0F);
            this.xrLabel25.Multiline = true;
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(80.30711F, 41.8533F);
            this.xrLabel25.StylePriority.UseBackColor = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseForeColor = false;
            this.xrLabel25.StylePriority.UsePadding = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "State\r\nName";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel8.BorderColor = System.Drawing.Color.Black;
            this.xrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.BorderWidth = 1F;
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.xrLabel8.ForeColor = System.Drawing.Color.Black;
            this.xrLabel8.KeepTogether = true;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(39.57482F, 41.8533F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Stat\r\nAbbr";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.plngCompanyID.Description = "plngCompanyID";
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "0";
            dynamicListLookUpSettings1.DataMember = "dsLookupCompany";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.ValueMember = "ID";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings1;
            this.plngCompanyID.Visible = false;
            // 
            // pstrSortby
            // 
            this.pstrSortby.Description = "Sort By";
            this.pstrSortby.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "\'C\'")});
            this.pstrSortby.Name = "pstrSortby";
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Description = "Show Criteria";
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "True";
            // 
            // pbitMaskTaxID
            // 
            this.pbitMaskTaxID.Description = "Mask TaxID";
            this.pbitMaskTaxID.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "True")});
            this.pbitMaskTaxID.Name = "pbitMaskTaxID";
            this.pbitMaskTaxID.Type = typeof(bool);
            this.pbitMaskTaxID.ValueInfo = "False";
            // 
            // pstrSelectEmployee
            // 
            this.pstrSelectEmployee.Description = "Parameter1";
            this.pstrSelectEmployee.MultiValue = true;
            this.pstrSelectEmployee.Name = "pstrSelectEmployee";
            this.pstrSelectEmployee.Type = typeof(int);
            // 
            // ExcelPR_StateTableListing
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix1,
            this.pageHeaderBand1});
            this.BorderColor = System.Drawing.Color.White;
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "dsPRStateTableListing";
            this.DataSource = this.Dynamic;
            this.DisplayName = "PR_StateTableListing";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 0F, 0F);
            this.PageWidth = 2236;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrSortby, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowCriteria, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbitMaskTaxID, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrServerName,
            this.pstrDatabaseName,
            this.plngUserID,
            this.Subtitle,
            this.plngCompanyID,
            this.pstrSortby,
            this.pbooShowCriteria,
            this.pbitMaskTaxID,
            this.pstrSelectEmployee});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter pstrSortby;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.Parameters.Parameter pbitMaskTaxID;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel Textbox158;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel34;
        private DevExpress.XtraReports.UI.XRLabel xrLabel35;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.Parameters.Parameter pstrSelectEmployee;
    }
}
