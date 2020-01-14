using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string fName = Console.ReadLine();

            Console.Write("Введите свою фамилию: ");
            string lName = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            string age = Console.ReadLine();

            Console.Write("Введите ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш вес: ");
            byte mass = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Привет {fName} {lName}, твой возраст {age} лет.");
            double I = mass / (height * height);
            Console.WriteLine($"С помощью введеных тобой роста {height} и {mass} веса, я посчитал индекс массы твоего тела.");
            Console.WriteLine($"И он составляет: {I}");

            Console.ReadKey();
        }
    }
}
