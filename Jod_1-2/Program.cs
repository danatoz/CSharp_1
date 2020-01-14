using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jod_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эдуард Гуляев");

            Console.WriteLine("1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост (в метрах), вес). В результате вся информация выводится в одну строчку.");

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

            Console.WriteLine($"Привет {fName} {lName}, твой возраст {age} лет, твой рост {height} твой вес {mass} кг.\n");

            what.Print("2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах\n");
            double I = mass / (height * height);
            Console.WriteLine($"С помощью введеных тобой роста {height} и {mass} веса, я посчитал индекс массы твоего тела.");
            Console.WriteLine("И он составляет: {0:f2}",I);

            what.Pause();
        }
    }
}
