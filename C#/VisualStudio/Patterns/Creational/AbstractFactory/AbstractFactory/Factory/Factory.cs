namespace AbstractFactory
{
    public interface IFactory
    {
        IWorker CreateWorker();

        IMachine CreateMachine();
    }

    class TableFactory : IFactory
    {
        public IWorker CreateWorker()
        {
            return new TableFactoryWorker();
        }

        public IMachine CreateMachine()
        {
            return new TableFactoryMachine();
        }
    }

    class ChairFactory : IFactory
    {
        public IWorker CreateWorker()
        {
            return new ChairFactoryWorker();
        }

        public IMachine CreateMachine()
        {
            return new ChairFactoryMachine();
        }
    }
}