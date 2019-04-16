using System;
namespace SumOfPrimes
{
    internal class SumOfPrimes
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ReturnSumOfPrimes(200));
            Console.ReadKey();
        }
        //Given a number, add all of the prime
        //numbers from 0 to that number, to include given number.
        public static bool IsPrime(int Num)
        {
            bool isPrime = true;
            for (int i = 2; i <Num; i++)
            {
                if (Num == 2)
                {
                    isPrime = true;
                }
                if (Num == 1 || Num % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
        public static int ReturnSumOfPrimes(int Num)
        {
            int Sum = 0;
            for (int i = 2; i <= Num; i++)
            {
                if (IsPrime(i))
                {
                    Sum+=i;
                }
            }
            return Sum;
        }
    }
}
