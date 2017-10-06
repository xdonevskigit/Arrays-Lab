using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Again:
            int[] condenseArray = new int[array.Length - 1];

            if (array.Length == 1)
            {
                Console.WriteLine(String.Join(" ", array));
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {        

                if (i + 1 >= array.Length)
                {
                    array = condenseArray;
                    goto Again;
                }
                condenseArray[i] = array[i] + array[i + 1];
            }
        }
    }
}
