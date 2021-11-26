using System;


namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.Moving += Animal_Moving;

            animal.Move(20);

            Console.ReadKey();
        }

        private static void Animal_Moving(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}