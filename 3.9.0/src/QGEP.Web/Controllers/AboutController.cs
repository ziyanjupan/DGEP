using System.Web.Mvc;

namespace QGEP.Web.Controllers
{
    public class AboutController : QGEPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}