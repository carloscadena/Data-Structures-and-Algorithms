using BinaryTree.Classes;
using System;
using System.Collections.Generic;
using Xunit;
using static TreeIntersection.Program;

namespace TreeIntersectionTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that when passed two Binary Trees, the common values are returned
        /// </summary>
        [Fact]
        public void CorrectDuplicateNumbersAreReturnedTest()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            n1.LChild = n2;
            n1.RChild = n3;
            n2.LChild = n4;
            n3.RChild = n5;
            n5.LChild = n6;
            BinaryTree.Classes.BinaryTree t1 = new BinaryTree.Classes.BinaryTree(n1);

            Node n4_2 = new Node(4);
            Node n5_2 = new Node(5);
            Node n6_2 = new Node(6);
            Node n7 = new Node(7);
            Node n8 = new Node(8);
            Node n9 = new Node(9);
            n4_2.LChild = n5_2;
            n4_2.RChild = n6;
            n5_2.LChild = n7;
            n6.RChild = n8;
            n8.LChild = n9;
            BinaryTree.Classes.BinaryTree t2 = new BinaryTree.Classes.BinaryTree(n4_2);

            List<int> commonNums = TreeIntersections(t1, t2);

            Assert.True(TreeIntersections(t1, t2)[0] == 4);
            Assert.True(TreeIntersections(t1, t2)[1] == 5);
            Assert.True(TreeIntersections(t1, t2)[2] == 6);
        }
    }
}
