using System;

namespace AdapterInheritance
{
    // Суть шаблона Адаптер - реализация интерфейса,
    // предназначенного для использования методов класса,
    // недоступного для изменения.
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем наш адаптерн
            IMachine machine = new Adapter();

            // Заставляем его работать, с помощью пользовательского интерфейса
            machine.Work();

            Console.ReadKey();
        }
    }
}
