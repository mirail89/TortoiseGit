using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theCatTom
{
    class theCatTom
    {
        static void Main(string[] args)
        {
            var freedays = int.Parse(Console.ReadLine());
            var workingDays = (365 - freedays) * 63;
            var realTimeforPlay = ((workingDays) + (freedays * 127));
            if (realTimeforPlay > 30000)
            {
                int hours = (realTimeforPlay - 30000) / 60;
                int minutes = (realTimeforPlay - 30000) % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                int hours2 = (30000 - realTimeforPlay) / 60;
                int minutes2 = (30000 - realTimeforPlay) % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours2, minutes2);
            }
        }
    }
}
