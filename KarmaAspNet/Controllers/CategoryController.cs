using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
