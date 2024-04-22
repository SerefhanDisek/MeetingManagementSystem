using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using MeetingManagementSystem.Web.Models;
using MeetingManagementSystem.Web.Services;
using Refit;
using MeetingManagementSystem.DataAccess.Models;

namespace MeetingManagementSystem.Web.Controllers
{
    public class MeetingsController : Controller
    {
        private readonly IMeetingApi _meetingApi;

        public MeetingsController(IMeetingApi meetingApi)
        {
            _meetingApi = meetingApi;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: /Meetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Meetings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MeetingViewModel meetingViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // API'ye istek gönder
                    Meeting meeting = new Meeting();
                    meeting.Id = meetingViewModel.Id;
                    meeting.Description = meetingViewModel.Description;
                    meeting.StartTime = meetingViewModel.StartTime;
                    meeting.EndTime = meetingViewModel.EndTime;
                    meeting.Organizer = meetingViewModel.Organizer;
                    meeting.Title = meetingViewModel.Title;
                    await _meetingApi.CreateMeeting(meeting);
                    // Başarılı olursa yönlendir
                    return RedirectToAction("Index", "Home");
                }
                catch (ApiException ex)
                {
                    // Hata durumunda ModelState'a hata ekleyin
                    ModelState.AddModelError(string.Empty, $"Failed to create meeting: {ex.Message}");
                    return View(meetingViewModel);
                }
            }
            // Geçersiz model durumunda aynı görünüme geri dönün
            return View(meetingViewModel);
        }
    }
}

