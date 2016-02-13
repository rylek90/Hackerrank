using System;
using System.Linq;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/pangrams
    internal static class PangramsExtensions{
        
        private static string _alphabet = "thequickbrownfoxjumpsoverthelazydog";
        
        public static bool IsPangram(this string str) {
            return _alphabet.All(str.ToLower().Contains);
        }
    }
    public class Pangrams
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            
            Console.WriteLine(line.IsPangram() ? "pangram" : "not pangram");
        }
    }
}
