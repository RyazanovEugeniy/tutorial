using System;
using System.Threading;

namespace Delegates1
{
    class Animal
    {
        private DoSmthWithMessage doSmthWithMessage;

        public void setDoSmthWithMessage(DoSmthWithMessage doSmthWithMessage) => this.doSmthWithMessage = doSmthWithMessage;

        public void Move(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);

                if (doSmthWithMessage != null)
                    doSmthWithMessage($"Animal moving... Current distance: {i}");
                else
                    Console.WriteLine("doSmthWithMessage == null");
            }
        }
    }
}