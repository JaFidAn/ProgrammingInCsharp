using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTenProgramming
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            Name = name;
        }
        public override void Move()
        {
            Console.WriteLine($"Dog {Name} is moving");
        }
    }
}
