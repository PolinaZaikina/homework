using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стихотворение

{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Ночь, улица, фонарь,аптека");
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				{
					Console.WriteLine(@"Ночь, улица, фонарь, аптека,
Бессмысленный и тусклый свет.
Живи еще хоть четверть века —
Всё будет так.Исхода нет.

Умрешь — начнешь опять сначала
И повторится всё, как встарь:
Ночь, ледяная рябь канала,
Аптека, улица, фонарь.");
					Console.ForegroundColor = ConsoleColor.Gray;

					Console.ReadKey();
				}
			}
		}
	}
}
	

