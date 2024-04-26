using System.Diagnostics;
using Mediplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mediplus.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }
        public IActionResult mediplus()
        {
            return View();
        }
        public IActionResult bookappointment()
        {
            return View();
        }
        public IActionResult datachart()
        {
            return View();
        }
        public IActionResult doctorinfo()
        {
            return View();
        }
        public IActionResult hospital()
        {
            return View();
        }
        public IActionResult aboutus()
        {
            return View();
        }
    }
}
