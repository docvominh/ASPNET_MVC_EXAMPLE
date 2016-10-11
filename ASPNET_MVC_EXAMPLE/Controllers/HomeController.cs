using ASPNET_MVC_EXAMPLE.Custom;
using MONGO_CONNECT.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_EXAMPLE.Controllers
{
    public class HomeController : Controller
    {
        [Test]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 10)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page." + DateTime.Now.ToString();

            return View();
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}