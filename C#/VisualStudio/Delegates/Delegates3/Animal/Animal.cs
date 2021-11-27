using System;
using System.Threading;

namespace Delegates1
{
    class Animal
    {
        private string state = string.Empty;

        public void Move(int distance, Func<string, string> func)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);
                state = func($"Animal moving... Current distance: {i}");
                Console.WriteLine("state == " + state);
            }
        }
    }
}