using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _01.Box
{
    public class Box<T>
    {
        private List<T> boxItems;

        public Box()
        {
            this.boxItems = new List<T>();
        }

        public int Count => this.boxItems.Count;

        public void Add(T element)
        {
            boxItems.Add(element);
        }

        public T Remove()
        {
            T lastElement = boxItems.Last();
            boxItems.RemoveAt(Count - 1);

            return lastElement;

        }
    }
}
