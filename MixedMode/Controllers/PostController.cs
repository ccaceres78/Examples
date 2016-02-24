using Piranha.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MixedMode.Controllers
{
    public class PostController : SinglePostController
    {
        // GET: Page
        public ActionResult Index()
        {
			var model = GetModel();

            return View(model.GetView(), model);
        }
    }
}