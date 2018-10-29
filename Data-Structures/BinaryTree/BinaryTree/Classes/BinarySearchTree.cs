using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            Root = node;
        }

        public int Search(int num)
        {
            Node curr = Root;
            while (curr != null)
            {
                if (curr.Value == num) return curr.Value;
                if (curr.Value < num) curr = curr.LChild;
                if (curr.Value > num) curr = curr.RChild;
            }
            return -1;
        }

        public string Add(Node node)
        {
            Node curr = Root;
            while (curr != null)
            {
                if (node.Value >= curr.Value)
                {
                    if (curr.RChild == null)
                    {
                        curr.RChild = node;
                        return "Node Successfully Added";
                    }
                    else curr = curr.RChild;

                }
                else if (node.Value < curr.Value)
                {
                    if (curr.LChild == null)
                    {
                        curr.LChild = node;
                        return "Node successfully added";
                    }
                    else curr = curr.LChild;
                }
            }
            return "Node succesfully added";            
        }
    }
}
