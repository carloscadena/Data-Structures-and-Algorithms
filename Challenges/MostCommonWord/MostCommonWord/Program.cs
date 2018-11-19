using Hashtables.Classes;
using LinkedList.Classes;
using System;

namespace MostCommonWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"{FindMostCommonWord("No Try not Do or do not There is no try")}");
            ;
        }

        public static string FindMostCommonWord(string str)
        {
            Node highVal = new Node(0);
            string highWord = "";
            Hashtable table = new Hashtable();
            string[] strArr = str.Split(" ");

            foreach (var item in strArr)
            {
                if (table.Contains(item))
                {
                    int num = (int)table.Find(item);
                    if ((int)highVal.Value < num + 1)
                    {
                        highVal.Value = num + 1;
                        table.Add(item.ToLower(), num += 1);
                        highWord = item.ToLower();
                    }
                    else
                    {
                        table.Add(item.ToLower(), num += 1);
                    }
                    
                } 
                else table.Add(item.ToLower(), 1);

            }
            return highWord;
        }
    
    }
}
