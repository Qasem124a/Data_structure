using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist1
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
        class linkedlist
        {
            int count = 0;
            Node head;
            Node tail;
            public void linkedList()
            {
                head = tail = null;
                count = 0;
            }
            public bool empty()
            {
                if (head == null)
                    return true;
                else
                    return false;
            }
            public void addnodeinfront(int data)
            {
                Node node = new Node(data);
                node.next = head;
                head = node;
                count++;
            }

            public void addnodeinend(int data)
            {
                Node node = new Node(data);
                if (head == null)
                    head = node;
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                tail = temp;
                temp.next = node;
                tail = node;
                count++;
            }
            public void Add(int item, int index)
            {
                Node node = new Node(item);
                if (head == null)
                    head = node;
                Node temp = head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
                count++;
            }
            public int removefirst()
            {
                if (empty())
                    return 0;
                else if (count == 1)
                {
                    Node temp = head;
                    head = tail = null;
                    count = 0;
                    return temp.data;
                }
                else
                {
                    Node temp = head;
                    head = head.next;
                    count--;
                    return temp.data;
                }
            }
            public int removelast()
            {
                if (count == 0)
                    return 0;
                else if (count == 1)
                {
                    Node temp = head;
                    head = tail = null;
                    count = 0;
                    return temp.data;
                }
                else
                {
                    Node temp = head;
                    for (int i = 0; i < count - 2; i++)
                    {
                        temp = temp.next;
                    }
                    Node value = tail;
                    tail = temp;
                    tail.next = null;
                    count--;
                    return value.data;
                }
            }
            public int Remove(int index)
            {
                if (empty())
                    return 0;
                else if (count == 1)
                {
                    Node temp = head;
                    head = tail = null;
                    count = 0;
                    return temp.data;
                }
                else
                {
                    Node temp = head;
                    for (int i = 0; i < index - 2; i++)
                    {
                        temp = temp.next;
                    }
                    Node value = temp.next;
                    temp.next = temp.next.next;
                    value.next = null;
                    count--;
                    return value.data;
                }
            }
            public void printlist()
            {
                if (empty())
                {
                    Console.Write("the list is empty");
                }
                else
                {
                    Node temp = head;
                    while (temp != null)
                    {
                        Console.Write(" " + temp.data);
                        temp = temp.next;
                    }
                    Console.WriteLine();
                }
            }

            public int  Search(int item)
            {
                if (empty()) 
                    return 0;
                else
                {
                    int value = 0;
                    int k = 0;
                    Node temp = head;
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
                    head = tail = null;
                    count = 0;
                }

                public void the_count()
                {
                    Console.WriteLine("the count is :" + count);
                }

        }
        static void Main(string[] args)
        {
            linkedlist newnode = new linkedlist();
            Console.WriteLine("insert in the first of the list");
            newnode.addnodeinfront(5);
            newnode.addnodeinfront(4);
            newnode.addnodeinfront(3);
            newnode.addnodeinfront(2);
            newnode.addnodeinfront(1);
            newnode.printlist();
            Console.WriteLine("------------------");
            Console.WriteLine("insert in the last of the list");
            newnode.addnodeinend(6);
            newnode.addnodeinend(7);
            newnode.printlist();
            Console.WriteLine("------------------");
            Console.WriteLine("insert at a specific index");
            newnode.Add(8, 5);
            newnode.Add(9, 6);
            newnode.printlist();
            Console.WriteLine("------------------");
            Console.WriteLine("remove from the begien");

            int x = newnode.removefirst();
            if (x == 0)
                Console.WriteLine("the list is empty");
            else
            {
                Console.WriteLine("the removed element is :" + x);
                newnode.printlist();
            }
            Console.WriteLine("------------------");
            Console.WriteLine("remove from the end");
            int y = newnode.removelast();
            if (y == 0)
                Console.WriteLine("the list is empty");
            else
            {
                Console.WriteLine("the removed element is :" + y);
                newnode.printlist();
            }

            Console.WriteLine("------------------");
            Console.WriteLine("remove at a specific index");
            int z = newnode.Remove(4);
            if (z == 0)
                Console.WriteLine("the list is empty");
            else
            {
                Console.WriteLine("the removed element is :" + z);
                newnode.printlist();
            }

            Console.WriteLine("------------------");

            int item = newnode.Search(4);
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

            //newnode.Clear();
            //newnode.printlist();
            Console.WriteLine("------------------");
            if (newnode.empty())
                Console.WriteLine("the list is empty");
            else
                Console.WriteLine("the list is not empty");
            newnode.the_count();
        }
    }
}