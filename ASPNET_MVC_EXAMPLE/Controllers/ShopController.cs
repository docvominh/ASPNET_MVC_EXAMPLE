using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MY_WEB.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        // GET: Shop
        public ActionResult HighTech()
        {
            return View();
        }

        public ActionResult Clothing()
        {
            return View();
        }

        public ActionResult Cosmetics()
        {
            return View();
        }
    }
}