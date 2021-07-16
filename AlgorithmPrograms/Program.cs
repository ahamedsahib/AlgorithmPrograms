using System;
using System.Collections.Generic;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs");
            Console.WriteLine("MENU");
            Console.WriteLine("1.Permutation\n2.Binary Search\n3.Insertion Sort\n4.Bubble Sort\n5.Merge Sort\n6.Anagram\n7.Prime Within Range\n8.Anagram and palindrome of prime numbers\n9.Exit\nENTER AN OPTION");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Permutation.ComputePermutation();
                    break;
                case 2:
                    BinarySearch<string>.InputWords();
                    break;
                case 3:
                    List<string> InsertionSortInputArray = new List<string> { "how","are","you","do","Insertion","sort"};
                    InsertionSort<string>.InputArray(InsertionSortInputArray);

                    break;
                case 4:

                    List<int> BubbleSortInputArray = new List<int>{ 43, 25, 32, 5, 13, 7, 3, 20 };
                    BubbleSort<int>.InputArray(BubbleSortInputArray);
                    break;
                case 5:
                    List<string> MergeSortList = new List<string> { "xyz","ade","ygf","dfwe","qudw","awds"};
                    MergeSort<string> ms = new MergeSort<string>(MergeSortList);
                    ms.MergeSortArray();
                    break;
                case 6:
                    Anagram.InputString();
                    break;
                case 7:
                    List<int> PrimeList = PrimeNumberRange.FindPrimeNumber();
                    break;
                case 8:
                    AnagramPalindromeUsingPrime anagramPalindrome = new AnagramPalindromeUsingPrime();
                    anagramPalindrome.CheckPrimeAnagramAndPalindrome();
                    break;
                case 9:
                    GuessingNumber.GuessNumber();
                    break;
                case 10:
                    Console.WriteLine("Exited");
                    break;
            }


        }
    }
}
