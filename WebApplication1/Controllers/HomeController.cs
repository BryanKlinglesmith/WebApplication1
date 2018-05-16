using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Car car = new Car()
            {
                Brand = "Bmw",
                Color = "Black"
            };

            return View(car);
        }
    }
}