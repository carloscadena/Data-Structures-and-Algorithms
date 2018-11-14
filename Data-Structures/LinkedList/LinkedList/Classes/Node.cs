using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Node
    {
        /// <summary>
        /// the value contained in the node
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// the pointer to the next node
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Key stored in case of collisions in hash table
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// constructor for our nodes
        /// </summary>
        /// <param name="value">the value contained in the node</param>
        public Node(object value)
        {
            Value = value;
        }
    }
}