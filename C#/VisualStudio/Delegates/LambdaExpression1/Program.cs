using System;

namespace LambdaExpression
{
    delegate int Operation(int x, int y);

    class Program
    {
        public static int Operation1(int x, int y) => x + y;

        static void Main(string[] args)
        {
            Console.WriteLine("Program.Operation1(2, 6) == " + Program.Operation1(2, 6));

            Operation operation2 = delegate(int x, int y)
            {
                return x + y;
            };

            Console.WriteLine("operation2(3, 4) == " + operation2(3, 4));

            Operation operation3 = (x, y) => x + y;

            Console.WriteLine("operation3(5, 2) == " + operation3(5, 2));

            Operation operation4 = Program.Operation1;

            Console.WriteLine("operation4(8, 4) == " + operation4(8, 4));

            Console.ReadKey();
        }
    }
}
