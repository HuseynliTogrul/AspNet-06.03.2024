using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
