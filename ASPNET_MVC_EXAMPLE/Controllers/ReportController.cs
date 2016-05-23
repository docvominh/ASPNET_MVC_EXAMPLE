using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_EXAMPLE.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult ReportManager()
        {
            return View();
        }
    }
}