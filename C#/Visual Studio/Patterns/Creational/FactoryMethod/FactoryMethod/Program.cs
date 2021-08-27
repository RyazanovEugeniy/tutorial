using System;

using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете тип компании:");
            Console.WriteLine("1: Дорожная компания");
            Console.WriteLine("2: Морская компания");
            Console.WriteLine("3: Компания смешанного типа");

            int typeCompany;
            while (!int.TryParse(Console.ReadLine(), out typeCompany) || typeCompany < 1 || typeCompany > 3)
                Console.WriteLine("Ошибка ввода!");

            switch (typeCompany)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }

            Company company = new Company(new RoadFactory());
            company.Create();

            Console.ReadKey();
        }
    }
}
