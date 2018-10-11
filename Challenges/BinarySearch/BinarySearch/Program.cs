using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //BinarySearch();
        }
        public static int BinarySearch(int[] arr, int num)
        {
            int first = 0;
            int last = arr.Length - 1;
            while(first <= last)
            {
            int middle = (first + last) / 2; ;
                if (arr[middle] == num)
                {
                    return middle;
                }
                else if (arr[middle] > num)
                {
                    last = middle - 1;
                }
                else if (arr[middle] < num)
                {
                    first = middle + 1;
                }
            }
            return -1;
        }
    }
}
