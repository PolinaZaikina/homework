using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4_вариант_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i =1; ;i++)
            {
                if (n % 2 == 1)
                    count++;
                n = n / 2;
                if (n == 0)
                    break;
            }
            Console.WriteLine($"Количество единиц в двоичной записи числа: {count}");
            Console.ReadKey();
        }
    }
}
