namespace ReportsEngine.Reports.JIBReports
{
    partial class JIBStatementDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JIBStatementDetail));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Tablix2 = new DevExpress.XtraReports.UI.DetailBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.PropertyNumber = new DevExpress.XtraReports.UI.XRTableCell();
            this.Description = new DevExpress.XtraReports.UI.XRTableCell();
            this.DebitAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.CreditAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.Balance = new DevExpress.XtraReports.UI.XRTableCell();
            this.Tablix2_GroupHeaderBand = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Tablix2_GroupFooterBand = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Tablix2_GroupFooterBand_1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngJIBProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngJIBStatementID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngOwnerID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pdtePaymentDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrStatementMessage = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 56F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 56F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // Tablix2
            // 
            this.Tablix2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details_table});
            this.Tablix2.HeightF = 20F;
            this.Tablix2.MultiColumn.ColumnSpacing = 50F;
            this.Tablix2.Name = "Tablix2";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.Details_table.SizeF = new System.Drawing.SizeF(736.46F, 20F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.PropertyNumber,
            this.Description,
            this.DebitAmount,
            this.CreditAmount,
            this.Balance});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // PropertyNumber
            // 
            this.PropertyNumber.BorderColor = System.Drawing.Color.Black;
            this.PropertyNumber.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PropertyNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PropertyNumber.BorderWidth = 1F;
            this.PropertyNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([PhaseWellNumber] = \'0\', \'\', [PhaseWellNumber])")});
            this.PropertyNumber.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PropertyNumber.KeepTogether = true;
            this.PropertyNumber.Name = "PropertyNumber";
            this.PropertyNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.PropertyNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.PropertyNumber.Weight = 0.16860385420018845D;
            // 
            // Description
            // 
            this.Description.BorderColor = System.Drawing.Color.Black;
            this.Description.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Description.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Description.BorderWidth = 1F;
            this.Description.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
            this.Description.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Description.KeepTogether = true;
            this.Description.Name = "Description";
            this.Description.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Description.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Description.Weight = 0.30551556538985347D;
            // 
            // DebitAmount
            // 
            this.DebitAmount.BorderColor = System.Drawing.Color.Black;
            this.DebitAmount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.DebitAmount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DebitAmount.BorderWidth = 1F;
            this.DebitAmount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DebitAmount]")});
            this.DebitAmount.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.DebitAmount.KeepTogether = true;
            this.DebitAmount.Name = "DebitAmount";
            this.DebitAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.DebitAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.DebitAmount.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.DebitAmount.Weight = 0.1748227957508606D;
            // 
            // CreditAmount
            // 
            this.CreditAmount.BorderColor = System.Drawing.Color.Black;
            this.CreditAmount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CreditAmount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CreditAmount.BorderWidth = 1F;
            this.CreditAmount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CreditAmount]")});
            this.CreditAmount.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.CreditAmount.KeepTogether = true;
            this.CreditAmount.Name = "CreditAmount";
            this.CreditAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CreditAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.CreditAmount.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.CreditAmount.Weight = 0.17907286335728489D;
            // 
            // Balance
            // 
            this.Balance.BorderColor = System.Drawing.Color.Black;
            this.Balance.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Balance.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Balance.BorderWidth = 1F;
            this.Balance.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Balance]")});
            this.Balance.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Balance.KeepTogether = true;
            this.Balance.Name = "Balance";
            this.Balance.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Balance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Balance.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.Balance.Weight = 0.17199847159340903D;
            // 
            // Tablix2_GroupHeaderBand
            // 
            this.Tablix2_GroupHeaderBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Tablix2_GroupHeaderBand.HeightF = 20F;
            this.Tablix2_GroupHeaderBand.Name = "Tablix2_GroupHeaderBand";
            this.Tablix2_GroupHeaderBand.Visible = false;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(736.46F, 20F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox8,
            this.Textbox10,
            this.Textbox12,
            this.Textbox16,
            this.Textbox14});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // Textbox8
            // 
            this.Textbox8.BorderColor = System.Drawing.Color.Black;
            this.Textbox8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox8.BorderWidth = 1.39F;
            this.Textbox8.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox8.KeepTogether = true;
            this.Textbox8.Name = "Textbox8";
            this.Textbox8.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox8.Text = "Property/Well";
            this.Textbox8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox8.Weight = 0.16860385420018845D;
            // 
            // Textbox10
            // 
            this.Textbox10.BorderColor = System.Drawing.Color.Black;
            this.Textbox10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox10.BorderWidth = 1.39F;
            this.Textbox10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox10.KeepTogether = true;
            this.Textbox10.Name = "Textbox10";
            this.Textbox10.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox10.Text = "Description";
            this.Textbox10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox10.Weight = 0.30551556538985347D;
            // 
            // Textbox12
            // 
            this.Textbox12.BorderColor = System.Drawing.Color.Black;
            this.Textbox12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox12.BorderWidth = 1.39F;
            this.Textbox12.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox12.KeepTogether = true;
            this.Textbox12.Name = "Textbox12";
            this.Textbox12.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox12.Text = "Debit";
            this.Textbox12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox12.Weight = 0.1748227957508606D;
            // 
            // Textbox16
            // 
            this.Textbox16.BorderColor = System.Drawing.Color.Black;
            this.Textbox16.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox16.BorderWidth = 1.39F;
            this.Textbox16.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox16.KeepTogether = true;
            this.Textbox16.Name = "Textbox16";
            this.Textbox16.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox16.Text = "Credit";
            this.Textbox16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox16.Weight = 0.17907286335728489D;
            // 
            // Textbox14
            // 
            this.Textbox14.BorderColor = System.Drawing.Color.Black;
            this.Textbox14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Textbox14.BorderWidth = 1F;
            this.Textbox14.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Textbox14.KeepTogether = true;
            this.Textbox14.Name = "Textbox14";
            this.Textbox14.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox14.Text = "Balance";
            this.Textbox14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox14.Weight = 0.17199847159340903D;
            // 
            // Tablix2_GroupFooterBand
            // 
            this.Tablix2_GroupFooterBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Tablix2_GroupFooterBand.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif((IsNullOrEmpty(?pdtePaymentDate) Or ?pdtePaymentDate) < \'01/01/1970\', True, F" +
                    "alse)")});
            this.Tablix2_GroupFooterBand.HeightF = 20F;
            this.Tablix2_GroupFooterBand.Name = "Tablix2_GroupFooterBand";
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable2.SizeF = new System.Drawing.SizeF(736.46F, 20F);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox1});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // Textbox1
            // 
            this.Textbox1.BorderColor = System.Drawing.Color.Black;
            this.Textbox1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox1.BorderWidth = 1F;
            this.Textbox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Statement does not reflect payments received after \' + FormatString(\'{0:MM/dd/yy" +
                    "yy}\',?pdtePaymentDate)")});
            this.Textbox1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox1.KeepTogether = true;
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox1.Weight = 1.0000135088533959D;
            // 
            // Tablix2_GroupFooterBand_1
            // 
            this.Tablix2_GroupFooterBand_1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.Tablix2_GroupFooterBand_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?pstrStatementMessage = \'\', True, False)")});
            this.Tablix2_GroupFooterBand_1.HeightF = 20F;
            this.Tablix2_GroupFooterBand_1.Level = 1;
            this.Tablix2_GroupFooterBand_1.Name = "Tablix2_GroupFooterBand_1";
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable3.SizeF = new System.Drawing.SizeF(736.46F, 20F);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox6,
            this.Textbox7});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // Textbox6
            // 
            this.Textbox6.BorderColor = System.Drawing.Color.Black;
            this.Textbox6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox6.BorderWidth = 1F;
            this.Textbox6.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox6.KeepTogether = true;
            this.Textbox6.Name = "Textbox6";
            this.Textbox6.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Textbox6.Weight = 0.16860385420018845D;
            // 
            // Textbox7
            // 
            this.Textbox7.BorderColor = System.Drawing.Color.Black;
            this.Textbox7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox7.BorderWidth = 1F;
            this.Textbox7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pstrStatementMessage")});
            this.Textbox7.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox7.KeepTogether = true;
            this.Textbox7.Name = "Textbox7";
            this.Textbox7.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Textbox7.Weight = 0.8314096753723077D;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSJIB_GetStatementDetail";
            queryParameter1.Name = "@plngJIBPrintedStatementID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngJIBStatementID", typeof(int));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "Report_JIBStatementDetail";
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
            this.plngUserID.Visible = false;
            // 
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // plngJIBProcessTrackingID
            // 
            this.plngJIBProcessTrackingID.Description = "plng JIBProcess Tracking ID";
            this.plngJIBProcessTrackingID.Name = "plngJIBProcessTrackingID";
            this.plngJIBProcessTrackingID.Type = typeof(int);
            this.plngJIBProcessTrackingID.ValueInfo = "1";
            // 
            // plngJIBStatementID
            // 
            this.plngJIBStatementID.Description = "plng JIBStatement ID";
            this.plngJIBStatementID.Name = "plngJIBStatementID";
            this.plngJIBStatementID.Type = typeof(int);
            this.plngJIBStatementID.ValueInfo = "47";
            // 
            // plngOwnerID
            // 
            this.plngOwnerID.Description = "plng Owner ID";
            this.plngOwnerID.Name = "plngOwnerID";
            this.plngOwnerID.Type = typeof(int);
            this.plngOwnerID.ValueInfo = "71";
            // 
            // pdtePaymentDate
            // 
            this.pdtePaymentDate.AllowNull = true;
            this.pdtePaymentDate.Description = "pdte Payment Date";
            this.pdtePaymentDate.Name = "pdtePaymentDate";
            this.pdtePaymentDate.Type = typeof(System.DateTime);
            // 
            // pstrStatementMessage
            // 
            this.pstrStatementMessage.Description = "pstr Statement Message";
            this.pstrStatementMessage.Name = "pstrStatementMessage";
            // 
            // JIBStatementDetail
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.Tablix2,
            this.Tablix2_GroupHeaderBand,
            this.Tablix2_GroupFooterBand,
            this.Tablix2_GroupFooterBand_1});
            this.BorderColor = System.Drawing.Color.White;
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "DSJIB_GetStatementDetail";
            this.DataSource = this.Dynamic;
            this.DisplayName = "JIBStatementDetail";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(56F, 56F, 56F, 56F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.plngJIBProcessTrackingID,
            this.plngJIBStatementID,
            this.plngOwnerID,
            this.pdtePaymentDate,
            this.pstrStatementMessage});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand Tablix2;
        private DevExpress.XtraReports.UI.XRTable Details_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell PropertyNumber;
        private DevExpress.XtraReports.UI.XRTableCell Description;
        private DevExpress.XtraReports.UI.XRTableCell DebitAmount;
        private DevExpress.XtraReports.UI.XRTableCell CreditAmount;
        private DevExpress.XtraReports.UI.XRTableCell Balance;
        private DevExpress.XtraReports.UI.GroupHeaderBand Tablix2_GroupHeaderBand;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell Textbox8;
        private DevExpress.XtraReports.UI.XRTableCell Textbox10;
        private DevExpress.XtraReports.UI.XRTableCell Textbox12;
        private DevExpress.XtraReports.UI.XRTableCell Textbox16;
        private DevExpress.XtraReports.UI.XRTableCell Textbox14;
        private DevExpress.XtraReports.UI.GroupFooterBand Tablix2_GroupFooterBand;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell Textbox1;
        private DevExpress.XtraReports.UI.GroupFooterBand Tablix2_GroupFooterBand_1;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell Textbox6;
        private DevExpress.XtraReports.UI.XRTableCell Textbox7;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter plngJIBProcessTrackingID;
        private DevExpress.XtraReports.Parameters.Parameter plngJIBStatementID;
        private DevExpress.XtraReports.Parameters.Parameter plngOwnerID;
        private DevExpress.XtraReports.Parameters.Parameter pdtePaymentDate;
        private DevExpress.XtraReports.Parameters.Parameter pstrStatementMessage;
    }
}
