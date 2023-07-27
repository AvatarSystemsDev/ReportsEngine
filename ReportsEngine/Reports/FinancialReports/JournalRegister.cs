using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.FinancialReports
{
    public partial class JournalRegister : DevExpress.XtraReports.UI.XtraReport
    {
        public JournalRegister()
        {
            InitializeComponent();
            JournalRegister_BeforePrint(null,null);
        }
        private void JournalRegister_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Get the value of the 'plngSortBy' parameter
            int sortByValue = Convert.ToInt32(Parameters["plngSortBy"].Value);

            // Determine the grouping field based on the parameter value and set the grouping
            string sortingFieldName;
            string labelText;

            switch (sortByValue)
            {
                case 1:
                    GroupHeader.GroupFields.Clear();
                    GroupHeader.GroupFields.Add(new GroupField("Source"));
                    sortingFieldName = "Source";
                    labelText = "Source:";
                    break;
                case 2:
                    GroupHeader.GroupFields.Clear();
                    GroupHeader.GroupFields.Add(new GroupField("DocumentVoucher"));
                    sortingFieldName = "DocumentVoucher";
                    labelText = "Document Voucher:";
                    break;
                case 3:
                    GroupHeader.GroupFields.Clear();
                    GroupHeader.GroupFields.Add(new GroupField("PostDate"));
                    sortingFieldName = "PostDate";
                    labelText = "Post Date:";
                    break;
                case 4:
                    GroupHeader.GroupFields.Clear();
                    GroupHeader.GroupFields.Add(new GroupField("Source"));
                    sortingFieldName = "Source";
                    labelText = "Source:";
                    break;
                case 5:
                    GroupHeader.GroupFields.Clear();
                    GroupHeader.GroupFields.Add(new GroupField("Vendor"));
                    sortingFieldName = "Vendor";
                    labelText = "Vendor:";
                    break;
                case 6:
                    GroupHeader.GroupFields.Clear();
                    GroupHeader.GroupFields.Add(new GroupField("Well"));
                    sortingFieldName = "Well";
                    labelText = "Well:";
                    break;
                case 7:
                    GroupHeader.GroupFields.Clear();
                    GroupHeader.GroupFields.Add(new GroupField("Owner"));
                    sortingFieldName = "Owner";
                    labelText = "Owner:";
                    break;
                default:
                    sortingFieldName = string.Empty;
                    labelText = "Unknown Sorting:";
                    // You can set a default grouping field here in case of an invalid value.
                    // For example, if 'plngSortBy' has a value outside the range 1 to 7.
                    break;
            }

            // Set the label text to the appropriate value
            xrGroupHeader1label.Text = labelText;
            xrGroupHeader1label.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        }

    }
}
