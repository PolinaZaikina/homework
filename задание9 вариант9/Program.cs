using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание9_вариант9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите необходимое количество чисел в массиве");

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)

                array[i] = rand.Next();

            PrintArray(array);

            PrintArray(ChangeArraySigns(array));

            Console.WriteLine($"Квадратный корень из суммы квадратов: {GetRootFromSumOfSquares(array)}");

            PrintArray(GetArrayOfFactorials(array));

            Console.ReadKey();

        }

        static void PrintArray(int[] array)

        {

            Console.WriteLine(String.Join(", ", array));

            return;

        }

        static int[] ChangeArraySigns(int[] array)

        {

            for (int i = 0; i < array.Length; i++)

                array[i] = -array[i];

            return array;

        }

        static double GetRootFromSumOfSquares(int[] array)

        {

            double x = 0.0;
            for (int i = 0; i < array.Length; i++)

                x += array[i] * array[i];

            return Math.Sqrt(x);

        }

        static int[] GetArrayOfFactorials(int[] array)

        {

            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)

            {

                newArray[i] = 1;

                for (int j = 1; j <= Math.Abs(array[i]); j++)

                    newArray[i] *= j;

            }

            return newArray;
        }
    }
}
