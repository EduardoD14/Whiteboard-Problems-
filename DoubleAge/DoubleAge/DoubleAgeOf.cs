using System;

namespace DoubleAge
{
    internal class DoubleAgeOf
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(DoubleAge(24, 4));
            Console.ReadKey();

        }

        //Given the age of two people, find the age of the second person
        //at which the first person will be twice as old as the second. 

        public static int DoubleAge(int p1, int p2)
        {
            int p2Age = 0;
            int p1Age = p2 - p1;
            while (p2Age != p1Age * 2)
            {
                p1Age++;
                p2Age++;
            }
            return p1Age;

        }
    }
}
