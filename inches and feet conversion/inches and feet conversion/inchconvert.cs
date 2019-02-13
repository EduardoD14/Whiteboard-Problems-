using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inches_and_feet_conversion
{
    class inchconvert
    {

        public static double InFeet(int inches)
        {
           return (inches * 12);
          
        }
        public static double InchesToFeet(int inches)
        {
            return (double)inches / 12.0;
        }

        static void Main()
        {
            Console.WriteLine("InchesToFeet");
            Console.WriteLine(InchesToFeet(76));
            Console.ReadKey();
        }
    }
}
