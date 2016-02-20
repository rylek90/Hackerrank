using System;
using System.Linq;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/pangrams
    public class Pangrams
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            
            Console.WriteLine(IsPangram(line) ? "pangram" : "not pangram");
        }
        
        private static string _alphabet = "thequickbrownfoxjumpsoverthelazydog";
        
        public static bool IsPangram(string str) {
            return _alphabet.All(str.ToLower().Contains);
        }
    }
}
