using System;
using System.ComponentModel;
using System.Web.WebPages;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

// C# does not support multiple inheritance so I had to do this the most ratchety way ever (needs to modify properties of XtraReport that cannot be passed to function).
// This mixes separate functions in the XSelected_PrintOnPageLabelFunction and has any report modified in the designer modified by inheriting through here.
// First Inherit this class
// Then use the EnableDescriptionParameters method with the following:
// original filter string (The filter string will be edited to filter using the description or number parameters upon report submission).
// the dynamic datasource that you use (most likely named Dynamic)
// FederationDataSource (probably federationDataSource1)
// The data member that you are using from FederationDataSource (this.DataMember from from subclass)
// This is designed to make adding report parameters copy-paste "friendly".

namespace ReportsEngine.Reports
{
    public partial class ReportWithDescriptionParameters : XtraReport
    {
        private string originalFilterString;
        private bool DescriptionParametersInitialized = false;
        protected internal bool EnableDescriptionParameters(string filterString, ref DevExpress.DataAccess.Sql.SqlDataSource dynamic, ref DevExpress.DataAccess.DataFederation.FederationDataSource federationDataSource, string mainDataMember)
        {
            try
            {
                originalFilterString = filterString;
                Parameter pbooSearchSortParameter = Parameters["pbooSearchSortParameters"];
                if (pbooSearchSortParameter is null)
                {
                    AddPbooSearchSortParametersToReport();
                    pbooSearchSortParameter = Parameters["pbooSearchSortParameters"];
                }
                if (!(pbooSearchSortParameter is null))
                {
                    bool pbooSearchSortParameterValue = bool.Parse(pbooSearchSortParameter.Value.ToString());
                    AddDescriptionParametersToReport();
                    haveFilterStringUseDescriptionParameters(pbooSearchSortParameterValue);
                    ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref dynamic, ref federationDataSource, mainDataMember, this.Parameters, true);
                }
            }
            catch
            {
                return false; // Unsuccessful
            }
            return true; // Successful
        }
        protected internal void EnableDescriptionParametersOnDataSourceDemanded(object sender, EventArgs e)
        {
            Parameter pbooSearchSortParameter = Parameters["pbooSearchSortParameters"];
            if (pbooSearchSortParameter != null)
            {
                bool pbooSearchSortParameterValue = bool.Parse(pbooSearchSortParameter.Value.ToString());
                AddDescriptionParametersToReport();
                haveFilterStringUseDescriptionParameters(pbooSearchSortParameterValue);
            }
        }

        private void AddPbooSearchSortParametersToReport()
        {
            try
            {
                int indexOfLastDateParameter = 0;
                string keyOfLastDateParameter = "";
                for (int index = 0; index < ParameterPanelLayoutItems.Count; index++)
                {
                    ParameterLayoutItem layoutItemindex = (ParameterLayoutItem)ParameterPanelLayoutItems[index];
                    string layoutItemString = layoutItemindex.Parameter.Name.ToString();
                    if (layoutItemString.StartsWith("pdte"))
                    {
                        indexOfLastDateParameter = index;
                        keyOfLastDateParameter = layoutItemString;
                    }
                }

                Parameter pbooSearchSortParameter = new Parameter();
                StaticListLookUpSettings pbooSearchSortParameterStaticLookupSettings = new StaticListLookUpSettings();
                pbooSearchSortParameter.Name = "pbooSearchSortParameters";
                pbooSearchSortParameter.Description = "Search/Sort Parameters by";
                pbooSearchSortParameter.Type = typeof(bool);
                pbooSearchSortParameter.Value = true;
                pbooSearchSortParameter.MultiValue = false;
                pbooSearchSortParameter.Visible = true;
                pbooSearchSortParameter.Enabled = true;
                pbooSearchSortParameter.AllowNull = false;
                pbooSearchSortParameterStaticLookupSettings.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(false, "Description"));
                pbooSearchSortParameterStaticLookupSettings.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(true, "Number"));
                pbooSearchSortParameter.ValueSourceSettings = pbooSearchSortParameterStaticLookupSettings;

