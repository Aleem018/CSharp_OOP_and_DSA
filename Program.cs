// implementing a linked list queue from scratch on my own
using System;

namespace DsaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Goooooo!!!!");

            LinkedQueue queue = new LinkedQueue();
            queue.Enqueue(10);
            queue.Display();

            queue.Enqueue(20);
            queue.Display();
            
            queue.Enqueue(30);
            queue.Display();

            queue.Dequeue();
            queue.Display();

            queue.Dequeue();
            queue.Display();

            queue.Dequeue();
            queue.Display();

            queue.Dequeue();
        }
    }

    // class for node creation
    public class Node
    {
        public int Data; //This contains the value
        public Node Next; // This contains the memory address of the next node

        public Node(int value)
        {
            Data = value;
            Next = null;
        }
    }

    // class to link the nodes
    public class LinkedQueue
    {
        private Node _head;
        private Node _tail;


        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (_tail == null)
            {
                _tail = newNode;
                _head = newNode;
                return;
            }
            _tail.Next = newNode;
            _tail = newNode;
        }

        public void Dequeue()
        {
            if (_head == null)
            {
                Console.WriteLine("The queue is empty!");
                return;
            }

            _head = _head.Next;

            if (_head == null)
            {
                _tail = null;
            }
        }

        public void Display()
        {
            Node current = _head;

            Console.Write("The state of the queue is: ");
            if (current == null)
                {
                    Console.WriteLine("Empty");
                    return;
                }
            while (current != null)
            {
                Console.Write($"{current.Data} ");
                
                current = current.Next;
            }
            
            Console.WriteLine();
        }
    }
}