using MeetingManagementSystem.DataAccess.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeetingManagementSystem.Web.Models
{
    public class MeetingViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Organizer { get; set; }
        public Room MeetingRoom { get; set; }
       /* public int RoomId
        {
            get { return MeetingRoom.Id; }
            set { MeetingRoom.Id = value; }
        }
        public string RoomName
        {
            get { return MeetingRoom.Name; }
            set { MeetingRoom.Name = value; }
        }*/


    }
}
