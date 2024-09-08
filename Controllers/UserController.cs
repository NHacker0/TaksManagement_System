using Microsoft.AspNetCore.Mvc;
using TaksManagement_System.Data;

namespace TaksManagement_System.Controllers
{
    public class UserController : Controller
    {
        private readonly TaskManagementContext _context;

        public UserController(TaskManagementContext context)
        {
            _context = context;
        }

        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.SingleOrDefault(u => u.Username == model.Username);

                if (user != null && BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
                {
                    // Create a simple session
                    HttpContext.Session.SetString("Username", user.Username);
                    return RedirectToAction("Index", "Task");
                }

                ModelState.AddModelError("", "Invalid login attempt.");
            }

            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Username");
            return RedirectToAction("Login");
        }
    }
}
