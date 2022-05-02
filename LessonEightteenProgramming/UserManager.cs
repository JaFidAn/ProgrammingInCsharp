using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEightteenProgramming
{
    public class UserManager
    {
        private readonly List<User> _user = new List<User>();
        
        public void AddUser(User user)
        {
            _user.Add(user);
        }

        public void UpdateUser(User user, int id)
        {
            var oldUser = _user.FirstOrDefault(u=>u.Id == id);
            oldUser.Name = user.Name;
            oldUser.DateOfBirth = user.DateOfBirth;
        }
        public void DeleteUser(int id)
        {
            _user.RemoveAll(u=>u.Id == id);
        }
        public List<User> GetAll()
        {
            return _user;
        }
        public List<User> GetUsersFiltred(Func<User, bool> predicate)
        {
            return _user.Where(predicate).ToList();
        }


        #region Indexer

        //Indexer-in quruluşu
        public User this[int index]
        {
            get
            {
                return _user[index];
            }
            set
            {
                _user[index] = value;
            }
        }

        #endregion

    }
}
