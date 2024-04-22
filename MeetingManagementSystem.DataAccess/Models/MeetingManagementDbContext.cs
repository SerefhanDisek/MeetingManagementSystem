using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.DataAccess.Models
{
    internal class MeetingManagementDbContext : DbContext
    {
        public MeetingManagementDbContext(DbContextOptions<MeetingManagementDbContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
