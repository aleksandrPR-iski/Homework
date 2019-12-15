using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х");
            double x = double.Parse(Console.ReadLine());
            double y = (1 + (Math.Sqrt(((x * x) - 1) / ((x * x) + 1))));
            Console.WriteLine("F(x) = {0}", y);
            Console.ReadLine();
        }
    }
}
