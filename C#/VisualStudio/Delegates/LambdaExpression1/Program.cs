using System;

namespace LambdaExpression
{
    delegate int Operation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Operation operation1 = delegate(int x, int y)
            {
                return x + y;
            };

            Console.WriteLine("operation(3, 4) == " + operation1(3, 4));

            Operation operation2 = (x, y) => x + y;

            Console.WriteLine("operation2(3, 4) == " + operation1(5, 2));

            Console.ReadKey();
        }
    }
}
