using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace QueueWithStacks.Classes
{
    public class StacksQueue
    {
        public Node Top { get; set; }

        Stack stack1 = new Stack(null);
        Stack stack2 = new Stack(null);

        // require a node at instantiation
        public StacksQueue(Node node)
        {
            Top = node;
            stack1.Push(node);
        }

        /// <summary>
        /// Add a node to the queue
        /// </summary>
        /// <param name="node">Node to be added</param>
        public void Enqueue(Node node)
        {
            if (stack1.Top == null) stack1.Push(node);
            else
            {
                while(stack1.Top != null)
                {
                    stack2.Push(stack1.Pop());
                }

                stack1.Push(node);

                while (stack2.Top != null)
                {
                    stack1.Push(stack2.Pop());
                }
            }
        }

        // Dequeue removes node from front and makes next node the front
        public Node Dequeue()
        {
            return stack1.Pop();
        }
    }
}
