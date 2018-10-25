using System;
using StacksAndQueues.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiBrackValidation("{}(()})");
        }

        public static bool MultiBrackValidation(string brackets)
        {
            char[] charArr = brackets.ToCharArray();
            Stack bracketStack = new Stack(null);
            string openBrackets = "([{";
            string closeBrackets = ")]}";
            for (int i = 0; i < charArr.Length; i++)
            {
                if (openBrackets.Contains(charArr[i]))
                {
                    Console.WriteLine("open brack");
                    bracketStack.Push(new Node(charArr[i]));
                }
                if (closeBrackets.Contains(charArr[i]))
                {
                    string temp = bracketStack.Pop().Value.ToString();
                    if (charArr[i].ToString() == ")")
                    {
                        if (temp != "(") return false;
                    }
                    if (charArr[i].ToString() == "]")
                    {
                        if (temp != "[") return false;
                    }
                    if (charArr[i].ToString() == "}")
                    {
                        if (temp != "{") return false;
                    }
                }

            }
            if (bracketStack.Top == null) return true;
            else return false;

        }
    }
}
