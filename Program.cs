using System;
using System.Xml;

namespace DsaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddFirst(30);

            list.Display();
        }
    }

    // My Custom class
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int value)
        {
            Data = value;
            Next = null;
        }
    }

    public class LinkedList
    {
        private Node _head;
        private Node _tail;

        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            // if the list is empty
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            } else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }

            
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data); // creating a new node object
            newNode.Next = _head;
            _head = newNode;

            if (_tail == null)
            {
                _tail = _head;
            }
        }

        public void Display()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("NULL");
        }

    }

}