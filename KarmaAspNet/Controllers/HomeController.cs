using KarmaAspNet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KarmaAspNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }
    }
}