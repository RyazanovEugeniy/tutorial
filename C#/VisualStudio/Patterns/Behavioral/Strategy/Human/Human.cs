using System;

namespace Strategy
{
    // Интерфейс профессии человека
    public interface IProfession
    {
        // Метод работы
        void DoWork();
    }

    // Класс танцора
    class Dancer : IProfession
    {
        // Который танцует
        public void DoWork()
        {
            Console.WriteLine("Human dancing");
        }
    }

    // Класс певца
    class Singer : IProfession
    {
        // Который внезапно поет
        public void DoWork()
        {
            Console.WriteLine("Human singing");
        }
    }

    // Класс нашего человека
    class Human
    {
        // Поле в котором мы храним текущую профессию
        private IProfession profession;

        // Конструктор
        public Human()
        { }

        // Метод установки профессии
        public void SetProfession(IProfession profession)
        {
            this.profession = profession;
            Console.WriteLine($"SetProfession to {this.GetType().Name}: {profession.GetType().Name}");
        }

        // Метод работы
        public void DoWork()
        {
            // Который проверяет, есть ли профессия. Если есть работаем, если нет, то ничего не делаем.
            if (profession != null)
                this.profession.DoWork();
            else
                Console.WriteLine($"{this.GetType().Name} have no profession");
        }
    }
}