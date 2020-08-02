using System;
using System.Collections.Generic;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();

            Animal animal1 = new Animal("cat", 9);
            list.Add(animal1);
            animal1 = new Animal("dog", 8);
            list.Add(animal1);
            animal1.Name = "elephant";
            list.Add(animal1);

            foreach(Animal animal in list)
                Console.WriteLine(animal.ToString());

            Console.WriteLine("Done!");
        }
    }
}
