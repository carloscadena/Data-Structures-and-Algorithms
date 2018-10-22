using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTest
{
    public class UnitTest1
    {
        Node n1 = new Node(1);
        Node n2 = new Node(2);
        Node n3 = new Node(3);
        Node n4 = new Node(4);
        Node n5 = new Node(5);
        
        [Fact]
        public void PushNodeOntoStackTest()
        {
            Stack stack = new Stack(n1);
            stack.Push(n2);
            stack.Push(n5);
            Assert.Equal(n5, stack.Peek());
        }
        [Fact]
        public void PopNodeOffStackTest()
        {
            Stack stack = new Stack(n4);
            stack.Push(n3);
            stack.Push(n2);
            Assert.Equal(n2, stack.Pop());

        }
        [Fact]
        public void PeekAtTopOfStackTest()
        {
            Stack stack = new Stack(n1);
            stack.Push(n2);
            stack.Push(n4);
            Assert.Equal(n4, stack.Peek());
        }
        [Fact]
        public void EnqueueNodeTest()
        {
            Queue queue = new Queue(n1);
            queue.Enqueue(n2);
            queue.Enqueue(n3);
            queue.Enqueue(n4);
            queue.Enqueue(n5);
            Assert.Equal(n1, queue.Peek());
        }
        [Fact]
        public void DequeueNodeTest()
        {
            Queue queue = new Queue(n5);
            queue.Enqueue(n3);
            queue.Enqueue(n2);
            queue.Enqueue(n1);
            Assert.Equal(n5, queue.Dequeue());

        }
        [Fact]
        public void PeekAtFrontOfQueueTest()
        {
            Queue queue = new Queue(n3);
            queue.Enqueue(n2);
            queue.Enqueue(n1);
            queue.Enqueue(n4);
            Assert.Equal(n3, queue.Peek());
        }
    }
}
