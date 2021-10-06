using System;

namespace Builder
{
    // Суть шаблона Builder - создание класса позволяющего создавать
    // сложные объекты пошагово.
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем строителя
            Builder builder = new Builder();
            // Создаем директора, которому передаем нашего строителя
            Director director = new Director(builder);

            // Построим простой дом, с помощью директора
            director.BuildMinimal();
            Home home1 = builder.GetHome();
            Console.WriteLine("home1 " + home1.ListParts());

            // Построим сложный дом, с помощью директора
            director.BuildMaximal();
            Home home2 = builder.GetHome();
            Console.WriteLine("home2 " + home2.ListParts());

            // Ну и построим дом без директора, напрямую строителем
            builder.BuildKitchen();
            builder.BuildBathRoom();
            Home home3 = builder.GetHome();
            Console.WriteLine("home3 " + home3.ListParts());

            // Выведем еще не построенный дом
            Home home4 = builder.GetHome();
            Console.WriteLine("home4 " + home4.ListParts());

            Console.ReadKey();
        }
    }
}