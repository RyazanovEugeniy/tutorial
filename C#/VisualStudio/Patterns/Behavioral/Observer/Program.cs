using System;

namespace Observer
{
    // Суть шаблона Наблюдатель - ассоциация двух классов,
    // с целью реагирования одним классом,
    // на события происходящие в другом классе.
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим журнал
            var newYorkTimes = new NewYorkTimes();

            // Создаем подписчика и добавляем к журналу
            newYorkTimes.Attach(new Subscriber());

            // Выпускаем журнал
            newYorkTimes.NewPublication();
            newYorkTimes.NewPublication();
            newYorkTimes.NewPublication();

            Console.ReadKey();
        }
    }
}