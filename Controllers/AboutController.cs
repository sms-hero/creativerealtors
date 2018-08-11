using Microsoft.AspNetCore.Mvc;

namespace Creative_webapp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}