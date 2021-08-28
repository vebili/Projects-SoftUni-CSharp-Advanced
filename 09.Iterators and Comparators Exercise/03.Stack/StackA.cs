using System;
using System.Collections;
using System.Collections.Generic;

namespace _03.Stack
{
    public class StackA<T> : IEnumerable<T>
    {
        private int sizeOfData = 16;
        private T[] data;
        private int index;

        public StackA()
        {
            this.data = new T[sizeOfData];
            index = -1;
        }

        public void Push(T element)
        {
            if (index + 1 >= this.data.Length)
            {
                Resize();
            }

            index++;
            this.data[index] = element;
        }

        public void Pop()
        {
            if (this.data.Length == 0 || index < 0)
            {
                Console.WriteLine("No elements");
                return;
            }

            this.data[index] = default(T);
            index--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = index; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        private void Resize()
        {
            T[] newData = new T[this.data.Length * 2];
            Array.Copy(this.data, newData, newData.Length);
            this.data = newData;
        }

    }    
}