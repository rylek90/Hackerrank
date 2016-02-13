using System;
using System.Linq;

namespace Hackerrank
{
    internal static class Extensions{
        
        private static string _alphabet = "thequickbrownfoxjumpsoverthelazydog";
        
        public static bool IsPangram(this string str) {
            return _alphabet.All(str.ToLower().Contains);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            
            Console.WriteLine(line.IsPangram() ? "pangram" : "not pangram");
        }
    }
}
