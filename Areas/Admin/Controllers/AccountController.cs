using Microsoft.AspNetCore.Mvc;
using RoutingNavigation.Areas.Admin.Models;
namespace RoutingNavigation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdminModel objAml)
        {
            if (ModelState.IsValid)
            {
                TempData["UserName"] = objAml.UserName;
                return RedirectToAction("Dashboard", "Account");
            }
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
}
