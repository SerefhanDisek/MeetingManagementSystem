using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.DataAccess.Models
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Organizer { get; set; }

        [ForeignKey("Room")]
        public Room RoomId { get; set; }

        [ForeignKey("User")]
        public User ParticipantUsersId { get; set; }
    }
}
