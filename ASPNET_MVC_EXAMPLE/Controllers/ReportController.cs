using CrystalDecisions.CrystalReports.Engine;
using MONGO_CONNECT.Dto;
using MONGO_CONNECT.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace ASPNET_MVC_EXAMPLE.Controllers
{
    public class ReportController : Controller
    {
        public ActionResult ReportManager()
        {
            NttDataEmployeeManager ndem = new NttDataEmployeeManager();

            ICollection<NttEmployeeDTO> list = ndem.GetNTTEmployeeList();

            return View(list);
        }

        // GET: Report
        public ActionResult GetListReport()
        {
            NttDataEmployeeManager ndem = new NttDataEmployeeManager();
            ICollection<NttEmployeeDTO> list = ndem.GetNTTEmployeeList();

            foreach (NttEmployeeDTO obj in list)
            {
                obj.Age = (byte)(DateTime.Now.Year - obj.DayOfBirth.Year);
            }

            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/Report/EmployeeReport.rpt")));
            rd.SetDataSource(list);

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();

            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);

            return File(stream, "application/pdf", "ListEmployee.pdf");
        }
    }
}