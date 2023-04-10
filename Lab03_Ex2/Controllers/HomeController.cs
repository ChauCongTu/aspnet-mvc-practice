using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_Ex2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormRegister()
        {
            ViewBag.listBusinessType = new List<string>()
            {
                "Đơn vị sự nghiệp nhà nước",
                "Đơn vị sự nghiệp tự chủ"
            };
            return View();
        }

        public ActionResult Register()
        {
            // lấy giá trị được các trường đẩy lên server khi submit
            TempData["recruitingAgencyName"] = Request["recruitingAgencyName"];
            TempData["businessType"] = Request["businessType"];
            TempData["numberOfEmployees"] = Request["numberOfEmployees"];
            TempData["address"] = Request["address"];
            TempData["contactPerson"] = Request["contactPerson"];
            TempData["phoneNumber"] = Request["phoneNumber"];
            TempData["faxNumber"] = Request["faxNumber"];
            TempData["email"] = Request["email"];
            TempData["websiteUrl"] = Request["websiteUrl"];
            TempData["username"] = Request["username"];
            TempData["password"] = Request["password"];
            TempData["receiveEmail"] = Request["receiveEmail"].ToString();
            return View();
        }
    }
}