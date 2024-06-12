using DevExpress.Drawing;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using ReportsEngine.Services;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.ServiceModel;
using WebMatrix.Data;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDCheckStubs : DevExpress.XtraReports.UI.XtraReport
    {
        private int pageCounter = 1;
        private static readonly string ReportUser = Environment.GetEnvironmentVariable("Report_User", EnvironmentVariableTarget.Machine) ?? "reportuser";
        private static readonly string ReportUserPassword = Environment.GetEnvironmentVariable("Report_User_Password", EnvironmentVariableTarget.Machine) ?? "Re.port_243";
        public RDCheckStubs() : this(0,0)
        {

        }

        public RDCheckStubs(int databaseID = 0, int companyID = 0)
        {
            InitializeComponent();

            xrPages.PrintOnPage += XrPages_PrintOnPage;
            CheckBegin.PrintOnPage += CheckBegin_PrintOnPage;
            CheckCoverPage.PrintOnPage += CheckCoverPage_PrintOnPage;
            xrPageBeginningLabel.PrintOnPage += XrPageBeginningLabel_PrintOnPage;
            xrEndCoverPage.PrintOnPage += XrEndCoverPage_PrintOnPage;
            CheckGroupBottom.BeforePrint += CheckBottomBand_BeforePrint;
            xrPictureBoxLogo.BeforePrint += XrPictureBoxLogo_BeforePrint;
            xrPictureBoxLogoTwo.BeforePrint += XrPictureBoxLogo_BeforePrint;
            LoadOverflowOptionCodeID(databaseID, companyID);

        }

        private void LoadOverflowOptionCodeID(int databaseID, int companyID)
        {
            if (databaseID != 0)
            {
                DynamicConnectionHandler.ConnectionStringInfo connectionStringParts = DynamicConnectionHandler.getConnectionStringInfo((int)databaseID);
                //Get the Database ConnectionString based on plngDatabaseID
                string connectionStringDynamic = $"Data Source={connectionStringParts.ServerName}; User ID={ReportUser}; Password={ReportUserPassword}; Initial Catalog={connectionStringParts.DatabaseName}; Persist Security Info=true; TrustServerCertificate=true;";

                using (SqlConnection connection = new SqlConnection(connectionStringDynamic))
                {
                    using (SqlCommand command = new SqlCommand("CheckFormattingOptions_ReportLookup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.Add(new SqlParameter("@plngCompanyID", SqlDbType.Int)).Value = companyID;
                        command.Parameters.Add(new SqlParameter("@plngCheckTypeCode", SqlDbType.Int)).Value = 2;
                        command.Parameters.Add(new SqlParameter("@plngDatabaseID", SqlDbType.Int)).Value = databaseID;
                        command.Parameters.Add(new SqlParameter("@plngCompanyCheckPrintingFormatID", SqlDbType.Int)).Value = 0;
                        command.Parameters.Add(new SqlParameter("@plngCheckPrintingFormatID", SqlDbType.Int)).Value = 0;

                        connection.Open();
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Assuming OverflowOptionCodeID is a column in the result set
                                    var overflowOptionCodeID = reader["OverflowOptionCodeID"].ToString();

                                    // Using the retrieved value to set RepeatEveryPage properties
                                    CheckBeginningHeader.RepeatEveryPage = overflowOptionCodeID == "1";
                                    CheckGroupBottom.RepeatEveryPage = overflowOptionCodeID == "1";
                                }
                            }
                        }
                        catch (SystemException ex)
                        {
                            throw new FaultException("Could not get report data." + ex.Message);
                        }
                    }
                }
            }
        }

        private void XrPictureBoxLogo_BeforePrint(object sender, CancelEventArgs e)
        {
            XRPictureBox pictureBox = sender as XRPictureBox;
            string imagePathLogo = GetCurrentColumnValue("LogoPath") is null ? "" : GetCurrentColumnValue("LogoPath").ToString();
            try
            {
                pictureBox.ImageSource = ImageSource.FromFile(imagePathLogo);
            }
            catch
            {
                // Probably add some error handling here.
            }
        }

        private void CheckBottomBand_BeforePrint(object sender, CancelEventArgs e)
        {
            GroupFooterBand band = sender as GroupFooterBand;
            string OverflowOptionCodeIDValue = GetCurrentColumnValue("OverflowOptionCodeID") is null ? "1" : GetCurrentColumnValue("OverflowOptionCodeID").ToString();
            band.RepeatEveryPage = OverflowOptionCodeIDValue == "1";
        }

        private void XrEndCoverPage_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void XrPageBeginningLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter++;
        }

        private void CheckCoverPage_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void CheckBegin_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCounter = 1;
        }

        private void XrPictureBoxLogo_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRPictureBox pictureBox = sender as XRPictureBox;
            string imagePathLogo = GetCurrentColumnValue("LogoPath") is null ? "" : GetCurrentColumnValue("LogoPath").ToString();
            try
            {
                pictureBox.ImageSource = ImageSource.FromFile(imagePathLogo);
            }
            catch
            {
                // Probably add some error handling here.
            }
        }

        private void XrCheckNumber_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 1; // This will make the check number visible if it is at the top of the form.
        }

        private void XrMICRTransitNumber_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 1; // This will make the check number visible if it is at the top of the form.
        }

        private void XrMICRAccountNumber_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Visible = pageCounter <= 1; // This will make the check number visible if it is at the top of the form.
        }

        private void XrPages_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label = sender as XRLabel;
            label.Text = "Page " + pageCounter.ToString();
        }

        private void XrNonNegotiablePicture_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRPictureBox picture = sender as XRPictureBox;
            picture.Visible = pageCounter > 1; // This will make the nonnegotiable image visible if it is at the top of the form. I guess that is the same as void or something. That's the way that was explained to me, I have nothing else.
        }

    }
}
