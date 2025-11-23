using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint3.Task7.V6.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = {
                15.19, 11.67, 8.65, 5.53, 2.26, 0, -3.30, -6.44, -9.63, -12.78, -15.91
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}