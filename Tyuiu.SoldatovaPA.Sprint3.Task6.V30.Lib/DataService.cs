using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SoldatovaPA.Sprint3.Task6.V30.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task6.V30.Lib
{
    public class DataService : ISprint3Task6V30
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisors = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                // Для каждого числа находим количество делителей
                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        totalDivisors++;
                    }
                }
            }

            return totalDivisors;
        }
    }
}