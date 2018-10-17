using System;
using LinkedList.Classes;

namespace LL_Kth_From_End
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static object KthFromEnd(int k)
        {
            LList ll = MakeList();

            int count = 0;
            Node current = ll.Head;
            Node current2;

            while(current.Next != null)
            {
                if(k == count)
                {
                    current2 = ll.Head;
                }
                if(k > count)
                {
                    current2 = ll.Head.Next;
                }
                current = current.Next;
                count++;
            }

            return ll;
        } 
        public static LList MakeList()
        {
            Node uno = new Node(1);
            Node dos = new Node(2);
            Node tres = new Node(3);
            Node cuatro = new Node(4);
            Node cinco = new Node(5);
            LList ll = new LList(uno);
            ll.Append(dos);
            ll.Append(tres);
            ll.Append(cuatro);
            ll.Append(cinco);

            return ll;
        }
    }
}
