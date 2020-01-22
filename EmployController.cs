using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using WebApplication6.model;


namespace WebApplication6.Controllers


{
    public class EmployController : Controller
    {
        private readonly Interface empr;
        //dependancy injected object
        public EmployController(Interface empr1)
        {
            empr = empr1;
        }
        //Interface empr = new Employr();
        public ActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employ emp1 =empr.GetEmploy(ID);
            //if (emp1 != null)
            //{
            //    return Content(emp1.Id + "\n" + emp1.Name + "\n" + emp1.Email + "\n" + emp1.dept);
            //}
            //return Content("emp does not exist");
            //ViewData["id"] = emp1.Id;
            //ViewData["name"] = emp1.Name;
            //ViewData["email"] = emp1.Email;
            //ViewData["dept"] = emp1.dept;
            ////ViewBag.id = emp1.Id;
            ////ViewBag.name = emp1.Name;

            ////ViewBag.email= emp1.Email;

            ////ViewBag.dept = emp1.dept;

            //ViewData["employ"] = emp1;
            //ViewBag.employ = emp1;
           


            return View(emp1);
        }
        public IActionResult Index()
        {
            List<Employ> elist = empr.DisplayDetails();
            return View(elist);
        }
        //public string ContactUs()
        //{
        //    return "hiiii";
        //}
        //public JsonResult AboutUs()
        //{
        //    return JsonResult("{(id:1;name:")
        //}
        public ViewResult AboutEmp()
        {
            Employ emp1 = empr.GetEmploy(2);
            //ViewBag.projectName = "Book
            EmployprojectviewModel ep = new EmployprojectviewModel();
            ep.employ = emp1;
            ep.projectName = "Book";

            return View(ep);

        }
        public IActionResult GetallEmploy()
        {
            List<Employ> elist = (empr.DisplayDetails()).Where(e=>e.dept=="csf").ToList();

            // return View("~/Views/Employ/Index.cshtml",elist);/*@*absolute path details*@*/
            return View("Index", elist);//relativepath

        }

    }
}
