using System.Collections.Generic;
using System.Text;

namespace _02._Generic_Box_of_Integer
{
    public class Box<TItem>
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