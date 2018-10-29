using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node RChild { get; set; }
        public Node LChild { get; set; }

        public Node(int value)
        {
            Value = value;
        }

    }
}
