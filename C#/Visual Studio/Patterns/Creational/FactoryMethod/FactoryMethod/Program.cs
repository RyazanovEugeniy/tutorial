using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Create();

            Console.ReadKey();
        }
    }
}
