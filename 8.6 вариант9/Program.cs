using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6_вариант9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Sum(n)}");
            Console.ReadKey();
        }
        static int Sum(int n)
        {
            int result;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                result = 1;
                for (int j=1;j<=i;j++)
                {
                    result = result * i;
                }
                
                sum += result;
            }
            return sum;
        }
    }
}
        

 

