using System;

namespace TemplateMethod
{
    // Суть шаблона TemplateMethod - задание структуры алгоритма
    // в методе базового класса, заставляющего производные классы
    // выполнить все шаги данного алгоритма.
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим человека
            SmartHuman smartHuman = new SmartHuman();
            // Выполним его шаблонный метод
            smartHuman.TemplateMethod();

            Console.ReadKey();
        }
    }
}