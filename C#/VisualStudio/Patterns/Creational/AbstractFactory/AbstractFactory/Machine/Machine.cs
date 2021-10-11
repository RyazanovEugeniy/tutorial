namespace AbstractFactory
{
    public interface IMachine
    {
        string GetInfo();
    }

    class TableFactoryMachine : IMachine
    {
        public string GetInfo()
        {
            return "TableFactoryMachine.";
        }

    }

    class ChairFactoryMachine : IMachine
    {
        public string GetInfo()
        {
            return "ChairFactoryMachine.";
        }
    }


}