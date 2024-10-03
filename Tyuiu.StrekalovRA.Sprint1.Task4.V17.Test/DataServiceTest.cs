using Tyuiu.StrekalovRA.Sprint1.Task4.V17.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            Assert.AreEqual(0.5, DS.Calculate(9, 1));
        }
    }
}