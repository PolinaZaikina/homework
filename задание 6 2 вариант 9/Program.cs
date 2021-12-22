using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6_2_вариант_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты для того, чтобы определить принадлежит ли точка области ");
            var CoordinateX = double.Parse(Console.ReadLine());
            var CoordinateY = double.Parse(Console.ReadLine());
            if ((XandYonGraphic(CoordinateX, CoordinateY)) == true)
                Console.WriteLine($"Точка ({CoordinateX};{CoordinateY}) принадлежит заданной области");
            else
                Console.WriteLine($"Точка ({CoordinateX};{CoordinateY}) не принадлежит заданной области");
            Console.ReadKey();
        }
        static bool XandYonGraphic(double x, double y)
        {
            if ((x <= 1.5) && (x >= -1) && (y <= 2) && (y >= -0.5))
                return true;
            else
                return false;
        }
    }
}


   
