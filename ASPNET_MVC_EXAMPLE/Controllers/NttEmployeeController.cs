using MONGO_CONNECT.Dto;
using MONGO_CONNECT.Utils;
using System.Web.Mvc;

namespace ASPNET_MVC_EXAMPLE.Controllers
{
    public class NttEmployeeController : Controller
    {
        // GET: NttEmployee
        [HttpPost]
        public ActionResult Insert(NttEmployeeDTO emp)
        {
            NttDataEmployeeManager ndem = new NttDataEmployeeManager();
            bool result = ndem.InsertNTTEmployee(emp);

            if (result)
            {
                return RedirectToAction("ReportManager", "Report");
            }

            return Json("FAIL", JsonRequestBehavior.AllowGet);
        }
    }
}