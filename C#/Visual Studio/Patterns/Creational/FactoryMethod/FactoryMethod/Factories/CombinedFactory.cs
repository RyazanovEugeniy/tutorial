using System;

using FactoryMethod.Transport;

namespace FactoryMethod.Factories
{
    class CombinedFactory : ITransportFactory
    {
        public ITransport Create()
        {
            return new RoadTransport();
        }

        public override string ToString() // реализуем приведение экземпляра класс к строке
        {
            return "Компания комбинированного типа";
        }
    }
}