using Microsoft.AspNetCore.Mvc;

namespace Creative_webapp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}