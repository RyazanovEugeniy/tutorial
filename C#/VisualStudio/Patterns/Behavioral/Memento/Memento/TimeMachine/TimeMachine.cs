using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    // Интерфейс снимка (Backup'a)
    public interface IMemento
    {
        // Который должен уметь, возвращать информацию по снимку
        string GetInformation();

        // Возвращать состояние объекта для восстановления
        int GetYearsOfLive();

        // Ну и возвращать дату снимка
        DateTime GetDate();
    }

    // Конкретно снимок человека, реализующий интерфейс снимка
    class HumanMemento : IMemento
    {
        // Поле состояния объекта
        private int yearsOfLive;

        // Поле даты снимка
        private DateTime date;

        // Конструктор снимка
        public HumanMemento(int yearsOfLive)
        {
            this.yearsOfLive = yearsOfLive;
            this.date = DateTime.Now;
        }

        // Метод возврата состояния объекта
        public int GetYearsOfLive()
        {
            return this.yearsOfLive;
        }

        // Метод запроса информации о снимке
        public string GetInformation()
        {
            return $"Backup: {this.date} / Human is {this.yearsOfLive} years old";
        }

        // Метод запроса даты снимка
        public DateTime GetDate()
        {
            return this.date;
        }
    }

    // Класс машины времени
    class TimeMachine
    {
        // Поле листа снимков
        private List<IMemento> mementos = new List<IMemento>();

        // Поле ссылки на человека, которого снимаем
        private Human human = null;

        // Конструктор машины времени
        public TimeMachine(Human human)
        {
            this.human = human;
        }

        // Метод сохранения состояния человека
        public void Backup()
        {
            this.mementos.Add(this.human.Save());
        }

        // Метод возврата человека в прошлое
        public void BackToPast()
        {
            if (this.mementos.Count == 0)
            {
                Console.WriteLine("No backups of life");
                return;
            }

            var memento = this.mementos.Last();

            Console.WriteLine("TimeMachine: Human return to the past\n" + memento.GetInformation());
            this.human.Restore(memento);
            this.mementos.Remove(memento);
        }

        // Метод выводящий все снимки состояний человека
        public void ShowBackups()
        {
            Console.WriteLine("TimeMachine: ShowBackups");

            foreach (var memento in this.mementos)
            {
                Console.WriteLine(memento.GetInformation());
            }
        }
    }
}