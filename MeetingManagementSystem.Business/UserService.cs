using System;
using System.Threading.Tasks;
using MeetingManagementSystem.DataAccess;
using MeetingManagementSystem.DataAccess.Models;

namespace MeetingManagementSystem.Business.Services
{
    public class UserService
    {
        private readonly MeetingManagementDbContext _dbContext;

        public UserService(MeetingManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task RegisterUserAsync(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}

