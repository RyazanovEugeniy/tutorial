using System;

using Iterator.Words;
using Iterator.Pizzas;

namespace Iterator
{
    // Суть шаблона Итератор - вынос поведения обхода коллекции в отдельный класс,
    // что позволяет избежать размывания сущности коллекции,
    // которая заключается в хранении данных, а не в хранении вариантов обхода этих данных.

    // Есть два варианта реализации паттерна:
    // 1) Итератор принимает коллекцию в параметрах конструктора при создании
    // 2) Итератор возвращается самой коллекцией (как в данном примере(метод GetEnumerator))

    // Бонусом является то, что реализуя интерфейсы IEnumenator, IEnumerable,
    // можно спокойно использовать оператор foreach, а может еще какие.

    // Правда в данном примере я не стал городить что-то сложное,
    // вроде коллекций в виде деревьев или еще чего, а просто обходил список.

    // P.S. Iteration - Повторение, Iterator - Повторитель,
    // Enumerator - Перечислитель (Счетчик), Enumerable - Перечисляемый

    class Program
    {
        static void Main(string[] args)
        {
            // Коллекция слов возврающая StraightIterator
            var wordCollection = new WordCollection();
            // Добавляем элементы коллекции
            wordCollection.Add("First");
            wordCollection.Add("Second");
            wordCollection.Add("Third");
            wordCollection.Add("Fourth ");
            wordCollection.Add("Fifth");

            // Выводим
            Console.WriteLine("Слова:");
            foreach (var element in wordCollection)
                Console.WriteLine(element);

            // Немного усложненная коллекция объектов пицца
            // реализованы три варианта обхода прямой, обратный и странный.
            // Возвращается StrangeIterator
            var pizzaCollection = new PizzaCollection();
            // Добавляем элементы коллекции
            pizzaCollection.Add(new Pizza("1", 123.0f, 500.0f));
            pizzaCollection.Add(new Pizza("2", 110.0f, 700.0f));
            pizzaCollection.Add(new Pizza("3", 115.0f, 750.0f));
            pizzaCollection.Add(new Pizza("4", 116.0f, 750.0f));
            pizzaCollection.Add(new Pizza("5", 117.0f, 750.0f));
            pizzaCollection.Add(new Pizza("6", 118.0f, 750.0f));
            pizzaCollection.Add(new Pizza("7", 119.0f, 750.0f));
            pizzaCollection.Add(new Pizza("8", 121.0f, 750.0f));
            pizzaCollection.Add(new Pizza("9", 116.0f, 750.0f));

            Console.WriteLine();
            Console.WriteLine("Пицца");

            // Обход по StrangeIterator, через foreach
            foreach (Pizza pizza in pizzaCollection)
            {
                pizza.price = pizza.weight * 6;
                Console.WriteLine("Пицца: " + pizza + " Вес, г.: " + pizza.weight + " Цена, р.: " + pizza.price);
            }

            Console.ReadKey();
        }
    }
}