using MeetingManagementSystem.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.Business
{
    public interface IMeetingService
    {
        public List<Meeting> GetAllMeetings();



        public Meeting GetMeetingById(int id);



        public void CreateMeeting(Meeting meeting);

        public void UpdateMeeting(Meeting updatedMeeting);


        public void DeleteMeeting(int id);



    }

}
