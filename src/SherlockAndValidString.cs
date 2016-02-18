using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackerrank
{
    //https://www.hackerrank.com/challenges/sherlock-and-valid-string
    public class SherlockAndValidString
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            Console.WriteLine(ValidStr(str) ? "YES" : "NO");
        }

        private static bool ValidStr(string str)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item] += 1;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }

            if (IsValid(dictionary))
            {
                return true;
            }

            var valuesDistinct = dictionary.Values.Distinct();

            if (valuesDistinct.Count() > 2)
            {
                return false;
            }

            var tmpDict = new Dictionary<int, List<char>>();
            foreach (var item in dictionary)
            {
                if (tmpDict.ContainsKey(item.Value))
                {
                    tmpDict[item.Value].Add(item.Key);
                }
                else
                {
                    tmpDict.Add(item.Value, new List<char> { item.Key });
                }
            }

            var key = tmpDict.Where(x => x.Value.Count() == tmpDict.Values.Min(y => y.Count())).Select(x => x.Value.First()).FirstOrDefault();

            dictionary[key] -= 1;

            return IsValid(dictionary);
        }

        private static bool IsValid(Dictionary<char, int> dictionary)
        {
            return dictionary
                .Where(x => x.Value != 0)
                .Select(x => x.Value)
                .Distinct()
                .Count() == 1;
        }
    }
}
