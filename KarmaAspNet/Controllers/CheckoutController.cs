using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
