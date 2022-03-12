using System;

namespace RNC_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало цикла, напишите exit для выхода");
            string _exit = "exit";
            string _vod = "";
            while (_vod != _exit)

            {
                Console.Write("Я работаю, для остановки напиши exit: ");
                _vod = Console.ReadLine();
            }
            Console.WriteLine("Я не работаю");
            Console.ReadKey();
        }
    }
}
