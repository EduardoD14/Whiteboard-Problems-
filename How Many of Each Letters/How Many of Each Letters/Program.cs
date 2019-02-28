using System;
using System.Linq;


// Given a string, return how many of each letters ther are
//ALABAMA would return 
//A=4
//B=1
//L=1
//M=1
namespace How_Many_of_Each_Letters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter a string for me to count");
            Console.WriteLine(ReturnCharCount(Console.ReadLine()));
            Console.ReadKey();
        }

        public static string ReturnCharCount(string given)
        {
            int num = 0;
            int[] Counter = new int[given.Length];
            char[] letters = new char[given.Length];
            given = given.ToLower();
            foreach (char letter in given)
            {
                if (letters.Contains(letter))
                {
                    for (int i = 0; i < num; i++)
                    {
                        if (letters[i] == letter)
                        {
                            Counter[i]++;
                        }
                    }
                }
                else
                {
                    letters[num] = letter;
                    Counter[num++]++;
                }
            }
            return Counter.ToString();
        }
    }
}


