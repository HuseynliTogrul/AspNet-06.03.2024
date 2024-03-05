using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
