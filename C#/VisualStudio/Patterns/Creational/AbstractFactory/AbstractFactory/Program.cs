using System;

namespace AbstractFactory
{
    // Суть шаблона абстрактная фабрика - реализация интерфейса
    // по созданию продуктов семейства связанных классов.
    // Фабрика сама создает объекты нужного семейства, что упрощает работу с ней.
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем фабрику по производству столов
            IFactory factory = new TableFactory();

            // Создаем рабочего и станок
            var worker = factory.CreateWorker();
            var machine = factory.CreateMachine();

            // Смотри информацию того, что создали
            Console.WriteLine(worker.GetInfo());
            Console.WriteLine(machine.GetInfo());
            // Проверяем взаимодействие рабочего со станком
            Console.WriteLine(worker.CreateItem(machine));

            Console.WriteLine();

            // То же самое с другой фабрикой
            factory = new ChairFactory();

            // Создаем рабочего и станок
            worker = factory.CreateWorker();
            machine = factory.CreateMachine();

            // Смотри информацию того, что создали
            Console.WriteLine(worker.GetInfo());
            Console.WriteLine(machine.GetInfo());
            // Проверяем взаимодействие рабочего со станком
            Console.WriteLine(worker.CreateItem(machine));

            Console.ReadKey();
        }
    }
}