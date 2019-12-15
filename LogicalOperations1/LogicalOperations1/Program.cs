using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperations1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Input("n");
            Console.WriteLine("Значение выражения" + F(n));
            Console.ReadKey();

        }
        static bool F(double n)
        {
            return (n % 5 == 0 | n % 7 == 0);

        }
        static double Input(string Name)
        {
            Console.WriteLine("Введите число " + Name);
            return double.Parse(Console.ReadLine());
        }
    }
    }
}
