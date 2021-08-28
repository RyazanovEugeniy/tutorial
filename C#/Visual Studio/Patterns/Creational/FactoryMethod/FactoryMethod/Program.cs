using System;

using FactoryMethod.Factory;

namespace FactoryMethod
{
    // Суть шаблона Фабричный Метод - делегирование обязанности по созданию объекта отдельному классу
    // Это упрощает расширение кода, в случае необходимости добавления объектов нового типа 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете тип компании:");
            Console.WriteLine("1: Дорожная компания");
            Console.WriteLine("2: Морская компания");
            Console.WriteLine("3: Компания смешанного типа");

            int typeCompany;

            // Ждем ввода числа и тут же проверяем:
            // Что это число и то, что оно находится в заданных пределах
            // Возможно нужно было разделить на две разные проверки
            // Ибо не на 100% уверен возможна ли ошибка
            // При работе данной конструкции, но вроде как работает
            while (!int.TryParse(Console.ReadLine(), out typeCompany) || typeCompany < 1 || typeCompany > 3)
                Console.WriteLine("Ошибка ввода!");

            // Объявляем объект компании
            Company company;

            // И создаем нужный тип компании
            switch (typeCompany)
            {
                case 1:
                    company = new Company(new RoadFactory());
                    break;
                case 2:
                    company = new Company(new SeaFactory());
                    break;
                case 3:
                    company = new Company(new CombinedFactory());
                    break;
                default:
                    throw new Exception("Данный тип компании отсутсвует");
            }

            // Запрашиваем состав транспорта
            Console.WriteLine("Состав транспорта компании:");
            company.TransportInfo();

            // Запускаем транспорт
            Console.WriteLine("Запуск транспорта:");
            company.TransportDeliver();

            Console.ReadKey();
        }
    }
}
