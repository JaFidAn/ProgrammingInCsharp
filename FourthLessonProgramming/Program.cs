using System;

namespace FourthLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum
            //var studentType = (StudentType)int.Parse(Console.ReadLine());

            //if (studentType == StudentType.veryBadStudent)
            //{
            //    Console.WriteLine("This is very bad Student");
            //}
            //else if (studentType == StudentType.badStudent)
            //{
            //    Console.WriteLine("This is bad Student");
            //}
            //else if (studentType == StudentType.goodStudent)
            //{
            //    Console.WriteLine("This is good Student");
            //}
            //else if (studentType == StudentType.veryGoodStudent)
            //{
            //    Console.WriteLine("This is very good Student");
            //}
            //else if (studentType == StudentType.excelentStudent)
            //{
            //    Console.WriteLine("This is excelent Student");
            //}
            #endregion
            #region DateTime
            //DateTime date = DateTime.UtcNow;
            //Console.WriteLine((int)date.DayOfWeek);
            //Console.WriteLine(date.TimeOfDay);
            #endregion
            #region Arrays
            //int[] array1 = new int[3];
            //array1[0] = 5;
            //array1[1] = 6; 
            //array1[2] = 15;
            //int sum = 0;
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    sum +=array1[i];
            //}
            //Console.WriteLine(sum);

            //int[] array2 = new int[50];
            //Random random = new Random();
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    array2[i] = random.Next(0,100);
            //}

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    Console.WriteLine(array2[i]);
            //}
            #endregion

            #region ToDo1
            //DateTime myBirthday = DateTime.Parse("28.05.1984");
            //var weekDay = myBirthday.DayOfWeek;
            //Console.WriteLine(weekDay);
            #endregion

            #region ToDo2
            //DateTime today = DateTime.Today;    
            //DateTime dayOfBirthday = DateTime.Parse("28.05.1984");
            //TimeSpan diff = today - dayOfBirthday;
            //Console.WriteLine(diff);
            #endregion

            #region ToDo3
            //DateTime after40Days = DateTime.Now.AddDays(40);
            //Console.WriteLine(after40Days.DayOfWeek.ToString());
            #endregion

            #region ToDo4
            DateTime day = DateTime.Parse("17/09/2016");
            Console.WriteLine(day.ToString("dd.MM.yyyy"));

            #endregion
        }
    }
    public enum StudentType
    {
        veryBadStudent = 1,
        badStudent,
        goodStudent,
        veryGoodStudent,
        excelentStudent
    }
}
