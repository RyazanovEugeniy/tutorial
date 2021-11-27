using System;


namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.Move(3);

            animal.setAction(PrintMessage);
            animal.Move(3);

            Console.ReadKey();
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}