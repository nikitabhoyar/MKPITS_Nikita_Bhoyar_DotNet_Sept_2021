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
        public EmployeeDBEntities db = new EmployeeDBEntities();
        private readonly Employee emp;

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

        internal class emp
        {
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        //public ActionResult Create(FormCollection formCollection)
        //{
        // if (ModelState.IsValid)

        //        {
        //        Employee employee = new Employee();
        //        employee.fname = formCollection["fname"];
        //        employee.fname = formCollection["lname"];
        //        employee.salary = Convert.ToInt32(formCollection["salary"]);
        //        db.Employees.Add(employee);
        //        db.SaveChanges();
        //       }
        //    return View();

        //}

        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

            public ActionResult Delete (int? id)
        {
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost , ActionName("Delete"]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}