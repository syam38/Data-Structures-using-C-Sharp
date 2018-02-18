// implementing stack and its operations using c# language using classes 
using System;
namespace DataStructures {
    class mainscreen
    {
        static void Main(string[] args)

        {
            string num;
            Stack a = new Stack();
            while (true)
            {
                Console.WriteLine("\nStack Operations\n");
                Console.WriteLine("===============\n");
                Console.WriteLine("1.Insert element into the stack\n");
                Console.WriteLine("2.Remove element from the stack\n");
                Console.WriteLine("3.Display the top elemnt\n");
                Console.WriteLine("4.Display all the elemnts\n");


                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice <= 0)
                {
                    Console.WriteLine("Enter only an Integer\n");
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the number to insert : ");
                            num = Console.ReadLine();
                            a.Push(num);
                            break;
                        case 2:
                            Console.WriteLine("Enter the number to insert : ");
                            num = Console.ReadLine();
                            a.Pop();
                            break;
                        case 3:
                            a.Top();
                            break;
                        case 4:
                            a.printElements();
                            break;

                    }

                }
            }
            //a.Push(5);
            //a.Push(6);
            //a.Push(7);
            //a.Top();
            //a.printElements();

        }
        
    }
    //block which holds the data for the stack 
    class node
    {
        public node next;
        public Object num;
    }
    //Implementing push,pop and top operations for the stack
    class Stack
    {
        node head, current, newnode, previous;
        public void Push(Object element)
        {
            if (head == null)
            {
                head = new node();
                head.num = element;
                head.next = null;
               
            }
            else
            {
                current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                newnode = new node();
                newnode.num = element;
                newnode.next = null;
                current.next= newnode;
            }
        }
        public void Pop()
        {
            current = head;
            while (current != null)
            {
                previous = current;
                current = current.next;
            }
            previous.next = null;


        }
        public void Top()
        {
            //current = new node();
            current =head;
            while (current.next != null)
            {
                current = current.next;
            }
            Console.WriteLine("Top element of the stack is {0}",current.num);

        }
        public void printElements()
        {
            node current = head;
            if (current == null)
                Console.WriteLine("There are no elements in the stack");
            else
            {
                Console.WriteLine("Elemnts in the stack are\n");
                while (current != null)
                {
                    Console.WriteLine("{0}\t",current.num);
                    current = current.next;
                }
            }

        }
    }
}
