using System;

using FactoryMethod.Transport;

namespace FactoryMethod.Factories
{
    // Фабрика выпускающая только дорожный транспорт
    class RoadFactory : ITransportFactory
    {
        // Реализуем метод создания объекта транспорта интерфейса транспортной фабрики
        public ITransport Create()
        {
            // Создаем и возвращаем объект дорожный транспорт
            return new RoadTransport();
        }

        // Переопределяем приведение экземпляра класс к строке
        public override string ToString()
        {
            return "Дорожная компания";
        }
    }
}