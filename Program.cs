// implementing a binary search tree
using System;

namespace DsaLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree BST = new BinarySearchTree();

            BST.InsertNode(2);
            BST.InsertNode(4);
            BST.InsertNode(8);
            BST.InsertNode(6);
            BST.InsertNode(14);
            BST.InsertNode(12);
            BST.InsertNode(10);
            BST.InsertNode(16);

            BST.Display();

            Console.WriteLine(BST.Contains(14));
            Console.WriteLine(BST.Contains(24));
            Console.WriteLine(BST.Contains(4));

            BST.Delete(14);

            BST.Display();
        }
    }

    // class for node creation
    public class TreeNode
    {
        public int Data; //This contains the value
        public TreeNode Left; // This contains the memory address of the next node
        public TreeNode Right;

        public TreeNode(int value)
        {
            Data = value;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        public TreeNode _root;

        public void InsertNode(int data)
        {
            TreeNode newNode = new TreeNode(data);

            if (_root == null)
            {
                _root = newNode;
                return;
            }

            TreeNode current = _root;

            while (current != null)
            {
                if (newNode.Data < current.Data)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        return;
                    } else
                    {
                        current = current.Left;
                    }
                } else if (newNode.Data > current.Data)
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        return;
                    } else
                    {
                        current = current.Right;
                    }
                } else
                {
                    Console.WriteLine($"{data} is already in the tree");
                    return;
                }

            }
        }

        public void Display()
        {
            Console.Write("Tree values in order: ");
            PrintInOrder(_root);
            Console.WriteLine();
        }

        private void PrintInOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            PrintInOrder(node.Left);
            
            Console.Write($"{node.Data} ");

            PrintInOrder(node.Right);
        }

        // a method to search for a particular number in the BST
        public bool Contains(int data)
        {
            TreeNode current = _root;

            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                } else if (current.Data < data)
                {
                    current = current.Right;
                } else if (current.Data > data)
                {
                    current = current.Left;
                }
            }
            return false;
            
        }

        public void Delete(int data)
        {
            _root = DeleteNode(_root, data);

        }

        private TreeNode DeleteNode(TreeNode current, int target)
        {
            if (current == null)
            {
                return current;
            }

            if (target < current.Data)
            {
                current.Left = DeleteNode(current.Left, target);
            } else if (target > current.Data)
            {
                current.Right = DeleteNode(current.Right, target);
            } else
            {
                if (current.Left == null)
                {
                    return current.Right;
                } else if (current.Right == null)
                {
                    return current.Left;
                } else
                {
                    int stuntDoubleValue = FindMin(current.Right);
                    current.Data = stuntDoubleValue;
                    current.Right = DeleteNode(current.Right, stuntDoubleValue);
                }

            }
            return current;
        }

        private int FindMin(TreeNode node)
        {
            TreeNode current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Data;
        }

    }

}