using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList();

            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddFirst(2);
            doublyLinkedList.AddFirst(3);

            doublyLinkedList.Print(Console.WriteLine);
        }
    }
}
