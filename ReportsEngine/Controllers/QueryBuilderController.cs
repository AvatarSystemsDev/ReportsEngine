using DevExpress.Web.Mvc.Controllers;
using System.Web.Mvc;

namespace ReportsEngine.Controllers
{
    public class QueryBuilderController : QueryBuilderApiControllerBase
    {
        // GET: QueryBuilder
        public ActionResult Index()
        {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }
    }
}