using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_Ex.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrimeNumbers()
        {
            return View();
        }
        public ActionResult Factorials()
        {
            return View();
        }
        public ActionResult MultiplicationTable()
        {
            return View();
        }
    }
}