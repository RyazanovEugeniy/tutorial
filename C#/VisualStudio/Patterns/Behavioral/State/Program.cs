using System;

namespace State
{
    // Суть шаблона State - запихивание state-machine'ы в ООП,
    // а конкретно создание абстрактного класса состояния класса,
    // у которого мы реализуем state-машину,
    // и реализация поведения в производных классах состояния.
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим животное в состоянии сна
            var animal = new Animal(new Sleep());

            // Заставим животное поработать
            animal.DoWork();
            // Посмотрим его состояние
            animal.GetState();

            // Заставим животное поработать
            animal.DoWork();
            // Посмотрим его состояние
            animal.GetState();

            Console.ReadKey();
        }
    }
}