using System;
using System.Collections.Generic;

namespace AlgorithmPrograms
{
    public class AnagramPalindromeUsingPrime
    {
        static List<int> palindromeList = new List<int>();
        List<int> primeList;
        public  void CheckPrimeAnagramAndPalindrome()
        {
            primeList = PrimeNumberRange.FindPrimeNumber();
            Random rand = new Random();
            int num1 = primeList[rand.Next(1, primeList.Count - 1)];
            int num2 = primeList[rand.Next(1, primeList.Count - 1)];

            string AnagramResult = Anagram.FindAnagram(num1.ToString(), num2.ToString());
            Console.WriteLine(AnagramResult);

            AnagramPalindromeUsingPrime palindrome = new AnagramPalindromeUsingPrime();

            foreach (int i in primeList)
            {
                palindrome.CheckPalindrome(i);
            }
            Console.WriteLine("Prime Numbers that are palindrome are");
            PrimeNumberRange.Display(palindromeList);
        }

        private void CheckPalindrome(int num)
        {
            int temp = num;
            int rev = 0, t;
            while (num > 0)
            {
                t = num % 10;
                rev = (rev * 10) + t;
                num = num / 10;
            }
            if (rev == temp)
            {
                palindromeList.Add(rev);
            }
        }

    }
}
