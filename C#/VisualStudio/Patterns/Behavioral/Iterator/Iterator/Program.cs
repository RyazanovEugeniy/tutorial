using System;

using Iterator.Words;
using Iterator.Pizzas;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordCollection = new WordCollection();
            wordCollection.Add("First");
            wordCollection.Add("Second");
            wordCollection.Add("Third");

            Console.WriteLine("Слова:");

            foreach (var element in wordCollection)
                Console.WriteLine(element);

            var pizzaCollection = new PizzaCollection();
            pizzaCollection.Add(new Pizza("Пепперони", 123.0f, 500.0f));
            pizzaCollection.Add(new Pizza("Венецианская", 110.0f, 700.0f));
            pizzaCollection.Add(new Pizza("Сицилианская", 111.0f, 750.0f));

            Console.WriteLine();
            Console.WriteLine("Пицца");

            foreach (Pizza pizza in pizzaCollection)
                Console.WriteLine("Пицца: " + pizza + " Вес: " + pizza.weight + " Цена: " + pizza.price);

            /*pizzaCollection.Add(new Pizza("Навалено от души", 190.0f, 1150.0f));
            foreach (Pizza pizza in pizzaCollection)
                Console.WriteLine("Пицца: " + pizza + " Вес: " + pizza.weight + " Цена: " + pizza.price);
*/
            Console.ReadKey();
        }
    }
}