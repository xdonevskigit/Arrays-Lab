using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            string[] days =
                {
                "Invalid Day!",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
                };
            if (index > 0 && index < 8)
            {
                Console.WriteLine(days[index]);
            }
            else
            {
                index = 0;
                Console.WriteLine(days[index]);
            }          
        }
    }
}
