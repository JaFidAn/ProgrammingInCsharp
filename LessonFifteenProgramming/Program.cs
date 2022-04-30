using System;
using System.Collections;
using System.Collections.Generic;

namespace LessonFifteenProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(16);
            myList.Add(17);
            myList.Add(18);

            int sum = 0;
            foreach (var item in myList)
            {
                sum += (int) item;
            }
            Console.WriteLine(sum);

            DataStore<double> data = new DataStore<double>();
            data.Data = 15.02f;
            data.Data = 58.25f;

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            Dictionary<string, int> cityPopulation = new Dictionary<string, int>();
            cityPopulation.Add("Baku", 3000000);
            cityPopulation.Add("Gence", 1000000);
            cityPopulation.Add("Sumqayit", 1500000);

            foreach (var item in cityPopulation)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            
            Console.WriteLine(list.Capacity);

            Dictionary<int, User> users = new Dictionary<int, User>();

            var user1 = new User
            {
                Name = "Rasim",
                Id = 1,
                DateOfBirth = DateTime.Parse("28.05.1984")
            };

            var user2 = new User
            {
                Name = "Cavid",
                Id = 2,
                DateOfBirth = DateTime.Parse("05.07.2014")
            };

            users.Add(user1.Id, user1);
            users.Add(user2.Id, user2);

            Console.WriteLine("Enter User Id");
            var userId = int.Parse(Console.ReadLine());

            if (users.ContainsKey(userId))
            {
                var foundUser = users[userId];
                Console.WriteLine(foundUser);
            }
            else
            {
                Console.WriteLine("Could not found User by given ID");
            }
            
        }
    }

    public class DataStore<T>
    {
        public T Data { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"Id is {Id}, Name is {Name}, Date of Birth is {DateOfBirth:dd.MM.yyyy}";
        }
    }
}
