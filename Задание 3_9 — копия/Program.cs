using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x для вычисления y ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(Metod(x));
            Console.ReadKey();
        }
        static double Metod(double x)
        { 

            double y = Math.Abs((1 + Math.Sqrt(x + 1)) / (1 - Math.Sqrt(x - 1)));
            return y;
        }
    }
}

