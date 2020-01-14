using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Написать программу обмена значениями двух переменных.\nа) с использованием третьей переменной;");
            int a = 10;
            int temp = 0;
            int b = 44;

            Console.WriteLine($"Переменная а равна {a}, переменная б равна {b}");

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Переменная а равна {a}, переменная б равна {b}\n");

            Console.WriteLine("б) *без использования третьей переменной.");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Переменная а равна {a}, переменная б равна {b}");

            Console.ReadKey();
        }
    }
}
