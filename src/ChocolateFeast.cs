using System;

namespace Hackerrank
{
    //https://www.hackerrank.com/challenges/chocolate-feast
    public class ChocolateFeast
    {
        static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                var tmpArray = Console.ReadLine().Split(' ');
                var bobMoney = Convert.ToInt32(tmpArray[0]);
                var chocolatePrice = Convert.ToInt32(tmpArray[1]);
                var discountBars = Convert.ToInt32(tmpArray[2]);

                Console.WriteLine(CalculateNumberOfChocolates(bobMoney, chocolatePrice, discountBars));
            }
        }

        private static int CalculateNumberOfChocolates(int bobMoney, int chocolatePrice, int discountBars)
        {
            var chocolatesToBuy = bobMoney / chocolatePrice;
            var discountGained = 0;

            var sleevesLeft = chocolatesToBuy;
            while (sleevesLeft > 0 && sleevesLeft >= discountBars)
            {
                sleevesLeft -= discountBars;
                sleevesLeft += 1;
                discountGained += 1;
            }

            return discountGained + chocolatesToBuy;
        }
    }
}
