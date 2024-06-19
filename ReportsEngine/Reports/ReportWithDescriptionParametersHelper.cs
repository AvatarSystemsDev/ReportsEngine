using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using System;
using System.ComponentModel;

namespace ReportsEngine.Reports
{
    public class ReportWithDescriptionParametersHelper : IReportWithDescriptionParameters
    {
        private XtraReport _report;
        private bool descriptionParametersAdded;
        private string _originalFilterString;
        public ReportWithDescriptionParametersHelper(XtraReport report)
        {
            _report = report;
            descriptionParametersAdded = false;
            _originalFilterString = _report.FilterString;
        }

        public bool EnableDescriptionParameters()
        {
            try
            {
                Parameter pbooSearchSortParameter = _report.Parameters["pbooSearchSortParameters"];
                if (pbooSearchSortParameter != null)
                {
                    bool pbooSearchSortParameterValue = bool.Parse(pbooSearchSortParameter.Value.ToString());
                    AddDescriptionParametersToReport();
                    haveFilterStringUseDescriptionParameters(pbooSearchSortParameterValue);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public void EnableDescriptionParametersOnDataSourceDemanded(object sender, EventArgs e)
        {
            Parameter pbooSearchSortParameter = _report.Parameters["pbooSearchSortParameters"];
            if (pbooSearchSortParameter != null)
            {
                bool pbooSearchSortParameterValue = bool.Parse(pbooSearchSortParameter.Value.ToString());
                AddDescriptionParametersToReport();
                haveFilterStringUseDescriptionParameters(pbooSearchSortParameterValue);
            }
        }

        private void AddDescriptionParametersToReport()
        {
            if (!descriptionParametersAdded)
            {
                descriptionParametersAdded = true;
                for (int index = 0; index < _report.Parameters.Count; index++)
                {
                    string parameterName = _report.Parameters[index].Name;
                    string descriptionParameterIdentity = ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.GetDescriptionParameterName(parameterName);
                    if (_report.Parameters[index].ValueSourceSettings is DynamicListLookUpSettings && !(descriptionParameterIdentity is null))
                    {
                        string parameterDescription = _report.Parameters[index].Description;
                        var parameterValue = _report.Parameters[index].Value;
                        Parameter newDescriptionParameter = new Parameter();
                        newDescriptionParameter.Value = parameterValue;
                        newDescriptionParameter.Description = parameterDescription;
                        newDescriptionParameter.Name = ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.GetDescriptionParameterName(parameterName);

                        DynamicListLookUpSettings descriptionParameterLookupSettings = new DynamicListLookUpSettings();
                        descriptionParameterLookupSettings.ValueMember = (_report.Parameters[index].ValueSourceSettings as DynamicListLookUpSettings).ValueMember;
                        descriptionParameterLookupSettings.DataMember = (_report.Parameters[index].ValueSourceSettings as DynamicListLookUpSettings).DataMember;
                        descriptionParameterLookupSettings.DataSource = (_report.Parameters[index].ValueSourceSettings as DynamicListLookUpSettings).DataSource;
                        descriptionParameterLookupSettings.FilterString = (_report.Parameters[index].ValueSourceSettings as DynamicListLookUpSettings).FilterString;
                        descriptionParameterLookupSettings.DisplayMember = "DescriptionFirstThenNumber";
                        descriptionParameterLookupSettings.SortMember = descriptionParameterLookupSettings.DisplayMember;
                        descriptionParameterLookupSettings.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                        newDescriptionParameter.ValueSourceSettings = descriptionParameterLookupSettings;

                        newDescriptionParameter.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] { new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Visible", "not ?pbooSearchSortParameters") });
                        _report.Parameters[index].ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] { new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Visible", "?pbooSearchSortParameters") });
                        try
                        {
                            ParameterLayoutItem DescriptionParameterLayoutItem = new ParameterLayoutItem(newDescriptionParameter, DevExpress.XtraReports.Parameters.Orientation.Horizontal);
                            int LayoutItemIndex = 0;
                            for (; LayoutItemIndex < _report.ParameterPanelLayoutItems.Count; LayoutItemIndex++)
                            {
                                ParameterLayoutItem layoutItem = (ParameterLayoutItem)_report.ParameterPanelLayoutItems[LayoutItemIndex];

                                string layoutItemString = layoutItem.Parameter.Name.ToString();
                                if (layoutItemString == parameterName)
                                {
                                    break;
                                }
                            }
                            _report.ParameterPanelLayoutItems.Insert(LayoutItemIndex, DescriptionParameterLayoutItem);
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
                        _report.Parameters.Insert(index, newDescriptionParameter);
                    }
                }
            }
        }
        public void haveFilterStringUseDescriptionParameters(bool pbooSearchSortParameters)
        {
            _report.FilterString = _originalFilterString; // Changes filter string to original filter string just in case Number is selected after Description was. 
            if (!pbooSearchSortParameters)
            {
                for (int index = 0; index < _report.Parameters.Count; index++)
                {

                    string parameterName = _report.Parameters[index].Name;
                    string s = _report.Parameters[index].Description.ToString();
                    if (parameterName.Contains("Description") && _report.Parameters[index].Description.ToString() == _report.Parameters[index - 1].Description.ToString()) // Assumes description parameter is the parameter right in front and no other parameter contains "Description" that is not a boolean variable
                    {
                        if (parameterName.Contains("pstrSelect"))
                        {
                            _report.FilterString = _report.FilterString.Replace("(?" + _report.Parameters[index - 1].Name + ")", "(?" + _report.Parameters[index].Name + ")");
                        }
                    }
                }
            }
        }


        public void XrOwnersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, _report.Parameters, "Owner", _report.DisplayName, true, true);
        }
        public void XrVendorsSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, _report.Parameters, "Vendor", _report.DisplayName, true, true);
        }
        public void XrEntitiesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, _report.Parameters, "Vendor", _report.DisplayName, true, true);
        }
        public void XrAccountsSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, _report.Parameters, "Account", _report.DisplayName, true, true);
        }
        public void XrAccountingCentersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, _report.Parameters, "AccountingCenter", _report.DisplayName, true, true);
        }

        public void XrPropertiesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, _report.Parameters, "Property", _report.DisplayName, true, true);

        }
        public void XrBatchesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, _report.Parameters, "Batch", _report.DisplayName, true, true);

        }
    }
}