using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
