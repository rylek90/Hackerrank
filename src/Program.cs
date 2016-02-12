using System;
using System.Collections.Generic;

namespace Hackerrank
{
    internal static class Extensions
    {
        public static void AddOrInit<T>(this List<T> list, T item)
        {
            if (list == null)
            {
                list = new List<T> { item };
            }
            else
            {
                list.Add(item);
            }
        }
        
        public static IList<int> GetAt(this IList<int>[] matrix, int index) {
            if (matrix[index] == null) {
                matrix[index] = new List<int>();
            }
            
            return matrix[index];
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');

            var lastans = 0;
            var n = int.Parse(line[0]);
            var q = int.Parse(line[1]);
            
            var matrix = new List<int>[n];

            for (var i = 0; i < q; i += 1)
            {
                line = Console.ReadLine().Split(' ');
                var queryType = int.Parse(line[0]);    
                var x = int.Parse(line[1]);    
                var y = int.Parse(line[2]);  
                
                var index = ((x ^ lastans) % n);
                if (queryType == 1) {
                    matrix[index].AddOrInit(y);
                } else {
                    var valueIndex = matrix.GetAt(index).Count == 0 ? 0 : (y % matrix.GetAt(index).Count);
                    var val = matrix[index][valueIndex];
                    
                    Console.WriteLine("Printing val {0}, from collection {1}", valueIndex, val);
                    
                    Console.WriteLine(val);
                    lastans = val;
                }
            }
        }
    }
}
