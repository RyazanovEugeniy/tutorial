using System;

namespace FactoryMethod.Transport
{
    class SeaTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Доставка морем");
        }

        public override string ToString()
        {
            return "Морской транспорт";
        }
    }
}