using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortBuild
{
    class FortBuild
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 3 || n == 4)
            {
                Console.WriteLine("/{0}\", newstring('^',n/2));
            }
        }
    }
}
