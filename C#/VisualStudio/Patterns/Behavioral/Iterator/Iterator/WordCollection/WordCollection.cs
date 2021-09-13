using System.Collections;
using System.Collections.Generic;

namespace Iterator.Words
{
    // Итератор прямого обхода, реализующий интерфейс IEnumerator
    class StraightIterator : IEnumerator
    {
        // Поле коллекции, которую будем обходить
        private WordCollection collection;

        // Текущая позиция обхода
        private int position;

        // Конструктор итератора принимающий коллекцию
        public StraightIterator(WordCollection collection) => this.collection = collection;

        // Реализация методов IEnumerator
        // Возврат текущего элемента(с наращиванием текущей позиции)
        object IEnumerator.Current => collection.getCollection()[position++];

        // Метод определенияя возможности дальнейшего продвижения итератора
        public bool MoveNext() => position < collection.getCollection().Count;

        // Сброс текущей позиции обхода
        public void Reset() => position = 0;
    }

    // Коллекция слов, реализующая интерфейс IEnumerable
    class WordCollection : IEnumerable
    {
        // Поле нашего списка слов
        private List<string> collection = new List<string>();

        // Возвращаем коллекцию
        public List<string> getCollection()
        {
            return collection;
        }

        // Добавляем элемент
        public void Add(string item)
        {
            this.collection.Add(item);
        }

        // Возвращаем итератор
        public IEnumerator GetEnumerator()
        {
            return new StraightIterator(this);
        }
    }
}
   