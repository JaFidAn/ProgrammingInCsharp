using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTenProgramming
{
    public class Doberman : Dog
    {
        public Doberman(string name) : base(name)
        {
            Name = name;
        }
        public override void Move()
        {
            Console.WriteLine($"Doberman {Name} is moving");
        }
    }
}
