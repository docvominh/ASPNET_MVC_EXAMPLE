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
            EmployeeManager ndem = new EmployeeManager();

            ICollection<EmployeeDTO> list = ndem.GetEmployeeList();

            model.listModel = list;
            model.insertModel = new EmployeeDTO();

            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(EmployeeDTO emp)
        {
            if (!ModelState.IsValid)
            {
                return Json("Validate fail !", JsonRequestBehavior.AllowGet);
            }
            EmployeeManager ndem = new EmployeeManager();
            bool result = ndem.InsertEmployee(emp);

            if (result)
            {
                //return RedirectToAction("ReportManager", "Report");
                return Redirect("Index");
            }

            return Json("FAIL", JsonRequestBehavior.AllowGet);
        }
    }
}