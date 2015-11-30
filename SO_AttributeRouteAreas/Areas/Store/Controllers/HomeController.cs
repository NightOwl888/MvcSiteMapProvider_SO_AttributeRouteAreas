using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SO_AttributeRouteAreas.Areas.Store.Controllers
{
    [RouteArea("Store")]
    //[Route("{action=list}")]
    public class HomeController : Controller
    {
        // GET: Store/Home
        [Route("List/{page?}/{itemsPerPage?}")]
        public ActionResult List(int page = 1, int itemsPerPage = -1, string msg = "")
        {
            return View();
        }

        [Route("Search/{tags?}/{page?}")]
        public ActionResult Search(string tags = "", int page = 1)
        {
            return View();
        }
    }
}