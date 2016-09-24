using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipesinpool
{
    class pipesinpool
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double vPipes = h*(p1 + p2);
            if (vPipes <= v)
            {
                double SumPercent = ( vPipes/ v) * 100;
                double PipeOnePercent = ((h * p1) / vPipes) * 100;
                double PipeTwoPercent = ((h * p2) / vPipes) * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (int)SumPercent, (int)PipeOnePercent, (int)PipeTwoPercent);
                // Console.WriteLine("The pool is {0}% full.Pipe 1: {1}%.Pipe 2: {3}%.", Math.Truncate((vPipes / v) * 100), Math.Truncate(((p1 * h) / vPipes) * 100),Math.Truncate(((p2 * h) / vPipes) * 100));
            }

            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, vPipes - v);
            }
        }
    }
}
