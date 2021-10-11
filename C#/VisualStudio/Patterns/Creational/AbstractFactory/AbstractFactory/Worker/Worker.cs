namespace AbstractFactory
{
    public interface IWorker
    {
        string GetInfo();

        string CreateItem(IMachine machine);
    }

    class TableFactoryWorker : IWorker
    {
        public string GetInfo()
        {
            return "TableFactoryWorker.";
        }

        public string CreateItem(IMachine machine)
        {
            var result = machine.GetInfo();

            return $"TableFactoryWorker create item on {result}";
        }
    }

    class ChairFactoryWorker : IWorker
    {
        public string GetInfo()
        {
            return "ChairFactoryWorker.";
        }

        public string CreateItem(IMachine machine)
        {
            var result = machine.GetInfo();

            return $"ChairFactoryWorker create item on {result}";
        }
    }


}