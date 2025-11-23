using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SoldatovaPA.Sprint3.Task7.V6.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task7.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 4 * x - 0.5;

                // Проверка деления на ноль (когда 4x - 0.5 = 0)
                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double term1 = (3 * Math.Cos(x)) / denominator;
                    double term2 = Math.Sin(x) - 5 * x - 2;
                    valueArray[count] = Math.Round(term1 + term2, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}