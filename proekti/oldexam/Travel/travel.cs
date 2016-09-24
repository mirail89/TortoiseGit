using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class travel
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
          
            if (budjet > 1000)
            {
                Console.WriteLine("");
                Console.WriteLine("Hotel - {0:f2}", 0.90 * budjet);
            }
            else if (budjet > 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", 0.40 * budjet);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", 0.80 * budjet, 2);
                }
            }
            else if (budjet <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", 0.30 * budjet, 2);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", 0.70 * budjet, 2);
                }
            }
        }
    }
}
