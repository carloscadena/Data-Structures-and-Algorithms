using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node node)
        {
            Root = node;
        }

        public List<Node> PreOrder(Node root)
        {
            List<Node> list = new List<Node>();
            list.Add(root);
            if (root.LChild != null) PreOrder(root.LChild);
            if (root.RChild != null) PreOrder(root.RChild);
            return list;
        }

        public List<Node> InOrder(Node root)
        {
            List<Node> list = new List<Node>();
            if (root.LChild != null) InOrder(root.LChild);
            list.Add(root);
            if (root.RChild != null) InOrder(root.RChild);
            return list;
        }

        public List<Node> PostOrder(Node root)
        {
            List<Node> list = new List<Node>();
            if (root.LChild != null) InOrder(root.LChild);
            if (root.RChild != null) InOrder(root.RChild);
            list.Add(root);
            return list;
        }

      


    }
}
