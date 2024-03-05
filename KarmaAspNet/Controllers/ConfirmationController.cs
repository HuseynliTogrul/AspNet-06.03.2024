using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class ConfirmationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
