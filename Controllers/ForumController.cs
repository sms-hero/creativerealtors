using Microsoft.AspNetCore.Mvc;

namespace Creative_webapp.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}