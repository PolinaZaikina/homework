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
            Console.WriteLine("Введите длину стороны треугольника и прилежащие к ней углы в градусах");
            //Console.WriteLine("Обозначения: n k m -стороны треугольника, a b - углы, s - площадь, p - периметр");

            var n = double.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            a = a* Math.PI / 180;
            b = b* Math.PI / 180;
            
            double s = (n*n) / 2 * (Math.Sin(a) * Math.Sin(b)) / Math.Sin(Math.PI - (a + b));
            Console.WriteLine("Площадь равна " + s);
            Console.ReadKey();

            var k = n * Math.Sin(a) / Math.Sin(Math.PI - a - b);
            var m = n * Math.Sin(b) / Math.Sin(a);
            Console.ReadKey();
            

            double p = n + k + m;
            Console.WriteLine("Периметр равен " + p);
            Console.ReadKey();
        }
    }
}
