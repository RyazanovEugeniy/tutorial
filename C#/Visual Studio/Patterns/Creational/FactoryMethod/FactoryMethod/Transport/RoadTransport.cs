using System;

namespace FactoryMethod.Transport
{
    class RoadTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Доставка морем");
        }

        public override string ToString()
        {
            return "Дорожный транспорт";
        }
    }
}