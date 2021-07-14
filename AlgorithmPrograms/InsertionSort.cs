using System;
namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public static void InputArray()
        {

            int[] arr = { 12,1,26,4,3,13, 5, 6 };
            Console.WriteLine("Array Before Sorting");
            PrintArray(arr);
            sort(arr);
            Console.WriteLine("Array After sorted");
            PrintArray(arr);

        }
        static void sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
         public static void PrintArray(int[] array)
         {
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
         }
        
    }
}
