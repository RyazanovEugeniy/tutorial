using System;
using System.Threading;

namespace Delegates3
{
    class Animal
    {
        private Func<string, string> func;

        private string state = string.Empty;

        public void setFunc(Func<string, string> func) => this.func = func;

        public void Move(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);

                if (func != null)
                    state = func($"Animal moving... Current distance: {i}");
                else
                    Console.WriteLine("func == null");

                Console.WriteLine("state == " + state);
            }
        }
    }
}