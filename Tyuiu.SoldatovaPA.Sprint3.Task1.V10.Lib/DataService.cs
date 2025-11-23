using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SoldatovaPA.Sprint3.Task1.V10.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;

            while (i <= stopValue)
            {
                // Правильная формула: (1/(i + x^i))^i
                double denominator = i + Math.Pow(value, i);
                double term = Math.Pow(1.0 / denominator, i);
                sumSeries += term;
                i++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}