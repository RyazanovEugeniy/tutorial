using System.Collections.Generic;

namespace Proxy
{
    // Интерфейс класса шефа
    interface IChief
    {
        // Метод возвращения возможных статусов заказа
        IDictionary<int, string> GetStatuses();

        // Получение списка текущих заказов
        IEnumerable<Order> GetOrders();
    }
}

