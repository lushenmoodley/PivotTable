using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = new List<object>
            {
                new { Name = "John", Age = 30, Gender = "Male" },
                new { Name = "Jane", Age = 25, Gender = "Female" },
                new { Name = "Doe", Age = 35, Gender = "Male" }
            };

            // Convert data to JSON and pass it to the view
            ViewBag.PivotData = JsonConvert.SerializeObject(data);

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

    }
}