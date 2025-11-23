using System;
using Tyuiu.SoldatovaPA.Sprint3.Task2.V23.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Солдатова П. А. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла do...while                                        *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #23                                                            *");
            Console.WriteLine("* Выполнила: Солдатова П. А. | ИСПБ-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет       *");
            Console.WriteLine("* сумму ряда по формуле, при a=1,5                                       *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("* S = Σ(k=1 to 13) (aᵏ + 1/4) * sin(k)                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            double a = 1.5;
            int startValue = 1;
            int stopValue = 13;

            Console.WriteLine($"Переменная A = {a}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            DataService ds = new DataService();
            double result = ds.GetSumSeries(a, startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма ряда = {result}");
            Console.ReadKey();
        }
    }
}
