using System;
using System.Collections.Generic;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/dynamic-array
    public class DynamicArrays
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');

            var lastans = 0;
            var n = int.Parse(line[0]);
            var q = int.Parse(line[1]);

            var matrix = new List<List<int>>(n);

            for (var i = 0; i < n; i += 1)
            {
                matrix.Add(new List<int>());
            }

            for (var i = 0; i < q; i += 1)
            {
                line = Console.ReadLine().Split(' ');

                var queryType = int.Parse(line[0]);
                var x = int.Parse(line[1]);
                var y = int.Parse(line[2]);
                var index = ((x ^ lastans) % n);

                if (queryType == 1)
                {
                    matrix[index].Add(y);
                }
                else
                {
                    var valueIndex = matrix[index].Count == 0 ? 0 : (y % matrix[index].Count);
                    var val = matrix[index][valueIndex];

                    Console.WriteLine(val);
                    lastans = val;
                }
            }
        }
    }
}
