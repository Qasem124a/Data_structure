using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAsDatastructure
{
    internal class Program
    {
        public class MyArray
        {
            int[] arr;
            int size;
            int lenght;
            public MyArray(int s)
            {
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
            public int The_Count()
            {
                return lenght;
            }
            public void Clear()
            {
                lenght = 0;
            }
            public void Print_Array()
            {
                for (int i = 0; i < lenght; i++)
                    Console.Write(" " + arr[i]);
                Console.WriteLine();
            }
            public void InsertAt(int index,int item)
            {
                if (IsFull())
                    Console.WriteLine("the array is full");
                else
                {
                    for (int i = lenght; i > index; i--)
                        arr[i] = arr[i - 1];
                    arr[index] = item;
                    lenght++;
                }
            }
            /*public void InsertAtFirst(int item)
            {
                if (IsFull())
                    Console.WriteLine("the array is full");
                else
                {
                    for (int i = 0; i < lenght; i++)
                    {
                        arr[i+1] = arr[i];
                    }
                    arr[0] = item;
                    lenght++;
                }
            }*/
            public void InsertAtEnd(int item)
            {
                if (IsFull())
                    Console.WriteLine("the array is full");
                else
                {
                    arr[lenght] = item;
                    lenght++;
                }
            }
            public int RemoveAtfirst()
            {
                if (IsEmpty())
                    return -1;
                else
                {
                    int value = arr[0];
                    for (int i = 0; i < lenght; i++)
                        arr[i] = arr[i + 1];
                    lenght--;
                    return value;
                }
            }
            /*public int RemoveAtend()
            {
                if (IsEmpty())
                    return -1;
                else
                {
                    int value = arr[lenght];
                    for (int i = lenght; i > 0; i--)
                        arr[i] = arr[i - 1];
                    lenght--;
                    return value;
                }
            }*/
            public int RemoveAt(int index)
            {
                if (IsEmpty())
                    return -1;
                else
                {
                    int value = arr[index];
                    for (int i = index; i < lenght; i++)
                        arr[i] = arr[i + 1];
                    lenght--;
                    return value;
                }
            }
            public void Sort()
            {
                if (IsEmpty())
                    Console.WriteLine("the array is empty");
                else
                {
                    int temp;
                    for (int i = 0; i < lenght-1; i++)
                    {
                        for (int j = i + 1; j < lenght - 1; j++)
                        {
                            if (arr[i] > arr[j])
                            {
                                temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("--------------Bubble sort-----------");
                    for (int i = 0; i < lenght; i++)
                        Console.Write(" " + arr[i]);
                    Console.WriteLine();
                    int temp1;
                    for (int i = 0; i < lenght; i++)
                    {
                        int min = i;
                        for (int j = i + 1; j < lenght; j++)
                        {
                            if (arr[i] > arr[j])
                                temp1 = j;
                        }
                        temp1 = arr[min];
                        arr[min] = arr[i];
                        arr[i] = temp1;
                    }
                    Console.WriteLine("-----------Selection sort-----------");
                    for (int i = 0; i < lenght; i++)
                        Console.Write(" " + arr[i]);
                    Console.WriteLine();
                    int key;
                    int y;
                    for (int i = 1; i < lenght; i++)
                    {
                        key = arr[i];
                        y = i - 1;
                        while (y >= 0 && arr[y] > key)
                        {
                            arr[y + 1] = arr[y];
                            y = y - 1;
                        }
                        arr[y + 1] = key;
                    }

                    Console.WriteLine("-----------insertion sort----------");
                    for (int i = 0; i < lenght; i++)
                        Console.Write(" " + arr[i]);
                    Console.WriteLine();
                }
            }
            public int[] InsertionSort()
            {
                int key;
                int y;
                for (int i = 1; i < lenght; i++)
                {
                    key = arr[i];
                    y = i - 1;
                    while (y >= 0 && arr[y] > key)
                    {
                        arr[y + 1] = arr[y];
                        y = y - 1;
                    }
                    arr[y + 1] = key;
                }
                return arr;
            }
            public int BinarySearch(int item)
            {
                int[] arr1 = InsertionSort();
                int k = -1;
                int end = lenght - 1; ;
                int start=0;
                int mid;
                for (int i = start; i < end; i++)
                {
                    mid = (start + end) / 2;
                    if (item == arr1[mid])
                        k = mid;
                    else if (item > arr1[mid])
                    {
                        start = mid + 1;
                    }
                    else if(item < arr1[mid])
                    {
                        end = mid - 1;
                    }
                }
                return k;
            }
            public int search(int item)
            {
                for (int i = 0; i < lenght; i++)
                    if (arr[i] == item)
                        return i;
                return -1;
            }
            public void DoNotInsertDoublicate(int item)
            {
                if (search(item) == -1)
                    InsertAtEnd(item);
                else
                    Console.WriteLine("the element is already there");
            }
        }

        static void Main(string[] args)
        {
            MyArray array = new MyArray(100);
            array.InsertAt(0, 3);
            array.InsertAt(1, 1);
            array.InsertAtEnd(2);
            array.InsertAtEnd(4);
            array.InsertAt(0, 0);
            //array.InsertAtFirst(0);
            array.Print_Array();
            Console.WriteLine("-------removing-------");
            int x = array.RemoveAt(0);
            if (x == -1)
                Console.WriteLine("the array is empty");
            else
                Console.WriteLine("the removing elemnt is :" + x);
            array.Print_Array();
            Console.WriteLine("test the Sortion functon");
            array.Sort();
            Console.WriteLine("---------------------------");
            int y = array.search(4);
            if (y == -1)
                Console.WriteLine("the element is not found");
            else
                Console.WriteLine("the element is found in index:" + y);
            Console.WriteLine("test the Binary search");
            int z = array.search(1);
            if (z == -1)
                Console.WriteLine("the element is not found");
            else
                Console.WriteLine("the element is found in index:" + z);
            Console.WriteLine("-------------------");
            if (array.IsEmpty())
                Console.WriteLine("the array is empty");
            else
                Console.WriteLine("the array is not empty");

            if (array.IsFull())
                Console.WriteLine("the array is full");
            else
                Console.WriteLine("the array is not full");
            array.DoNotInsertDoublicate(1);
            array.Print_Array();
            Console.WriteLine("the count is :" + array.The_Count());
        }
    }
}