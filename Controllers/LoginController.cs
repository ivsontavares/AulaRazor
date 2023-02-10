using Microsoft.AspNetCore.Mvc;

namespace RazorAulas.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
