using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyProject2
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            //create queue
            Queue myQueue = new Queue();

            //add elements to the queue
            myQueue.Enqueue("First");
            myQueue.Enqueue(2);
            myQueue.Enqueue("Third");
            myQueue.Enqueue('4');
            myQueue.Enqueue("Five");
            myQueue.Enqueue("Red");

            //displays first entered element
            Console.WriteLine(myQueue.Peek());  //returns First = first entered element displays
            
            //counting element of queue
            Console.WriteLine(myQueue.Count);

            //check element is available or not
            Console.WriteLine(myQueue.Contains(2));

            //remove first element from queue
            Console.WriteLine(myQueue.Dequeue());

            //returns datatype
            Console.WriteLine(myQueue.GetType());

            //clear all element from queue
            //myQueue.Clear();

            //retriving data from queue
            foreach(var i in myQueue)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
