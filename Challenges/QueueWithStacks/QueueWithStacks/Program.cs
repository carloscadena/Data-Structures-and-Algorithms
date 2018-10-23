using System;
using QueueWithStacks.Classes;
using StacksAndQueues.Classes;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            StacksQueue sq = new StacksQueue(n1);
            sq.Enqueue(n2);
            sq.Enqueue(n3);
            sq.Enqueue(n4);
            Console.WriteLine($"{sq.Dequeue().Value}");
            Console.WriteLine($"{sq.Dequeue().Value}");
            Console.WriteLine($"{sq.Dequeue().Value}");
            Console.WriteLine($"{sq.Dequeue().Value}");
        }
    }
}
