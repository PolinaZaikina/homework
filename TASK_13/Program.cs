using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TASK_13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Начало обработки данных...\n");

            var carriages = new Queue<string>();
            var line = string.Empty;
            using (var sr = new StreamReader("carriages.txt"))
            {
                while (!string.IsNullOrWhiteSpace(line = sr.ReadLine()))
                {
                    carriages.Enqueue(line);
                }
            }
            var c = new Stack<string>();

            using (var sw = new StreamWriter("orders.txt"))
            {
                string current = string.Empty;
                while (carriages.Count > 0)
                {
                    current = carriages.Dequeue();
                    if (carriages.Count == 0 && current.StartsWith("B")) sw.WriteLine($"Вагон {current} " +
                        $"перегнать на разгрузку на путь B");
                    else if (current.StartsWith("A")) sw.WriteLine($"Вагон {current} перегнать на разгрузку на путь A");
                    else
                    {
                        sw.WriteLine($"Вагон {current} перегнать на запасной путь C");
                        c.Push(current);
                    }
                }
                while (c.Count > 0)
                {
                    current = c.Pop();
                    sw.WriteLine($"Вагон {current} перегнать на разгрузку на путь B");
                }
            }

            int StringCount = File.ReadAllLines("orders.txt").Length;

            Console.WriteLine($"количество маневров: {StringCount} ");

            Console.ReadKey();
        }
    }
}
