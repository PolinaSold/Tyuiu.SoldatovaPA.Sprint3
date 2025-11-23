using System;
using Tyuiu.SoldatovaPA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Солдатова П. А. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                           *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #20                                                            *");
            Console.WriteLine("* Выполнила: Солдатова П. А. | ИСПБ-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв 'f' в строке:       *");
            Console.WriteLine("* 'gfft ntf f opf'                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            string str = "gfft ntf f opf";
            char ch = 'f';

            Console.WriteLine($"Исходная строка = {str}");
            Console.WriteLine($"Искомый символ = {ch}");

            DataService ds = new DataService();
            int result = ds.GetCharCount(str, ch);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество символов '{ch}' в строке = {result}");
            Console.ReadKey();
        }
    }
}
