using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_QueueDoublyLinkedList_SSule
{
    internal class Queue<T>
    {
        // A nested class for individual nodes
        public class QueueNode<T>
        {
            // The data stored in the node
            public T Data { get; set; }
            // The link to the next node
            public QueueNode<T> Next { get; set; }
            public QueueNode<T> Previous { get; set; }

            // The constructor to initialize the node
            public QueueNode(T data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }
        }
        // A field for the front and rear node
        private QueueNode<T> front;
        private QueueNode<T> rear;
        // A public property for accessing the number of elements
        public int Count { get; private set; }

        // A constructor to initialize the Queue
        public Queue()
        {
            front = null;
            rear = null;
            Count = 0;
        }
        // A method to add an element to the top of the queue
        public void Enqueue(T value)
        {
            // Create a new node with the given value
            QueueNode<T> newNode = new QueueNode<T>(value);
            // Lets link the new node to the new front and rear
            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {// Make the new node the new front and rear node
                rear.Next = newNode;
                newNode.Previous = rear;
                rear = newNode;
            }
            // Increment the count
            Count++;
        }
        // A method to remove and return the element from the top of the queue
        public T Dequeue()
        {
            // Check if the front stack is empty
            if (front == null)
            {
                // Throw an exception
                throw new InvalidOperationException("The stack is empty.");
            }
            // Store the data of the front node
            T data = front.Data;
            // Move the top node to the next node
            front = front.Next;
            if (front != null)
            {
                front.Previous = null;
            }
            else
            {
                rear = null;
            }
            // Decrement the count
            Count--;
            // Return the data
            return data;
        }
        // A method to return the element at the top of the stack without removing it
        public T Peek()
        {
            // Check if the stack is empty
            if (front == null)
            {
                // Throw an exception
                throw new InvalidOperationException("The stack is empty.");
            }
            // Return the data of the top node
            return front.Data;
        }
        // A method to check if the stack is empty
        public bool IsEmpty()
        {
            // Return true if the front node is null, false otherwise
            return front == null;
        }
        // A method to empty the stack
        public void Clear()
        {
            // Set the front and rear node to null
            front = null;
            rear = null;
            // Set the count to zero
            Count = 0;
        }
        // A method to display the elements in the stack
        public void Display()
        {
            // Check if the stack is empty
            if (IsEmpty())
            {
                // Print a message
                Console.WriteLine("The queue is empty.");
            }
            else
            {
                // Create a temporary node to traverse the stack
                QueueNode<T> temp = front;
                // Print a message
                Console.WriteLine("The elements in the queue are:");
                // Loop until the end of the stack
                while (temp != null)
                {
                    // Print the data of the current node
                    Console.WriteLine(temp.Data);
                    // Move to the next node
                    temp = temp.Next;
                }
            }
        }
    }
}
