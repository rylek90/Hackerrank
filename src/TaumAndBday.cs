using System;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/taum-and-bday/
    public class TaumAndBday
    {
        static void Main(string[] args)
        {
            int testsCount = int.Parse(Console.ReadLine());

            for (int a0 = 0; a0 < testsCount; a0++)
            {
                var tmpArray = Console.ReadLine().Split(' ');
                
                var blacksNeeded = UInt64.Parse(tmpArray[0]);
                var whiteNeeded = UInt64.Parse(tmpArray[1]);
                
                tmpArray = Console.ReadLine().Split(' ');
                
                var blackCost = UInt64.Parse(tmpArray[0]);
                var whiteCost = UInt64.Parse(tmpArray[1]);
                var convertCost = UInt64.Parse(tmpArray[2]);

                Console.WriteLine(CalculateMinimalCost(blacksNeeded, blackCost, whiteNeeded, whiteCost, convertCost));
            }
        }

        private static UInt64 CalculateMinimalCost(UInt64 blacksNeeded, UInt64 blackCost, UInt64 whiteNeeded, UInt64 whiteCost, UInt64 convertCost)
        {
            var blacksNormalCost = blacksNeeded * blackCost;  
            var blacksConvertedCost = blacksNeeded * (whiteCost + convertCost);  
            var whitesNormalCost = whiteNeeded * whiteCost;
            var whitesConvertedCost = whiteNeeded * (blackCost + convertCost);

            return Math.Min(blacksNormalCost, blacksConvertedCost) + Math.Min(whitesNormalCost, whitesConvertedCost);
        }
    }

}