using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
                Console.WriteLine(element);

            Console.ReadKey();
        }
    }
}