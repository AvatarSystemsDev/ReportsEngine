﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsEngine.Reports
{
    public class ReportsFactory
    {
        static ReportsFactory()
        {
            Reports.Add("APEditListcs", () => new APEditListcs());
            Reports.Add("AFEMasterList", () => new AFEMasterList());
            Reports.Add("ChartofAccountListing", () => new ChartofAccountListing());
            Reports.Add("DOIByOwnerAddress", () => new DOIByOwnerAddress());
        }
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>();
    }
}