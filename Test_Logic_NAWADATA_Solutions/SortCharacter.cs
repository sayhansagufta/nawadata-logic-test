using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Logic_NAWADATA_Solutions
{
    class SortCharacter
    {
        public static string procVowel(string param)
        {
            // Menyimpan Huruf Vokal
            string vowels = "aeiou";
            string result = "";

            // Konversi huruf ke huruf kecil
            param = param.ToLower();

            // Memisahkan huruf vokal
            foreach (char c in param)
            {
                if (vowels.Contains(c.ToString()))
                {
                    result += c; // Menambahkan huruf ke vokal
                }
            }

            // Mengurutkan string vokal
            char[] vowelArray = result.ToCharArray();
            Array.Sort(vowelArray);
            return new string(vowelArray);
        }

        public static string procConsonant(string param)
        {
            // Menyimpan Huruf Konsonan
            string vowels = "aeiou";
            string result = "";

            // Konversi huruf ke huruf kecil
            param = param.ToLower();

            // Memisahkan huruf konsonan
            foreach (char c in param)
            {
                if (char.IsLetter(c) && !vowels.Contains(c.ToString()))
                {
                    result += c; // Menambahkan huruf ke konsonan
                }
            }
            return result;
        }

        public static void Run()
        {
            Console.WriteLine("Input one line of words (S) : ");
            string input = Console.ReadLine();

            string charVowel = procVowel(input);
            string charConsonant = procConsonant(input);

            Console.WriteLine("Vowel Characters: ");
            Console.WriteLine(charVowel);
            Console.WriteLine("Consonant Characters: ");
            Console.WriteLine(charConsonant);
            Console.ReadKey();
        }
    }
}
