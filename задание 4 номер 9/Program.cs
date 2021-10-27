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
            var n = Math.Round(Math.Log10(3 + 2 * 2 * 2) / Math.Log10(2 + 3 * 3), 3);
            var k = Math.Round(Math.Log10(5 + 3*3*3*3*3) / Math.Log10(3 + 5*5*5), 3);
            var m = Math.Round(Math.Log10(7 + 4*4*4*4*4*4*4) / Math.Log10(4 + 7*7*7*7), 3);

            double x = n + k + m;

            Console.WriteLine($"x = {x}");

            Console.ReadKey();

        }
    }
}
