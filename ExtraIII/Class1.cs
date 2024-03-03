using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace prueba
{

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class Program
    {
        private static Node head = null;

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSimple Linked List Menu:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddNode();
                        break;
                    case 2:
                        ShowList();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void AddNode()
        {
            Console.Write("Enter value to add: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Node newNode = new Node(value);

            // Add node to the beginning of the list
            newNode.Next = head;
            head = newNode;

            Console.WriteLine("Value added successfully.");
        }

        private static void ShowList()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Console.Write("List: ");
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
    }

}


