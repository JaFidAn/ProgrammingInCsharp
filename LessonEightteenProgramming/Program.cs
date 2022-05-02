
using System;
using System.Collections.Generic;
using System.IO;

namespace LessonEightteenProgramming
{
    internal class Program
    {
        public delegate void DoSomething();

        public static void PrintHelloToScreen()
        {
            Console.WriteLine("Hello");
        }

        public static void WriteToFile()
        {
            File.AppendAllText("myFiles.txt", "Hello");
            Console.WriteLine("File writing is success!");
        }

        public static void WriteToScreen2()
        {
            
            Console.WriteLine("Second writing to screen");
        }

        static void Main(string[] args)
        {
            DoSomething myDelegate = new DoSomething(PrintHelloToScreen);
            myDelegate += WriteToFile;
            myDelegate += WriteToScreen2;
            myDelegate();

            User user = new User("Rasim", new DateTime(1984,05,28));
            user.PrintUserDetails();

            var users = InitializeUserList();

            
            var newList = users.GetAllUsersGreaterThan20Years();
            foreach (var item in newList)
            {
                Console.WriteLine(item.Name);
            }


            UserManager userManager = new UserManager();
            userManager.AddUser(new User("Cahid", DateTime.Parse("2024-08-18"), 1 ));
            userManager.GetUsersFiltred(u => u.Id == 1);


            //indexer
            userManager[2] = null;

        }

        public static List<User> InitializeUserList()
        {
            return new List<User>()
            {
                new User("Rasim", DateTime.Parse("1984-05-28")),
                new User("Cavid", DateTime.Parse("2014-07-05")),
                new User("Fidan", DateTime.Parse("2016-03-10")),
                new User("Rauf", DateTime.Parse("1982-10-26")),
                new User("Raul", DateTime.Parse("2007-09-06")),
            };
        }
    }

    public class User
    {
        public User(string name, DateTime dateOfBirth, int Id=0)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Id { get; set; }

       
    }
}
