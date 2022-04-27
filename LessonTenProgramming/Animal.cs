using System;

namespace LessonTenProgramming
{


    public class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine($"Animal {Name} is moving");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }
}
