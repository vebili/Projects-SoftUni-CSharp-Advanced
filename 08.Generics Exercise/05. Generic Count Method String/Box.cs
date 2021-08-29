using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<TItem>
    where TItem: IComparable<TItem>
    {
        private List<TItem> boxItems;

        public Box()
        {
            boxItems = new List<TItem>();
        }

        public void Add(TItem item)
        {
            boxItems.Add(item);
        }

        public void Swap(int indexItem1, int indexItem2)
        {
            if (indexItem1 < 0
                || indexItem1 >= boxItems.Count
                || indexItem2 < 0
                || indexItem2 >= boxItems.Count)
            {
                return;
            }

            TItem temp = boxItems[indexItem1];
            boxItems[indexItem1] = boxItems[indexItem2];
            boxItems[indexItem2] = temp;
        }

        public int CountGreater(TItem item)
        {
            int count = 0;
            foreach (var boxItem in boxItems)
            {
                if (boxItem.CompareTo(item) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var boxItem in boxItems)
            {
                sb.AppendLine($"{boxItem.GetType().FullName}: {boxItem}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}