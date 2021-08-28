using System;

namespace Adapter
{
    // Интерфейс необходимый для реализации
    public interface IMachine
    {
        void Work();
    }

    // Наследуемся от класса, который невозможно изменить
    // И объявляем необходимость реализации нашего интерфейса
    class Adapter : Machine, IMachine
    {
        // Реализуем наш интерфейс, с помощью родительского класса
        public void Work()
        {
            this.DoWork();
        }
    }
}