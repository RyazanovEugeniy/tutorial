using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent simple = new ConcreteComponent();

            Console.WriteLine("RESULT: " + simple.Operation());

            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("RESULT: " + decorator2.Operation());

            Console.ReadKey();
        }
    }
}