using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SoldatovaPA.Sprint3.Task0.V16.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Pow((double)value / k, 3);
                multiplySeries *= term;
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}