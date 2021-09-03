using System;

namespace Composite
{
    class Program 
    {
        static void Main(string[] args)
        {
            Branch tree = new Branch();
            Branch branch1 = new Branch();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Branch branch2 = new Branch();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Branch branch3 = new Branch();
            branch2.Add(branch3);
            branch3.Add(new Leaf());

            Console.WriteLine($"Composite: {tree.GetInfo()}\n");

            Console.ReadKey();
        }
    }
}