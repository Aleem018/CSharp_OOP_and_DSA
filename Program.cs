using System;

namespace DsaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleStack myStack = new SimpleStack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);
            myStack.Push(60);
            myStack.Push(70);
            myStack.Push(80);
            myStack.Push(90);
            myStack.Push(100);
            myStack.Push(110);

            myStack.Display();

            Console.WriteLine("Popped: " + myStack.Pop());
            Console.WriteLine("Popped: " + myStack.Pop());

            Console.WriteLine("Peek: " + myStack.Peek());
        }
    }
    // My Custom class
    public class SimpleStack
    {
        private int[] _items = new int[10];
        private int _top = -1;

        private void Grow()
        {
            int[] newArray = new int[_items.Length * 2];

            for (int i = 0; i <= _top; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
            Console.WriteLine($"Stack grew to {_items.Length} capacity.");
        }

        public void Push(int data)
        {
            if (_top >=9)
            {
                Grow();
            }
            _items[++_top] = data;
            Console.WriteLine($"Pushed {data} onto the stack.");
        }

        public int Pop()
        {
            if (_top < 0)
            {
                Console.WriteLine("Stack Underflow!");
                return -1;
            }
            return _items[_top--];
        }

        public int Peek()
        {
            if (_top < 0)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            return _items[_top];
        }

        public void Display()
        {
            if (_top < 0)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }

            for (int i = _top; i >= 0; i--)
            {
                Console.WriteLine($"| {_items[i]} |");
            }
            Console.WriteLine("------");
        }
    }
}