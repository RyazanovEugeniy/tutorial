using System;

namespace Strategy
{
    // Суть шаблона стратегия - вынос части кода
    // в собственные классы, реализующие один интерфейс (абстрактный класс).
    // Это позволяет увеличить уровень абстракции изначального класса,
    // а так же дает возможность смены алгоритмов на ходу.
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим человека
            var human = new Human();
            // Попробуем заставить его работать
            human.DoWork();
            Console.WriteLine();

            // Дадим ему профессию
            human.SetProfession(new Dancer());
            // Заставим работать
            human.DoWork();
            Console.WriteLine();

            // Дадим другую профессию
            human.SetProfession(new Singer());
            // И снова заставим работать
            human.DoWork();

            Console.ReadKey();
        }
    }
}