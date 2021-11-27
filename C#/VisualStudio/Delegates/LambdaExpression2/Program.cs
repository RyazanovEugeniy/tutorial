using System;

namespace LambdaExpression2
{
    class Program
    {
        static int Sum(int[] numbers, Func<int, bool> func)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
                if (func(numbers[i]))
                    result += numbers[i];

            return result;
        }

        static int SumTest(int[] numbers, Func<int, int, bool> func)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (func(numbers[i], 2))
                    result += numbers[i];

            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int x1 = Sum(numbers, n => n > 5);
            Console.WriteLine("x1 == " + x1);

            int x2 = Sum(numbers, n => n % 2 == 0);
            Console.WriteLine("x2 == " + x2);

            int x3 = SumTest(numbers, (x, y) => x > y);
            Console.WriteLine("x3 == " + x3);

            int x4 = SumTest(numbers, (x, y) => x % y == 0);
            Console.WriteLine("x4 == " + x4);
            Console.ReadKey();
        }
    }
}
