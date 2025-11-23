using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SoldatovaPA.Sprint3.Task4.V27.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task4.V27.Lib
{
    public class DataService : ISprint3Task4V27
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue; // Пропускаем x = 0
                }

                double denominator = Math.Cos(x) + Math.Sin(x);

                // Проверяем, чтобы знаменатель не был равен 0
                if (Math.Abs(denominator) > 0.0001) // Избегаем деления на 0
                {
                    double y = x / denominator;
                    sum += y;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}