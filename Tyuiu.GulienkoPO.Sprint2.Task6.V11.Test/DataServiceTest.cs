using Tyuiu.GulienkoPO.Sprint2.Task6.V11.Lib;

namespace Tyuiu.GulienkoPO.Sprint2.Task6.V11.Test
{
    public class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("€нварь", ds.FindDateOfNextDay(1990, 1, 1));
            Assert.AreEqual("февраль", ds.FindDateOfNextDay(1990, 2, 1));
            Assert.AreEqual("март", ds.FindDateOfNextDay(1990, 3, 1));
            Assert.AreEqual("апрель", ds.FindDateOfNextDay(1990, 4, 1));
            Assert.AreEqual("май", ds.FindDateOfNextDay(1990, 5, 1));
            Assert.AreEqual("июнь", ds.FindDateOfNextDay(1990, 6, 1));
            Assert.AreEqual("июль", ds.FindDateOfNextDay(1990, 7, 1));
            Assert.AreEqual("август", ds.FindDateOfNextDay(1990, 8, 1));
            Assert.AreEqual("сент€брь", ds.FindDateOfNextDay(1990, 9, 1));
            Assert.AreEqual("окт€брь", ds.FindDateOfNextDay(1990, 10, 1));
            Assert.AreEqual("но€брь", ds.FindDateOfNextDay(1990, 11, 1));
            Assert.AreEqual("декабрь", ds.FindDateOfNextDay(1990, 12, 1));
        }
    }
}