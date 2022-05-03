using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonNineteenProgramming
{
    public partial class MyClass
    {
        public string Profession { get; set; }
        public void DoIt2()
        {
            Console.WriteLine($"My Profession is {Profession}");
        }

        public partial void DoItAgain()
        {
            Console.WriteLine("Salam");
        }

    }
}
