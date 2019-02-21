using System;

namespace ReturnSumOfDigits
{
    public class ReturnSumOfDigits
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number please:");
            //Console.WriteLine(SumDig(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine(SingleSumDig(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
        }
        //The code below adds up all of the digits in a number.        
        public static int SumDig(int x)
        {
            int sum = 0;
            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }
        //The code below adds up all of the digits in a number and if the resulting number has
        //more than one digit we will cycle through it again until the result is a single digit.
        public static int SingleSumDig(int x)
        {
            int sum = 0;
            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum > 9 ? SumDig(sum) : sum;
        }
    }
}
