using Microsoft.AspNetCore.Mvc;

namespace KarmaAspNet.Controllers
{
    public class TrackingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
