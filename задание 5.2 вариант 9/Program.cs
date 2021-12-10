using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_5._2_вариант_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Получить из слова кратер слова катер и река");

            string str = "";

            str = "кратер";//к-0 р-1 а-2 т-3 е-4 р-5
            Console.WriteLine(str);

            string result1 = str.Substring(0, 1)
                + str.Substring(2);
            Console.WriteLine(result1);

            string result2 = str.Substring(5)
                + str.Substring(4, 1)
                + str.Substring(0, 1)
                + str.Substring(2, 1);
            Console.WriteLine(result2);

            Console.ReadKey();

        }
    }
}
