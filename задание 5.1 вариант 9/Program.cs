using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_5._1_вариант_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке");

            string text = Console.ReadLine().ToUpper();
            Console.WriteLine(Leet(text));
            Console.ReadKey();

        }
        static string Leet(string x)
        { 
            x = x.Replace("А", "A");
            x = x.Replace("Б", "6");
            x = x.Replace("В", "B");
            x = x.Replace("Г", "r");
            x = x.Replace("Д", "D");
            x = x.Replace("Е", "E");
            x = x.Replace("Ё", "E");
            x = x.Replace("Ж", "}|{");
            x = x.Replace("З", "3");
            x = x.Replace("И", "u");
            x = x.Replace("Й", "u*");
            x = x.Replace("К", "K");
            x = x.Replace("Л", "JI");
            x = x.Replace("М", "M");
            x = x.Replace("Н", "H");
            x = x.Replace("О", "O");
            x = x.Replace("П", "n");
            x = x.Replace("Р", "P");
            x = x.Replace("С", "C");
            x = x.Replace("Т", "T");
            x = x.Replace("У", "Y");
            x = x.Replace("Ф", "cp");
            x = x.Replace("Х", "X");
            x = x.Replace("Ц", "L|");
            x = x.Replace("Ч", "4");
            x = x.Replace("Ш", "LLI");
            x = x.Replace("Щ", "LLL");
            x = x.Replace("Ь", "b");
            x = x.Replace("Ы", "bI");
            x = x.Replace("Ъ", "`b");
            x = x.Replace("Э", "-)");
            x = x.Replace("Ю", "IO");
            x = x.Replace("Я", "9I");

            return x;
        }
    }
}
