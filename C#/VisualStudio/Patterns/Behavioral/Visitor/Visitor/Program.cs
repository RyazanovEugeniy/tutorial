using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>
            {
                new Cat(),
                new Dog(),
                new Cat(),
                new Cat()
            };

            var move = new Move();
            foreach (IAnimal animal in animals)
                animal.Accept(move);


            var speak = new Speak();
            foreach (IAnimal animal in animals)
                animal.Accept(speak);

            Console.ReadKey();
        }
    }
}