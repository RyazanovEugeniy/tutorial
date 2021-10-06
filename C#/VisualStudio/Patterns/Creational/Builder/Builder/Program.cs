using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder builder = new Builder();

            director.Builder = builder;

            Console.WriteLine("Minimal");
            director.BuildMinimal();

            Home home1 = builder.GetHome();
            Console.WriteLine("home1 " + home1.ListParts());

            Console.WriteLine("Maximal");
            director.BuildMaximal();
            Home home2 = builder.GetHome();
            Console.WriteLine("home2 " + home2.ListParts());

            Console.WriteLine("Custom");
            builder.BuildKitchen();
            builder.BuildBathRoom();

            Home home3 = builder.GetHome();

            Console.Write("home3 " + home3.ListParts());

            Console.ReadKey();
        }
    }
}