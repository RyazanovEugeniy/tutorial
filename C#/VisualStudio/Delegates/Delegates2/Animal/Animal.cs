using System;
using System.Threading;

namespace Delegates2
{
    class Animal
    {
        private Action<string> action;

        public void setAction(Action<string> action) => this.action = action;

        public void Move(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);

                if (action != null)
                    action($"Animal moving... Current distance: {i}");
                else
                    Console.WriteLine("action == null");
            }
        }
    }
}