using BinaryTree.Classes;
using System;
using System.Collections.Generic;

namespace MaximumValTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

            FindMaxValue(tree);
        }

        static int FindMaxValue(BinaryTree.Classes.BinaryTree tree)
        {
            int temp = 0;

            List<Node> list = tree.PreOrder(tree.Root);

            foreach (var item in list)
            {
                if (item.Value > temp) temp = item.Value;

            }
            Console.WriteLine($"The max Value in this tree is {temp}");
            return temp;
        }
    }
}
