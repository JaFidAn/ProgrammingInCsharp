using System;
using System.IO;

namespace LessonFourteeenProgramming
{
    internal class Program
    {
        const string LogFilePath = "D:\\C#\\LogToFile\\Logs.txt";
        static void Main(string[] args)
        { 
            Console.WriteLine("Please enter a number");
            int number=0;
            try
            {
                number = int.Parse(Console.ReadLine());
               
            }
            catch (DivideByZeroException ex)
            {
                File.AppendAllText(LogFilePath, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "\n" + ex.ToString() + "\n\n");
            }
            catch (Exception ex)
            {
            
                File.AppendAllText(LogFilePath, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "\n" + ex.ToString() + ex.Message+"\n\n");
                throw new OperationRestictedException("This is not allowed", ex);
            }
            finally
            {
                Console.WriteLine("This block will always run");
            }
            Console.WriteLine(number);
            
        }
    }
}
