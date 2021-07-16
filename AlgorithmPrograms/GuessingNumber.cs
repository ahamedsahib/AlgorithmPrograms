using System;
namespace AlgorithmPrograms
{
    public class GuessingNumber
    {
        static int start = 0, end = 100;
        static bool found = false;
        public static void GuessNumber()
        {
            Console.WriteLine($"Think a number between {start} - {end} ");
            while (start != end && found == false)
            {
                int mid = (start + end) / 2;
                FindNumber(mid);
            }
            if (start == end)
            {
                Console.WriteLine($"The Number You Guessed is {start}");
            }

        }

        public  static void FindNumber(int mid)
        {
            Console.WriteLine($"Pick One To Find Your Number\n1.Is your number is {mid}\n2.Is your number is less than {mid}\n3.Is your number is greater than {mid}");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"The Number You Guessed is {mid}");
                    found = true;
                    break;
                case 2:
                    end = mid - 1;
                    break;
                case 3:
                    start = mid + 1;
                    break;
            }
        }
    }
}
