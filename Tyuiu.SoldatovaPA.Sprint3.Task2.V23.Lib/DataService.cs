using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SoldatovaPA.Sprint3.Task2.V23.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task2.V23.Lib
{
    public class DataService : ISprint3Task2V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;

            do
            {
                double term = (Math.Pow(value, k) + 0.25) * Math.Sin(k);
                sumSeries += term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(sumSeries, 3);
        }
    }
}

