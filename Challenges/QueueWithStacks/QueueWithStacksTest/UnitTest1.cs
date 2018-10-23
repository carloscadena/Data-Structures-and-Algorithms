using System;
using Xunit;
using StacksAndQueues.Classes;
using QueueWithStacks.Classes;

namespace QueueWithStacksTest
{
    public class UnitTest1
    {
        Node n1 = new Node(1);
        Node n2 = new Node(2);
        Node n3 = new Node(3);
        Node n4 = new Node(4);

        [Fact]
        public void CorrectlyEnqueueWithTwoNodesTest()
        {
            StacksQueue sq = new StacksQueue(n1);
            sq.Enqueue(n2);
            sq.Dequeue();
            Assert.Equal(n2.Value, sq.Dequeue().Value);
        }

        [Fact]
        public void CorrectlyEnqueueWithThreeNodesTest()
        {
            StacksQueue sq = new StacksQueue(n1);
            sq.Enqueue(n2);
            sq.Enqueue(n3);
            sq.Dequeue();
            sq.Dequeue();
            Assert.Equal(n3.Value, sq.Dequeue().Value);
        }

        [Fact]
        public void CorrectlyEnqueueFourNodesTest()
        {
            StacksQueue sq = new StacksQueue(n1);
            sq.Enqueue(n2);
            sq.Enqueue(n3);
            sq.Enqueue(n4);
            sq.Dequeue();
            sq.Dequeue();
            sq.Dequeue();
            Assert.Equal(n4.Value, sq.Dequeue().Value);
        }

        [Fact]
        public void CorrectlyDequeueWithTwoNodesTest()
        {
            StacksQueue sq = new StacksQueue(n1);
            sq.Enqueue(n2);
            sq.Dequeue();
            Assert.Equal(n2.Value, sq.Dequeue().Value);
        }

        [Fact]
        public void CorrectlyDequeueFourNodesTest()
        {
            StacksQueue sq = new StacksQueue(n1);
            sq.Enqueue(n2);
            sq.Enqueue(n3);
            sq.Enqueue(n4);
            sq.Dequeue();
            sq.Dequeue();
            sq.Dequeue();
            Assert.Equal(n4.Value, sq.Dequeue().Value);
        }

        [Fact]
        public void CorrectlyDequeueNodeQueueWasInitializedWithTest()
        {
            StacksQueue sq = new StacksQueue(n1);
            Assert.Equal(n1.Value, sq.Dequeue().Value);
        }
    }
}
