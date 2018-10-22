using System;
using Xunit;
using LinkedList.Classes;
using static ReverseLinkedList.Program;

namespace ReverseLLTest
{
    public class UnitTest1
    {
        Node uno = new Node("Be sure");
        Node dos = new Node("to");
        Node tres = new Node("drink");
        Node cuatro = new Node("your");
        Node cinco = new Node("Ovaltine.");
        
        [Fact]
        public void OriginalHeadTest()
        {
            LList ll = new LList(uno);
            ll.Add(dos);
            ll.Add(tres);
            ll.Add(cuatro);
            ll.Add(cinco);
            Assert.True((string)ll.Head.Value == "Ovaltine.");
        }
        [Fact]
        public void ReverseHeadCheckTest()
        {
            LList ll = new LList(uno);
            ll.Add(dos);
            ll.Add(tres);
            ll.Add(cuatro);
            ll.Add(cinco);
            LinkedListInReverse(ll);
            Assert.True((string)ll.Head.Value == "Be sure");
        }
        [Fact]
        public void ConfirmCorrectSecondNodeInReverseTest()
        {
            LList ll = new LList(uno);
            ll.Add(dos);
            ll.Add(tres);
            ll.Add(cuatro);
            ll.Add(cinco);
            LinkedListInReverse(ll);
            Assert.True((string)ll.Head.Next.Value == "to");
        }
    }
}
