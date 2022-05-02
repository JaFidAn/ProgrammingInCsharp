using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonSeventeenProgramming
{
    internal class Program
    {
        delegate bool DelegateByFilter(int element, int comparingNumber);
        static void Main(string[] args)
        {

            
            List<int> list = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
            };

            var filtredList = list.Where(item => item > 10);

            //var newList = GetElementMoreTen(list, 11);
            //Console.WriteLine(GetElementAsString(newList));

            //User user = new User
            //{
            //    Name = "Rasim",
            //    Email = "r.alagezov@gmail.com"
            //};
            //Console.WriteLine(user);

            

            DelegateByFilter delegateByFilter = new DelegateByFilter(FiltredMyList);
            var newList = GetElementsFiltered(list, 3, delegateByFilter);

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            var newList1 = GetElementsFiltered(list, 10, delegate (int item, int comparingNumber)
            {
                return item < comparingNumber;
            });

        }

        static bool FiltredMyList(int element, int comparingNumber)
        {
            if (element % comparingNumber == 0)
            {
                return true;
            }
            return false;
        }

        public static List<int> GetElementMoreTen(List<int> list, int comparingNumber)
        {
            List<int> subList = new List<int>();
            foreach (int item in list)
            {
                if (item >= comparingNumber)
                {
                    subList.Add(item);
                }
            }
            return subList;
        }

        static string GetElementAsString(List<int> list)
        {
            var str = "";
            foreach (var item in list)
            {
                str += item + ",";
            }
            str = str.TrimEnd(',');
            return str;
        }

        static List<int> GetElementsFiltered(List<int> list, int comparingNumber, DelegateByFilter delegateByFilter)
        {
            List<int> subList = new List<int>();
            foreach (var item in list)
            {
                if (delegateByFilter(item, comparingNumber))
                {
                    subList.Add(item);
                }
            }
            return subList;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return Name + " : " + Email;
        }
    }
}
