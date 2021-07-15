using System;
namespace AlgorithmPrograms
{
    public class PrimeNumberRange
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the start range:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end range:");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nPrime numbers between {start} and {end} are :");
            FindPrime(start, end);
        }
        public static void FindPrime(int start,int end)
        {
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
                    Console.WriteLine(i);
            }
        }
    }
}
