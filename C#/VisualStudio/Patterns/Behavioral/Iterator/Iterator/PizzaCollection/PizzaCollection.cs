using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator.Pizzas
{
    class Pizza
    {
        public string name { get; }
        public float weight { get; }
        public float price { get; }

        public Pizza(string name, float weight, float price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        public override string ToString()
        {
            return name;
        }

    }
    class StraightIterator : IEnumerator
    {
        private PizzaCollection collection;

        private int position = 0;

        public StraightIterator(PizzaCollection collection) => this.collection = collection;

        object IEnumerator.Current => this.collection.getCollection()[position++];

        public bool MoveNext() => position < collection.getCollection().Count;

        public void Reset() => position = 0;
    }

    class ReverseIterator : IEnumerator
    {
        private PizzaCollection collection;

        private int position;

        public ReverseIterator(PizzaCollection collection)
        {
            position = collection.getCollection().Count - 1;

            this.collection = collection;
        }

        object IEnumerator.Current => this.collection.getCollection()[position--];

        public bool MoveNext() => position >= 0;

        public void Reset() => position = collection.getCollection().Count - 1;
    }

    class StrangeIterator : IEnumerator
    {
        private PizzaCollection collection;

        private int position = 0;

        public StrangeIterator(PizzaCollection collection) => this.collection = collection;

        object IEnumerator.Current
        {
            get
            {
                var tmpPosition = position;
                if (position % 2 == 0)
                    position += 2;
                else
                    position -= 1;

                return this.collection.getCollection()[tmpPosition];
            }
        }
        public bool MoveNext()
        {
            if (position % 2 == 0)
                return position - 1 < collection.getCollection().Count;
            else
                return true;
        }

        public void Reset() => position = 0;
    }

    class PizzaCollection : IEnumerable
    {
        List<Pizza> collection = new List<Pizza>();

        public List<Pizza> getCollection() => collection;

        public void Add(Pizza pizza)
        {
            this.collection.Add(pizza);
        }
        public void Remove(Pizza pizza)
        {
            this.collection.Remove(pizza);
        }

        public IEnumerator GetEnumerator()
        {
            return new StrangeIterator(this);
        }
    }
}
   