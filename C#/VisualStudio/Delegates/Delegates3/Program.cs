using System;


namespace Delegates3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.Move(3);

            animal.setFunc(PrintMessage);
            animal.Move(3);

            Console.ReadKey();
        }

        static string PrintMessage(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}