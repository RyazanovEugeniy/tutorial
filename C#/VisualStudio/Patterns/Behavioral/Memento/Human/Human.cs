using System;

namespace Memento
{
    // Класс человека
    class Human
    {
        // Годы жизни человека.
        // (В данном примере единственная характеристика состояния, которую сохраняем)
        private int yearsOfLife = 0;

        // Метод прожигания жизни
        public void LiveSomeTime()
        {
            this.yearsOfLife += new Random().Next(1, 20);
            Console.WriteLine($"Human lives and now is {yearsOfLife} years old");
        }

        // Метод сохранения состояния
        public IMemento Save()
        {
            return new HumanMemento(this.yearsOfLife);
        }

        // Метод восстановления состояния
        public void Restore(IMemento memento)
        {
            if (!(memento is HumanMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this.yearsOfLife = memento.GetYearsOfLive();
            Console.WriteLine($"Human is now {yearsOfLife} years old");
        }
    }

}