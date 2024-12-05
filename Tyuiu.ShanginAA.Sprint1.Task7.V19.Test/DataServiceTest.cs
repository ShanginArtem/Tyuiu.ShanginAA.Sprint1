using System.Transactions;
using Tyuiu.ShanginAA.Sprint1.Task7.V19.Lib;

namespace Tyuiu.ShanginAA.Sprint1.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double wait = 2502.641;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}