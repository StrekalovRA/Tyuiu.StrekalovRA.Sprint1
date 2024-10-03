using Tyuiu.StrekalovRA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            Assert.AreEqual(DS.Calculate(3.1494), 1);
        }
    }
}