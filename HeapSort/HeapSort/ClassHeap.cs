using System;
using System.Collections.Generic;
using System.Text;

namespace HeapSort
{
    public class Sort
    {


        public void heapSort(int[] arr, int n)
        //function heapSort() first converts the given elements into a heap.
        
        {
            //This is done by using the for loop and calling the
            //function heapify() for all the non-leaf elements of the heap.
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);


          //After the heap is created, a for loop is used to remove the
          //root element of the heap i.e.
          //the largest element. It is replaced by the rightmost leaf element
          //and then heapify() is called again to reestablish the heap.
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }


        //The function heapify() creates a heap structure by arranging
        //the elements as required.
        //This process starts from the element at index i ,for this 
        //the root element is considered for the heapify() function.
        public void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }




        public void Sorting()
        {
            int[] arr = { 5 ,1 ,7 ,2 ,6 ,8 ,3 ,10 ,4 ,9 };
            int n = 10, i;
            Console.WriteLine("Heap Sort");
            Console.Write("Initial array is: ");
            Console.WriteLine("\n");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            heapSort(arr, 10);

            Console.WriteLine("\n");
            Console.Write("Sorted Array is: ");
            Console.WriteLine("\n");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}