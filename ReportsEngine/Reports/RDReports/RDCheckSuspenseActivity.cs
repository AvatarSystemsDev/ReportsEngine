﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.RDReports
{
    public partial class RDCheckSuspenseActivity : ReportWithDescriptionParameters
    {
        public RDCheckSuspenseActivity()
        {
            InitializeComponent();
            xrOwnersSelected.BeforePrint += XrOwnersSelected_BeforePrint;
            EnableDescriptionParameters(this.FilterString, ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString());
            this.DataSourceDemanded += EnableDescriptionParametersOnDataSourceDemanded;
            this.DataSourceDemanded += (sender, args) => ReportsEngine.Reports.CommonReportsFunctions.XSelected_PrintOnPageLabelFunction.RewireDataSourceWithDescriptionParameters(ref this.Dynamic, ref this.federationDataSource1, this.DataMember.ToString(), this.Parameters);
        }
    }
}
