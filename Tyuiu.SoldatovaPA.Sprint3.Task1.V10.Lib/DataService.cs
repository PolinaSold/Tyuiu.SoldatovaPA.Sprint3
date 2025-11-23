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
                sumSeries += Math.Pow(1 + (1.0 / Math.Pow(i, value)), i);
                i++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}