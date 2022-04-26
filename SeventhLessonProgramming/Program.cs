using System;
using System.Collections.Generic;
using System.Linq;

namespace SeventhLessonProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> candles = new List<int> { 1, 2, 5, 5 };

           
            Console.WriteLine(candles.Count(x => x == candles.Max()));
           
            //Console.WriteLine(arr.Sum()-arr.Max() + " "+ (arr.Sum()-arr.Min()));
            
        }
    }
}
