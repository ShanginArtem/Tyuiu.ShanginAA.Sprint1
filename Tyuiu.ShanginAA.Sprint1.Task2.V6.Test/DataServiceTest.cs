using Tyuiu.ShanginAA.Sprint1.Task2.V6.Lib;

namespace Tyuiu.ShanginAA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 465;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(0.465, res);
        }
    }
}