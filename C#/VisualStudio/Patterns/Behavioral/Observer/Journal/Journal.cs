using System;
using System.Collections.Generic;

namespace Observer
{
    // Интерфейс наблюдателя
    public interface IObserver
    {
        // Метод покупки публикации
        void BuyPublication(IJournal subject);
    }

    // Класс подписчик реализующий интерфейс наблюдателя
    class Subscriber : IObserver
    {
        // Метод покупки публикации
        public void BuyPublication(IJournal journal)
        {
            // Если журнал NewYorkTimes, то выведем, что купили
            if (journal is NewYorkTimes)
                Console.WriteLine("Subscriber buying: NewYorkTimes.PublicationNumber " + (journal as NewYorkTimes).PublicationNumber);
        }
    }

    // Интерфейс журнала
    public interface IJournal
    {
        // Метод прикрепления подписчика
        void Attach(IObserver observer);

        // Метод открепления подписчика
        void Detach(IObserver observer);

        // Метод уведомления подписчиков о событии
        void Notify();
    }

    // Класс журнала NewYorkTimes, реализующий интерфейс журнала
    public class NewYorkTimes : IJournal
    {
        // Лист наблюдателей
        private List<IObserver> observers = new List<IObserver>();

        // Свойство текущего номера публикации
        public int PublicationNumber { get; set; } = 0;

        // Метод прикрепления подписчика
        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        // Метод открепления подписчика
        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        // Метод уведомления подписчиков о событии
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.BuyPublication(this);
            }
        }

        // Метод выпуска новой публикации
        public void NewPublication()
        {
            this.PublicationNumber++;

            this.Notify();
        }
    }
}