using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        // Peek at Node on the front of queue
        public Node Peek()
        {
            return Front;
        }

        // Enqueue adds new node to end of queue
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        // Dequeue removes node from front and makes next node the front
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
