using System.Web.Mvc;

namespace ReportsEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            return View();
        }

        public ActionResult Designer()
        {
            Models.ReportsModel model = new Models.ReportsModel();
            return View(model);
        }

        public ActionResult Viewer()
        {
            return View();
        }
    }
}