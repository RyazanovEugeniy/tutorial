using System;


namespace Delegates1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Func<string, string> func = PrintMessage;

            animal.Move(20, func);

            Console.ReadKey();
        }

        static string PrintMessage(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}