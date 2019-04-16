using System;
namespace SumOfOdds
{
    internal class SumOfOdds
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ReturnSum(13));
            Console.ReadKey();
            
        }
        //Given a number, return the sum of all 
        //the odd numbers below it starting from 0.
        public static int ReturnSum(int num)
        {
            int Sum = 0;

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 1)
                {
                    Sum += i;
                }
            }
            return Sum;
        }
    }
}
