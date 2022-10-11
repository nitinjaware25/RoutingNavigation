using Microsoft.AspNetCore.Mvc;
using RoutingNavigation.Areas.User.Models;

namespace RoutingNavigation.Areas.User.Controllers
{

    [Area("User")]
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel objUserModel)
        {
            if (ModelState.IsValid)
            {
                TempData["UserName"] = objUserModel.UserName;
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
