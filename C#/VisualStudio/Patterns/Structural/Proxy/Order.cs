using System;

namespace Proxy
{
    // Класс заказа
    public struct Order
    {
        // Уникальный идентификатор заказа
        public Guid id { get; set; }

        // Имя заказа
        public string? name { get; set; }

        // Статус заказа
        public int statusId { get; set; }
    }
}
