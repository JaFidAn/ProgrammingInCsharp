using System;

namespace FirstLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            Console.WriteLine("Please enter First number");
            while (true)
            {
                try
                {
                    a = Convert.ToInt16(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("You can enter only a number");
                }
            }
            Console.WriteLine("Please eneter second number");
            int b;
            while (true)
            {
                try
                {
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("You can enter only a number");
                }
            }
            
            int sum = Sum(a, b);
            Console.WriteLine("Sum is :" + sum);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
