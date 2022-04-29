using System;

namespace LessonThirteenProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISmsService smsService = new SmsService1();
            UserManager userManager = new UserManager(smsService);

            userManager.RegisterNewUser(new User
            {
                Id = 1,
                Name = "Rasim"
            });


            //Animal animal = new Dog();
            //Console.WriteLine("Hello World!");
        }
    }
    public abstract class Animal
    {
        public void Go()
        {
            Console.WriteLine("Animal is moving");
        }

        public abstract void MakeSound();
        
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("hav-hav");
        }
    }
}
