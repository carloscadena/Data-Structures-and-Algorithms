using BinaryTree.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace TreeTest
{
    public class UnitTest1
    {
        Node n1 = new Node(1);
        Node n2 = new Node(2);
        Node n3 = new Node(3);
        Node n4 = new Node(4);
        Node n5 = new Node(5);
        Node n6 = new Node(6);

        [Fact]
        public void PreOrderTest()
        {
            BinaryTree.Classes.BinaryTree tree = new BinaryTree.Classes.BinaryTree(n1);
            tree.Root.LChild = n2;
            tree.Root.RChild = n3;
            tree.Root.LChild.LChild = n4;
            tree.Root.RChild.RChild = n5;
            tree.Root.RChild.RChild.LChild = n6;

            List<Node> list = tree.PreOrder(n1);

            Assert.True(list[1].Value == 2);
        }

        //[Fact]
        //public void InOrderTest()
        //{

        //}

        //[Fact]
        //public void PostOrderTest()
        //{

      
    }
}
