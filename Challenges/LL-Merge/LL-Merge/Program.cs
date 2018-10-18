using System;
using LinkedList.Classes;

namespace LL_Merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static object Merge(LList ll1, LList ll2)
        {
            Node current = ll1.Head;
            Node current2 = ll2.Head;

            while(current.Next != null && current2.Next != null)
            {
                Node temp = current.Next;
                Node temp2 = current2.Next;
                current.Next = current2;
                current2.Next = temp;
                current = temp;
                current2 = temp2;
            }
            if(current.Next == null)
            {
                current.Next = current2;
            }
            else
            {
                current2.Next = current;
            }

            return ll1.Head;
        }
    }
}
