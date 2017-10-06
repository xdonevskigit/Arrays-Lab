using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfStrings = Console.ReadLine()
                .Split(' ')
                .ToArray();
           
            foreach (var item in arrayOfStrings.Reverse())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
