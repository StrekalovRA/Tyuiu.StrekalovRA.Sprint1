using Tyuiu.StrekalovRA.Sprint1.Task2.V17.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var G = DS.ConvertMinutesToHours(299);
            Assert.AreEqual(4, G);
        }
    }
}