using System;
using System.Collections.Generic;

namespace Mediator
{
    // Интерфейс нашего посредника
    public interface IMediator
    {
        // Метод уведомления, в который мы передаем,
        // объект который уведомляет и что за событие произошло
        void Notify(object sender, string ev);
    }

    class Mediator : IMediator
    {
        // Набор наших кнопок
        private List<Button> buttons = new List<Button>();

        // Конструктор медиатора
        public Mediator() { }

        // Метод добавления кнопки
        public void AddButton(Button button)
        {
            buttons.Add(button);
            button.SetMediator(this);
        }

        // Метод удаления кнопки
        public void RemoveButton(Button button)
        {
            buttons.Remove(button);
            button.ResetMediator();
        }

        // Метод обработки уведомлений
        public void Notify(object sender, string ev)
        {
            // Ищем кнопку, которая вызвала событие (Вроде можно более красиво сделать)
            foreach (Button button in buttons)
                if (sender == button)
                    // Выводим имя кнопки и событие, которое произошло
                    Console.WriteLine(button.name + "." + ev);
        }
    }
}