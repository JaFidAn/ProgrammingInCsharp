using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace LessonNineteenProgramming
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            PrintAsync();   // вызов асинхронного метода
            Console.WriteLine("Некоторые действия в методе Main");
            //Thread threadForMetod1Runner = new Thread(Metod1);
            //threadForMetod1Runner.Start();
            //Metod2();

            //MyClass myClass = new MyClass("Muhendis");
            //myClass.DoIt();
            //myClass.DoIt2();
            //myClass.DoItAgain();

            //var currentThread = Thread.CurrentThread;
            //Console.WriteLine($"Name : {currentThread.Name}");
            //var dateTime = DateTime.Now;

            //Console.WriteLine("az culture:" + dateTime);

            //currentThread.Name = "Main Thread";
            //currentThread.CurrentCulture = new CultureInfo("en");
            //currentThread.CurrentUICulture = new CultureInfo("en");
            //Console.WriteLine("en culture:" + dateTime);
            void Print()
            {
                //Thread.Sleep(1000);     // имитация продолжительной работы
                Console.WriteLine("Hello METANIT.COM");
            }

            async Task PrintAsync()
            {
                Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
                await Task.Run(() => Print());                // выполняется асинхронно
                Console.WriteLine("Конец метода PrintAsync");
            }
        }

        public static void Metod1()
        {
            
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Metod 1 - {i}");
                Thread.Sleep(10);
            }
        }

        public static void Metod2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Metod 2 - {i}");
                Thread.Sleep(10);
            }
        }

        
    }
   
}
