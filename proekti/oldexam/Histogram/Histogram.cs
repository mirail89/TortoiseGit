using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countP1 = 0.0;
            var countP2 = 0.0;
            var countP3 = 0.0;
            var countP4 = 0.0;
            var countP5 = 0.0;
            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200)
                    countP1++;
                else if (num >= 200 && num <= 399)
                    countP2++;
                else if (num >= 400 && num <= 599)
                    countP3++;
                else if (num >= 600 && num <= 799)
                    countP4++;
                else if (num >= 800 && num <= 1000)
                    countP5++;
            }
            Console.WriteLine("{0:p2}", countP1/n);
            Console.WriteLine("{0:p2}", countP2/n);
            Console.WriteLine("{0:p2}",countP3/n);
            Console.WriteLine("{0:p2}", countP4/n);
            Console.WriteLine("{0:p2}", countP5/n);
        }
    }
}
