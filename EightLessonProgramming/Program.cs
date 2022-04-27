using System;

namespace EightLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Rasim";
            user.Surname = "Alagezov";
            user.BirthDate = DateTime.Parse("28.05.1984");
            user.PrintUserToConsole();
        }
    }
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        string GetFullName()
        {
            return Name + " " + Surname;
        }
        int GetAge()
        {
            return DateTime.Now.Year -  BirthDate.Year;
        }
        public void PrintUserToConsole()
        {
            var userInfo = $"My name is {Name} {Surname} and I am {GetAge()} years old";
            Console.WriteLine(userInfo);
        }
    }
}
