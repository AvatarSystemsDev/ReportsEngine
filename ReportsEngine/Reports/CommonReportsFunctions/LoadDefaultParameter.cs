using DevExpress.XtraReports.Parameters;
using ReportsEngine.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ReportsEngine.Reports.CommonReportsFunctions
{
    internal class LoadDefaultParameter
    {
        private static readonly string ReportUser = Environment.GetEnvironmentVariable("Report_User", EnvironmentVariableTarget.Machine) ?? "reportuser";
        private static readonly string ReportUserPassword = Environment.GetEnvironmentVariable("Report_User_Password", EnvironmentVariableTarget.Machine) ?? "Re.port_243";

        internal static void LoadFirstParameterFromStoredProcedure<T>(int databaseID,  string storedProcedureName, string parameterNameToChange, ref ParameterCollection Parameters, // Mandatory parameters
            int companyID = 0, string[] sqlParameterNames = null, T[] sqlParameterValues = null, string fieldName = "ID") // Optional parameters
        {
            if (databaseID != 0 && (sqlParameterNames is null && sqlParameterValues is null || sqlParameterNames.Length == sqlParameterNames.Length))
            {
                DynamicConnectionHandler.ConnectionStringInfo connectionStringParts = DynamicConnectionHandler.getConnectionStringInfo((int)databaseID);
                //Get the Database ConnectionString based on plngDatabaseID
                string connectionStringDynamic = $"Data Source={connectionStringParts.ServerName}; User ID={ReportUser}; Password={ReportUserPassword}; Initial Catalog={connectionStringParts.DatabaseName}; Persist Security Info=true; TrustServerCertificate=true;";

                using (SqlConnection connection = new SqlConnection(connectionStringDynamic))
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        if (companyID > 0)
                        {
                            command.Parameters.Add(new SqlParameter("@plngCompanyID", SqlDbType.Int)).Value = companyID;
                        }
                        for (int i = 0; i < sqlParameterNames.Length; i++)
                        {
                            int parameterType = parameterNameToChange.Substring(0, 3) == "plng" ? 0 : 1; // Probably add more types
                            switch (parameterType)
                            {
                                case 0:
                                    command.Parameters.Add(new SqlParameter(sqlParameterNames[i], SqlDbType.Int)).Value = int.Parse(sqlParameterValues[i].ToString());
                                    break;
                                case 1:
                                    command.Parameters.Add(new SqlParameter(sqlParameterNames[i], SqlDbType.VarChar)).Value = sqlParameterValues[i].ToString();
                                    break;
                                default:    //  Possibly add more cases
                                    break;
                            }

                        }
                        command.Parameters.Add(new SqlParameter("@plngReportGroupMasterID", SqlDbType.Int)).Value = 7;

                        connection.Open();
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                var row = reader.Read();
                                while (reader.Read())
                                {
                                    if (reader.GetInt32(0) != 0) 
                                    {
                                        row = true;
                                        break;
                                    }
                                }
                                int parameterType = parameterNameToChange.Substring(0, 3) == "plng" ? 0 : 1;
                                if (row)
                                {
                                    Parameter parameter = Parameters[parameterNameToChange];
                                    switch (parameterType)
                                    {
                                        case 0:
                                            parameter.Value = int.Parse(reader[fieldName].ToString());
                                            break;
                                        case 1:
                                            parameter.Value = reader[fieldName].ToString();
                                            break;
                                        default:
                                            break;
                                    }
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
    }
}
