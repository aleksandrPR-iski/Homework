using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFunction
{
    class Program
    {
        static void Main()
        {
            var x = Math.Pow(Math.E, F(2, 3)) + (Math.Pow(Math.E, F(3, 5))) * (Math.Pow(Math.E, F(5, 7)));
            Console.WriteLine("x={0:F3}", x);
            Console.ReadKey();
        }
        static double F(double x, double y)
        {
            return -(Math.Sqrt(x + (y * y)));

        }
    }
}
