using Microsoft.AspNetCore.Mvc;

namespace MeetingManagementSystem.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
