using Microsoft.EntityFrameworkCore;
using System;

namespace MeetingManagementSystem.DataAccess.Models
{
    public class MeetingManagementDbContext : DbContext
    {
        public MeetingManagementDbContext(DbContextOptions<MeetingManagementDbContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }


    }
}

