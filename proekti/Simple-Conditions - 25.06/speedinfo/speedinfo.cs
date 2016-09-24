using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedinfo
{
    class speedinfo
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());
            if (speed > 1000)
                Console.WriteLine("extremely fast");
            else if (speed > 150)
                Console.WriteLine("ultra fast");
            else if (speed > 50)
                Console.WriteLine("fast");
            else if (speed > 10)
                Console.WriteLine("average");
            else if (speed <= 10)
                Console.WriteLine("slow");
        }
    }
}
