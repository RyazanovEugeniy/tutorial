using System;

namespace Adapter
{
    // Класс, недоступный для изменения
    class Machine
    {
        // И его работа
        public void DoWork()
        {
            Console.WriteLine("Работаю");
        }
    }
}