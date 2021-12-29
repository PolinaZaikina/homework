using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1вариант9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите целое число");
            var n = int.Parse(Console.ReadLine());
            if (CheckNumber(n) == true)
                Console.WriteLine("Число соответствует условию");
            else
                Console.WriteLine("Число не соответствует условию");
            Console.ReadKey();
        }
        static bool CheckNumber(int n)
        {
            if (n % 4 != 0 || n % 10 != 0)
                return false;
            else
                return true;
        }
    }
}
