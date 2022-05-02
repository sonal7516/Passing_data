using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Passing_data.Models;

namespace Passing_data.Controllers
{
    public class EmployeeController : Controller
    {
       
        // GET: Employee
        public ActionResult View_Bag()
        {
            string message = "This is a message";
            ViewBag.msg = message;

            ViewBag.employees = new List<string>()
            { "Anuj","Anmol","Deepti"};
            return View();
        }
        public ActionResult View_Data()
        {
            //ViewData 
            string message = "This is a List of employee";
            ViewData["msg"] = message;

            ViewData["msg"] = new List<string>()
            { "Amit", "Pooja","Anjali","Prishu" };
            return View();
        }
        public ActionResult View_Model()
        {
            Employee rec = new Employee
            {
                Id = 101,
                Name = "Bouchers",
                Job = "The basic stocks"
            };
            return View(rec);
        }

        public ActionResult Temp_Data()
        {
            TempData["temp"] = "I am temp data";
            return RedirectToAction("View_Bag");
        }
    }
}