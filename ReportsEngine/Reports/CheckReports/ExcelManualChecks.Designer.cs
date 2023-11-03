namespace ReportsEngine.Reports.CheckReports
{
    partial class ExcelManualChecks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelManualChecks));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.Tablix1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Tablix1_Details_DetailBand = new DevExpress.XtraReports.UI.DetailBand();
            this.Details_table = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.CheckAmountLongString10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormat = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSignaturePath = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrTwoSignaturesRequiredAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormatIsMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngIsTwoSignaturesRequired = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.Details_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 25F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 25F;
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
            this.Tablix1.DataMember = "DSCheckHeader";
            this.Tablix1.DataSource = this.Dynamic;
            this.Tablix1.Level = 0;
            this.Tablix1.Name = "Tablix1";
            // 
            // Tablix1_Details_DetailBand
            // 
            this.Tablix1_Details_DetailBand.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Details_table});
            this.Tablix1_Details_DetailBand.HeightF = 57.37F;
            this.Tablix1_Details_DetailBand.MultiColumn.ColumnSpacing = 50F;
            this.Tablix1_Details_DetailBand.Name = "Tablix1_Details_DetailBand";
            // 
            // Details_table
            // 
            this.Details_table.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Details_table.Name = "Details_table";
            this.Details_table.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.Details_table.SizeF = new System.Drawing.SizeF(794.1F, 57.37F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.CheckAmountLongString10});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.056031955559529667D;
            // 
            // CheckAmountLongString10
            // 
            this.CheckAmountLongString10.BorderColor = System.Drawing.Color.Black;
            this.CheckAmountLongString10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.CheckAmountLongString10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CheckAmountLongString10.BorderWidth = 1F;
            this.CheckAmountLongString10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyAddressBlockShort]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif(?plngCheckFormatIsMICR = True, True, False)")});
            this.CheckAmountLongString10.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.CheckAmountLongString10.KeepTogether = true;
            this.CheckAmountLongString10.Name = "CheckAmountLongString10";
            this.CheckAmountLongString10.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.CheckAmountLongString10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.CheckAmountLongString10.Weight = 39786.565749235473D;
            // 
            // Dynamic
            // 
            this.Dynamic.ConnectionName = "Providence_Connection 1";
            this.Dynamic.Name = "Dynamic";
            storedProcQuery1.Name = "DSCheckHeader";
            queryParameter1.Name = "@plngProcessTrackingID";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?plngProcessTrackingID", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "ManualCheckPrinting_GetCheckHeader";
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
            this.plngUserID.Visible = false;
            // 
            // Subtitle
            // 
            this.Subtitle.Description = "Subtitle";
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Visible = false;
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
            this.plngCheckFormat.Visible = false;
            // 
            // pbooSignature
            // 
            this.pbooSignature.Description = "pbooSignature";
            this.pbooSignature.Name = "pbooSignature";
            this.pbooSignature.Type = typeof(bool);
            this.pbooSignature.ValueInfo = "True";
            this.pbooSignature.Visible = false;
            // 
            // pstrSignaturePath
            // 
            this.pstrSignaturePath.Description = "pstrSignaturePath";
            this.pstrSignaturePath.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Iif(?pbooSignature = True, \'/ProvidenceReports/Signatures/TestSig.png\', \'\')")});
            this.pstrSignaturePath.Name = "pstrSignaturePath";
            this.pstrSignaturePath.Visible = false;
            // 
            // pstrTwoSignaturesRequiredAmount
            // 
            this.pstrTwoSignaturesRequiredAmount.Description = "pstrTwoSignaturesRequiredAmount";
            this.pstrTwoSignaturesRequiredAmount.Name = "pstrTwoSignaturesRequiredAmount";
            this.pstrTwoSignaturesRequiredAmount.ValueInfo = "0";
            this.pstrTwoSignaturesRequiredAmount.Visible = false;
            // 
            // plngCheckFormatIsMICR
            // 
            this.plngCheckFormatIsMICR.Description = "plngCheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Name = "plngCheckFormatIsMICR";
            this.plngCheckFormatIsMICR.Type = typeof(bool);
            this.plngCheckFormatIsMICR.ValueInfo = "True";
            this.plngCheckFormatIsMICR.Visible = false;
            // 
            // plngIsTwoSignaturesRequired
            // 
            this.plngIsTwoSignaturesRequired.Description = "plngIsTwoSignaturesRequired";
            this.plngIsTwoSignaturesRequired.Name = "plngIsTwoSignaturesRequired";
            this.plngIsTwoSignaturesRequired.Type = typeof(bool);
            this.plngIsTwoSignaturesRequired.ValueInfo = "False";
            this.plngIsTwoSignaturesRequired.Visible = false;
            // 
            // plngProcessTrackingID
            // 
            this.plngProcessTrackingID.Description = "plngProcessTrackingID";
            this.plngProcessTrackingID.Name = "plngProcessTrackingID";
            this.plngProcessTrackingID.Type = typeof(int);
            this.plngProcessTrackingID.ValueInfo = "3159";
            this.plngProcessTrackingID.Visible = false;
            // 
            // ExcelManualChecks
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.Tablix1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DisplayName = "ManualChecks";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(25F, 25F, 25F, 25F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pstrDatabaseName,
            this.pstrServerName,
            this.plngUserID,
            this.Subtitle,
            this.pbooMICR,
            this.plngCheckFormat,
            this.pbooSignature,
            this.pstrSignaturePath,
            this.pstrTwoSignaturesRequiredAmount,
            this.plngCheckFormatIsMICR,
            this.plngIsTwoSignaturesRequired,
            this.plngProcessTrackingID});
            this.Version = "23.1";
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
        private DevExpress.XtraReports.UI.XRTableCell CheckAmountLongString10;
        private DevExpress.DataAccess.Sql.SqlDataSource Dynamic;
        private DevExpress.XtraReports.Parameters.Parameter pstrDatabaseName;
        private DevExpress.XtraReports.Parameters.Parameter pstrServerName;
        private DevExpress.XtraReports.Parameters.Parameter plngUserID;
        private DevExpress.XtraReports.Parameters.Parameter Subtitle;
        private DevExpress.XtraReports.Parameters.Parameter pbooMICR;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormat;
        private DevExpress.XtraReports.Parameters.Parameter pbooSignature;
        private DevExpress.XtraReports.Parameters.Parameter pstrSignaturePath;
        private DevExpress.XtraReports.Parameters.Parameter pstrTwoSignaturesRequiredAmount;
        private DevExpress.XtraReports.Parameters.Parameter plngCheckFormatIsMICR;
        private DevExpress.XtraReports.Parameters.Parameter plngIsTwoSignaturesRequired;
        private DevExpress.XtraReports.Parameters.Parameter plngProcessTrackingID;
    }
}
