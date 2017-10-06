using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse(Console.ReadLine());
            int elementsForSuming = int.Parse(Console.ReadLine());

            long[] array = new long[elements];
            
            long sum = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = sum;
                sum = 0;
                for (int j = 0; j < elementsForSuming; j++)
                {     
                    if (i - j < 0)
                    {
                        break;
                    }
                    sum = sum + array[i - j];   
                }
            }

            Console.WriteLine(String.Join(" ",array));
        }
    }
}
