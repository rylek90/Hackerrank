using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackerrank
{
    //https://www.hackerrank.com/challenges/service-lane/
    public class ServiceLane
    {
        static void Main(string[] args)
        {
            var tmpArray = Console.ReadLine().Split(' ');
            var freewayLength = int.Parse(tmpArray[0]);
            var testCases = int.Parse(tmpArray[1]);
            tmpArray = Console.ReadLine().Split(' ');
            List<int> freewayWidths = Array.ConvertAll(tmpArray, Int32.Parse).ToList();
            
            for (int i = 0; i < testCases; i++)
            {
                tmpArray = Console.ReadLine().Split(' ');
                var min = Convert.ToInt32(tmpArray[0]);
                var max = Convert.ToInt32(tmpArray[1]);
                
                Console.WriteLine(PrintMaxVehicle(freewayWidths, min, max));
            }
        }

        private static int PrintMaxVehicle(List<int> freewayWidths, int min, int max)
        {
            var minimal = 3;
            for (var i = min; i <= max; i += 1) {
                
                if (freewayWidths[i] == 1) {
                    return 1;
                }
                
                if (freewayWidths[i] < minimal) {
                    minimal = freewayWidths[i];
                }
            }
            return minimal;
        }
    }
}
