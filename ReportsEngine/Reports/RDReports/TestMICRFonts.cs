using DevExpress.Drawing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportsEngine.Reports.RDReports
{
    public partial class TestMICRFonts : DevExpress.XtraReports.UI.XtraReport
    {
        public TestMICRFonts()
        {
            InitializeComponent();
            xrMICRAccountNumber.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrMICRTransitNumber.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
            xrCheckNumber.Font = new DXFont("MICRE13B", 12F, DXFontStyle.Regular, DXGraphicsUnit.Point);
        }

    }
}
