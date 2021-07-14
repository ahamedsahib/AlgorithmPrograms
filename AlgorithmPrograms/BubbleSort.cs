using System;
namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public static void InputArray()
        {
            int[] arr = { 43,25,32,5,13,7,3,20 };
            int len = arr.Length;
            Console.WriteLine("Before Sorting:\n");
            PrintArray(arr);
            sort(arr, len);
            Console.WriteLine("\nAfter Sorting:\n");
            PrintArray(arr);
        }

        private static void sort(int[] arr, int len)
        {
            int temp;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            
        }

        public static void PrintArray(int[] arr)
        {
            Console.Write("[");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.Write("]");
        }
    }
}
