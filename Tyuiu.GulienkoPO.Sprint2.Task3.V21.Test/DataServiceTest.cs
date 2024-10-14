using Tyuiu.GulienkoPO.Sprint2.Task3.V21.Lib;

namespace Tyuiu.GulienkoPO.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 2;
            DataService ds = new DataService();
            Assert.AreEqual(242, ds.Calculate(x));
        }
    }
}