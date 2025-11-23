using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SoldatovaPA.Sprint3.Task5.V25.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                double innerSum = 0;
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    // Правильная формула: (x^k + cos(k))
                    double term = Math.Pow(x, k) + Math.Cos(k);
                    innerSum += term;
                }
                totalSum += innerSum;
            }

            return Math.Round(totalSum, 3);
        }
    }
}