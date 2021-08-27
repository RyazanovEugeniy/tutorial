using System;

using FactoryMethod.Transport;

namespace FactoryMethod.Factories
{
    class SeaFactory : ITransportFactory
    {
        public ITransportFactory Create()
        {
            return new SeaTransport();
        }

        public override string ToString() // реализуем приведение экземпляра класс к строке
        {
            return "Морская компания";
        }
    }
}