using System;

namespace Adapter
{
    // Суть шаблона Адаптер - реализация интерфейса,
    // предназначенного для использования методов класса,
    // недоступного для изменения.
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();

            adapter.Work();

            Console.ReadKey();
        }
    }
}
