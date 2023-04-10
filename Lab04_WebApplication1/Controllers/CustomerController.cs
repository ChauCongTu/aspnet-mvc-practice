using Lab04_WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04_WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/CustomerDetail
        // Trả về thông tin 1 khách hàng
        public ActionResult CustomerDetail()
        {
            Customer customer = new Customer()
            {
                CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "Tp.HCM",
                Email = "dung.ta@gmail.com",
                Phone = "0988.611.889",
                Balance = 15200000
            };
            return View(customer);
        }
        public ActionResult CustomerList()
        {
            List<Customer> customerList = new List<Customer>()
            {
                new Customer(){
                    CustomerId = "KH001",
                    FullName = "Trịnh Văn Chung",
                    Address = "Tp.HCM",
                    Email = "dung.ta@gmail.com",
                    Phone = "0988.611.889",
                    Balance = 15200000
                },
                new Customer(){
                    CustomerId = "KH002",
                    FullName = "Đỗ Thị Cúc",
                    Address = "Hà Nội",
                    Email = "cucdt@gmail.com",
                    Phone = "0988.767.444",
                    Balance = 22000000
                },
                new Customer(){
                    CustomerId = "KH003",
                    FullName = "Nguyễn Tuấn Thắng",
                    Address = "Nam Định",
                    Email = "thang.nt@gmail.com",
                    Phone = "0988.656.542",
                    Balance = 12000000
                },
                new Customer(){
                    CustomerId = "KH004",
                    FullName = "Lê Ngọc Hải",
                    Address = "Hà Nội",
                    Email = "hailn@gmail.com",
                    Phone = "0996.555.267",
                    Balance = 6200000
                },
            };
            ViewBag.listcustomer = customerList;
            return View();
        }
    }
}