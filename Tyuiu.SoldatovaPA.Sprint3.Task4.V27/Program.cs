using System;
using Tyuiu.SoldatovaPA.Sprint3.Task4.V27.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Солдатова П. А. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах              *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #27                                                            *");
            Console.WriteLine("* Выполнила: Солдатова П. А. | ИСПБ-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение   *");
            Console.WriteLine("* функции y = x / (cos(x) + sin(x)). При х = 0 пропустить значение.     *");
            Console.WriteLine("* Полученные значения суммировать.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            DataService ds = new DataService();
            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма значений функции = {result}");
            Console.ReadKey();
        }
    }
}