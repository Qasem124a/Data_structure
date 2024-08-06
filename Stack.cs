
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LinkedList
{
    internal class Program
    {
        class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public class Stackls
        {
            int count;
            Node top;
            public void linkedList()
            {
                top = null;
                count = 0;
            }
            public bool empty()
            {
                if (top == null)
                    return true;
                else
                    return false;
            }
            public void Push(int data)
            {
                Node node = new Node(data);
                    node.next = top;
                    top = node;
                    count++;
                
            }
            public int pop()
            {
                if (empty())
                    return 0;
                else if (count == 1)
                {
                    Node temp = top;
                    top = null;
                    count = 0;
                    return temp.data;
                }
                else
                {
                    Node temp = top;
                    top = top.next;
                    count--;
                    return temp.data;
                }
            }


            public void printlist()
            {
                int value;
                Node temp = top;
                while (temp != null)
                {
                    value = temp.data;
                    Console.Write(" " + value);
                    temp = temp.next;
                }
                Console.WriteLine();
            }

            public int Contains(int item)
            {
                if (empty())
                    return 0;
                else
                {
                    int value = 0;
                    int k = 0;
                    Node temp = top;
                    while (temp != null)
                    {
                        if (temp.data == item)
                        {
                            k = 1;
                            value = temp.data;
                        }

                        temp = temp.next;
                    }
                    if (k == 0)
                        return -1;
                    else
                        return value;
                }
            }
            public void Clear()
            {
                top = null;
                count = 0;
            }

            public void the_count()
            {
                Console.WriteLine("the count is :" + count);
            }

        }
        public class StackAr
        {
            int[] arr;
            int top;
            int size;
            int lenght;
            public StackAr(int s)
            {
                top = -1;
                size = s;
                lenght = 0;
                arr = new int[size];
            }
            public bool IsEmpty()
            {
                return lenght == 0;
            }
            public bool IsFull()
            {
                return lenght == size;
            }
            public int The_Count1()
            {
                return lenght;
            }
            public void Clear1()
            {
                lenght = 0;
            }
            public void Push1(int item)
            {
                if (IsFull())
                    Console.WriteLine("the stack is full");
                else
                {
                    top++;
                    arr[top] = item;
                    lenght++;
                }
            }
            public int Pop1()
            {
                int value = 0 ;
                if (IsEmpty())
                    Console.WriteLine("the stack is full");
                else
                {
                    value = arr[top];
                    top--;
                    lenght--;
                }
                return value;
            }
            public int Contains1(int item)
            {
                for (int i = 0; i < top + 1; i++)
                    if (arr[i] == item)
                        return i;
                return -1;
            }
            public void Print_Stack()
            {
                for (int i = top; i >= 0; i--)
                    Console.Write(" " + arr[i]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Stackls newnode = new Stackls();

            Console.WriteLine("creating stack using linked list");
            newnode.Push(1);
            newnode.Push(2);
            newnode.Push(3);
            newnode.Push(4);
            newnode.Push(5);
            newnode.printlist();
            Console.WriteLine("__________remove the top___________");

            int x = newnode.pop();
            if (x == 0)
                Console.WriteLine("the list is empty");
            else
            {
                Console.WriteLine("the removed element is :" + x);
                newnode.printlist();
            }
            Console.WriteLine("------------------");
            int item = newnode.Contains(4);
            if (item == 0)
                Console.WriteLine("the list is empty");
            else if (item == -1)
            {
                Console.WriteLine("the element is not found :");
            }
            else
            {
                Console.WriteLine("the element is found :" + item);
                newnode.printlist();
            }
            Console.WriteLine("------------------");
            if (newnode.empty())
                Console.WriteLine("the list is empty");
            else
                Console.WriteLine("the list is not empty");
            newnode.the_count();

            Console.WriteLine("----------------------------");
            Console.WriteLine("creating stack using array");
            StackAr array = new StackAr(100);
            array.Push1(1);
            array.Push1(2);
            array.Push1(3);
            array.Push1(4);
            array.Push1(5);
            array.Print_Stack();
            Console.WriteLine("the count is :"+array.The_Count1());
            Console.WriteLine("__________remove the top___________");
            int p = array.Pop1();
            if (p == 0)
                Console.WriteLine("the list is empty");
            else
            {
                Console.WriteLine("the removed element is :" + p);
            }
            array.Print_Stack();
            int item1 = array.Contains1(1);
            if (item == -1)
            {
                Console.WriteLine("the element is not found :");
            }
            else
            {
                Console.WriteLine("the element is found at index :" + item1);
            }
            array.Print_Stack();
            Console.WriteLine("------------------");
            if (array.IsEmpty())
                Console.WriteLine("the array is empty");
            else
                Console.WriteLine("the array is not empty");
            if (array.IsFull())
                Console.WriteLine("the array is full");
            else
                Console.WriteLine("the array is not full");
            Console.WriteLine("the count is :" + array.The_Count1());
        }
    }
}