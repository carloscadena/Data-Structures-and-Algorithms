using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        //Peek at Node on top of Stack
        public Node Peek()
        {
            return Top;
        }

        //Pop and return Top node from stack
        public Node Pop()
        {
            Node temp = Peek();
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }
        //Push new node onto stack and make it top
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
