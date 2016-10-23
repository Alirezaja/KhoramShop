using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhoramShop.Areas.FrontOffice.Controllers
{
    public class HomeController : Controller
    {
        // GET: FrontOffice/Home
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
    }
}