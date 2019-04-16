using System;

namespace DoubleAge
{
    internal class DoubleAgeOf
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(DoubleAge(40, 1));
           
            Console.WriteLine(SonAgeWhenFatherIsDouble(40,1));
            Console.ReadKey();

        }

        //Given the age of two people, find the age of the second person
        //at which the first person will be twice as old as the second. 

        public static int DoubleAge(int dad, int son)
        {
            int sonAge = 0;
            int dadAge = dad - son;            
            while (dadAge != sonAge * 2)
            {
                dadAge++;
                sonAge++;
            }
            return sonAge;

        }
        //simpler answer

        public static int SonAgeWhenFatherIsDouble(int dad,int son)
        {
          // int ageofdobule = dad - son;
          // return son - ageofdobule;
            return dad - son;
        }
    }
}
