using Refit;
using MeetingManagementSystem.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetingManagementSystem.Web.Services
{
    public interface IMeetingApi
    {
        [Get("/api/Meetings")]
        Task<List<Meeting>> GetAllMeetings();

        [Get("/api/Meetings/{id}")]
        Task<Meeting> GetMeetingById(int id);

        [Post("/api/Meetings")]
        Task CreateMeeting([Body] Meeting meeting);

        [Put("/api/Meetings/{id}")]
        Task UpdateMeeting(int id, [Body] Meeting meeting);

        [Delete("/api/Meetings/{id}")]
        Task DeleteMeeting(int id);
    }
}


