using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class areaoffigures
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a*a,3));
            }
            if (figure == "rectangle")
            {
                var a1 = double.Parse(Console.ReadLine());
                var b1 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a1*b1,3));
            }
            if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI*r*r,3));
            }
            if (figure == "triangle")
            {
                var c = double.Parse(Console.ReadLine());
                var hc = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(c*hc/2,3));
            }
        }
    }
}
