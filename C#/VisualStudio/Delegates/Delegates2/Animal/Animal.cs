using System;
using System.Threading;

namespace Delegates2
{
    public class MovingEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public MovingEventArgs(string message)
        {
            Message = message;
        }
    }

    class Animal
    {
        public event EventHandler<MovingEventArgs> Moving;

        public void Move(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);

                if (Moving != null)
                    Moving(this, new MovingEventArgs($"Animal moving... Current distance: {i}"));
            }
        }
    }
}