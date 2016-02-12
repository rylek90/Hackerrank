using System;
using System.Collections.Generic;
using System.Linq;

// https://www.hackerrank.com/challenges/sparse-arrays
class SparseArrays
{
    private static ICollection<string> GetEntries()
    {
        var numOfEntries = int.Parse(Console.ReadLine());
        var collection = new List<string>();

        for (var i = 0; i < numOfEntries; i += 1)
        {
            collection.Add(Console.ReadLine());
        }

        return collection;
    }

    private static void ComputeSolution(ICollection<string> strings, ICollection<string> queries)
    {
        queries.FirstOrDefault(q => { Console.WriteLine(strings.Where(s => s == q).Count()); return false; });
    }

    public static void Main(string[] args)
    {
        var isis = new List<int> { 0, 1 };
        var collections = isis.Select(x => GetEntries()).ToList();
        ComputeSolution(collections[0], collections[1]);
    }
}