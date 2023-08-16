using System.Web.Mvc;

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