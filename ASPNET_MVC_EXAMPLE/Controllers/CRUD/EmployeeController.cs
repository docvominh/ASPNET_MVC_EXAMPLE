using ASPNET_MVC_EXAMPLE.Models;
using MONGO_CONNECT.Dto;
using MONGO_CONNECT.Utils;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ASPNET_MVC_EXAMPLE.Controllers.CRUD
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeModels model = new EmployeeModels();
            NttDataEmployeeManager ndem = new NttDataEmployeeManager();

            ICollection<NttEmployeeDTO> list = ndem.GetNTTEmployeeList();

            model.listModel = list;
            model.insertModel = new NttEmployeeDTO();

            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(NttEmployeeDTO emp)
        {
            if (!ModelState.IsValid)
            {
                return Json("Validate fail !", JsonRequestBehavior.AllowGet);
            }
            NttDataEmployeeManager ndem = new NttDataEmployeeManager();
            bool result = ndem.InsertNTTEmployee(emp);

            if (result)
            {
                //return RedirectToAction("ReportManager", "Report");
                return Redirect("Index");
            }

            return Json("FAIL", JsonRequestBehavior.AllowGet);
        }
    }
}