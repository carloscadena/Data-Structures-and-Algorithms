using StacksAndQueues.Classes;
using System;

namespace EeneyMeenyMineyMoe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "Carlos", "Jimmy", "Jeff", "Tre", "Aaron", "Kris" };
            EeneyMeenyMineyMoeMethod(names, 3);
        }

        public static string EeneyMeenyMineyMoeMethod(string[] arr, int n)
        {
            Queue q = new Queue(new Node(arr[0]));
            for (int i = 1; i < arr.Length; i++)
            {
                q.Enqueue(new Node(arr[i]));
            }
            while (q.Front != q.Rear)
            {
             
                int count = 1;
                while (count < n)
                {
                    Node temp = q.Dequeue();
                    q.Enqueue(temp);
                    count++;
                }
                Console.WriteLine($"{(string)q.Front.Value} is out!");
                q.Dequeue();
            }
            Console.WriteLine($"{(string)q.Front.Value} is the last man standing!");
            return (string)q.Front.Value;

        }
    }
}
