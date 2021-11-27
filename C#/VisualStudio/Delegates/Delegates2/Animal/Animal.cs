using System;
using System.Threading;

namespace Delegates1
{
    class Animal
    {
        public void Move(int distance, Action<string> action)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);
                action($"Animal moving... Current distance: {i}");
            }
        }
    }
}