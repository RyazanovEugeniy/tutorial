using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new TableFactory();

            var worker = factory.CreateWorker();
            var machine = factory.CreateMachine();

            Console.WriteLine(worker.GetInfo());
            Console.WriteLine(machine.GetInfo());
            Console.WriteLine(worker.CreateItem(machine));

            factory = new ChairFactory();

            worker = factory.CreateWorker();
            machine = factory.CreateMachine();

            Console.WriteLine(worker.GetInfo());
            Console.WriteLine(machine.GetInfo());
            Console.WriteLine(worker.CreateItem(machine));

            Console.ReadKey();
        }
    }
}