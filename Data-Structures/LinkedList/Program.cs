using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Node node1 = new Node(7);
            Node node2 = new Node("cat");
            Node node3 = new Node(234);

            LList myAwesomeList = new LList(node1);
            myAwesomeList.Append(node2);

            myAwesomeList.Print();
        }
    }
}
