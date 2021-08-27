using System;

namespace FactoryMethod
{
    class Company
    {
        public Company(ITransportFactory transportFactory)
        {

        }

        public void Create()
        {
            Console.WriteLine("Создаем компанию");
        }
    }
}
