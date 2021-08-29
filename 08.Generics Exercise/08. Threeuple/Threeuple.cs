using System;

namespace _08.Threeuple
{
    public class Threeuple<T, V, Z>
    {
        public T Item1 { get; set; }
        public V Item2 { get; set; }
        public Z Item3 { get; set; }

        public Threeuple(T item1, V item2, Z item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }
        public void Print()
        {
            Console.WriteLine($"{this.Item1} -> {this.Item2} -> {this.Item3}");
        }
    }
}