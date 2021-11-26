using System;


namespace Delegates1
{
    public delegate void DoSmthWithMessage(string message);

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            DoSmthWithMessage doSmthWithMessage = PrintMessage;

            animal.Move(20, doSmthWithMessage);

            Console.ReadKey();
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}