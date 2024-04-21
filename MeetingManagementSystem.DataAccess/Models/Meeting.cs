using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.DataAccess.Models
{
    internal class Meeting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Organizer { get; set; }

        [ForeignKey("User")]
        public User ParticipantUsersId { get; set; }
    }
}
