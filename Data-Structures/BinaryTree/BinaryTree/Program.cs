using System;
using System.Collections.Generic;
using BinaryTree.Classes;

namespace BinaryTree
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
            Console.WriteLine($"hereee {n2.LChild.Value}");
            List<Node> list = tree.PreOrder(n1);
            foreach (var item in list)
            {
                Console.WriteLine($"foreach {item.Value}");
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i].Value}");
            }
        }
    }
}
