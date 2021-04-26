using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. This method will show you all the prime numbers [2..n]. Input int n: ");
            int n;
            string inputN = Console.ReadLine();
            bool isInputNCorrect = ((int.TryParse(inputN, out n)) && (n >= 2));
            if (isInputNCorrect)
                PrimeNumbers(n);
            else
                Console.WriteLine("Error: only int number >= 2 is applicable!");
        }

        public static void PrimeNumbers(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = (i - 1); j > 0; j--)
                {
                    if ((i % j == 0) && (j != 1))
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                    Console.Write(i + " ");
            }
        }

    }
}
