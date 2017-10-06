using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            bool isTripleExist = false;

            for (int i = 0; i < array.Length; i++)
            {               
                for (int j = i + 1 ; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {                      
                        if (array[i] + array[j] == array[k])
                        {
                            Console.WriteLine($"{array[i]} + {array[j]} == {array[k]}");
                            isTripleExist = true;
                            break;
                        }
                    }
                }
            }

            if (!isTripleExist)
            {
                Console.WriteLine("No");
            }
        }
    }
}
