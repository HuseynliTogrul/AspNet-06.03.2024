using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
