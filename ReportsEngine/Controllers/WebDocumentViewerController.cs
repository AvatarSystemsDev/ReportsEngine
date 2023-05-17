using DevExpress.Web.Mvc.Controllers;
using System.Web.Mvc;
using System.Web.Http.Cors;

namespace ReportsEngine.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WebDocumentViewerController : WebDocumentViewerApiControllerBase
    {
        // GET: WebDocumentViewer
        public ActionResult Index()
        {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }
    }
}