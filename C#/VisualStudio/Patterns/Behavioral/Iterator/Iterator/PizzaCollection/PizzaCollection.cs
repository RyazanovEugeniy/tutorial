using System.Collections;
using System.Collections.Generic;

namespace Iterator.Pizzas
{
    // Класс пицца
    class Pizza
    {
        // Которая имеет свойства:
        // Название
        public string name { get; }
        // Вес
        public float weight { get; set; }
        // Цену
        public float price { get; set; }

        // Конструктор класса, в который передаем начальные параметры
        public Pizza(string name, float weight, float price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        // Заместим ToString()
        public override string ToString()
        {
            return name;
        }

    }

    // Наша коллекция пицц, реализующая интерфейс IEnumerable
    class PizzaCollection : IEnumerable
    {
        // Поле нашего списка пицц
        private List<Pizza> collection = new List<Pizza>();

        // Возвращаем коллекцию
        public List<Pizza> getCollection() => collection;

        // Добавляем элемент
        public void Add(Pizza pizza)
        {
            this.collection.Add(pizza);
        }

        // Удаляем элемент
        public void Remove(Pizza pizza)
        {
            this.collection.Remove(pizza);
        }

        // Возвращаем итератор.
        // Здесь можно подставить любой из реализованных и foreach их будет кушать.
        public IEnumerator GetEnumerator()
        {
            return new StrangeIterator(this);
        }
    }

    // Прямой итератор реализующий интерфейс IEnumenator
    class StraightIterator : IEnumerator
    {
        // Поле коллекции, которую будем обходить
        private PizzaCollection collection;

        // Текущая позиция обхода
        private int position = 0;

        // Конструктор итератора принимающий коллекцию
        public StraightIterator(PizzaCollection collection) => this.collection = collection;

        // Реализация методов IEnumerator
        // Возврат текущего элемента(с наращиванием текущей позиции)
        object IEnumerator.Current => this.collection.getCollection()[position++];

        // Метод определенияя возможности дальнейшего продвижения итератора
        public bool MoveNext() => position < collection.getCollection().Count;

        // Сброс текущей позиции обхода
        public void Reset() => position = 0;
    }

    // Обратный итератор
    class ReverseIterator : IEnumerator
    {
        // Поле коллекции, которую будем обходить
        private PizzaCollection collection;

        // Текущая позиция обхода
        private int position;

        // Конструктор итератора принимающий коллекцию
        public ReverseIterator(PizzaCollection collection)
        {
            // Начальную позицию пришлось инициализровать в конструкторе
            // Ибо как оказалось foreach не делает сброса методом Reset =(
            position = collection.getCollection().Count - 1;

            // Записываем коллекцию
            this.collection = collection;
        }

        // Реализация методов IEnumerator
        // Возврат текущего элемента(с наращиванием текущей позиции)
        object IEnumerator.Current => this.collection.getCollection()[position--];

        // Метод определенияя возможности дальнейшего продвижения итератора
        public bool MoveNext() => position >= 0;

        // Сброс текущей позиции обхода
        public void Reset() => position = collection.getCollection().Count - 1;
    }

    // Странный итератор.
    // Вперед на два, назад на один.
    class StrangeIterator : IEnumerator
    {
        // Поле коллекции, которую будем обходить
        private PizzaCollection collection;

        // Текущая позиция обхода
        private int position = 0;

        // Текущая итерация обхода, для реализации странной методы
        private int iteration = 0;

        // Конструктор итератора принимающий коллекцию
        public StrangeIterator(PizzaCollection collection) => this.collection = collection;

        // Реализация методов IEnumerator
        // Возврат текущего элемента(с наращиванием текущей позиции)
        // Собственно здесь вся суть паттерна,
        // ТО - КАК МЫ ОБХОДИМ.
        object IEnumerator.Current
        {
            get
            {
                var tmpPosition = position;

                if (iteration++ % 2 == 0)
                    position += 2;
                else
                    position--;

                return this.collection.getCollection()[tmpPosition];
            }
        }

        // Метод определенияя возможности дальнейшего продвижения итератора
        public bool MoveNext()
        {
            if (iteration % 2 != 0)
                return position < collection.getCollection().Count;
            else
                return true;
        }

        // Сброс текущей позиции обхода
        public void Reset()
        {
            position = 0;
            iteration = 0;
        }
    }
}
   