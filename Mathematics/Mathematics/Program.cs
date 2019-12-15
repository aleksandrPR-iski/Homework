using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите больший диаметр");
            double R = (double.Parse(Console.ReadLine()) / 2);
            Console.WriteLine("Введите меньший диаметр");
            double r = (double.Parse(Console.ReadLine()) / 2);
            double square = (Math.PI * (r * r));
            double Square = (Math.PI * (R * R));
            double ringSq = Square - square;
            Console.WriteLine("Площадь кольца равна: {0}", ringSq);
            Console.ReadKey();
        }
    }
}
