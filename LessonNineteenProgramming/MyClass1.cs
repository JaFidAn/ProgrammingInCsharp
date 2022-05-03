using System;

namespace LessonNineteenProgramming
{
    public partial class MyClass
    {
        public MyClass(string profession)
        {
            Profession = profession;
        }
        public void DoIt()
        {
            Console.WriteLine("Hello");
        }

        public partial void DoItAgain();
    }
}
