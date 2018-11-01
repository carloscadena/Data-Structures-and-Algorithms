using BinaryTree.Classes;
using System;
using System.Collections.Generic;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n15 = new Node(15);
            BinaryTree.Classes.BinaryTree tree = new BinaryTree.Classes.BinaryTree(n1);
            tree.Root.LChild = n2;
            tree.Root.RChild = n3;
            tree.Root.LChild.LChild = n4;
            tree.Root.RChild.RChild = n5;
            tree.Root.RChild.RChild.LChild = n6;
            tree.Root.RChild.RChild.LChild.RChild = n15;

            FizzBuzzTree(tree, n1);
            
        }

        public static void FizzBuzzTree(BinaryTree.Classes.BinaryTree tree, Node node)
        {
            List<Node> list = tree.PreOrder(node);
            foreach (var item in list)
            {
                if (item.Value % 15 == 0) Console.WriteLine($"{item.Value}: Fizzbuzz");
                else if (item.Value % 3 == 0) Console.WriteLine($"{item.Value}: Fizz");
                else if (item.Value % 5 == 0) Console.WriteLine($"{item.Value}: Buzz");
                else Console.WriteLine($"{item.Value}");
                
            }
        }

    }
}
