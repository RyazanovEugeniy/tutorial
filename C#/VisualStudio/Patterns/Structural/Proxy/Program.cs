using System;
using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
    // Суть шаблона Proxy - замещение исходного класса,
    // который мы не имеем права изменять, на класс реализующий с помощью
    // исходного класса дополнительную логику.

    // Это может быть логгирование и кэширование как в данном варианте.
    // Соответственно кэширование может быть защитного свойства
    // (При доступе к объекту происходит запрос прав доступа)
    // При этом за счет ленивой инициализации

    // Обычно я пересматриваю несколько видео на какую либо задачу
    // и на основе их создаю свой вариант, но данный вариант оказался
    // настолько хорош, что я не вижу как еще проще и более полноценно
    // показать применение данного шаблона.
    // Соответственно ссылка на исходный вариант https://www.youtube.com/watch?v=ceotfvYSm7I
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем шефа и передаем в него прокси в которую помещаем исходный класс
            IChief chief = new ChiefProxy(new Chief());

            while (true)
            {
                Console.WriteLine("Welcome to Cooker!\n");
                Console.WriteLine("========= Orders =========\n");

                // Запрашиваем список текущих заказов
                IEnumerable<Order> orders = chief.GetOrders();

                // Для каждого заказа
                foreach (Order order in orders)
                {
                    // Получаем возможные статусы заказов
                    string status = chief.GetStatuses().First(s => s.Key == order.statusId).Value;

                    // Выводим состояние данного заказа
                    Console.WriteLine($"{order.name}\t\t{status}");
                }
            }
        }
    }
}