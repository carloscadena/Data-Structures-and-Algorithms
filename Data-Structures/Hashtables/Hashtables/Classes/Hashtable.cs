using LinkedList.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        Node[] table = new Node[1024];

        public int GetHash(string key)
        {
            int hashVal = 0;
            foreach (var letter in key)
            {
                hashVal += (int)letter;
            }
            Console.WriteLine($"{hashVal}");
            hashVal = (hashVal * 599) % table.Length;
            return hashVal;
        }

        public bool Contains(string key)
        {
            if (table[GetHash(key)].Value == null) return false;
            return true;
        }

        static void Add(string key, object value)
        {

        }

        static Node Find(string key)
        {

        }
    }
}
