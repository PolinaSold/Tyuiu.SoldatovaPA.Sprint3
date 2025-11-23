using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint3.Task1.V10.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 15.963; // Ожидаемое значение суммы
            Assert.AreEqual(wait, res);
        }
    }
}
