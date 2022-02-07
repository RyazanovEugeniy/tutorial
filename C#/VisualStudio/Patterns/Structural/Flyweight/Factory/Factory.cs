using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Flyweight
{
    public class Flyweight
    {
        private Car car;

        public Flyweight(Car car) => this.car = car;

        public void Operation(Car uniqueState)
        {
            string serializedCar = JsonConvert.SerializeObject(this.car);
            string serializedState = JsonConvert.SerializeObject(uniqueState);

            Console.WriteLine($"Flyweight: Displaying shared {serializedCar} and unique {serializedState} state.");
        }
    }

    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] cars)
        {
            foreach (var car in cars)
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(car), this.getHash(car)));
        }

        public string getHash(Car car)
        {
            List<string> list = new List<string>();

            list.Add(car.Company);
            list.Add(car.Model);
            list.Add(car.Color);

            if (car.Owner != null && car.Number != null)
            {
                list.Add(car.Number);
                list.Add(car.Owner);
            }

            return string.Join("_", list);
        }

        // Возвращает существующий Легковес с заданным состоянием или создает
        // новый.
        public Flyweight GetFlyweight(Car car)
        {
            string hash = this.getHash(car);

            if (flyweights.Where(t => t.Item2 == hash).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(car), hash));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }

            return this.flyweights.Where(t => t.Item2 == hash).FirstOrDefault().Item1;
        }

        public void listFlyweights()
        {
            Console.WriteLine($"\nFlyweightFactory: I have {flyweights.Count} flyweights:");

            foreach (var flyweight in flyweights)
                Console.WriteLine("hash: " + flyweight.Item2);
        }
    }
}