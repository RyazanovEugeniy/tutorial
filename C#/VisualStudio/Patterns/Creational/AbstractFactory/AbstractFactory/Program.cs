using System;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractChair CreateChair();

        IAbstractTable CreateTable();
    }

    class ModernFactory : IAbstractFactory
    {
        public IAbstractChair CreateChair()
        {
            return new ModernChair();
        }

        public IAbstractTable CreateTable()
        {
            return new ModernTable();
        }
    }

    class VictorianFactory : IAbstractFactory
    {
        public IAbstractChair CreateChair()
        {
            return new VictorianChair();
        }

        public IAbstractTable CreateTable()
        {
            return new VictorianTable();
        }
    }

    public interface IAbstractChair
    {
        string GetInfo();
    }

    class ModernChair : IAbstractChair
    {
        public string GetInfo()
        {
            return "ModernChair.";
        }
    }

    class VictorianChair : IAbstractChair
    {
        public string GetInfo()
        {
            return "VictorianChair.";
        }
    }

    public interface IAbstractTable
    {
        string GetInfo();

        string AnotherUsefulFunctionB(IAbstractChair collaborator);
    }

    class ModernTable : IAbstractTable
    {
        public string GetInfo()
        {
            return "ModernTable.";
        }

        public string AnotherUsefulFunctionB(IAbstractChair collaborator)
        {
            var result = collaborator.GetInfo();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }

    class VictorianTable : IAbstractTable
    {
        public string GetInfo()
        {
            return "VictorianTable.";
        }

        public string AnotherUsefulFunctionB(IAbstractChair collaborator)
        {
            var result = collaborator.GetInfo();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory = new ModernFactory();

            var chair = factory.CreateChair();
            var table = factory.CreateTable();

            Console.WriteLine(table.GetInfo());
            Console.WriteLine(table.AnotherUsefulFunctionB(chair));

            Console.ReadKey();
        }
    }
}