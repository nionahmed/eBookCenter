using Microsoft.AspNetCore.Mvc;

namespace eBookCenter.web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminLogin()
        {
            return View();
        }

    }
}
