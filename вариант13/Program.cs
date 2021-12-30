using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вариант13
{
    class Program
    {
        public static string Encryption(string text, int[] key)
        {
            string new_text = "";
            for (int i = 0; i < key.Length; i++)
            { 
                new_text += text[key[i] + 3];
            }
            return new_text;
        }

        private static void Main()
        {
            Console.WriteLine("Введите текст ");
            var s = Console.ReadLine().ToUpper();
            int[] key = { А, Б, В, Г, Д, Е, Ё, Ж, З, И, Й, К, Л, М, Н, О, П, Р, С, Т, У, Ф, Х, Ц, Ч, Ш, Щ, Ъ, Ы, Ь, Э, Ю, Я };
            var s2 = Encryption(s, key);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
