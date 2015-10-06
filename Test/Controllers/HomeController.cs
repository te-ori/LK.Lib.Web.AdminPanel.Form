using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LK.Lib.Web.AdminPanel.Form.FormGenerator;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ContentResult TestEmpty()
        {
            var m = new Test.Models.Custom();

            return Content(m.GenerateForm());
        }public ContentResult TestFull()
        {
            var m = new Test.Models.Custom
            {
                BirthPlace = "Elazığ",
                BirthYear = 1985,
                Name = "Orhan",
                Surname = "Aygün"
            };

            return Content(m.GenerateForm());
        }
    }
}