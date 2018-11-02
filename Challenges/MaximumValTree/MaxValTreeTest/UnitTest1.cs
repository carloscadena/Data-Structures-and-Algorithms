using BinaryTree.Classes;
using System;
using System.Collections.Generic;
using Xunit;
using static MaximumValTree.Program;

namespace MaxValTreeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 10)]
        [InlineData(12, 12)]
        [InlineData(150, 150)]
        public void CorrectMaxValIsReturnedTest(int highNode, int expected)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            BinaryTree.Classes.BinaryTree tree = new BinaryTree.Classes.BinaryTree(n1);
            tree.Root.LChild = n2;
            tree.Root.RChild = n3;
            tree.Root.LChild.LChild = n4;
            tree.Root.RChild.RChild = n5;
            tree.Root.RChild.RChild.LChild = n6;
            tree.Root.RChild.RChild.RChild = new Node(highNode);
            List<Node> list = tree.PreOrder(tree.Root);
            Assert.Equal(FindMaxValue(tree), expected);

        }
    }
}
