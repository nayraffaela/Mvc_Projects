using Microsoft.AspNetCore.Mvc;

namespace Games_Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
