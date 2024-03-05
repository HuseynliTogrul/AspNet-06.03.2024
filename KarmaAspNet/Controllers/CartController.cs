using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
