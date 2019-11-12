using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cf.Models;

namespace cf.Controllers
{
    public class HomeController : Controller
    {
        Class1 db = new Class1();
        // GET: Default
        public ActionResult Index()
        {
            //var e = db.Employeestable.ToList();
            return View(db.Employeestable.ToList());
        }
        public ActionResult Index2()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index2(int id)
        {
            TempData["data"] = id;
            return RedirectToAction("Display");
        }
        public ActionResult Display()
        {
            int id =Convert.ToInt32( TempData["data"]);
            List<Employee> searchedId = db.Employeestable.Where(x => x.DepartmentId == id).ToList();
            return View (searchedId);
        }
        //        // GET: Home
        //        List<Employee> emp = new List<Employee>();
        //        Class1 employee = new Class1();
        //        public ActionResult Index()
        //        {
        //            //employee.insertdepartments();
        //            //employee.insertemployees();
        //            return View();
        //        }
        //        [HttpPost]
        //        public ActionResult Index(FormCollection form)
        //        {

        //            int id = int.Parse(form[0]);
        //            TempData["id"] = id;
        //            return RedirectToAction("Display", "Home");

        //        }
        //        public ActionResult Display()
        //        {

        //            int id = Convert.ToInt32(TempData["id"]);
        //            emp = employe.Where(x => x.DepartmentId == id).ToList();
        //            ViewBag.department = emp.ElementAt(0).Department.Name;
        //            return View(emp);

        //        }

        //        public ActionResult About()
        //        {
        //            ViewBag.Message = "Your application description page.";

        //            return View();
        //        }

        //        public ActionResult Contact()
        //        {
        //            ViewBag.Message = "Your contact page.";

        //            return View();
        //        }
        //    }
        //}
    }
}