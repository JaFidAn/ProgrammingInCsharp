using System;

namespace ThirdLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ToDo1
            //Console.WriteLine("Please enter first number");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter second number");
            //int b = int.Parse(Console.ReadLine());

            //if(a%2==0 && b % 2 == 0)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            #endregion


            #region ToDo2
            //Console.WriteLine("Please enter first word");
            //string a = Console.ReadLine();
            //Console.WriteLine("Please enter second word");
            //string b = Console.ReadLine();
            //if (a.Contains(b))
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //    Console.WriteLine(false);
            #endregion


            #region ToDo3
            Console.WriteLine("Please enter first number");
            int a = int.Parse(Console.ReadLine());
            double x = a;
            Console.WriteLine("Please enter second number");
            int b = int.Parse(Console.ReadLine());
            double y = b;
            var devideNumber = x / y;
            Console.WriteLine(devideNumber);
            #endregion

        }
    }
}
