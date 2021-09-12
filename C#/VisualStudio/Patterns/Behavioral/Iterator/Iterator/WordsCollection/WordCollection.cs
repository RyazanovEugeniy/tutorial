using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator.Words
{
    class StraightIterator : IEnumerator
    {
        private WordCollection collection;

        private int position;

        public StraightIterator(WordCollection collection) => this.collection = collection;

        object IEnumerator.Current => collection.getCollection()[position++];

        public bool MoveNext() => position < collection.getCollection().Count;

        public void Reset() => position = 0;
    }

    class WordCollection : IEnumerable
    {
        List<string> collection = new List<string>();

        public List<string> getCollection()
        {
            return collection;
        }

        public void Add(string item)
        {
            this.collection.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            return new StraightIterator(this);
        }
    }
}
   