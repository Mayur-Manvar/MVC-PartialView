using MVCPartialViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPartialViewDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeEntities employeeEntities = new EmployeeEntities();
            return View(employeeEntities.tblEmployee2.ToList());
        }
    }
}