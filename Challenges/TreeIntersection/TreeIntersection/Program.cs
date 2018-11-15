using BinaryTree.Classes;
using Hashtables.Classes;
using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            n1.LChild = n2;
            n1.RChild = n3;
            n2.LChild = n4;
            n3.RChild = n5;
            BinaryTree.Classes.BinaryTree t1 = new BinaryTree.Classes.BinaryTree(n1);

            Node n4_2 = new Node(4);
            Node n5_2 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);
            Node n8 = new Node(8);
            n4_2.LChild = n5_2;
            n4_2.RChild = n6;
            n5_2.LChild = n7;
            n6.RChild = n8;
            BinaryTree.Classes.BinaryTree t2 = new BinaryTree.Classes.BinaryTree(n4_2);

            List<int> commonNums = TreeIntersections(t1, t2);
            foreach (int num in commonNums)
            {
                Console.WriteLine($"{num}");
            }
        }

        /// <summary>
        /// Returns list of common values in two Binary Trees
        /// </summary>
        /// <param name="uno">binary tree 1</param>
        /// <param name="dos">binary tree 2</param>
        /// <returns>list of common vals</returns>
        static public List<int> TreeIntersections(BinaryTree.Classes.BinaryTree uno, BinaryTree.Classes.BinaryTree dos)
        {
            List<int> commonVals = new List<int>();
            Hashtable table = new Hashtable();

            foreach (Node node in uno.PreOrder(uno.Root))
            {
                table.Add(node.Value.ToString(), node.Value);
            }

            foreach (Node node in dos.PreOrder(dos.Root))
            {
                if (table.Contains(node.Value.ToString()))
                {
                    commonVals.Add(node.Value);
                }
            }

            return commonVals;
        }
    }
}
