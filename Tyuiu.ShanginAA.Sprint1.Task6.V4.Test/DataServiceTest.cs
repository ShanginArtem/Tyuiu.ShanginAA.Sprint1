using Tyuiu.ShanginAA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.ShanginAA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "������ ������� ���������, ��������? ������� ��� ��";
            DataService ds = new DataService();

            string res = ds.CheckDoubleN(strTest);
            string wait = "������� ���";
            Assert.AreEqual(wait, res);
        }
    }
}