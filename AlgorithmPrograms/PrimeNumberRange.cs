using System;
using System.Collections.Generic;

namespace AlgorithmPrograms
{
    public class PrimeNumberRange
    {
        public static List<int> FindPrimeNumber()
        {
            List<int> primeNumbers = new List<int>();

            Console.WriteLine("Enter Range to Find Prime Number between them");
            Console.WriteLine("Enter the Start Number:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the End Number:");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nPrime numbers between {start} and {end} are :");
        
            int flag;
            for (int i = start; i <= end; i++)
            {
                // Skip 0 and 1 as they are not prime Number
                if (i == 1 || i == 0)
                    continue;

                // flag variable to tell prime or not
                flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime
                if (flag == 1)
                {
                    primeNumbers.Add(i);
                }
                    
            }
            Display(primeNumbers);
            return primeNumbers;
        }
        public static void Display(List<int> primeNumber)
        {
            foreach(int i in primeNumber)
            {
                Console.WriteLine(i);
            }
        }
    }
}
