using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_3
{

    class Program
    {
        static double Distance(double x1, double x2, double y1, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками: {0:f2}", r);

            return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 выполненая в виде метода.");

            Distance(-2.3, 8.5, 4, 0.7);

            Distance(5, 8, 18.5, 15);

            Distance(21, 2.2, 13, 33);

            Console.ReadLine();
        }
    }
}
