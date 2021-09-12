using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class StraightIterator : IEnumerator
    {
        private WordsCollection collection;

        private int position;

        public StraightIterator(WordsCollection collection) => this.collection = collection;

        object IEnumerator.Current
        {
            get
            {
                Console.WriteLine("position == " + position);
                Console.WriteLine("this.collection.getItems()[position] == " + this.collection.getItems()[position]);

                return this.collection.getItems()[position++];
            }
        }

        public bool MoveNext() => position < collection.getItems().Count;

        public void Reset() => position = 0;
    }

    class WordsCollection : IEnumerable
    {
        List<string> collection = new List<string>();

        public List<string> getItems()
        {
            return collection;
        }

        public void AddItem(string item)
        {
            this.collection.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            return new StraightIterator(this);
        }
    }
}
   