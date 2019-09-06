using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start application");

            var words = new List<string>() { "aab", "a", "aabb", "aavvxxfgg" };

            foreach(var word in words)
                Console.WriteLine($"Word:{word}, Palindrome:{Palindrome(word)}");

            Console.WriteLine($"done");
        }
        static string Palindrome(string word)
        {
            var sb = new StringBuilder(word.Length * 2);
            var canPasteSymbols = false;
            sb.Append(word);

            var lastSymbol = word.Last();
            var index = word.Length - 2;

            for (; index >= 0; index--)
            {
                if (word[index] != lastSymbol) canPasteSymbols = true;
                if (canPasteSymbols) sb.Append(word[index]);
            }

            var result = sb.ToString();

            return result;
        }
    }
}
