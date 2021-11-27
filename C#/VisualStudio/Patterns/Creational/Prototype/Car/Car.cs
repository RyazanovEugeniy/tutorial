using System;

namespace Prototype
{
    // Класс двигателя автомобиля
    public class Engine
    {
        // С полями фабричного номера
        public int factoryNumber;
        // и мощности
        public float power;

        // Конструктор двигателя
        public Engine(int factoryNumber, float power)
        {
            this.factoryNumber = factoryNumber;
            this.power = power;
        }
    }

    // Класс машины, с возможностью его клонирования
    public class Car
    {
        // С полями имени машины
        public string name;
        // и двигателя
        public Engine engine;
        
        // Конструктор машины
        public Car (string name, int engineFactoryNumber, float enginePower)
        {
            this.name = name;
            this.engine = new Engine(engineFactoryNumber, enginePower);
        }

        // Поверхностное копирование машины
        public Car ShallowCopy()
        {
            return (Car)this.MemberwiseClone();
        }

        // Глубокое копирование машины
        public Car DeepCopy()
        {
            Car clone = (Car)this.MemberwiseClone();
            clone.engine = new Engine(engine.factoryNumber, engine.power);
            return clone;
        }

        // Вывод информации о машине
        public void Information()
        {
            Console.WriteLine("Name == " + name);
            Console.WriteLine("engine.factoryNumber == " + engine.factoryNumber);
            Console.WriteLine("engine.power == " + engine.power);
        }
    }
}