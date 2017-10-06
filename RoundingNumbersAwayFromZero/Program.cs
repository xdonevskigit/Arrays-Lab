using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            PrintTheRoundedAwayFromZeroDoubleArray(array);
        }

        private static void PrintTheRoundedAwayFromZeroDoubleArray(double[] array)
        {
            double roundNumber;
            for (int i = 0; i < array.Length; i++)
            {
                roundNumber = Math.Round(array[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {roundNumber}");
            }
        }
    }
}
