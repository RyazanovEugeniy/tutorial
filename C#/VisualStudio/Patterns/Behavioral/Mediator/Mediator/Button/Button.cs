using System;

namespace Mediator
{
    class Button
    {
        // Поле в которое, в дальнейшем запишется медиатор кнопки
        private IMediator mediator;
        // Имя кнопки
        public string name { get; }

        // Конструктор кнопки
        public Button(string name) => this.name = name;

        // Установка медиатора
        public void SetMediator(IMediator mediator) => this.mediator = mediator;
        // Сброс медиатора
        public void ResetMediator() => this.mediator = null;

        // Методы Clicked и Released, которые на самом деле
        // просто посылают сигнал медиатору, о том, что с таким-то объектом,
        // произошло такое-то событие.
        // А медиатор уже сам думает, что с этим всем делать.
        public void Clicked() => this.mediator.Notify(this, "Clicked");
        public void Released() => this.mediator.Notify(this, "Released");
    }
}