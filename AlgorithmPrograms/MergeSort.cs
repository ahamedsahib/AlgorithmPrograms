using System;
using System.Collections.Generic;

namespace AlgorithmPrograms
{
    public class MergeSort<T> where T : IComparable
    {
        List<T> strArr;
        public MergeSort(List<T> ls)
        {
            this.strArr = ls;
        }
        public MergeSort()
        {
            Console.WriteLine("Merge Sort");
        }

        public void MergeSortArray()
        {
            int len = strArr.Count;
            MergeSort<T>.sort(strArr, 0, len - 1);
            PrintArray(strArr);
        }
        //sort() used to divide the array into halves
        public static void sort(List<T> arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                sort(arr, l, m);
                sort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }
        static void merge(List<T> arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int sizeOfSubarray1 = m - l + 1;
            int sizeOfSubarray2 = r - m;

            // Create temp arrays
            List<T> L = new List<T>(sizeOfSubarray1);
            List<T> R = new List<T>(sizeOfSubarray2);

            int i, j;

            for (i = 0; i < sizeOfSubarray1; i++)
                L.Add(arr[l + i]);
            for (j = 0; j < sizeOfSubarray2; j++)
                R.Add(arr[m + 1 + j]);

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            
            int k = l;
            while (i < sizeOfSubarray1 && j < sizeOfSubarray2)
            {
                int res = L[i].CompareTo(R[j]);
                if (res<=0)
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < sizeOfSubarray1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < sizeOfSubarray2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        
        static void PrintArray(List<T> arr)
        {
            foreach(var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
