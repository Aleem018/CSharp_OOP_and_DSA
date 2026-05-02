// implementing a linked list from scratch on my own
using System;

namespace DsaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Goooooo!!!!");

            LinkedList linkedlist = new LinkedList();
            linkedlist.AddToEnd(10);
            linkedlist.AddToEnd(20);
            linkedlist.AddToEnd(30);
            linkedlist.AddToEnd(40);

            linkedlist.AddToBeginning(0);
            linkedlist.AddToBeginning(-10);

            linkedlist.Display();
            Console.WriteLine();
            
            linkedlist.RemoveFirst();

            linkedlist.Display();
            Console.WriteLine();

            linkedlist.RemoveLast();
            linkedlist.Display();
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
    public class LinkedList
    {
        private Node _head; // holds the memory address of the first node
        private Node _tail; // holds the memory address of the last node

        public void AddToEnd(int data) // method to add a node to the list
        {
            Node newNode = new Node(data);

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

        public void AddToBeginning(int data)
        {
            Node newNode = new Node(data);

            newNode.Next = _head;
            _head = newNode;

            if (_tail == null)
            {
                _tail = newNode;
            }
        }

        public void Display()
        {
            Node current = _head;

            while (current != null)
            {
                Console.WriteLine($"{current.Data}");
                current = current.Next;
            }
            
            Console.WriteLine("NULL");
            
        }

        public void RemoveFirst()
        {
            if (_head != null)
            {
                _head = _head.Next;
                if (_head == null)
                {
                    _tail = null;
                }
            } else
            {
                Console.WriteLine("List already Empty");
            }
        }

        public void RemoveLast()
        {
            Node pointer = _head;

            if (pointer == null)
            {
                Console.WriteLine("This list is already empty");
            } else if (pointer.Next == null)
            {
                _head = null;
                _tail = null;
                Console.WriteLine("Cleared.");
            } else
            {
                while (pointer.Next.Next != null) // pointer.Next != _tail also works
                {
                    pointer = pointer.Next;
                }
                pointer.Next = null;
                _tail = pointer;
                Console.WriteLine("Last node removed succesfully!");
            }


        }


    }
}