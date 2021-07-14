using System;
namespace AlgorithmPrograms
{
    public class MergeSort
    {
        public static void InputArray()
        {
            string[] arr = { "pwe", "xyz", "ert", "fds", "asm", "atm" };
            Console.WriteLine("Array before Sort");
            printArray(arr);
            sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
        //sort() used to divide the array into halves
        public static void sort(string[] arr, int l, int r)
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
        static void merge(string[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int sizeOfSubarray1 = m - l + 1;
            int sizeOfSubarray2 = r - m;

            // Create temp arrays
            string[] L = new string[sizeOfSubarray1];
            string[] R = new string[sizeOfSubarray2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < sizeOfSubarray1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < sizeOfSubarray2; ++j)
                R[j] = arr[m + 1 + j];

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

        
        static void printArray(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
