using System;
using System.Collections.Generic;
using System.Linq;

using MeetingManagementSystem.DataAccess.Models;

namespace MeetingManagementSystem.Business
{
    public class MeetingService : IMeetingService
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
            if (meeting == null)
            {
                throw new ArgumentNullException(nameof(meeting));
            }

            _dbContext.Meetings.Add(meeting);
            _dbContext.SaveChanges();
        }

        public void UpdateMeeting(Meeting updatedMeeting)
        {
            if (updatedMeeting == null)
            {
                throw new ArgumentNullException(nameof(updatedMeeting));
            }

            var existingMeeting = _dbContext.Meetings.FirstOrDefault(m => m.Id == updatedMeeting.Id);
            if (existingMeeting == null)
            {
                throw new InvalidOperationException("Meeting not found");
            }

            existingMeeting.Title = updatedMeeting.Title;
            existingMeeting.Description = updatedMeeting.Description;
            existingMeeting.StartTime = updatedMeeting.StartTime;
            existingMeeting.EndTime = updatedMeeting.EndTime;
            existingMeeting.Organizer = updatedMeeting.Organizer;

            _dbContext.SaveChanges();
        }

        public void DeleteMeeting(int id)
        {
            var meeting = _dbContext.Meetings.FirstOrDefault(m => m.Id == id);
            if (meeting == null)
            {
                throw new InvalidOperationException("Meeting not found");
            }

            _dbContext.Meetings.Remove(meeting);
            _dbContext.SaveChanges();
        }



    }
}




