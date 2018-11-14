using Hashtables.Classes;
using LinkedList.Classes;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hashtable table = new Hashtable();
            table.Add("cat", "stack");
            table.Add("1990", "waterfalls");
            table.Add("clocks", "umbrella");
            // tac should collide with cat
            table.Add("act", "one billion dollars");
            Console.WriteLine($"{table.Contains("cat")}");
            //Console.WriteLine($"1990 hash: {table.GetHash("1990")}");
            //Console.WriteLine($"1990 hash: {table.table[437].Key.GetType()}");
            Console.WriteLine($"{table.Contains("1990")}");
            Console.WriteLine($"{table.Contains("clocks")}");
            Console.WriteLine($"{table.Contains("act")}");
            Console.WriteLine($"{table.Find("act")}");
        }

        
    }
}
