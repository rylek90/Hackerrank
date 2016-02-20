using System;
using System.Text;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/cavity-map/
    public class CavityMap
    {
        static string CavityCharacter { get; } = "X";

        static void Main(String[] args)
        {
            int gridSize = Convert.ToInt32(Console.ReadLine());
            var stringBuilder = new StringBuilder();
            
            for (var i = 0; i < gridSize; i += 1)
            {
                stringBuilder.Append(Console.ReadLine());
            }

            ComputeCavities(stringBuilder.ToString(), gridSize);
        }

        private static void ComputeCavities(string str, int gridSize)
        {
            if (str.Length == 1) 
            {
                Console.WriteLine($"{str[0]}"); 
                return;   
            }
            
            DisplayRange(str, minInclusive: 0, maxExclusive: gridSize);

            for (var i = gridSize; i < str.Length - gridSize; i += 1)
            {
                if (i % gridSize == 0)
                {
                    Console.Write(str[i]);
                    continue;
                }

                if (gridSize - 1 == i % gridSize)
                {
                    Console.Write($"{str[i]}\n");
                    continue;
                }

                Console.Write(
                    IsCavity(
                        current: Convert.ToUInt16(str[i]),
                        up: Convert.ToUInt16(str[i - gridSize]),
                        right: Convert.ToUInt16(str[i + 1]),
                        down: Convert.ToUInt16(str[i + gridSize]),
                        left: Convert.ToUInt16(str[i - 1]))
                    ? CavityCharacter
                    : $"{str[i]}");
            }
            
            DisplayRange(str, minInclusive: str.Length - gridSize, maxExclusive: str.Length);
        }

        private static void DisplayRange(string str, int minInclusive, int maxExclusive)
        {
            for (var i = minInclusive; i < maxExclusive; i += 1)
            {
                Console.Write(str[i]);
            }

            Console.Write("\n");
        }

        private static bool IsCavity(ushort current, ushort up, ushort right, ushort down, ushort left)
        {
            return current > up && current > right && current > down && current > left;
        }
    }
}