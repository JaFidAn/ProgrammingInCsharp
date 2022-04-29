using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThirteenProgramming
{
    public class UserManager
    {
        private User[] _users = new User[20];
        private int _currentPosition = 0;

        private readonly ISmsService _smsService;
        public UserManager(ISmsService smsService)
        {
            _smsService = smsService;
        }

        public void RegisterNewUser(User user)
        {
            _users[_currentPosition] = user;
            _currentPosition++;

            _smsService.SendSms("0552130686", $"New user with ID : {user.Id} has been registered");
           
        }
        public void EditUser(User user)
        {
            var oldUser = GetUserById(user.Id);
            oldUser.Name = user.Name;

            _smsService.SendSms("0552130686", $"User information with {user.Id} has been changed");
           
        }
        private User GetUserById(int id)
        {
            foreach (var user in _users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
