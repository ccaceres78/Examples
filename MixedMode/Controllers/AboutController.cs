using System.Web.Mvc;

namespace MixedMode.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index() {
            return View();
        }

		public ActionResult SubPage() {
			return View();
		}
    }
}