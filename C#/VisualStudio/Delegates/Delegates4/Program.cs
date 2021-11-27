using System;


namespace Delegates4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.Move(3);

            animal.Moving += Animal_Moving;
            animal.Move(3);

            Console.ReadKey();
        }

        private static void Animal_Moving(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}