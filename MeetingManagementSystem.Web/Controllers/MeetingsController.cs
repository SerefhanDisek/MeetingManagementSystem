using Microsoft.AspNetCore.Mvc;

namespace MeetingManagementSystem.Web.Controllers
{
    public class MeetingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
