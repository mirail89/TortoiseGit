using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutLeftover
{
    class WithoutLeftover
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countP1 = 0.0;
            var countP2 = 0.0;
            var countP3 = 0.0;
            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    countP1++;
                if (num % 3 == 0)
                    countP2++;
                if (num % 4 == 0)
                    countP3++;
            }
            Console.WriteLine("{0:f2}%", countP1 / n*100);
            Console.WriteLine("{0:f2}%", countP2 / n*100); 
            Console.WriteLine("{0:f2}%", countP3 / n*100); 
        }
    }
}
