using LinkedList.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        /// <summary>
        ///  Hash table
        /// </summary>
        public Node[] table = new Node[1024];

        /// <summary>
        /// Hash the key and map to spot in table
        /// </summary>
        /// <param name="key">The string to get hashed</param>
        /// <returns>returns index in table</returns>
        public int GetHash(string key)
        {
            int hashVal = 0;
            foreach (var letter in key)
            {
                hashVal += (int)letter;
            }
            hashVal = (hashVal * 599) % table.Length;
            return hashVal;
        }

        /// <summary>
        /// Return bool based on if key is in table
        /// </summary>
        /// <param name="key">key to be searched for</param>
        /// <returns>return true or false</returns>
        public bool Contains(string key)
        {
            if (table[GetHash(key)] == null) return false;
            else
            {
                Node current = table[GetHash(key)];
                if (current.Key == key) return true;
                while (current.Next != null)
                {
                    current = current.Next;
                    if (current.Key == key) return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Add new key/value to table
        /// </summary>
        /// <param name="key">key to be hashed</param>
        /// <param name="value">value to be stored with key</param>
        public void Add(string key, object value)
        {
            Node nodeToAdd = new Node(value);
            nodeToAdd.Key = key;
            if (table[GetHash(key)] == null) table[GetHash(key)] = nodeToAdd;
            else
            {
                Node current = table[GetHash(key)];
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(value);
            }
        }

        /// <summary>
        /// Find val in string
        /// </summary>
        /// <param name="key">key to be found</param>
        /// <returns>returns value at hashed key index</returns>
        public object Find(string key)
        {
           
            if (table[GetHash(key)].Key == key) return table[GetHash(key)].Value;
            else
            {
                Node current = table[GetHash(key)];
                while (current.Next != null)
                {
                    if (current.Key == key) return table[GetHash(key)].Value;
                    current = current.Next;
                }
            }
            return "The key does not exist in the table";
        }
    }
}
