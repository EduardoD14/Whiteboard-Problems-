using System;

namespace Count_Vowels_In_A_String
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence to count voewls for: ");
            string sentence = Console.ReadLine();
            Console.WriteLine(CountVowels(sentence));
            Console.ReadKey();
        }
        public static int CountVowels(string sentence)
        {
            int total = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if
                    (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' ||
                    sentence[i] == 'o' || sentence[i] == 'u')
                {
                    total++;
                };

            }
            return total;
        }
    }
}
