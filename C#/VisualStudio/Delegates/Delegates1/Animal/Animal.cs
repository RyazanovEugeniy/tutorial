using System;
using System.Threading;

namespace Delegates1
{
    class Animal
    {
        public void Move(int distance, DoSmthWithMessage doSmthWithMessage)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);
                doSmthWithMessage($"Animal moving... Current distance: {i}");
            }
        }
    }
}