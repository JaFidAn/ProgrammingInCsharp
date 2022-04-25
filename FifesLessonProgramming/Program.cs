using System;

namespace FifesLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i > 70)
            //    {
            //        break;
            //    }
            //    if(i/10>=1 && i % 10 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}
            #endregion

            #region While
            //int i = 0;
            //while (i<=100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion

            #region while2
            //Console.WriteLine("Do you want to continue ? Yes/No");
            //while (true)
            //{
            //    string userAnswer = Console.ReadLine();
            //    bool isContinue = userAnswer.ToLower() == "yes";

            //    if (isContinue)
            //    {
            //        Console.WriteLine("Do you want to continue ? Yes/No");
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You choose to exit");
            //        break;
            //    }
            //}
            #endregion

            #region do While
            //do
            //{
            //    Console.WriteLine("Do you want to continue ? Yes/No");
            //    string userAnswer = Console.ReadLine();
            //    bool isContinue = userAnswer.ToLower() == "yes";
            //    if (isContinue)
            //    { 
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You choose to exit");
            //        break;
            //    }
            //}
            //while (true);

            #endregion

            #region foreach
            //int [] array1 = new int[] { 5, 10, 15, 20, 25, 30 };
            //int sumItems = 0;
            //foreach (var item in array1)
            //{
            //    sumItems += item;
            //}
            //Console.WriteLine(sumItems);

            #endregion

            #region findMagicNumber
            //Random random = new Random();

            //var magicNumber = random.Next(1,101);

            //int input = 0;

            //Console.WriteLine("Enter Number!");

            //while (input!=magicNumber)
            //{
            //    input = int.Parse(Console.ReadLine());

            //    if(input > magicNumber)
            //    {
            //        Console.WriteLine("Enter small number");
            //    }
            //   else
            //    {
            //        Console.WriteLine("Enter big number");    
            //    }    
            //}
            //Console.WriteLine($"Magic Number is : {input}");
            #endregion

            #region ToDo1
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region ToDo2
            //int sum = 0;
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region ToDo3
            //int[] numbers = new int[5];
            //Console.WriteLine("Enter first number");
            //numbers[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //numbers[1] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter third number");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter forth number");
            //numbers[3] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter fives number");
            //numbers[4] = int.Parse(Console.ReadLine());

            //int sum = 0;
            //foreach (int item in numbers)
            //{
            //    sum += item;
            //} 
            //Console.WriteLine($"Sum of numbers is : {sum}");
            //Console.WriteLine($"Average of numbers is : {sum/(numbers.Length)}");
            #endregion
        }
    }
}
