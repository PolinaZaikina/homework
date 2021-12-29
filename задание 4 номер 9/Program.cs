using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_4_номер_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление значения x");
            Console.WriteLine("x = In(3+2^3)/In(2+3^2) + In(5+3^5)/In(3+5^3) + In(7+4^7)/In(4+7^4)");
            double x = Metod(3,2)+Metod(5,3)+Metod(7,4);
            Console.WriteLine($"x={x:F3}");
            Console.ReadKey();
        }
        static double Metod(double a, double b)
        {
            return Math.Log(a + Math.Pow(b, a), Math.E) / Math.Log(b + Math.Pow(a, b), Math.E);   
        }
    }
}
