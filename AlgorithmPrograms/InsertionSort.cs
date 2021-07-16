using System;
using System.Collections.Generic;

namespace AlgorithmPrograms
{
    public class InsertionSort<T> where T:IComparable
    {
        public static void InputArray(List<T> InputArray)
        {
            List<T> arr = InputArray;
            int length = arr.Count;
            Console.WriteLine("Array Before Sorting");
            PrintArray(arr);
            sort(arr,length);
            Console.WriteLine("Array After sorted");
            PrintArray(arr);

        }
        static void sort(List<T> arr,int length)
        {
            for (int i = 1; i < length; i++)
            {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key)>0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
         public static void PrintArray(List<T> array)
         {
            foreach(var i in array)
            {
                Console.WriteLine(i);
            }
         }
        
    }
}
