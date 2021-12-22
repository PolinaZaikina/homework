using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6_1_вариант_9
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите число,кратное 4 и не оканчивающееся нулем");
                var n = int.Parse(Console.ReadLine());
                if (n % 4 != 0)
                    Console.WriteLine("Число не соответствует условию");
                else
                    if (n % 10 != 0)
                              Console.WriteLine("Переменная не соответствует условию");

                else
                    Console.WriteLine("Переменная соответствует условию");

                Console.ReadKey();
            
        }
    }
}
