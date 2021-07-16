using System;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmPrograms
{
    public class BinarySearch<T> where T:IComparable
    {
        public static void InputWords()
        {
            string file = File.ReadAllText("/Users/Akshal/Projects/AlgorithmPrograms/AlgorithmPrograms/Words.txt");
            List<string> list = new List<string>(file.Split(" "));
            Console.WriteLine($"The Words in the File\n{file}");
            list.Sort();
            SearchWord(list);
        }
        public static void SearchWord(List<string> list)
        { 
            int mid;
            int start = 0, end = list.Count - 1;
            int flag = 0;
            Console.WriteLine("Enter the word you want Search");
            string word = Console.ReadLine();

             while (start <= end)
            {
                mid = (start + end) / 2;
                int result = word.CompareTo(list[mid]);
                if (result == 0)
                {
                    Console.WriteLine($"{word} Found");
                    flag = 1;
                    break;
                }
                else if (result > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Word not found!");
            }

        } 
    }
}
