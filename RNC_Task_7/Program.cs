using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNC_Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            int kolvo;
            kolvo = Convert.ToInt32(Console.ReadLine());
            int[] arrayy = new int[kolvo];
            for (int i = 0; i < kolvo; i++)
            {
                Console.Write("Введите {0} элемент массива: ", i);
                arrayy[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            Random shuffle = new Random();
            for (int i = 0; i < kolvo; i++)
            {
                var firstNum = shuffle.Next(0, kolvo - 1);
                var secondNum = shuffle.Next(0, kolvo - 1);
                var thirdNum = arrayy[firstNum];
                arrayy[firstNum] = arrayy[secondNum];
                arrayy[secondNum] = thirdNum;
            }
            for (int i = 0; i < kolvo; i++)
            {
                Console.WriteLine("{0} элемент массива после функции shuffle = {1}", i, arrayy[i]);
            }
        }
    }
}