using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            do {
                Console.WriteLine("1-Вывести агргументы командной строки");
                Console.WriteLine("2-Вывести високосные года");
                Console.WriteLine("3-Вывести числа Фиббоначи");
                Console.WriteLine("4-Вывести факториал числа");
                Console.WriteLine("5-Вывести все простые числа до заданного");
                Console.Write("Введите команду: ");

                key = Console.ReadKey().Key;

                if (key == ConsoleKey.D1) {
                    Console.WriteLine("");
                    Task1.printArgs(args);
                }
                else if (key == ConsoleKey.D2) {
                    Console.WriteLine("");
                    Task2.years();
                }
                else if (key == ConsoleKey.D3)
                {
                    Console.Write("\nВведите максимальное число Фиббоначи: ");
                    String input = Console.ReadLine();
                    int a = int.Parse(input);
                    Task3.fibbonachi(a);
                }
                else if (key == ConsoleKey.D4)
                {
                    Console.Write("\nВведите число: ");
                    String input = Console.ReadLine();
                    int a = int.Parse(input);
                    Task4.factr(a);
                }
                else if (key == ConsoleKey.D5)
                {
                    Console.Write("\nВведите максимальное число: ");
                    String input = Console.ReadLine();
                    int a = int.Parse(input);
                    Task5.eratosfen(a);
                }

                Console.WriteLine("\nНажмите любую клавишу чтобы продолжить");
                Console.ReadKey();
                Console.Clear();
            } while (key != ConsoleKey.Escape);

        }
    }

}
