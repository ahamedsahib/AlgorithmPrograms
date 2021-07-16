using System;
namespace AlgorithmPrograms
{
    public class Anagram
    {
        public static void InputString()
        {
            Console.WriteLine("Check whether 2 Strings are Anagram");
            Console.WriteLine("Enter First String");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string secondString = Console.ReadLine();
            if(firstString.Length == secondString.Length)
            {
                Console.WriteLine(FindAnagram(firstString, secondString));
            }
            else
            {
                Console.WriteLine($"{firstString} and {secondString} are not anagrams");
            }
        }

        public static string FindAnagram(string str1, string str2)
        {
            char[] str1Arr = str1.ToCharArray();
            char[] str2Arr = str2.ToCharArray();

            Array.Sort(str1Arr);
            Array.Sort(str2Arr);
            String s1 = new String(str1Arr);
            String s2 = new String(str2Arr);
            if (s1.Equals(s2))
            {
                return $"{s1} and {s2} are anagrams";
            }
            else
            {
                return $"{s1} and {s2} are not anagrams";
            }
        }
    }
}
