using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(FibonacciSeq(i));
            }
        }
        public static int FibonacciSeq(int n)
        {
            int prev1 = 0;
            int prev2 = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = prev1;
                prev1 = prev2;
                prev2 = temp + prev2;
            }
            return prev1;
        }
    }
}
