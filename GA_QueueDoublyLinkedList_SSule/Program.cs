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
            // Create a stack of integers
            Stack<int> intstack = new Stack<int>();
            // Test the Equeue the method
            intstack.Enqueue(10);
            intstack.Enqueue(20);
            intstack.Enqueue(30);
            intstack.Enqueue(40);
            intstack.Enqueue(50);
            // Test the display method
            intstack.Display();
            // Test the peek method
            Console.WriteLine("The front element is: " + intstack.Peek());
            // Test the Dequeue method
            Console.WriteLine("The dequeue element is: " + intstack.Dequeue());
            Console.WriteLine("The dequeue element is: " + intstack.Dequeue());
            // Test the display method again
            intstack.Display();
            // Test the clear method
            intstack.Clear();
            // Test the isEmpty method
            Console.WriteLine("The stack is empty: " + intstack.IsEmpty());

        }
    }

}
    

