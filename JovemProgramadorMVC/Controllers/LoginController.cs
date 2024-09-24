using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
