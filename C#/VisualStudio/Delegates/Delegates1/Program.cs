using System;


namespace Delegates1
{
    public delegate void DoSmthWithMessage(string message);

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.Move(3);

            animal.setDoSmthWithMessage(PrintMessage);
            animal.Move(3);

            Console.ReadKey();
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}