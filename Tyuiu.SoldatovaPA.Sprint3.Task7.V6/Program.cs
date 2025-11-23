using System;
using Tyuiu.SoldatovaPA.Sprint3.Task7.V6.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Солдатова П. А. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнила: Солдатова П. А. | ИСПБ-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:         *");
            Console.WriteLine("* F(x) = (3cos(x))/(4x-0.5) + sin(x) - 5x - 2                           *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль.  *");
            Console.WriteLine("* Значения занести в массив!                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            DataService ds = new DataService();
            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i < valueArray.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}  |", x, valueArray[i]);
            }

            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
