using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_вариант_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Значение функции f(x) = {Metod(x)}");
            Console.ReadKey();
        }
        static double Metod(double x)
        {
            double f;
            if (Math.Sin(x) < 0)
            f = - Math.Cos(x);

            else
                if (Math.Sin(x) == 0)
                    f = x / Math.PI;
            
            else
                f = Math.Cos(x);
            return f;
        }

    }
}
