using System;

namespace Command
{
    // Интерфейс команды
    public interface ICommand
    {
        string Execute();
    }

    // Простая команда, которая реализует метод Execute
    class SimpleCommand : ICommand
    {
        public string Execute() => "SimpleCommand.Execute()";
    }

    // Составная команда
    class CompositeCommand : ICommand
    {
        // Которая имеет поле солдата
        private Soldier soldier;

        // Которого она создает в конструкторе
        public CompositeCommand() => this.soldier = new Soldier();

        // Реализуем метод интерфейса, через солдата
        public string Execute() => "CompositeCommand." + this.soldier.Execute();
    }

    // Класс солдата
    class Soldier
    {
        // Метод выполнения команды
        public string Execute() => "Soldier.Execute()";
    }

    // Класс командира
    class Commander
    {
        // С двумя полями установленных команд
        private ICommand command1;
        private ICommand command2;

        // Метод установки первой команды
        public void SetCommand1(ICommand command) => this.command1 = command;

        // Метод установки второй команды
        public void SetCommand2(ICommand command) => this.command2 = command;

        // Метод запускающий последовательное выполнение двух команд
        public void Execute()
        {
            if (this.command1 is ICommand)
                Console.WriteLine(this.command1.Execute());
            if (this.command2 is ICommand)
                Console.WriteLine(this.command2.Execute());
        }
    }
}