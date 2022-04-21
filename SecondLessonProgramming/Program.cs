using System;

namespace SecondLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //string name1 = Console.ReadLine();
            //string name2 = Console.ReadLine();
            //string name3 = Console.ReadLine();
            //Console.WriteLine(name1+" "+name2+" "+name3);

            //2
            //Console.WriteLine("Please eneter your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Please enter your Surname");
            //string surname = Console.ReadLine();
            //Console.WriteLine(name + " " + surname);

            
            Console.WriteLine("Please enter radius of circle");
            double circleRadius = double.Parse(Console.ReadLine());
            double perimetr = 2 * 3.14 * circleRadius;
            Console.WriteLine("Perimetr of Circle :" + perimetr);
        }
    }
}
