using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckValidEmail
{
    class CheckEmail
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isEmailValid("quatemoc14@aim.com"));
            Console.WriteLine(isEmailValid("quatemoc14@aimcom"));
            Console.WriteLine(isEmailValid("quatemoc14@aim..com"));
            Console.WriteLine(isEmailValid("quatemoc14@.aim.com"));
            Console.WriteLine(isEmailValid("@aim.com"));
            Console.WriteLine(isEmailValid("@.o"));
            Console.ReadKey();
        }
      public static bool isEmailValid(string email)
        {
            string[] EmailPortion = email.Split('@');
            if (EmailPortion.Count() != 2)
                return false;
            if (EmailPortion[0].Length == 0 || EmailPortion[1].Length < 3)
                return false;
            if (!EmailPortion[1].Contains("."))
                return false;
            if (!Char.IsLetter((EmailPortion[0])[0]))
                return false;
            foreach (char c in email)
            {
                if (!Char.IsLetter(c) && !Char.IsNumber(c) && c != '_' && c != '.' && c != '@')
                    return false;
            }
            if (email.Contains("..") || email.Contains(".@") || email.Contains("@.") || email.Contains("._."))
                return false;
            if (email.EndsWith("."))
                return false;
            return true;
        }         
    }
}
