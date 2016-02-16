using System;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/two-strings/
    public class TwoStrings
    {
        static void Main(string[] args)
        {
            var testCasesCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < testCasesCount; i += 1)
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                Console.WriteLine(Compute(first, second) ? "YES" : "NO");
            }
        }

        private static bool Compute(string first, string second)
        {
            for (int i = 'a'; i <= 'z'; i += 1)
            {
                if (first.IndexOf((char)i) != -1 && second.IndexOf((char)i) != -1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
