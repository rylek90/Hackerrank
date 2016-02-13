using System;
using System.Linq;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/funny-string
    internal static class FunnyExtensions
    {
        public static bool IsFunnyString(this string str)
        {
            var reverse = string.Join("", str.Reverse());
            
            for (var i = 1; i < str.Length; i += 1){
                if (Math.Abs(str[i] - str[i - 1]) != Math.Abs(reverse[i] - reverse[i - 1])) {
                    return false;
                }
            }
            
            return true;
        }
    }
    public class Program
    {
        private const string Funny = "Funny";
        private const string NotFunny = "Not Funny";
        
        static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());

            for (var i = 0; i < testCases; i += 1)
            {
                Console.WriteLine(Console.ReadLine().IsFunnyString() ? Funny : NotFunny);
            }
        }
    }
}
