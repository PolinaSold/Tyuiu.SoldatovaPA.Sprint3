using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint3.Task3.V20.Lib;

namespace Tyuiu.SoldatovaPA.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "gfft ntf f opf";
            char ch = 'f';
            int res = ds.GetCharCount(str, ch);
            int wait = 5; // Ожидаемое количество: gfft(2) + ntf(1) + f(1) + opf(1) = 5
            Assert.AreEqual(wait, res);
        }
    }
}
