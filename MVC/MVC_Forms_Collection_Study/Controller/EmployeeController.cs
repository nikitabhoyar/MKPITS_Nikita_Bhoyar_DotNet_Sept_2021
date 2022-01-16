using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Form_Collection_Study.Models;

namespace MVC_Form_Collection_Study.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDBEntities db;
        // GET: Employee
        public ActionResult Index()
        {
            db = new EmployeeDBEntities();
            return View(db.Employees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(FormCollection formCollection)
        {
            if (ModelState.IsValid)
              
                {
                Employee employee = new Employee();
                employee.fname = formCollection["fname"];
                employee.fname = formCollection["lname"];
                employee.salary = Convert.ToInt32(formCollection["salary"]);
                db.Employees.Add(employee);
                db.SaveChanges();
                }
            return View();
        }
    }
}