using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabetize_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string word = Console.ReadLine();
            Console.WriteLine("Enter char number to find: ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            char c = word[0];
            Console.WriteLine(c);
            Console.ReadKey();
        }
       
    }
}
