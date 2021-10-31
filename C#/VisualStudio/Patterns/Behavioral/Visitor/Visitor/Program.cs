using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICargo> cargoList = new List<ICargo>
            {
                new LightCargo(),
                new HeavyCargo(),
                new LightCargo(),
                new LightCargo()
            };

            var transportCompany1 = new TransportCompany1();
            foreach (ICargo cargo in cargoList)
                cargo.Deliver(transportCompany1);


            var transportCompany2 = new TransportCompany2();
            foreach (ICargo transport in cargoList)
                transport.Deliver(transportCompany2);

            Console.ReadKey();
        }
    }
}