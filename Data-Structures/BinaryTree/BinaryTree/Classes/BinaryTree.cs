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

        List<Node> preList = new List<Node>();
        List<Node> inList = new List<Node>();
        List<Node> postList = new List<Node>();

        public List<Node> PreOrder(Node root)
        {
            preList.Add(root);
            if (root.LChild != null) PreOrder(root.LChild);
            if (root.RChild != null) PreOrder(root.RChild);
            return preList;
        }

        public List<Node> InOrder(Node root)
        {
            if (root.LChild != null) InOrder(root.LChild);
            inList.Add(root);
            if (root.RChild != null) InOrder(root.RChild);
            return inList;
        }

        public List<Node> PostOrder(Node root)
        {
            if (root.LChild != null) InOrder(root.LChild);
            if (root.RChild != null) InOrder(root.RChild);
            postList.Add(root);
            return postList;
        }
    }
}
