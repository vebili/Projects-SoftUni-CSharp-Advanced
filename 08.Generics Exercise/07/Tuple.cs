using System;

namespace _07.Tuple
{
    public class Tuple<T, V>
    {
        private T item1;
        private V item2;

        public Tuple(T item1, V item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public void Print()
        {
            Console.WriteLine($"{this.item1} -> {this.item2}");
        }
    }
}