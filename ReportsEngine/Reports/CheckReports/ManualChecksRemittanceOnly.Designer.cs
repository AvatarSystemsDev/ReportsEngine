namespace ReportsEngine.Reports.CheckReports
{
    partial class ManualChecksRemittanceOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualChecksRemittanceOnly));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.pstrDatabaseName = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrServerName = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngUserID = new DevExpress.XtraReports.Parameters.Parameter();
            this.Subtitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormatIsMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.Dynamic = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pbooMICR = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngCheckFormat = new DevExpress.XtraReports.Parameters.Parameter();
            this.pbooSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrSignaturePath = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrTwoSignaturesRequiredAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngIsTwoSignaturesRequired = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngProcessTrackingID = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.pbooRunningAtEnd = new DevExpress.XtraReports.Parameters.Parameter();
            this.pstrCompanyAddressBlockLong = new DevExpress.XtraReports.Parameters.Parameter();
            this.plngOverflowOptionCodeID = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2});
            this.detailBand1.HeightF = 2F;
            this.detailBand1.MultiColumn.ColumnSpacing = 50F;
            this.detailBand1.Name = "detailBand1";
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
            this.plngCheckFormatIsMICR.ValueInfo = "True";
            this.plngCheckFormatIsMICR.Visible = false;
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
            // PageHeader
            // 
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand2});
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
            // PageFooter
            // 
            this.PageFooter.HeightF = 0F;
            this.PageFooter.Name = "PageFooter";
            // 
            // pbooRunningAtEnd
            // 
            this.pbooRunningAtEnd.Description = "Running At End";
            this.pbooRunningAtEnd.Name = "pbooRunningAtEnd";
            this.pbooRunningAtEnd.Type = typeof(bool);
            this.pbooRunningAtEnd.ValueInfo = "False";
            // 
            // pstrCompanyAddressBlockLong
            // 
            this.pstrCompanyAddressBlockLong.Description = "pstrCompanyAddressBlockLong";
            this.pstrCompanyAddressBlockLong.Name = "pstrCompanyAddressBlockLong";
            this.pstrCompanyAddressBlockLong.Visible = false;
            // 
            // plngOverflowOptionCodeID
            // 
            this.plngOverflowOptionCodeID.Description = "Overflow Option Code";
            this.plngOverflowOptionCodeID.Name = "plngOverflowOptionCodeID";
            this.plngOverflowOptionCodeID.Type = typeof(int);
            this.plngOverflowOptionCodeID.ValueInfo = "0";
            this.plngOverflowOptionCodeID.Visible = false;
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.GenerateOwnPages = true;
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrDatabaseName", this.pstrDatabaseName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrServerName", this.pstrServerName));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngUserID", this.plngUserID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Subtitle", this.Subtitle));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngCheckFormatIsMICR", this.plngCheckFormatIsMICR));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdblCheckAmount", null, "DSCheckHeader.CheckAmount"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pdteCheckDate", null, "DSCheckHeader.CheckDate"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCheckNumber", null, "DSCheckHeader.CheckNumber"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrEntity", null, "DSCheckHeader.EntityNumber"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngImbursementID", null, "DSCheckHeader.CheckID"));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pbooRunningAtEnd", this.pbooRunningAtEnd));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("plngOverflowOptionCodeID", this.plngOverflowOptionCodeID));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("pstrCompanyAddressBlockLong", this.pstrCompanyAddressBlockLong));
            this.xrSubreport2.ReportSource = new ReportsEngine.ManualCheckRemittanceSubreport();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(794F, 2F);
            // 
            // ManualChecksRemittanceOnly
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.PageHeader,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.Dynamic});
            this.DataMember = "DSCheckHeader";
            this.DataSource = this.Dynamic;
            this.DisplayName = "ManualChecks";
            this.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.Margins = new DevExpress.Drawing.DXMargins(28F, 28F, 12.5F, 12.5F);
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
            this.plngProcessTrackingID,
            this.pbooRunningAtEnd,
            this.pstrCompanyAddressBlockLong,
            this.plngOverflowOptionCodeID});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
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
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.Parameters.Parameter pbooRunningAtEnd;
        private DevExpress.XtraReports.Parameters.Parameter pstrCompanyAddressBlockLong;
        private DevExpress.XtraReports.Parameters.Parameter plngOverflowOptionCodeID;
    }
}
