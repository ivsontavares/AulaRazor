using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

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
