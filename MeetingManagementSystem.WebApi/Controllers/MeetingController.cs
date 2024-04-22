using Microsoft.AspNetCore.Mvc;
using System;
using MeetingManagementSystem.DataAccess.Models;
using MeetingManagementSystem.Business;
using static MeetingManagementSystem.Business.MeetingService;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeetingsController : ControllerBase
    {
        private readonly IMeetingService _meetingService;

        public MeetingsController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }

        [HttpGet]
        public IActionResult GetAllMeetings()
        {
            var meetings = _meetingService.GetAllMeetings();
            return Ok(meetings);
        }

        [HttpGet("{id}")]
        public IActionResult GetMeetingById(int id)
        {
            var meeting = _meetingService.GetMeetingById(id);
            if (meeting == null)
            {
                return NotFound();
            }
            return Ok(meeting);
        }

        [HttpPost]
        public IActionResult GetMeetings()
        {
            var meetings = GetMeetings(); 
            return Ok(meetings);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMeeting(int id, Meeting meeting)
        {
            if (id != meeting.Id)
            {
                return BadRequest();
            }

            try
            {
                _meetingService.UpdateMeeting(meeting);
            }
            catch (Exception)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMeeting(int id)
        {

            _meetingService.DeleteMeeting(id);
            return NoContent();
        }
    }


}