                ParameterLayoutItem layoutItemNew = new ParameterLayoutItem(pbooSearchSortParameter, Orientation.Horizontal);
                if (indexOfLastDateParameter > 0 && !keyOfLastDateParameter.IsEmpty())
                {
                    int lastKeyIndexParameters = Parameters.IndexOf(Parameters[keyOfLastDateParameter]); // index in Parameters is different than ParameterPanelLayoutItems
                    Parameters.Insert(indexOfLastDateParameter + (ParameterPanelLayoutItems.Count > indexOfLastDateParameter + 1 ? 1 : 0), pbooSearchSortParameter);
                }
                else
                {
                    Parameters.Insert(0, pbooSearchSortParameter); 
                }
                ParameterPanelLayoutItems.Insert(indexOfLastDateParameter + (ParameterPanelLayoutItems.Count > indexOfLastDateParameter + 1 ? 1 : 0), layoutItemNew);
            }
            catch (Exception ex)
            {
                string errorString = "Report Name: " + DisplayName  // Not sure this is using the right display name. Should be from class inheriting this one.
                    + Environment.NewLine + "Parameter pbooSearchSortParameters could not be added in AddPbooSearchSortParametersToReport() in class ReportWithDescriptionParameters." + Environment.NewLine + "Error: " + Environment.NewLine + ex.ToString();
                Exception error = new Exception(errorString);
                DebugErrorHandler.Error_Occurred(error);
            }

        }

        private void AddDescriptionParametersToReport()
        {
            if (!DescriptionParametersInitialized)
            {
                DescriptionParametersInitialized = true;
                for (int index = 0; index < Parameters.Count; index++)
                {
                    string parameterName = Parameters[index].Name;
                    string descriptionParameterIdentity = ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.GetDescriptionParameterName(parameterName);
                    if (Parameters[index].ValueSourceSettings is DynamicListLookUpSettings && !(descriptionParameterIdentity is null))
                    {
                        string parameterDescription = Parameters[index].Description;
                        var parameterValue = Parameters[index].Value;
                        Parameter newDescriptionParameter = new Parameter();
                        newDescriptionParameter.Value = parameterValue;
                        newDescriptionParameter.Description = parameterDescription;
                        newDescriptionParameter.Name = ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.GetDescriptionParameterName(parameterName);

                        DynamicListLookUpSettings descriptionParameterLookupSettings = new DynamicListLookUpSettings();
                        descriptionParameterLookupSettings.ValueMember = (Parameters[index].ValueSourceSettings as DynamicListLookUpSettings).ValueMember;
                        descriptionParameterLookupSettings.DataMember = (Parameters[index].ValueSourceSettings as DynamicListLookUpSettings).DataMember;
                        descriptionParameterLookupSettings.DataSource = (Parameters[index].ValueSourceSettings as DynamicListLookUpSettings).DataSource;
                        descriptionParameterLookupSettings.FilterString = (Parameters[index].ValueSourceSettings as DynamicListLookUpSettings).FilterString;
                        descriptionParameterLookupSettings.DisplayMember = "DescriptionFirstThenNumber";
                        descriptionParameterLookupSettings.SortMember = descriptionParameterLookupSettings.DisplayMember;
                        descriptionParameterLookupSettings.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                        newDescriptionParameter.ValueSourceSettings = descriptionParameterLookupSettings;

                        newDescriptionParameter.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] { new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Visible", "not ?pbooSearchSortParameters") });
                        Parameters[index].ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] { new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Visible", "?pbooSearchSortParameters") });
                        try
                        {
                            ParameterLayoutItem DescriptionParameterLayoutItem = new ParameterLayoutItem(newDescriptionParameter, DevExpress.XtraReports.Parameters.Orientation.Horizontal);
                            int LayoutItemIndex = 0;
                            for (; LayoutItemIndex < ParameterPanelLayoutItems.Count; LayoutItemIndex++)
                            {
                                ParameterLayoutItem layoutItem = (ParameterLayoutItem)ParameterPanelLayoutItems[LayoutItemIndex];

                                string layoutItemString = layoutItem.Parameter.Name.ToString();
                                if (layoutItemString == parameterName)
                                {
                                    break;
                                }
                            }
                            ParameterPanelLayoutItems.Insert(LayoutItemIndex, DescriptionParameterLayoutItem);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }

                        if (newDescriptionParameter.Name.StartsWith("pstrSelect"))
                        {
                            newDescriptionParameter.MultiValue = true;
                            newDescriptionParameter.SelectAllValues = true;
                        }
                        index++;
                        this.Parameters.Insert(index, newDescriptionParameter);
                    }
                }
            }
        }
        private void haveFilterStringUseDescriptionParameters(bool pbooSearchSortParameters)
        {
            this.FilterString = originalFilterString; // Changes filter string to original filter string just in case Number is selected after Description was. 
            if (!pbooSearchSortParameters)
            {
                for (int index = 0; index < Parameters.Count; index++)
                {

                    string parameterName = Parameters[index].Name;
                    string s = Parameters[index].Description.ToString();
                    if (parameterName.Contains("Description") && Parameters[index].Description.ToString() == Parameters[index - 1].Description.ToString()) // Assumes description parameter is the parameter right in front and no other parameter contains "Description" that is not a boolean variable
                    {
                        if (parameterName.Contains("pstrSelect"))
                        {
                            this.FilterString = this.FilterString.Replace("(?" + Parameters[index - 1].Name + ")", "(?" + Parameters[index].Name + ")");
                        }
                    }
                }
            }
        }


        protected internal void XrOwnersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Owner", this.DisplayName, true, true);
        }
        protected internal void XrVendorsSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Vendor", this.DisplayName, true, true);
        }
        protected internal void XrEntitiesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Vendor", this.DisplayName, true, true);
        }
        protected internal void XrAccountsSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Account", this.DisplayName, true, true);
        }
        protected internal void XrAccountingCentersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "AccountingCenter", this.DisplayName, true, true);
        }

        protected internal void XrPropertiesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Property", this.DisplayName, true, true);

        }
        protected internal void XrBatchesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Batch", this.DisplayName, true, true);

        }
    }
}
