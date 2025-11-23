using System;
using Tyuiu.SoldatovaPA.Sprint3.Task5.V25.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task5.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Солдатова П. А. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #25                                                            *");
            Console.WriteLine("* Выполнила: Солдатова П. А. | ИСПБ-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Вычислить сумму сумм ряда по формуле при X=2:                         *");
            Console.WriteLine("* y = Σ[i=1 to 3] Σ[k=1 to 13] (10/k) * (xᵏ + cos(k))                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13; // Изменено с 10 на 13

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт внешнего цикла = {startValue1}");
            Console.WriteLine($"Конец внешнего цикла = {stopValue1}");
            Console.WriteLine($"Старт внутреннего цикла = {startValue2}");
            Console.WriteLine($"Конец внутреннего цикла = {stopValue2}");

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма сумм ряда = {result}");
            Console.ReadKey();
        }
    }
}
