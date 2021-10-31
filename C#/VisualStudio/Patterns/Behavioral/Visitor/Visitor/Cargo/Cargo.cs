using System;

namespace Visitor
{
    public interface ICargo
    {
        void Deliver(IVisitor visitor);
    }

    public class LightCargo : ICargo
    {
        public void Deliver(IVisitor visitor)
        {
            visitor.LightCargoDeliver(this);
        }

        public string LightCargoDeliver()
        {
            return "LightCargoDeliver";
        }
    }

    public class HeavyCargo : ICargo
    {
        public void Deliver(IVisitor visitor)
        {
            visitor.HeavyCargoDeliver(this);
        }

        public string HeavyCargoDeliver()
        {
            return "HeavyCargoDeliver";
        }
    }

    public interface IVisitor
    {
        void LightCargoDeliver(LightCargo lightCargo);

        void HeavyCargoDeliver(HeavyCargo heavyCargo);
    }

    class TransportCompany1 : IVisitor
    {
        public void LightCargoDeliver(LightCargo lightCargo)
        {
            Console.WriteLine(this.GetType().Name + " " + lightCargo.LightCargoDeliver());
        }

        public void HeavyCargoDeliver(HeavyCargo heavyCargo)
        {
            Console.WriteLine(this.GetType().Name + " " + heavyCargo.HeavyCargoDeliver());
        }
    }

    class TransportCompany2 : IVisitor
    {
        public void LightCargoDeliver(LightCargo lightCargo)
        {
            Console.WriteLine(this.GetType().Name + " " + lightCargo.LightCargoDeliver());
        }

        public void HeavyCargoDeliver(HeavyCargo heavyCargo)
        {
            Console.WriteLine(this.GetType().Name + " " + heavyCargo.HeavyCargoDeliver());
        }
    }
}