using System;

namespace Memento
{
    // Суть шаблона Memento - создание класса, который будет заниматься
    // сохранениями состояний объекта и возвращение его в это состояние
    // в случае необходимости.
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим человека
            Human human = new Human();
            // И запихаем человека в машину времени
            TimeMachine timeMachine = new TimeMachine(human);

            // Человек живет какое то время
            human.LiveSomeTime();

            // Сохраняем состояние человека
            timeMachine.Backup();
            // Человек живет какое то время
            human.LiveSomeTime();

            // Сохраняем состояние человека
            timeMachine.Backup();
            // Человек живет какое то время
            human.LiveSomeTime();

            // Сохраняем состояние человека
            timeMachine.Backup();
            // Человек живет какое то время
            human.LiveSomeTime();

            Console.WriteLine();
            // Смотрим какие состояния человека сохранили
            timeMachine.ShowBackups();

            // И ВРУБАЕМ МАШИНУ ВРЕМЕНИИИИ
            Console.WriteLine("\nTIME MACHINE: Turn on ");
            timeMachine.BackToPast();

            // И еще разок
            Console.WriteLine("\nTIME MACHINE: Turn on ONE MORE TIME");
            timeMachine.BackToPast();

            // И еще разок
            Console.WriteLine("\nTIME MACHINE: Turn on ONE MORE TIME");
            timeMachine.BackToPast();

            Console.ReadKey();
        }
    }
}