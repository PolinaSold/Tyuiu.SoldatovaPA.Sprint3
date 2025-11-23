using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint3.Task2.V23.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double a = 1.5;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetSumSeries(a, startValue, stopValue);
            double wait = 138.927; // Ожидаемое значение суммы
            Assert.AreEqual(wait, res);
        }
    }
}