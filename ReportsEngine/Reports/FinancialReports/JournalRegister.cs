using DevExpress.Data.Browsing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System;
using System.Linq;
using DevExpress.Data.NetCompatibility.Extensions;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class JournalRegister : DevExpress.XtraReports.UI.XtraReport
    {
        private string originalFilterString;
        public JournalRegister()
        {
            InitializeComponent();
            this.DataSourceDemanded += JournalRegister_BeforePrint;
            originalFilterString = this.FilterString;
            xrAccountsSelected.BeforePrint += xrAccountsSelected_BeforePrint;
            xrAccountingCentersSelected.BeforePrint += xrAccountingCentersSelected_BeforePrint;
            xrEntitiesSelected.BeforePrint += XrEntitiesSelected_BeforePrint;
            xrOwnersSelected.BeforePrint += XrOwnersSelected_BeforePrint;
            xrPropertiesSelected.BeforePrint += xrPropertiesSelected_BeforePrint;
            xrBatchesSelected.BeforePrint += xrBatchesSelected_BeforePrint;
            this.BeforePrint += JournalRegister_BeforePrint;
            AddDescriptionParametersToReport();
        }
        private void JournalRegister_BeforePrint(object sender, EventArgs e)
        {
            bool pbooSearchSortParameters = bool.Parse(Parameters["pbooSearchSortParameters"].Value.ToString());
            haveFilterStringUseDescriptionParameters(pbooSearchSortParameters);
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), Parameters, pbooSearchSortParameters);
        }

        private void AddDescriptionParametersToReport()
        {
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
                        for (;LayoutItemIndex < ParameterPanelLayoutItems.Count; LayoutItemIndex++)
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

                    if (newDescriptionParameter.Name.StartsWith("pstrSelect")) {
                        newDescriptionParameter.MultiValue = true;
                        newDescriptionParameter.SelectAllValues = true;
                    }
                    index++;
                    this.Parameters.Insert(index, newDescriptionParameter);
                }
            }
        }
        private void haveFilterStringUseDescriptionParameters(bool pbooSearchSortParameters)
        {
            this.FilterString = originalFilterString; // Changes filter string to original filter string just in case Number is selected after Description was. 
            if (!pbooSearchSortParameters)
            {
                // Change filter string parameters of the report for pstrSelect parameters
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
        private void XrOwnersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Owner", this.DisplayName, true, true);
        }

        private void XrEntitiesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Entity", this.DisplayName, true, true);
        }
        private void xrAccountsSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Account", this.DisplayName, true, true);
        }
        private void xrAccountingCentersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "AccountingCenter", this.DisplayName, true, true);
        }

        private void xrPropertiesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Property", this.DisplayName, true, true);

        }
        private void xrOwnersSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Owner", this.DisplayName, true, true);
        }
        private void xrBatchesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Batch", this.DisplayName, true, true);

        }
        private void xrEntitiesSelected_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.X_BeforePrint(ref sender, Parameters, "Entity", this.DisplayName, true, true);
        }
    }
}
