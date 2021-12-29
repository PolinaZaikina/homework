using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_8_вариант_9
{
    class Program
    {
        static void Main() 
        {
            Console.WriteLine("Введите значения для a и b ");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            int s = 0;
            while (a <= b)
            {
                s = s + a * a;
                a++;
            }
            Console.WriteLine($"Сумма квадратов целых чисел от a до b:{s} ");
            Console.ReadKey();
        }
    }
}
