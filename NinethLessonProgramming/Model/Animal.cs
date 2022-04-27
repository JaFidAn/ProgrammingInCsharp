using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinethLessonProgramming.Model
{
    public class Animal
    {
        public string Name;
        public int Age;


        public Animal(string name)
        {
            Name = name;
        }
        public void Move()
        {
            Console.WriteLine($"{Name} is moving");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is Eating");
        }
    }
    public class Dog : Animal
    {
        public string Voice;
        public Dog(string name, string voice): base(name)
        {
            Voice = voice;
            Console.WriteLine(voice);
        }  
    }
}
