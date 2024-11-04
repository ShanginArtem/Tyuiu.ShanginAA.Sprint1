using Tyuiu.ShanginAA.Sprint1.Task1.V30.Lib;

namespace Tyuiu.ShanginAA.Sprint1.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(3, res);


        }
    }
}