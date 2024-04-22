using MeetingManagementSystem.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Business.Services
{
    public class Commands
    {
        private readonly MeetingManagementDbContext _dbContext;

        public Commands(MeetingManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Meeting>> GetAllMeetingsAsync()
        {
            return await _dbContext.Meetings.ToListAsync();
        }

        public async Task<Meeting> GetMeetingByIdAsync(int id)
        {
            return await _dbContext.Meetings.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task CreateMeetingAsync(Meeting meeting)
        {
            if (string.IsNullOrEmpty(meeting.Title) || meeting.StartTime >= meeting.EndTime)
            {
                throw new InvalidOperationException("Geçersiz toplantı bilgileri.");
            }


            _dbContext.Meetings.Add(meeting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateMeetingAsync(Meeting meeting)
        {
            

            _dbContext.Meetings.Update(meeting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteMeetingAsync(int id)
        {
            var meeting = await _dbContext.Meetings.FirstOrDefaultAsync(m => m.Id == id);
            if (meeting != null)
            {
                _dbContext.Meetings.Remove(meeting);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}



