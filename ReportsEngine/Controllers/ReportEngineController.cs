using DevExpress.XtraReports.Web.ReportDesigner.Native;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ReportsEngine.Controllers
{
    public class ReportEngineController : Controller
    {
        // GET: ReportEngine
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RunReportEngine()
        {
            return View();
        }


    }
}