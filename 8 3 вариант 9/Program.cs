using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_вариант_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность действительных чисел");
            double a = double.Parse(Console.ReadLine());
            double result = 1;

            while (a != 0)
            {
                result = result*a;
                a = double.Parse(Console.ReadLine());  
            }
            Console.WriteLine($"Результат:{result}") ;
            Console.ReadKey();
        }
    }
}
