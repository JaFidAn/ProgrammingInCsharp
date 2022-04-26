using System;

namespace SixthLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintHelloWorld("Rasim", 38, 6);

            //var result = GetHelloWorldString("Cavid", 8);
            //Console.WriteLine(result.ToUpper());  

            //SumNumbers(1, 5, 9, 15);
            //SumNumbers(12, 25, 39, 158, -15);
            //SumNumbers(1, 2, 3);
            //SumNumbers(2, 3, 4);

            #region ToDo1 to ToDo3
            //    Console.WriteLine("Enter Rank of Array");
            //    int rankArray = int.Parse(Console.ReadLine());
            //    int[] array1 = new int[rankArray]; 
            //    Random random = new Random();
            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        array1[i] = random.Next(10, 100);
            //    }
            //    Array.Sort(array1);
            //    Console.WriteLine("Array sorted by ascending : ");
            //    foreach (var i in array1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("___________________");
            //    Array.Reverse(array1);
            //    Console.WriteLine("Array sorted by descending : ");
            //    foreach (var i in array1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine($"Third element of Array is : {array1[2]}");

            //    Console.WriteLine($"First 4 Max element of Array are : {array1[0]} - {array1[1]} - {array1[2]} - {array1[3]}");
            //
            #endregion
            #region ToDo6
            //SumOfNumbers(1,2,3,4);
            #endregion

        }

        #region Method PrintHelloWorld
        //static void PrintHelloWorld(string name, int age, int expierence = 0)
        //{
        //    var result = $"Hello World! {name}  your age is {age}";
        //    if (expierence > 0)
        //    {
        //        result += $"your expierence is {expierence} year";
        //    }
        //    Console.WriteLine(result);
        //}
        #endregion

        #region Method GetHelloWorldString
        //static string GetHelloWorldString(string name, int age)
        //{
        //    return $"Hello World! {name}  your age is {age}";
        //}
        #endregion


        #region Methods params
        //static int SumNumbers(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        sum += number;

        //    }
        //    Console.WriteLine(sum);
        //    return sum;
        //}
        #endregion

        #region ToDo6Method
        //static int SumOfNumbers(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        sum += number;
        //    }
        //    Console.WriteLine(sum);
        //    return sum;
        //}
        #endregion


    }

}
