using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class BlogDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
