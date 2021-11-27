using System;

namespace AdapterAssociation
{
    // Суть шаблона Адаптер - реализация интерфейса,
    // предназначенного для использования методов класса,
    // недоступного для изменения.
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем наш адаптерн
            Adapter adapter = new Adapter();

            // Заставляем его работать, с помощью пользовательского интерфейса
            adapter.Work();

            Console.ReadKey();
        }
    }
}
