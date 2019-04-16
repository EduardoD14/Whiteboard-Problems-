using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3,3,5,6,7,2,2};
            RemoveDups(nums);
            Console.ReadKey();
        }

        public static void RemoveDups(int[] given)
        {
            for (int i = 0; i < given.Length; i++)
            {
                for (int j=i+1; j < given.Length; j++)
                {
                    if (given[i] == given[j])
                    {
                        Console.WriteLine(given[i]);
                    }
                }
            }
        }
    }
}
