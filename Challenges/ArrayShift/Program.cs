using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayShift();
        }

        static void ArrayShift(int[] arr, int num)
        {
            int[] newArr = new int[arr.Length + 1];
            double middle = Math.Ceiling(arr.Length / 2);
            for(int i = 0; i < newArr.Length; i++)
            {
                if(i < middle)
                {
                    newArr[i] == arr[i];
                }
                else if (i == middle)
                {
                    newArr[i] == num;
                }
                else
                {
                    newArr[i] == arr[i - 1];
                }
            }
            return newArr;
        }
    }
}
