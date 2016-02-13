using System;

namespace Hackerrank
{
    //https://www.hackerrank.com/challenges/2d-array
    public class TwoDimensionalArray
    {
        private static int SumOfHourglass(int[][] arr, int i, int j)
        {
            return arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
            + arr[i + 1][j + 1]
            + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
        }
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            var max = int.MinValue;
            for (int i = 0; i < 6; i+=1)
            {
                string[] arrStr = Console.ReadLine().Split(' ');
                arr[i] = Array.ConvertAll(arrStr, int.Parse);
            }
            
            for (var i = 0; i < 4; i += 1) {
                for (var j = 0; j < 4; j += 1) {
                    var sum = SumOfHourglass(arr, i, j);
                    max = sum > max ? sum : max;
                }
            }
            
            Console.WriteLine(max);
        }
    }
}
