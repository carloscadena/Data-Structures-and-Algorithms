using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 23, 44, 55, 12, 21, 5 };
            ArrayShift(testArr, 10);
        }

        static int[] ArrayShift(int[] arr, int num)
        {
            int[] newArr = new int[arr.Length + 1];
            double middle = Math.Ceiling((double) arr.Length / 2);
            for(int i = 0; i < newArr.Length; i++)
            {
                if(i < middle)
                {
                    newArr[i] = arr[i];
                }
                else if (i == middle)
                {
                    newArr[i] = num;
                }
                else
                {
                    newArr[i] = arr[i - 1];
                }
            }
            return newArr;
        }
    }
}
