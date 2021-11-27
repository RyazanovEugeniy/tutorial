using System;

namespace Mediator
{
    // Суть шаблона Mediator - создание класса посредника,
    // в который выносится исполнительный код,
    // что позволяет сохранить уровень абстракции классов,
    // из которых этот код изымается, что в свою очередь дает,
    // возможность более гибкого использования этих классов.

    // В данном примере есть класс посредник,
    // в котором есть список объектов класса Button
    // При добавлении кнопки в класс посредник, происходит запись
    // этого посредника в защищенное поле кнопки.
    // После нажатия кнопки происходит вызов
    // метода Notify, т.е. уведомления класса Mediator о событии
    // и происходит обработка события, уже в самом посреднике.
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем наш медиатор
            Mediator mediator = new Mediator();

            // Создаем кнопочки
            Button button1 = new Button("Button1");
            Button button2 = new Button("Button2");
            Button button3 = new Button("Button3");

            // Добавляем кнопочки;)
            mediator.AddButton(button1);
            mediator.AddButton(button2);
            mediator.AddButton(button3);

            // Вызываем случайный набор сигналов
            button1.Clicked();
            button2.Released();
            button3.Clicked();
            button1.Released();
            button2.Clicked();

            Console.ReadKey();
        }
    }
}