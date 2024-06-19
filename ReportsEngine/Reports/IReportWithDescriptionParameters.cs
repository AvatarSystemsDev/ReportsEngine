using System;
using System.ComponentModel;

namespace ReportsEngine.Reports
{
    public interface IReportWithDescriptionParameters
    {
        bool EnableDescriptionParameters();
        void EnableDescriptionParametersOnDataSourceDemanded(object sender, EventArgs e);
        void XrOwnersSelected_BeforePrint(object sender, CancelEventArgs e);
        void XrVendorsSelected_BeforePrint(object sender, CancelEventArgs e);
        void XrEntitiesSelected_BeforePrint(object sender, CancelEventArgs e);
        void XrAccountsSelected_BeforePrint(object sender, CancelEventArgs e);
        void XrAccountingCentersSelected_BeforePrint(object sender, CancelEventArgs e);
        void XrPropertiesSelected_BeforePrint(object sender, CancelEventArgs e);
        void XrBatchesSelected_BeforePrint(object sender, CancelEventArgs e);
    }
}
