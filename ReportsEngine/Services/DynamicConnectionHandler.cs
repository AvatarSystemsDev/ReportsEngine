using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ReportsEngine.Services
{
    public class DynamicConnectionHandler
    {
        private static string GetPulseDataBaseConnectionString()
        {
            const string DataSourcePulseValue = "pulse.avatar.local";
            const string DatabasePulse = "AvatarPulse";
            string PulseUserID = Environment.GetEnvironmentVariable("Pulse_Report_User", EnvironmentVariableTarget.Machine) ?? "RoyaltyOwnerRelationsUser";
            string PulseUserPassword = Environment.GetEnvironmentVariable("Pulse_Report_Password", EnvironmentVariableTarget.Machine) ?? "SzCz0tka";

            return "Data Source=" + DataSourcePulseValue + "; Initial Catalog=" + DatabasePulse
                + ";User Id=" + PulseUserID + ";Password=" + PulseUserPassword
                + ";MultipleActiveResultSets = True; Application Name = EntityFramework";
        }

        public struct ConnectionStringInfo
        {
            public int DatabaseID;
            public string ServerName;
            public string DatabaseName;
            public string DisplayName;

            public ConnectionStringInfo(int databaseID, string serverName, string databaseName, string displayName)
            {
                DatabaseID = databaseID;
                ServerName = serverName;
                DatabaseName = databaseName;
                DisplayName = displayName;
            }
        }

        public static ConnectionStringInfo getConnectionStringInfo(string currentDatabaseID)
        {
            return getConnectionStringInfo(Int32.Parse(currentDatabaseID));
        }

        public static ConnectionStringInfo getConnectionStringInfo(int currentDatabaseID)
        {
            string PulseConnectionString = GetPulseDataBaseConnectionString();
            int DatabaseID = 0;
            string DatabaseName = "";
            string ServerName = "";
            string DisplayName = "";

            using (SqlConnection sqlcon = new SqlConnection(PulseConnectionString))
            {
                sqlcon.Open();
                string query = "Select DatabaseName, ServerName, Name FROM Master_ApplicationDatabase Where ID=" + currentDatabaseID;
                using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                {
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter dat = new SqlDataAdapter(cmd))
                    {
                        DataTable results = new DataTable();

                        dat.Fill(results);
                        foreach (var rows in results.Rows.OfType<DataRow>())
                        {
                            //var expandos = new ExpandoObject() as IDictionary<string, object>;
                            foreach (var col in rows.Table.Columns.OfType<DataColumn>())
                            {
                                if (col.ColumnName == "ID")
                                {
                                    DatabaseID = (int)rows[col];
                                }
                                else if (col.ColumnName == "DatabaseName")
                                {
                                    DatabaseName = rows[col].ToString();
                                }
                                else if (col.ColumnName == "ServerName")
                                {
                                    ServerName = rows[col].ToString();
                                }
                                else if (col.ColumnName == "Name")
                                {
                                    DisplayName = rows[col].ToString();
                                }
                            }
                        }
                    }
                }
            }
            return new ConnectionStringInfo(DatabaseID, ServerName, DatabaseName, DisplayName);
        }
    }
}