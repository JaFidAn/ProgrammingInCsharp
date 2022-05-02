using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEightteenProgramming
{
    public static class MyExtensions
    {
        public static void PrintUserDetails(this User user)
        {
            Console.WriteLine($"Name is {user.Name} and Date of Birth is {user.DateOfBirth}");
        }

        public static List<User> GetAllUsersGreaterThan20Years(this List<User> users)
        {
            return users.Where(x => x.DateOfBirth.Year > 2000).ToList();
        }
    }
}
