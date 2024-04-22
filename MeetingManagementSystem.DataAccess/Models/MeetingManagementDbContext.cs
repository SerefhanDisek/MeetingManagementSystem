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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DESKTOP-N1QFE9C\\SQLEXPRESS;Database=MeetingManagementSystemDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}

