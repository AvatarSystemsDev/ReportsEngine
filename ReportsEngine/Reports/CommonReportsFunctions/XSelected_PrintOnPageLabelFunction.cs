using DevExpress.CodeParser;
using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ReportsEngine.Reports.CommonReportsFunctions
{
    internal sealed class XSelected_PrintOnPageLabelFunction
    {
        private static Dictionary<string, string[]> dataDictionary;
        static XSelected_PrintOnPageLabelFunction()
        {
            dataDictionary = new Dictionary<string, string[]>();

            dataDictionary["APCheck"] = new string[10]
            {
                "pstrSelectAPCheckID",
                "pstrSelectAPCheckIDDescription",
                "plngBeginningCheckSortNumber",
                "plngBeginningCheckSortDescription",
                "plngEndingCheckSortNumber",
                "plngEndingCheckSortDescription",
                "Check",
                "Checks",
                "0",
                "999999999"
            };

            dataDictionary["Account"] = new string[10]
            {
                "pstrSelectAccount",
                "pstrSelectAccountDescription",
                "pstrBeginningAccountNumber",
                "pstrBeginningAccountDescription",
                "pstrEndingAccountNumber",
                "pstrEndingAccountDescription",
                "Account",
                "Accounts",
                "!",
                "ZZZZZZZZZZ-ZZZZ"
            };

            dataDictionary["CostCenter"] = new string[10]
            {
                "pstrSelectAccountingCenter",
                "pstrSelectAccountingCenterDescription",
                "pstrBeginningCostCenterNumber",
                "pstrBeginningCostCenterDescription",
                "pstrEndingCostCenterNumber",
                "pstrEndingCostCenterDescription",
                "Accounting Center",
                "Accounting Centers",
                "!",
                "ZZZZ"
            };

            dataDictionary["AccountingCenter"] = new string[10]
            {
                "pstrSelectAccountingCenter",
                "pstrSelectAccountingCenterDescription",
                "pstrBeginningCostCenter",
                "pstrBeginningCostCenterDescription",
                "pstrEndingCostCenter",
                "pstrEndingCostCenterDescription",
                "Accounting Center",
                "Accounting Centers",
                "!",
                "ZZZZ"
            };

            dataDictionary["Owner"] = new string[10]
            {
                "pstrSelectOwner",
                "pstrSelectOwnerDescription",
                "pstrBeginningOwnerNumber",
                "pstrBeginningOwnerDescription",
                "pstrEndingOwnerNumber",
                "pstrEndingOwnerDescription",
                "Owner",
                "Owners",
                "!",
                "ZZZZZZZZZZ"
            };

            dataDictionary["Batch"] = new string[10]
            {
                "pstrSelectBatch",
                "pstrSelectBatchDescription",
                "plngBeginningBatch",
                "plngBeginningBatchDescription",
                "plngEndingBatch",
                "plngEndingBatchDescription",
                "Batch",
                "Batches",
                "-1",
                "999999999"
            };

            dataDictionary["Vendor"] = new string[10]
            {
                "pstrSelectVendor",
                "pstrSelectVendorDescription",
                "pstrBeginningVendorNumber",
                "pstrBeginningVendorDescription",
                "pstrEndingVendorNumber",
                "pstrEndingVendorDescription",
                "Vendor",
                "Vendors",
                "!",
                "ZZZZZZZZZZ"
            };

            dataDictionary["Entity"] = new string[10]
            {
                "pstrSelectEntity",
                "pstrSelectEntityDescription",
                "pstrBeginningEntityNumber",
                "pstrBeginningEntityDescription",
                "pstrEndingEntityNumber",
                "pstrEndingEntityDescription",
                "Entity",
                "Entities",
                "!",
                "ZZZZZZZZZZ"
            };

            dataDictionary["Property"] = new string[10]
            {
                "pstrSelectProperty",
                "pstrSelectPropertyDescription",
                "pstrBeginningPropertyNumber",
                "pstrBeginningPropertyDescription",
                "pstrEndingPropertyNumber",
                "pstrEndingPropertyDescription",
                "Property/Well",
                "Properties/Wells",
                "!",
                "ZZZZZZZZZZ-ZZZZZZZZZZ"
            };
        }

        internal static void X_BeforePrint(ref object sender, ParameterCollection Parameters, string dataDictionaryKey, string reportName, bool useSelectParameter = true, bool hasDescriptionParameter = true)
        {
            // reportName is exclusively for error logging.
            string errorStart = "Report Name : " + reportName + Environment.NewLine;
            bool useSelectDescriptionParameter = false;
            if (hasDescriptionParameter)
            {
                try
                {
                    useSelectDescriptionParameter = bool.Parse(Parameters["pbooSearchSortParameters"].Value.ToString()) == false;
                }
                catch
                {
                    string noKeyForDataDictionaryError = errorStart + "Report does not have parameter pbooSearchSortParameters";
                    Exception error = new Exception(noKeyForDataDictionaryError);
                    DebugErrorHandler.Error_Occurred(error);
                    return;
                }
            }
            
            
            if (dataDictionaryKey is null || !dataDictionary.ContainsKey(dataDictionaryKey))
            {
                string noKeyForDataDictionaryError = errorStart + "dataDictionary does not contain a key for " + dataDictionaryKey + Environment.NewLine + "Please add a select parameter name, beginning parameter name, and ending parameter name for both description and number parameters, singular of that parameter, plural of that parameter, the beginning index, and the ending index of that parameter to the constructor of XSelected_PrintOnPageLabelFunction.";
                Exception error = new Exception(noKeyForDataDictionaryError);
                DebugErrorHandler.Error_Occurred(error);
                return;
            }

            string[] dictionaryValues = dataDictionary[dataDictionaryKey];

            if (dictionaryValues.Length == 10)
            {
                try
                {
                    XRLabel label = sender as XRLabel;
                    Parameter selectParameter = Parameters[useSelectDescriptionParameter ? dictionaryValues[1] : dictionaryValues[0]];
                    Parameter start = Parameters[useSelectDescriptionParameter ? dictionaryValues[3] : dictionaryValues[2]];
                    Parameter end = Parameters[useSelectDescriptionParameter ? dictionaryValues[5] : dictionaryValues[4]];

                    if (useSelectParameter && (selectParameter.MultiValue == false || selectParameter.LookUpSettings == null))
                    {
                        string selectParameterError = errorStart + selectParameter + " is not a multivariate parameter with a lookup. Cannot use X_BeforePrint in XSelected_PrintOnPageLabelFunction.";
                        Exception error = new Exception(selectParameterError);
                        DebugErrorHandler.Error_Occurred(error);
                        Console.WriteLine(selectParameterError);
                        return;
                    }
                    LookUpValueCollection col = null;
                    if (useSelectParameter)
                    {
                        var dataContext = ((IServiceProvider)label.RootReport).GetService(typeof(DataContext)) as DataContext;
                        col = LookUpHelper.GetLookUpValues(selectParameter.LookUpSettings, dataContext);
                    }

                    string singlularNoun = dictionaryValues[6];
                    string pluralNoun = dictionaryValues[7]; // May need to change with other plural rules
                    string startingIndex = dictionaryValues[8];
                    string endingIndex = dictionaryValues[9];


                    if (!useSelectParameter || col.Count == (selectParameter.Value as Array).Length)
                    {
                        if (String.Compare(start.Value.ToString(), startingIndex) <= 0 && String.Compare(end.Value.ToString(), endingIndex) >= 0)
                        {
                            label.Text = "All " + pluralNoun;
                        }
                        else
                        {
                            if (start.Value.ToString() == startingIndex)
                            {
                                label.Text = "First " + singlularNoun + " to ";
                            }
                            else
                            {
                                label.Text = start.Value.ToString() + " to ";
                            }
                            if (end.Value.ToString() == endingIndex)
                            {
                                label.Text += "Last " + singlularNoun;
                            }
                            else
                            {
                                label.Text += end.Value.ToString();
                            }
                        }
                    }
                    else if ((selectParameter.Value as Array).Length == 0)
                    {
                        label.Text = "No Values Selected";
                    }
                    else
                    {
                        if (String.Compare(start.Value.ToString(), startingIndex) <= 0 && String.Compare(end.Value.ToString(), endingIndex) >= 0)
                        {
                            label.Text = "Selected " + pluralNoun;
                        }
                        else
                        {
                            if (start.Value.ToString() == startingIndex)
                            {
                                label.Text = "First " + singlularNoun + " to ";
                            }
                            else
                            {
                                label.Text = start.Value.ToString() + " to ";
                            }
                            if (end.Value.ToString() == endingIndex)
                            {
                                label.Text += "Last " + singlularNoun;
                            }
                            else
                            {
                                label.Text += end.Value.ToString();
                            }
                        }
                    }
                }
                catch(Exception error)
                {
                    DebugErrorHandler.Error_Occurred(error);
                    Console.WriteLine(errorStart + "Error: likely mismatched parameter name" + Environment.NewLine + error);
                }
            }
            else
            {
                string numberOfParametersInDictionaryError = errorStart + "dataDictionary " + dataDictionaryKey + " does not contain exactly 10 values to run X_BeforePrint in XSelected_PrintOnPageLabelFunction class." + Environment.NewLine + "Values:" + dictionaryValues.ToString() + ".";
                Exception error = new Exception(numberOfParametersInDictionaryError);
                DebugErrorHandler.Error_Occurred(error);
                Console.WriteLine(numberOfParametersInDictionaryError);
            }

        }
        private static void noDescriptionParameterError(string parameterName, string reportName)
        {
            string errorString = "Report Name : " + reportName + Environment.NewLine + "Parameter " + parameterName + " not found in data dictionary.";
            Exception error = new Exception(errorString);
            DebugErrorHandler.Error_Occurred(error);
        }
        // Have not decided if I want to use this one.

        internal static string getDescriptionParameter(string parameterName, string reportName)
        {
            foreach (KeyValuePair<string, string[]> dataDictionaryentry in dataDictionary)
            {
                for (int i = 0; i < 2; i++)
                {
                    string filterParameterName = dataDictionaryentry.Value[i * 2]; // Happen to be even indexes for filter parameters
                    if (parameterName == filterParameterName)
                    {
                        return dataDictionaryentry.Value[(i * 2) + 1]; // Description parameter happens to be the next parameter
                    }
                }
            }
            noDescriptionParameterError(parameterName, reportName);
            return "";
        }
        internal static void getSelectDescriptionParameter(ref string parameters, List<string> parameterNames, string reportName)
        {
            foreach (string parameterName in parameterNames)
            {
                bool found = false;
                foreach (KeyValuePair<string, string[]> dataDictionaryEntry in dataDictionary)
                {
                    string filterParameterName = dataDictionaryEntry.Value[1]; // Happen to be even indexes for filter parameters
                    if (parameterName == filterParameterName)
                    {
                        parameters = parameters.Replace(parameterName, dataDictionaryEntry.Value[0]); // Description parameter happens to be the next parameter
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    noDescriptionParameterError(parameterName, reportName);
                }
            }
        }

        internal static void getBeginningDescriptionParameter(ref string parameters, List<string> parameterNames, string reportName)
        {
            foreach (string parameterName in parameterNames)
            {
                bool found = false;
                foreach (KeyValuePair<string, string[]> dataDictionaryEntry in dataDictionary)
                {
                    string filterParameterName = dataDictionaryEntry.Value[3]; // Happen to be even indexes for filter parameters
                    if (parameterName == filterParameterName)
                    {
                        parameters = parameters.Replace(parameterName, dataDictionaryEntry.Value[2]); // Description parameter happens to be the next parameter
                        found = true;
                        break; // Move to next index of parameter
                    }
                }
                if (!found)
                {
                    noDescriptionParameterError(parameterName, reportName);
                }
            }
        }

        
        internal static void getEndingDescriptionParameter(ref string parameters, List<string> parameterNames, string reportName)
        {
            foreach (string parameterName in parameterNames)
            {
                bool found = false;
                foreach (KeyValuePair<string, string[]> dataDictionaryEntry in dataDictionary)
                {
                    string filterParameterName = dataDictionaryEntry.Value[5]; // Happen to be even indexes for filter parameters
                    if (parameterName == filterParameterName)
                    {
                        parameters = parameters.Replace(parameterName, dataDictionaryEntry.Value[4]); // Description parameter happens to be the next parameter
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    noDescriptionParameterError(parameterName, reportName);
                }
            }
        }
        // Used to get parameter description names if they map to an entry in the dictionary
        internal static string GetDescriptionParameterName(string parameterName, bool getOriginalParameterName = false)
        {
            if (parameterName == null)
            {
                return null;
            }
            else if (parameterName.StartsWith("pstrSelect"))
            {
                return GetSelectDescriptionParameterName(parameterName, getOriginalParameterName);
            }
            else if (parameterName.StartsWith("pstrBeginning") || parameterName.StartsWith("plngBeginning"))
            {
                return GetBeginningDescriptionParameterName(parameterName, getOriginalParameterName);
            }
            else if (parameterName.StartsWith("pstrEnding") || parameterName.StartsWith("plngEnding"))
            {
                return GetEndingDescriptionParameterName(parameterName, getOriginalParameterName);
            }
            return null;
        }
        // Helper method to GetDescriptionParameterName
        private static string GetSelectDescriptionParameterName(string parameterName, bool getOriginalParameterName = false)
        {
            foreach (KeyValuePair<string, string[]> dataDictionaryEntry in dataDictionary)
            {
                string filterParameterName = dataDictionaryEntry.Value[getOriginalParameterName ? 1: 0]; // Happen to be even indexes for filter parameters
                if (parameterName == filterParameterName)
                {
                    return dataDictionaryEntry.Value[getOriginalParameterName ? 0 : 1];
                }
            }
            return null;
        }
        // Helper method to GetDescriptionParameterName
        private static string GetBeginningDescriptionParameterName(string parameterName, bool getOriginalParameterName = false)
        {
            foreach (KeyValuePair<string, string[]> dataDictionaryEntry in dataDictionary)
            {
                string filterParameterName = dataDictionaryEntry.Value[getOriginalParameterName ? 3: 2]; // Happen to be even indexes for filter parameters
                if (parameterName == filterParameterName)
                {
                    return dataDictionaryEntry.Value[getOriginalParameterName ? 2 : 3];
                }
            }
            return null;
        }
        // Helper method to GetDescriptionParameterName
        private static string GetEndingDescriptionParameterName(string parameterName, bool getOriginalParameterName = false)
        {
            foreach (KeyValuePair<string, string[]> dataDictionaryEntry in dataDictionary)
            {
                string filterParameterName = dataDictionaryEntry.Value[getOriginalParameterName ? 5 : 4]; // Happen to be even indexes for filter parameters
                if (parameterName == filterParameterName)
                {
                    return dataDictionaryEntry.Value[getOriginalParameterName ? 4 : 5];
                }
            }
            return null;
        }

        internal static void RewireDataSourceWithDescriptionParameters(ref DevExpress.DataAccess.Sql.SqlDataSource dynamic, ref DevExpress.DataAccess.DataFederation.FederationDataSource federationDataSource, string mainDataMember, ParameterCollection Parameters, bool pbooSearchSortParameters)
        {
            // Change the expression for what is loaded into SQL stored procedures in Dynamic (changes "Dynamic" query parameters that the federation data source member for the report uses)
            var mainQueryNode = federationDataSource.Queries.OfType<DevExpress.DataAccess.DataFederation.SelectNode>().FirstOrDefault(q => q.Alias == mainDataMember); // Gets main member of federation source that the report uses

            if (mainQueryNode != null)
            {
                foreach (var source in mainQueryNode.Sources)
                {
                    if (source.DataSource is DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource && sqlDataSource == dynamic) // Getting Dynamic query that the federation data source member uses.
                    {
                        foreach (var query in sqlDataSource.Queries)
                        {
                            foreach (DevExpress.DataAccess.Sql.QueryParameter parameter in query.Parameters)
                            {
                                if (parameter.Value is DevExpress.DataAccess.Expression)
                                {
                                    var parameterValue = (DevExpress.DataAccess.Expression)parameter.Value;
                                    // Might need to change parameters back to the original ones set in the designer hense the if statement.
                                    if (!pbooSearchSortParameters)
                                    {
                                        string parameterDescriptionName = ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.GetDescriptionParameterName(parameterValue.ExpressionString.ToString().Substring(1), false);
                                        if (!string.IsNullOrEmpty(parameterDescriptionName))
                                        {
                                            Parameter parameter1 = Parameters[parameterDescriptionName];
                                            bool stringType = parameterDescriptionName.StartsWith("pstr");
                                            parameter.Value = new DevExpress.DataAccess.Expression("?" + parameter1.Name, stringType ? typeof(string) : typeof(int)); // Changing the parameter to use the Description parameter instead of regular.
                                        }
                                    }
                                    else
                                    {
                                        string parameterOriginalName = ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.GetDescriptionParameterName(parameterValue.ExpressionString.ToString().Substring(1), true);
                                        if (!string.IsNullOrEmpty(parameterOriginalName))
                                        {
                                            parameter.Value = new DevExpress.DataAccess.Expression("?" + parameterOriginalName, parameterOriginalName.StartsWith("pstr") ? typeof(string) : typeof(int)); // Changing the parameter to use the Description parameter instead of regular.
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}