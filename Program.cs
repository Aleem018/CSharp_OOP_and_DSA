// implementing a doubly linked list from scratch
using System;

namespace DsaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Gooooo!");

            DoublyLinkedList Doubly = new DoublyLinkedList();

            Doubly.AddLast(20);
            Doubly.AddLast(30);
            Doubly.AddLast(40);
            Doubly.Display();

            Doubly.AddToBeginning(10);
            Doubly.Display();

            Doubly.RemoveLast();
            Doubly.Display();

            Doubly.RemoveFromBeginning();
            Doubly.Display();

            Doubly.InsertAfter(20, 25);
            Doubly.Display();


        }
    }

    // class for node creation
    public class Node
    {
        public int Data; //This contains the value
        public Node Next; // This contains the memory address of the next node
        public Node Prev;

        public Node(int value)
        {
            Data = value;
            Next = null;
            Prev = null;
        }
    }

    // class to link the nodes
    public class DoublyLinkedList
    {
        private Node _head;
        private Node _tail;

        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Prev = _tail;
                _tail = newNode;
            }
        }

        public void RemoveLast()
        {
            if (_head == null)
            {
                Console.WriteLine("The list is empty!");
            }
            else if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _tail = _tail.Prev;
                _tail.Next = null;
            }
        }

        public void AddToBeginning(int data)
        {
            Node newNode = new Node(data);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _head.Prev = newNode;
                newNode.Next = _head;
                _head = newNode;
            }
        }

        public void RemoveFromBeginning()
        {
            if (_head == null)
            {
                Console.WriteLine("The list is empty!");

            }
            else if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = _head.Next;
                _head.Prev = null;
            }

        }

        // To insert a node in the middle of the list...
        public void InsertAfter(int targetData, int data)
        {
            Node current = _head;
            while (current != null)
            {
                if (current.Data == targetData)
                {
                    Node newNode = new Node(data);

                    newNode.Next = current.Next;
                    newNode.Prev = current;

                    if (current.Next == null)
                    {
                        current.Next = newNode;
                        _tail = newNode;
                        return;
                    }
                    else
                    {
                        current.Next.Prev = newNode;
                    }

                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            return;

        }

        // To find the position where to insert the node



        public void Display()
        {
            Node current = _head;

            Console.Write("The state of the doubly linkedlist is: ");
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