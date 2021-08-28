using System;

namespace Adapter
{
    // Класс, недоступный для изменения
    class Machine
    {
        // И его работа
        protected void DoWork()
        {
            Console.WriteLine("Работаю");
        }
    }
}