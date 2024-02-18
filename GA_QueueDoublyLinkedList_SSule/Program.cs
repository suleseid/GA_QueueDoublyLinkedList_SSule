using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_QueueDoublyLinkedList_SSule
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a queue of integers
            Queue<int> intqueue = new Queue<int>();
            // Test the Equeue the method
            intqueue.Enqueue(10);
            intqueue.Enqueue(20);
            intqueue.Enqueue(30);
            intqueue.Enqueue(40);
            intqueue.Enqueue(50);
            // Test the display method
            intqueue.Display();
            // Test the peek method
            Console.WriteLine("The front element is: " + intqueue.Peek());
            // Test the Dequeue method
            Console.WriteLine("The dequeue element is: " + intqueue.Dequeue());
            Console.WriteLine("The dequeue element is: " + intqueue.Dequeue());
            // Test the display method again
            intqueue.Display();
            // Test the clear method
            intqueue.Clear();
            // Test the isEmpty method
            Console.WriteLine("The queue is empty: " + intqueue.IsEmpty());

        }
    }

}
    

