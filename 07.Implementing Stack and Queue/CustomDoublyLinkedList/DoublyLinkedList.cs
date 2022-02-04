using System;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private class LinkNode
        {
            public int Value { get; }

            public LinkNode(int value)
            {
                Value = value;
            }

            public LinkNode NextNode { get; set; }

            public LinkNode PreviousNode { get; set; }

        }

        private LinkNode head;
        private LinkNode tail;

        public int Count { get; private set; }
        public void AddFirst(int value)
        {
            LinkNode newHead = new LinkNode(value);

            if (Count == 0)
            {
                this.head = newHead;
                this.tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }
        public void AddLast(int value)
        {
            LinkNode newTail = new LinkNode(value);

            if (Count == 0)
            {
                this.head = newTail;
                this.tail = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }
        public int RemoveFirst()
        {
            CheckIfEmptyThrowException();

            int firstElement = this.head.Value;
            this.head = this.head.NextNode;
            if (this.head == null)
            {
                this.tail = null;
            }
            else
            {
                this.head.PreviousNode = null;
            }

            this.Count--;

            return firstElement;
        }
        public int RemoveLast()
        {
            CheckIfEmptyThrowException();

            int lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;
            if (this.tail == null)
            {
                this.head = null;
            }
            else
            {
                this.tail.NextNode = null;
            }

            this.Count--;

            return lastElement;
        }

        public bool Contains(int value)
        {
            var currentNode = this.head;
            
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return true;
                }
                currentNode = currentNode.NextNode;
            }

            return false;
        }
        public int[] ToArray()
        {
            int[] array = new int[this.Count];

            var currentNode = this.head;
            int counter = 0;

            while (currentNode != null)
            {
                array[counter++] = currentNode.Value;

                currentNode = currentNode.NextNode;
            }

            return array;
        }
        public void Print(Action<int> action)
        {
            LinkNode currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
            }
        }
        private void CheckIfEmptyThrowException()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("DoublyLinkedList is Empty");
            }

        }

    }
}