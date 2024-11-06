using Tyuiu.ShanginAA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.ShanginAA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 20;
            double y = 3;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(30, res);
        }
    }
}