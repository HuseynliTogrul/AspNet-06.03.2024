using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class ElementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
