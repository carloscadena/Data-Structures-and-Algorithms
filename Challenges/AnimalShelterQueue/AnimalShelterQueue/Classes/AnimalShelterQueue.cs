using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace AnimalShelterQueue.Classes
{
    public class AnimalShelterQueue
    {
        Queue q = new Queue(new Node("marker"));

        public void Enqueue(Node animal)
        {
            q.Enqueue(animal);
        }
        public void Dequeue(string pref)
        {
            q.Enqueue(q.Dequeue());
            while ((string)q.Front.Value != "marker")
            {
                if(q.Front.Value == )
                {

                }
                else
                {

                }
            }
        }
    }
}
