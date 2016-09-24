using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Condition
    {
        static void Main(string[] args)
        {
            var HaveTixo = int.Parse(Console.ReadLine());
            if (HaveTixo == 0)
                Console.WriteLine("not ");
            else
                Console.WriteLine("yes");
        }
    }
}
