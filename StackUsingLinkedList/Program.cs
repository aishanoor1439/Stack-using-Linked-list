using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    internal class Program
    {
        internal class Node
        {
            public int data;
            public Node next;
            public Node(int value)
            {
                data = value;
                next = null;
            }
        }

        internal class Stack
        {
            Node top;
            public Stack()
            {
                top = null;
            }

            internal bool isEmpty()
            {
                return top == null;
            }

            internal void push(int data)
            {
                Node newNode = new Node(data);
                newNode.next = top;
                top = newNode;
            }

            internal int pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack Underflow");
                    return 0;
                }
                int value = top.data;
                top = top.next;
                return value;
            }

            internal void peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                Console.WriteLine("The top most element of Stack is: {0}", top.data);
            }

            internal void PrintStack()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                Console.WriteLine("Items in the stack are:");
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }

            internal int count()
            {
                int count = 0;
                Node temp = top;
                while (temp != null)
                {
                    count++;
                    temp = temp.next;
                }
                return count;
            }

            static void Main(string[] args)
            {
                Stack myStack = new Stack();

                myStack.push(10);
                myStack.push(20);
                myStack.push(30);
                myStack.push(40);
                myStack.push(50);

                myStack.PrintStack();
                Console.WriteLine("Number of items in stack: {0}", myStack.count());

                myStack.peek();

                Console.WriteLine("Item popped from Stack : {0}", myStack.pop());
                Console.WriteLine("Number of items in stack after pop: {0}", myStack.count());

                myStack.PrintStack();
            }
        }
    }
}
