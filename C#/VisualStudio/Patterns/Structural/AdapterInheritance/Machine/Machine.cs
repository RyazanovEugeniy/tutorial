using System;

namespace AdapterInheritance
{
    // Класс, недоступный для изменения
    class Machine
    {
        // И его работа
        public void DoWork()
        {
            Console.WriteLine("Work");
        }
    }
}