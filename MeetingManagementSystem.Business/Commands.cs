using MeetingManagementSystem.DataAccess.Models;

namespace Business.Services
{
    public class MeetingService
    {
        private readonly MeetingManagementDbContext _dbContext;

        public MeetingService(MeetingManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Meeting> GetAllMeetings()
        {
            return _dbContext.Meetings.ToList();
        }

        public Meeting GetMeetingById(int id)
        {
            return _dbContext.Meetings.FirstOrDefault(m => m.Id == id);
        }

        public void CreateMeeting(Meeting meeting)
        {
            _dbContext.Meetings.Add(meeting);
            _dbContext.SaveChanges();
        }

        public void UpdateMeeting(Meeting meeting)
        {
            _dbContext.Meetings.Update(meeting);
            _dbContext.SaveChanges();
        }

        public void DeleteMeeting(int id)
        {
            var meeting = _dbContext.Meetings.FirstOrDefault(m => m.Id == id);
            if (meeting != null)
            {
                _dbContext.Meetings.Remove(meeting);
                _dbContext.SaveChanges();
            }
        }

        
    }
}

