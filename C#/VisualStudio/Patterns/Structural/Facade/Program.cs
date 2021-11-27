using System;

namespace Facade
{
    // Суть шаблона Фасад - создание класса предоставляющего простой доступ (урезанный)
    // к какой либо сложной логике.
    // Зачастую фасад контролирует жизненный цикл объектов управляемых им.

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем умный дом
            SmartHouse smartHouse = new SmartHouse();
             
            // Человек приходит в дом
            Console.WriteLine(smartHouse.HumanGoInto());
            // И уходит
            Console.WriteLine(smartHouse.HumanGoOut());
            // И еще разок приходит
            Console.WriteLine(smartHouse.HumanGoInto());

            Console.ReadKey();
        }
    }
}