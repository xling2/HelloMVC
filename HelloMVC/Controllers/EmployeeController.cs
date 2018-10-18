using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var employees = new List<Employee>()
            {//strong typed model
                new Employee(){Id = 1, Firstname = "bob1", Lastname = "jim1", DOB = DateTime.Now},
                new Employee(){Id = 2, Firstname = "bob2", Lastname = "jim2", DOB = DateTime.Now},
                new Employee(){Id = 3, Firstname = "bob3", Lastname = "jim3", DOB = DateTime.Now},
                new Employee(){Id = 4, Firstname = "bob4", Lastname = "jim4", DOB = DateTime.Now},
                new Employee(){Id = 5, Firstname = "bob5", Lastname = "jim5", DOB = DateTime.Now}
            };
            return View("MyIndex",employees);
        }
        //[HttpGet]
        public ActionResult Detail()
        {
            ViewBag.name = "Jessie";
            return View("MyDetail");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
        

            return View();
        }
        /*
        public ActionResult Create(FormCollection Collection)
        {
            var Firstname = Collection["Firstname"];
            var Lastname = Collection["Lastname"];
            var DOB = Collection["DOB"];

            return View();
        }
        
         public ActionResult Create(string Firstname, string Lastname, string DOB,string fname, string FIRSTNAME)
        {
        

            return View();
        }*/

    }
}