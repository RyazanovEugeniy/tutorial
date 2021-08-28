using System;

namespace Adapter
{
    // Интерфейс необходимый для реализации
    interface IMachine
    {
        void Work();
    }

    // Класс адаптер, которому необходимо реализовать интерфейс IMachine
    class Adapter : IMachine
    {
        // Создаем экземпляр класса Machine
        Machine machine = new Machine();

        // Реализуем наш интерфейс, с помощью экзепляра класса
        public void Work()
        {
            machine.DoWork();
        }
    }
}