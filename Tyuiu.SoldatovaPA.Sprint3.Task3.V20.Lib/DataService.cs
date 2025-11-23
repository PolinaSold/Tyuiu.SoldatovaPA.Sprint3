using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.SoldatovaPA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task3.V20.Lib
{
    public class DataService : ISprint3Task3V20
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    count++;
                }
            }

            return count;
        }
    }
}