using Microsoft.AspNetCore.Mvc;

namespace SocialMediaDashboard.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
