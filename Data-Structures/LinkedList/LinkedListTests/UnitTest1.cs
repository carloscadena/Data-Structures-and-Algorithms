using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test vanilla add
        /// </summary>
        /// <param name="value">node value to be added</param>
        [Theory]
        [InlineData(6)]
        [InlineData(77)]
        [InlineData(43)]
        public void AddTest(int val)
        {
            LList ll = new LList(new Node(1));
            ll.Add(new Node(val));
            Assert.True((int)ll.Head.Value == val);
        }

        /// <summary>
        /// Test adding node to end of LL
        /// </summary>
        /// <param name="value">value of node to add</param>
        [Theory]
        [InlineData(5)]
        [InlineData(4)]
        [InlineData(1)]
        public void AppendTest(int val)
        {
            LList ll = new LList(new Node(2));
            ll.Add(new Node(12));
            ll.Add(new Node(13));
            ll.Append(new Node(val));
            Assert.True((int)ll.Head.Next.Next.Next.Value == val);
        }

        /// <summary>
        /// Test AddBefore method that adds node before specific node
        /// </summary>
        /// <param name="value">value of node to add</param>
        [Theory]
        [InlineData(18)]
        [InlineData(12)]
        [InlineData(112)]
        public void AddBeforeTest(int val)
        {
            Node nodeToPrecede = new Node(1000);
            LList ll = new LList(nodeToPrecede);
            ll.AddBefore(new Node(val), nodeToPrecede);
            Assert.True((int)ll.Head.Value == val);
        }

        /// <summary>
        /// Test AddAfter method that adds node after specific node
        /// </summary>
        /// <param name="value">value of node to add</param>
        [Theory]
        [InlineData(12)]
        [InlineData(76)]
        [InlineData(11)]
        public void AddAfterTest(int val)
        {
            LList ll = new LList(new Node(100));
            ll.Add(new Node(390));
            Node nodeToFollow = new Node(1);
            ll.Add(nodeToFollow);
            ll.AddAfter(new Node(val), nodeToFollow);
            Assert.True((int)ll.Head.Next.Value == val);
        }



    }
}
