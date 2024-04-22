using MeetingManagementSystem.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.Business
{
    public interface IUserService
    {
        public Task RegisterUserAsync(User user);
    }
}
