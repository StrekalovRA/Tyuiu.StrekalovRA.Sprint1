using Tyuiu.StrekalovRA.Sprint1.Task7.V10.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var R = DS.Calculate(1);
            Assert.AreEqual(-13.142, R);
        }
    }
}