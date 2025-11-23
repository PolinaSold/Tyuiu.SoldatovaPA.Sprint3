using System;
using Tyuiu.SoldatovaPA.Sprint3.Task1.V10.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task1.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Солдатова П. А. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла while                                             *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #10                                                            *");
            Console.WriteLine("* Выполнила: Солдатова П. А. | ИСПБ-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда *");
            Console.WriteLine("* по формуле, при x=5                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine($"Переменная X = {value}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            DataService ds = new DataService();
            double result = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма ряда = {result}");
            Console.ReadKey();
        }
    }
}
