using System;

namespace Hackerrank
{
    //https://www.hackerrank.com/challenges/the-time-in-words/
    public class Program
    {
        static string[] onesWords = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        static string[] tensWords = new[] { "zero", "ten", "twenty" };

        static void Main(String[] args)
        {
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ProcessTime(hours, minutes));
        }

        private static string ProcessTime(int hours, int minutes)
        {
            if (minutes == 0)
            {
                return $"{onesWords[hours]} o' clock";
            }

            if (minutes == 30)
            {
                return $"half past {onesWords[hours]}";
            }

            if (minutes == 15)
            {
                return $"quarter past {onesWords[hours]}";
            }

            if (minutes == 45)
            {
                var hoursStr = hours == 12 ? onesWords[1] : onesWords[hours + 1];
                return $"quarter to {hoursStr}";
            }

            if (minutes > 30)
            {
                var minutesTo = 60 - minutes;
                var hoursStr = hours == 12 ? onesWords[1] : onesWords[hours + 1];

                return $"{GetDisplayValue(minutesTo)} {GetForm(minutesTo)} to {hoursStr}";
            }

            return $"{GetDisplayValue(minutes)} {GetForm(minutes)} past {onesWords[hours]}";
        }

        private static string GetForm(int minutes)
        {
            return minutes == 1 ? "minute" : "minutes";
        }

        private static string GetDisplayValue(int minutes)
        {
            if (minutes < 20)
            {
                return onesWords[minutes];
            }

            var result = tensWords[minutes / 10];

            if (minutes % 10 > 0)
            {
                result += $" {onesWords[minutes % 10]}";
            }

            return result;
        }
    }

}