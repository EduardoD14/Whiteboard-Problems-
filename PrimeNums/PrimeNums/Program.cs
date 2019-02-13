using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3000; i++)
            {
                if (i % 32 == 30)
                {
                    if (i % 58 == 44)
                    {
                        Console.WriteLine(i);
                    }   
                  

                }
                
            }
            Console.ReadKey();
        }
    }
}
       
