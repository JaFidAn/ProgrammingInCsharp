using System;
using System.Linq;

namespace LessonTenProgramming
{
    internal class Program
    {
        static void Main()
        {
            #region ToDo1
            Circle circle = new Circle();
            Console.WriteLine(circle.AreaOfShape());
            Console.WriteLine(circle.PerimetrOfShape());

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.AreaOfShape());
            Console.WriteLine(rectangle.PerimetrOfShape());
            #endregion

        }




        static void Main1(string[] args)
        {
            Student student = new Student();
            student.SetIq(int.Parse(Console.ReadLine()));
            Console.WriteLine(student.GetIq());
            
            //Animal animal = new Dog("Alabash");
            //animal.Move();

            Animal [] animals = new Animal[3];
            animals[0] = new Animal("Cat");
            animals[1] = new Dog("Coban iti");
            animals[2] = new Doberman("Reks");
            foreach (Animal animal1 in animals)
            {
                animal1.Move();
            }
            
            
            ProcessAnimals(animals);
        }
        static void ProcessAnimals(Animal[] animals)
        {
            var dogCount = animals.Where(animal => animal is Dog).Count();
            Console.WriteLine(dogCount);

            foreach (var animal in animals)
            {
                
                if (animal is Dog)
                {
                    var dog = animal as Dog;
                    dog.Eat();
                }
                
            }
        }
    }


}
