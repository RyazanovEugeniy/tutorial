using System;
using System.Collections.Generic;
using System.Threading;

namespace Proxy
{
    // Исходный класс шефа, который мы не имеем права изменять
    class Chief : IChief
    {
        // Получение возможных вариантов статусов заказа, которое происходит долго
        public IDictionary<int, string> GetStatuses()
        {
            // Здесь по идее должна быть логика запроса возможных статусов из БД,
            // но просто имитируется ее работа

            // Создаем словарик
            Dictionary<int, string> statuses = new Dictionary<int, string>();

            // Добавляем в него пары ключ-статус
            statuses.Add(1, "ready");
            statuses.Add(2, "not ready");
            statuses.Add(3, "preparing");

            // Имитируем задержку
            Thread.Sleep(5000);
            
            // Возвращаем статусы
            return statuses;
        }

        // Метод получения текущих заказов
        public IEnumerable<Order> GetOrders()
        {
            // Здесь по идее должна быть логика запроса текущих статусов заказов,
            // но просто имитируется ее работа.

            // Создаем список заказов
            List<Order> orders = new List<Order>();

            // Добавляем 3 заказа со случайным статусом
            orders.Add(new Order() { name = "Burger", statusId = RandomizeStatus() });
            orders.Add(new Order() { name = "Pasta", statusId = RandomizeStatus() });
            orders.Add(new Order() { name = "Omelet", statusId = RandomizeStatus() });

            // Возвращаем заказы
            return orders;
        }

        // Просто логика случайного выбора статуса
        private static int RandomizeStatus() => new Random().Next(1, 4);
    }
}
