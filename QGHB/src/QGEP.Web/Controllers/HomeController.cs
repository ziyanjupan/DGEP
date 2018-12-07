using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace QGEP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : QGEPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}