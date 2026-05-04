// implementing a linked list from scratch on my own
using System;

namespace DsaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Goooooo!!!!");

            LinkedStack linkedlist = new LinkedStack();
            linkedlist.Push(10);
            linkedlist.Push(20);
            linkedlist.Push(30);
            linkedlist.Push(40);
            linkedlist.Push(50);
            linkedlist.Push(60);
            linkedlist.Push(70);
            linkedlist.Display();

            linkedlist.Pop();
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
    public class LinkedStack
    {
        private Node _top;

        public void Push(int data)
        {
            Node newNode = new Node(data);

            newNode.Next = _top;
            _top = newNode;
        }

        public int Pop()
        {
            if (_top == null)
            {
                Console.WriteLine("Linked Stack is empty!");
                return -1;
            }
            
            int poppedValue = _top.Data;
            _top = _top.Next;
            Console.WriteLine($"{poppedValue} has been popped!");

            return poppedValue;
            
        }

        public void Display()
        {
            if (_top == null)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            Console.WriteLine("----Top of Stack----");

            Node current = _top;

            while(current != null)
            {
                Console.WriteLine($"\t{current.Data}");
                current = current.Next;
            }
            Console.WriteLine("--------------------");
        }


    }
}