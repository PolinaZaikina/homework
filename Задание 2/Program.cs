using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2номер_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длину стороны треугольника и прилежащие к ней углы");
            //Console.WriteLine("Обозначения: n k m -стороны треугольника, a b - углы, S - площадь, P - периметр");
            Console.ReadKey();

            var n = double.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            
            double S = (n*n) / 2 * (Math.Sin(a) * Math.Sin(b)) / Math.Sin(180 - (a + b));
            Console.WriteLine("Площадь равна " + S);
            Console.ReadKey();

            var k = n * Math.Sin(a) / Math.Sin(180 - a - b);
            var m = n * Math.Sin(b) / Math.Sin(a);
            Console.ReadKey();
            

            double P = n + k + m;
            Console.WriteLine("Периметр равен " + P);
            Console.ReadKey();
        }
    }
}
