﻿using DevExpress.XtraReports.UI;
using ReportsEngine.Services;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.ServiceModel;
using WebMatrix.Data;
using DevExpress.XtraReports.Parameters;
using static DevExpress.Web.Internal.ColorPicker;
using DevExpress.Web.Internal.XmlProcessor;

namespace ReportsEngine.Reports.MDReports
{
    public partial class DetailAFE : DevExpress.XtraReports.UI.XtraReport
    {
        private int PageNumber = 1;
        private bool EndAFE = false;
        private static readonly string ReportUser = Environment.GetEnvironmentVariable("Report_User", EnvironmentVariableTarget.Machine) ?? "reportuser";
        private static readonly string ReportUserPassword = Environment.GetEnvironmentVariable("Report_User_Password", EnvironmentVariableTarget.Machine) ?? "Re.port_243";
        public DetailAFE() : this(0, 0)
        {

        }
        public DetailAFE(int databaseID, int companyID)
        {
            InitializeComponent();
            xrAFEOver.PrintOnPage += XrAFEOver_PrintOnPage;
            xrPageNumber.PrintOnPage += XrPageNumber_PrintOnPage;
            LoadDefaultAFE(databaseID, companyID);
        }
        private void LoadDefaultAFE(int databaseID, int companyID)
        {
            if (databaseID != 0 || companyID != 0)
            {
                DynamicConnectionHandler.ConnectionStringInfo connectionStringParts = DynamicConnectionHandler.getConnectionStringInfo((int)databaseID);
                //Get the Database ConnectionString based on plngDatabaseID
                string connectionStringDynamic = $"Data Source={connectionStringParts.ServerName}; User ID={ReportUser}; Password={ReportUserPassword}; Initial Catalog={connectionStringParts.DatabaseName}; Persist Security Info=true; TrustServerCertificate=true;";

                using (SqlConnection connection = new SqlConnection(connectionStringDynamic))
                {
                    using (SqlCommand command = new SqlCommand("AFEs_ReportLookup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.Add(new SqlParameter("@plngCompanyID", SqlDbType.Int)).Value = companyID;

                        connection.Open();
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Parameter parameter = Parameters["plngReportGroupAFEID"];
                                    int AFEID = int.Parse(reader["ID"].ToString());
                                    parameter.Value = AFEID;
                                }
                            }
                        }
                        catch (SystemException ex)
                        {
                            Console.WriteLine(ex.ToString());
                            // Just means no data in AFE Company
                        }
                    }
                }
            }
        }

        private void XrPageNumber_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRLabel pageLabel = sender as XRLabel;
            pageLabel.Text = "Page " + PageNumber.ToString();
            if (!EndAFE)
            {
                PageNumber++;
            }
            else
            {
                EndAFE = true;
                PageNumber = 1;
            }

        }

        private void XrAFEOver_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            EndAFE = true;
        }
    }
}
