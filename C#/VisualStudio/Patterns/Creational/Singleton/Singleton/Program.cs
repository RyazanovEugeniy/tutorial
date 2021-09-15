using System;

namespace Singleton
{
    // Суть шаблона Синглтон - создание класса, который может существовать,
    // только в единственном экземплере.
    // Так как возвращается один и тот же экземпляр в любую точку кода,
    // то сей экземпляр становится глобальным.
    class Singleton
    {
        // Приватный конструктор, чтобы никто не смог залезть
        // и создавать экземпляры, как захочет
        private Singleton() { }

        // Статическое поле, куда будет записан наш экземпляр
        private static Singleton instance;

        // Статический метод получения экземпляра класса.
        // Статический потому что, иначе придется создать экземпляр класса,
        // а потом уже вызывать его метод.
        public static Singleton GetInstance()
        {
            // Если экземпляр не существует
            if (instance == null)
                // То создаем его
                instance = new Singleton();

            // И возвращаем
            return instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Получим парочку экземпляров нашего Singleton
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            // Проверяем совпадают ли экземпляры объектов
            Console.WriteLine("Проверяем совпадают ли экземпляры объектов");
            Console.WriteLine($"(s1 == s2) == {s1 == s2}");

            Console.ReadKey();
        }
    }
}