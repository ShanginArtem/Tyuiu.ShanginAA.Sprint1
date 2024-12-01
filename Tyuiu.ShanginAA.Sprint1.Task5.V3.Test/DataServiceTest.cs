using Tyuiu.ShanginAA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ShanginAA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int x = 54321;
            DataService ds = new DataService();
            int res = ds.Calculate(x);

            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}