using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗаикинаПолина
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckHarshadNumber(n));
            Console.WriteLine(CheckCrossingHarshadNumber(n));
            Console.WriteLine(CheckStrongHarshadNumber(n));
            Console.WriteLine(SimpleNumbers(n));
            Console.WriteLine(SimpleHarshedNumbers(n));
            int s = 0;
            for (int i = 100; i <= 10000; i++) //перебор начинается со 100 т.к. нужно вычеркнуть как минимум две цифры
            {
                if (SimpleHarshedNumbers(i) == true)
                    s += i;
            }
            Console.WriteLine($"Сумма простых чисел Харшеда равна: {s}");
            Console.ReadKey();
            Console.ReadKey();
        }
        static bool CheckHarshadNumber(int n)
        {
            int s = 0;
            int n1 = n;
            while (n1 > 0)
            {
                s = s + n1 % 10;
                n1 = n1 / 10;
            }
            if (n % s == 0)
                return true;
            else
                return false;         
        }
        static bool CheckCrossingHarshadNumber(int n)
        {
            bool flag = true;
            while (n > 10)
            {
                if (CheckHarshadNumber(n) == false)
                {
                    flag = false;
                    break;
                }
                n = n / 10;
            }
            if (flag == true)
                return true;
            else
                return false;
        }
        static bool CheckStrongHarshadNumber(int n)
        {
            int s = 0;
            int n1 = n;
            while (n1 > 0)
            {
                s = s + n1 % 10;
                n1 = n1 / 10;
            }
            n1 = n / s;
            if (SimpleNumbers(n1) == true)
                return true;
            else
                return false;
        }
        static bool SimpleNumbers(int n)
        {
            bool flag = true;
            for (int i = 2; i <= (n / 2 + 1); i++)
            {
                if (n % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (n == 2)
                return true;
            if (flag == true)
                return true;
            else
                return false;
        }
        static bool SimpleHarshedNumbers(int n)
        {
            if (SimpleNumbers(n) == false)
                return false;
            int n1 = n / 10;
            if ((CheckHarshadNumber(n1) == true) && (CheckCrossingHarshadNumber(n1) == true) && (CheckStrongHarshadNumber(n1) == true))
                return true;
            else
                return false;
        }
    }
}
