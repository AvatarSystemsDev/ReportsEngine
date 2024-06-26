namespace ReportsEngine.Reports.MDReports
{
    partial class CashDepositTicket
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashDepositTicket));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Tablix1_Details_DetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountSeven = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountFourteen = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.PaymentAmountOne = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountEight = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountFifteen = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.PaymentAmountTwo = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountNine = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountSixteen = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.PaymentAmountThree = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountTen = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountSeventeen = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.PaymentAmountFour = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountEleven = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountEighteen = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.PaymentAmountFive = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountTwelve = new DevExpress.XtraReports.UI.XRTableCell();
            this.DepositSubTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.PaymentAmountSix = new DevExpress.XtraReports.UI.XRTableCell();
            this.PaymentAmountThirteen = new DevExpress.XtraReports.UI.XRTableCell();
            this.CashBackAmount1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Textbox36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Textbox38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DepositedItemCount = new DevExpress.XtraReports.UI.XRTableCell();
            this.TotalDepositAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.CashDepositSummary = new DevExpress.XtraReports.UI.XRSubreport();
            this.plngBatchID = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCompanyID = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooShowCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter6 = new DevExpress.XtraReports.Parameters.Parameter();
            this.False = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSCashDepositTicket";
            queryParameter1.Name = "@plngBatchID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngBatchID", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "CashDepositPrinting_GetDepositTicket";
            storedProcQuery2.Name = "DSCashDepositBatchesLookup";
            queryParameter2.Name = "@plngCompanyID";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(string));
            storedProcQuery2.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter2});
            storedProcQuery2.StoredProcName = "ReportWizard_PopulateCashDepositBatches";
            storedProcQuery3.Name = "DSCompaniesLookup";
            queryParameter3.Name = "@plngCompanyID";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("?plngCompanyID", typeof(int));
            storedProcQuery3.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter3});
            storedProcQuery3.StoredProcName = "Companies_ReportLookup";
            this.Dynamic.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3});
            this.Dynamic.ResultSchemaSerializable = resources.GetString("Dynamic.ResultSchemaSerializable");
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 2F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 0F;
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
            this.Tablix1_Details_DetailBand});
            this.Tablix1.DataMember = "DSCashDepositTicket";
            this.Tablix1.DataSource = this.Dynamic;
            this.Tablix1.Level = 0;
            this.Tablix1.Name = "Tablix1";
            // 
            // Tablix1_Details_DetailBand
            // 
            this.Tablix1_Details_DetailBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.Details_table});
            this.Tablix1_Details_DetailBand.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[DataSource.RowCount] > 0\n")});
            this.Tablix1_Details_DetailBand.HeightF = 280F;
            this.Tablix1_Details_DetailBand.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1_Details_DetailBand.Name = "Tablix1_Details_DetailBand";
            this.Tablix1_Details_DetailBand.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1});
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DepositDate]")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(40F, 134.6174F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(105.2083F, 20.76784F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(225.29F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow5,
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow9});
            this.Details_table.SizeF = new System.Drawing.SizeF(600F, 280F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox41,
            this.PaymentAmountSeven,
            this.PaymentAmountFourteen});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.10227272727272728D;
            // 
            // Textbox41
            // 
            this.Textbox41.BorderColor = System.Drawing.Color.Black;
            this.Textbox41.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox41.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox41.BorderWidth = 1F;
            this.Textbox41.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox41.KeepTogether = true;
            this.Textbox41.Name = "Textbox41";
            this.Textbox41.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.Textbox41.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountSeven
            // 
            this.PaymentAmountSeven.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountSeven.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountSeven.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountSeven.BorderWidth = 1F;
            this.PaymentAmountSeven.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountSeven]")});
            this.PaymentAmountSeven.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountSeven.KeepTogether = true;
            this.PaymentAmountSeven.Name = "PaymentAmountSeven";
            this.PaymentAmountSeven.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountSeven.StylePriority.UsePadding = false;
            this.PaymentAmountSeven.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountSeven.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountSeven.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountFourteen
            // 
            this.PaymentAmountFourteen.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountFourteen.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountFourteen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountFourteen.BorderWidth = 1F;
            this.PaymentAmountFourteen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountFourteen]")});
            this.PaymentAmountFourteen.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountFourteen.KeepTogether = true;
            this.PaymentAmountFourteen.Name = "PaymentAmountFourteen";
            this.PaymentAmountFourteen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountFourteen.StylePriority.UsePadding = false;
            this.PaymentAmountFourteen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountFourteen.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountFourteen.Weight = 0.2538747706600783D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.PaymentAmountOne,
            this.PaymentAmountEight,
            this.PaymentAmountFifteen});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 0.10227272727272728D;
            // 
            // PaymentAmountOne
            // 
            this.PaymentAmountOne.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountOne.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountOne.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountOne.BorderWidth = 1F;
            this.PaymentAmountOne.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountOne]")});
            this.PaymentAmountOne.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountOne.KeepTogether = true;
            this.PaymentAmountOne.Name = "PaymentAmountOne";
            this.PaymentAmountOne.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountOne.StylePriority.UsePadding = false;
            this.PaymentAmountOne.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountOne.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountOne.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountEight
            // 
            this.PaymentAmountEight.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountEight.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountEight.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountEight.BorderWidth = 1F;
            this.PaymentAmountEight.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountEight]")});
            this.PaymentAmountEight.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountEight.KeepTogether = true;
            this.PaymentAmountEight.Name = "PaymentAmountEight";
            this.PaymentAmountEight.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountEight.StylePriority.UsePadding = false;
            this.PaymentAmountEight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountEight.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountEight.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountFifteen
            // 
            this.PaymentAmountFifteen.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountFifteen.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountFifteen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountFifteen.BorderWidth = 1F;
            this.PaymentAmountFifteen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountFifteen]")});
            this.PaymentAmountFifteen.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountFifteen.KeepTogether = true;
            this.PaymentAmountFifteen.Name = "PaymentAmountFifteen";
            this.PaymentAmountFifteen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountFifteen.StylePriority.UsePadding = false;
            this.PaymentAmountFifteen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountFifteen.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountFifteen.Weight = 0.2538747706600783D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.PaymentAmountTwo,
            this.PaymentAmountNine,
            this.PaymentAmountSixteen});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 0.10227272727272728D;
            // 
            // PaymentAmountTwo
            // 
            this.PaymentAmountTwo.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountTwo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountTwo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountTwo.BorderWidth = 1F;
            this.PaymentAmountTwo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountTwo]")});
            this.PaymentAmountTwo.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountTwo.KeepTogether = true;
            this.PaymentAmountTwo.Name = "PaymentAmountTwo";
            this.PaymentAmountTwo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountTwo.StylePriority.UsePadding = false;
            this.PaymentAmountTwo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountTwo.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountTwo.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountNine
            // 
            this.PaymentAmountNine.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountNine.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountNine.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountNine.BorderWidth = 1F;
            this.PaymentAmountNine.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountNine]")});
            this.PaymentAmountNine.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountNine.KeepTogether = true;
            this.PaymentAmountNine.Name = "PaymentAmountNine";
            this.PaymentAmountNine.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountNine.StylePriority.UsePadding = false;
            this.PaymentAmountNine.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountNine.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountNine.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountSixteen
            // 
            this.PaymentAmountSixteen.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountSixteen.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountSixteen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountSixteen.BorderWidth = 1F;
            this.PaymentAmountSixteen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountSixteen]")});
            this.PaymentAmountSixteen.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountSixteen.KeepTogether = true;
            this.PaymentAmountSixteen.Name = "PaymentAmountSixteen";
            this.PaymentAmountSixteen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountSixteen.StylePriority.UsePadding = false;
            this.PaymentAmountSixteen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountSixteen.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountSixteen.Weight = 0.2538747706600783D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.PaymentAmountThree,
            this.PaymentAmountTen,
            this.PaymentAmountSeventeen});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 0.10227272727272728D;
            // 
            // PaymentAmountThree
            // 
            this.PaymentAmountThree.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountThree.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountThree.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountThree.BorderWidth = 1F;
            this.PaymentAmountThree.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountThree]")});
            this.PaymentAmountThree.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountThree.KeepTogether = true;
            this.PaymentAmountThree.Name = "PaymentAmountThree";
            this.PaymentAmountThree.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountThree.StylePriority.UsePadding = false;
            this.PaymentAmountThree.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountThree.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountThree.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountTen
            // 
            this.PaymentAmountTen.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountTen.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountTen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountTen.BorderWidth = 1F;
            this.PaymentAmountTen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountTen]")});
            this.PaymentAmountTen.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountTen.KeepTogether = true;
            this.PaymentAmountTen.Name = "PaymentAmountTen";
            this.PaymentAmountTen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountTen.StylePriority.UsePadding = false;
            this.PaymentAmountTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountTen.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountTen.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountSeventeen
            // 
            this.PaymentAmountSeventeen.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountSeventeen.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountSeventeen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountSeventeen.BorderWidth = 1F;
            this.PaymentAmountSeventeen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountSeventeen]")});
            this.PaymentAmountSeventeen.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountSeventeen.KeepTogether = true;
            this.PaymentAmountSeventeen.Name = "PaymentAmountSeventeen";
            this.PaymentAmountSeventeen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountSeventeen.StylePriority.UsePadding = false;
            this.PaymentAmountSeventeen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountSeventeen.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountSeventeen.Weight = 0.2538747706600783D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.PaymentAmountFour,
            this.PaymentAmountEleven,
            this.PaymentAmountEighteen});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 0.10227272727272728D;
            // 
            // PaymentAmountFour
            // 
            this.PaymentAmountFour.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountFour.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountFour.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountFour.BorderWidth = 1F;
            this.PaymentAmountFour.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountFour]")});
            this.PaymentAmountFour.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountFour.KeepTogether = true;
            this.PaymentAmountFour.Name = "PaymentAmountFour";
            this.PaymentAmountFour.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountFour.StylePriority.UsePadding = false;
            this.PaymentAmountFour.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountFour.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountFour.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountEleven
            // 
            this.PaymentAmountEleven.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountEleven.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountEleven.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountEleven.BorderWidth = 1F;
            this.PaymentAmountEleven.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountEleven]")});
            this.PaymentAmountEleven.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountEleven.KeepTogether = true;
            this.PaymentAmountEleven.Name = "PaymentAmountEleven";
            this.PaymentAmountEleven.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountEleven.StylePriority.UsePadding = false;
            this.PaymentAmountEleven.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountEleven.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountEleven.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountEighteen
            // 
            this.PaymentAmountEighteen.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountEighteen.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountEighteen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountEighteen.BorderWidth = 1F;
            this.PaymentAmountEighteen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountEighteen]")});
            this.PaymentAmountEighteen.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountEighteen.KeepTogether = true;
            this.PaymentAmountEighteen.Name = "PaymentAmountEighteen";
            this.PaymentAmountEighteen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountEighteen.StylePriority.UsePadding = false;
            this.PaymentAmountEighteen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountEighteen.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountEighteen.Weight = 0.2538747706600783D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.PaymentAmountFive,
            this.PaymentAmountTwelve,
            this.DepositSubTotal});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 0.10227272727272728D;
            // 
            // PaymentAmountFive
            // 
            this.PaymentAmountFive.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountFive.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountFive.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountFive.BorderWidth = 1F;
            this.PaymentAmountFive.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountFive]")});
            this.PaymentAmountFive.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountFive.KeepTogether = true;
            this.PaymentAmountFive.Name = "PaymentAmountFive";
            this.PaymentAmountFive.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountFive.StylePriority.UsePadding = false;
            this.PaymentAmountFive.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountFive.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountFive.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountTwelve
            // 
            this.PaymentAmountTwelve.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountTwelve.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountTwelve.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountTwelve.BorderWidth = 1F;
            this.PaymentAmountTwelve.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountTwelve]")});
            this.PaymentAmountTwelve.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountTwelve.KeepTogether = true;
            this.PaymentAmountTwelve.Name = "PaymentAmountTwelve";
            this.PaymentAmountTwelve.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountTwelve.StylePriority.UsePadding = false;
            this.PaymentAmountTwelve.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountTwelve.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountTwelve.Weight = 0.2538747706600783D;
            // 
            // DepositSubTotal
            // 
            this.DepositSubTotal.BorderColor = System.Drawing.Color.Black;
            this.DepositSubTotal.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.DepositSubTotal.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DepositSubTotal.BorderWidth = 1F;
            this.DepositSubTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DepositSubTotal]")});
            this.DepositSubTotal.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.DepositSubTotal.KeepTogether = true;
            this.DepositSubTotal.Name = "DepositSubTotal";
            this.DepositSubTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.DepositSubTotal.StylePriority.UsePadding = false;
            this.DepositSubTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.DepositSubTotal.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.DepositSubTotal.Weight = 0.2538747706600783D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.PaymentAmountSix,
            this.PaymentAmountThirteen,
            this.CashBackAmount1});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 0.10227272727272728D;
            // 
            // PaymentAmountSix
            // 
            this.PaymentAmountSix.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountSix.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountSix.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountSix.BorderWidth = 1F;
            this.PaymentAmountSix.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountSix]")});
            this.PaymentAmountSix.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountSix.KeepTogether = true;
            this.PaymentAmountSix.Name = "PaymentAmountSix";
            this.PaymentAmountSix.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountSix.StylePriority.UsePadding = false;
            this.PaymentAmountSix.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountSix.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountSix.Weight = 0.2538747706600783D;
            // 
            // PaymentAmountThirteen
            // 
            this.PaymentAmountThirteen.BorderColor = System.Drawing.Color.Black;
            this.PaymentAmountThirteen.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PaymentAmountThirteen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PaymentAmountThirteen.BorderWidth = 1F;
            this.PaymentAmountThirteen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PaymentAmountThirteen]")});
            this.PaymentAmountThirteen.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.PaymentAmountThirteen.KeepTogether = true;
            this.PaymentAmountThirteen.Name = "PaymentAmountThirteen";
            this.PaymentAmountThirteen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.PaymentAmountThirteen.StylePriority.UsePadding = false;
            this.PaymentAmountThirteen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.PaymentAmountThirteen.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.PaymentAmountThirteen.Weight = 0.2538747706600783D;
            // 
            // CashBackAmount1
            // 
            this.CashBackAmount1.BorderColor = System.Drawing.Color.Black;
            this.CashBackAmount1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CashBackAmount1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CashBackAmount1.BorderWidth = 1F;
            this.CashBackAmount1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CashBackAmount]")});
            this.CashBackAmount1.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.CashBackAmount1.KeepTogether = true;
            this.CashBackAmount1.Name = "CashBackAmount1";
            this.CashBackAmount1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.CashBackAmount1.StylePriority.UsePadding = false;
            this.CashBackAmount1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.CashBackAmount1.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.CashBackAmount1.Weight = 0.2538747706600783D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox34,
            this.Textbox35,
            this.Textbox36});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 0.18939393939393939D;
            // 
            // Textbox34
            // 
            this.Textbox34.BorderColor = System.Drawing.Color.Black;
            this.Textbox34.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox34.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox34.BorderWidth = 1F;
            this.Textbox34.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox34.KeepTogether = true;
            this.Textbox34.Name = "Textbox34";
            this.Textbox34.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox34.Weight = 0.2538747706600783D;
            // 
            // Textbox35
            // 
            this.Textbox35.BorderColor = System.Drawing.Color.Black;
            this.Textbox35.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox35.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox35.BorderWidth = 1F;
            this.Textbox35.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox35.KeepTogether = true;
            this.Textbox35.Name = "Textbox35";
            this.Textbox35.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox35.Weight = 0.2538747706600783D;
            // 
            // Textbox36
            // 
            this.Textbox36.BorderColor = System.Drawing.Color.Black;
            this.Textbox36.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox36.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox36.BorderWidth = 1F;
            this.Textbox36.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox36.KeepTogether = true;
            this.Textbox36.Name = "Textbox36";
            this.Textbox36.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Textbox36.Weight = 0.2538747706600783D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Textbox38,
            this.DepositedItemCount,
            this.TotalDepositAmount});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 0.0946969696969697D;
            // 
            // Textbox38
            // 
            this.Textbox38.BorderColor = System.Drawing.Color.Black;
            this.Textbox38.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Textbox38.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Textbox38.BorderWidth = 1F;
            this.Textbox38.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.Textbox38.KeepTogether = true;
            this.Textbox38.Name = "Textbox38";
            this.Textbox38.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Textbox38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.Textbox38.Weight = 0.2538747706600783D;
            // 
            // DepositedItemCount
            // 
            this.DepositedItemCount.BorderColor = System.Drawing.Color.Black;
            this.DepositedItemCount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.DepositedItemCount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DepositedItemCount.BorderWidth = 1F;
            this.DepositedItemCount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DepositedItemCount]")});
            this.DepositedItemCount.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.DepositedItemCount.KeepTogether = true;
            this.DepositedItemCount.Name = "DepositedItemCount";
            this.DepositedItemCount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 35, 2, 2, 100F);
            this.DepositedItemCount.StylePriority.UsePadding = false;
            this.DepositedItemCount.StylePriority.UseTextAlignment = false;
            this.DepositedItemCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.DepositedItemCount.Weight = 0.2538747706600783D;
            // 
            // TotalDepositAmount
            // 
            this.TotalDepositAmount.BorderColor = System.Drawing.Color.Black;
            this.TotalDepositAmount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.TotalDepositAmount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalDepositAmount.BorderWidth = 1F;
            this.TotalDepositAmount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalDepositAmount]")});
            this.TotalDepositAmount.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9F);
            this.TotalDepositAmount.KeepTogether = true;
            this.TotalDepositAmount.Name = "TotalDepositAmount";
            this.TotalDepositAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.TotalDepositAmount.StylePriority.UsePadding = false;
            this.TotalDepositAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.TotalDepositAmount.TextFormatString = "{0:\'$\'#,0.00;(\'$\'#,0.00)}";
            this.TotalDepositAmount.Weight = 0.2538747706600783D;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.CashDepositSummary});
            this.SubBand1.HeightF = 99.66663F;
            this.SubBand1.Name = "SubBand1";
            this.SubBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            // 
            // CashDepositSummary
            // 
            this.CashDepositSummary.LocationFloat = new DevExpress.Utils.PointFloat(40F, 79.66663F);
            this.CashDepositSummary.Name = "CashDepositSummary";
            this.CashDepositSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngBatchID", this.plngBatchID));
            this.CashDepositSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCompanyID", this.plngCompanyID));
            this.CashDepositSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.CashDepositSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.CashDepositSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Subtitle", this.Subtitle));
            this.CashDepositSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooShowCriteria", this.pbooShowCriteria));
            this.CashDepositSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.CashDepositSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooShowHeader", null, "DSCashDepositTicket.False"));
            this.CashDepositSummary.ReportSource = new ReportsEngine.Reports.MDReports.CashDepositSummary();
            this.CashDepositSummary.SizeF = new System.Drawing.SizeF(770F, 20F);
            // 
            // plngBatchID
            // 
            this.plngBatchID.Name = "plngBatchID";
            this.plngBatchID.Type = typeof(int);
            this.plngBatchID.ValueInfo = "0";
            this.plngBatchID.Visible = false;
            // 
            // plngCompanyID
            // 
            this.plngCompanyID.Name = "plngCompanyID";
            this.plngCompanyID.Type = typeof(int);
            this.plngCompanyID.ValueInfo = "1";
            dynamicListLookUpSettings1.DataMember = "DSCompaniesLookup";
            dynamicListLookUpSettings1.DataSource = this.Dynamic;
            dynamicListLookUpSettings1.DisplayMember = "Description";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = null;
            dynamicListLookUpSettings1.ValueMember = "Number";
            this.plngCompanyID.ValueSourceSettings = dynamicListLookUpSettings1;
            this.plngCompanyID.Visible = false;
            // 
            // pstrDatabaseName
            // 
            this.pstrDatabaseName.Name = "pstrDatabaseName";
            this.pstrDatabaseName.ValueInfo = "0";
            this.pstrDatabaseName.Visible = false;
            // 
            // pstrServerName
            // 
            this.pstrServerName.Name = "pstrServerName";
            this.pstrServerName.Visible = false;
            // 
            // Subtitle
            // 
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
            // 
            // pbooShowCriteria
            // 
            this.pbooShowCriteria.Name = "pbooShowCriteria";
            this.pbooShowCriteria.Type = typeof(bool);
            this.pbooShowCriteria.ValueInfo = "False";
            this.pbooShowCriteria.Visible = false;
            // 
            // plngUserID
            // 
            this.plngUserID.Name = "plngUserID";
            this.plngUserID.Type = typeof(int);
            this.plngUserID.ValueInfo = "0";
            this.plngUserID.Visible = false;
            // 
            // parameter6
            // 
            this.parameter6.Description = "Deposit";
            this.parameter6.Name = "parameter6";
            this.parameter6.Type = typeof(int);
            this.parameter6.ValueInfo = "0";
            dynamicListLookUpSettings2.DataMember = "DSCashDepositBatchesLookup";
            dynamicListLookUpSettings2.DataSource = this.Dynamic;
            dynamicListLookUpSettings2.DisplayMember = "Item";
            dynamicListLookUpSettings2.ValueMember = "ItemData";
            this.parameter6.ValueSourceSettings = dynamicListLookUpSettings2;
            this.parameter6.Visible = false;
            // 
            // False
            // 
            this.False.DataMember = "DSCashDepositTicket";
            this.False.DataSource = this.Dynamic;
            this.False.Expression = "false";
            this.False.FieldType = DevExpress.XtraReports.UI.FieldType.Boolean;
            this.False.Name = "False";
            // 
            // CashDepositTicket
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.Tablix1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.False});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DisplayName = "CashDepositTicket";
            this.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[DataSource.RowCount] = 0\n")});
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 2F, 0F);
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngBatchID, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngCompanyID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrDatabaseName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pstrServerName, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Subtitle, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.pbooShowCriteria, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.plngUserID, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.parameter6, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.plngBatchID,
            this.plngCompanyID,
            this.pstrDatabaseName,
            this.pstrServerName,
            this.Subtitle,
            this.pbooShowCriteria,
            this.plngUserID,
            this.parameter6});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.DetailReportBand Tablix1;
        private DevExpress.XtraReports.UI.DetailBand Tablix1_Details_DetailBand;
        private DevExpress.XtraReports.UI.XRTable Details_table;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell Textbox41;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountSeven;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountFourteen;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountOne;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountEight;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountFifteen;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountTwo;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountNine;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountSixteen;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountThree;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountTen;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountSeventeen;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountFour;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountEleven;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountEighteen;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountFive;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountTwelve;
        private DevExpress.XtraReports.UI.XRTableCell DepositSubTotal;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountSix;
        private DevExpress.XtraReports.UI.XRTableCell PaymentAmountThirteen;
        private DevExpress.XtraReports.UI.XRTableCell CashBackAmount1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell Textbox34;
        private DevExpress.XtraReports.UI.XRTableCell Textbox35;
        private DevExpress.XtraReports.UI.XRTableCell Textbox36;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell Textbox38;
        private DevExpress.XtraReports.UI.XRTableCell DepositedItemCount;
        private DevExpress.XtraReports.UI.XRTableCell TotalDepositAmount;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter plngBatchID;
        private DevExpress.XtraReports.Parameters.Parameter plngCompanyID;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pbooShowCriteria;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter parameter6;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRSubreport CashDepositSummary;
        private DevExpress.XtraReports.UI.CalculatedField False;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
