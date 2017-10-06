using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleOneTwoOrThreeElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            ExtractMiddleOneTwoOrThreeElementsFromArray(array);
        }

        static void ExtractMiddleOneTwoOrThreeElementsFromArray(int[] array)
        {
            if (array.Length == 1)
            {
                int[] extractedArray = new int[1];
                extractedArray = array;
                Console.WriteLine(String.Join("", extractedArray));
            }
            else if (array.Length % 2 == 0)
            {
                int[] extractedArray = new int[2];
                extractedArray[0] = array[array.Length / 2 - 1];
                extractedArray[1] = array[array.Length / 2];
                Console.WriteLine(String.Join(" ", extractedArray));
            }
            else
            {
                int[] extractedArray = new int[3];
                extractedArray[0] = array[array.Length / 2 - 1];
                extractedArray[1] = array[array.Length / 2];
                extractedArray[2] = array[array.Length / 2 + 1];
                Console.WriteLine(String.Join(" ", extractedArray));
            }

        }
    }
}
