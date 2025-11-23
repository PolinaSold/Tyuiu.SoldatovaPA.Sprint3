using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint3.Task4.V27.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 61.733; // Ожидаемая сумма
            Assert.AreEqual(wait, res);
        }
    }
}