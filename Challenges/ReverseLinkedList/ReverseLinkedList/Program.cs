using System;
using LinkedList.Classes;

namespace ReverseLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node uno = new Node("Be sure");
            Node dos = new Node("to");
            Node tres = new Node("drink");
            Node cuatro = new Node("your");
            Node cinco = new Node("Ovaltine.");
            LList ll = new LList(uno);
            ll.Add(dos);
            ll.Add(tres);
            ll.Add(cuatro);
            ll.Add(cinco);

            Console.WriteLine("Forward:");
            ll.Print();

            Console.WriteLine("Reverse:");
            LinkedListInReverse(ll).Print();
        }

        public static LList LinkedListInReverse(LList ll)
        {
            Node prev = null;
            Node current = ll.Head;
            Node next = current.Next;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            ll.Head = prev;

            return ll;
        }
    }
}
