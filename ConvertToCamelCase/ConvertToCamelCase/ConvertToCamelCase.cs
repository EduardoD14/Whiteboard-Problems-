using System;

namespace ConvertToCamelCase
{
    internal class ConvertToCamelCase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CamelCase("Mary Had a Little Lamb"));
            Console.ReadKey();
        }

        public static string CamelCase(string sentence)
        {
            bool newWord = false;
            string returnstring = " ";
            sentence = sentence.ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
                while (sentence[i] == ' ')
                {
                    i++;
                    if (returnstring.Length > 0)
                    {
                        newWord = true;
                    }
                }
                returnstring += newWord ? char.ToUpper(sentence[i]) : sentence[i];
                newWord = false;
            }
            return returnstring;

        }
    }
}
