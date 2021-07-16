using System;
using System.Collections.Generic;

namespace AlgorithmPrograms
{
    public class BubbleSort<T> where T : IComparable
    {
        public static void InputArray(List<T> inputArray)
        {
            List<T> arr = inputArray;
            int len = arr.Count;
            Console.WriteLine("Before Sorting:\n");
            PrintArray(arr);
            sort(arr, len);
            Console.WriteLine("\nAfter Sorting:\n");
            PrintArray(arr);
        }

        private static void sort(List<T> arr, int len)
        {
            T temp;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (arr[j].CompareTo( arr[j + 1])>0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            
        }

        public static void PrintArray(List<T> arr)
        {
            Console.Write("[");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.Write("]");
        }
    }
}
