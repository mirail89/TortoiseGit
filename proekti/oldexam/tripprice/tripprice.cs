using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripprice
{
    class tripprice
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var travelDuring = Console.ReadLine();
            if (n >= 100 && travelDuring == "day")
            {
                Console.WriteLine(n * 0.06);
            }
            else if (n >= 100 && travelDuring == "night")
            {
                Console.WriteLine(n * 0.06);
            }
            else if (n >= 20 && travelDuring == "day")
            {
                Console.WriteLine(n * 0.09);
            }
            else if (n >= 20 && travelDuring == "night")
            {
                Console.WriteLine(n * 0.09);
            }

            else if (n < 20 && travelDuring == "day")
            {
                Console.WriteLine(0.70 + n * 0.79);
            }
            else if (n < 20 && travelDuring == "night")
            {
                Console.WriteLine(0.70 + n * 0.90);
            }
        }
    }
}
