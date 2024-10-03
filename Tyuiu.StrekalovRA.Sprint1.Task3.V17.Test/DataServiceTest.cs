using Tyuiu.StrekalovRA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            Assert.AreEqual(true, DS.ZeroCheck(3.031));
            Assert.AreEqual(true, DS.ZeroCheck(1.201));
            Assert.AreEqual(false, DS.ZeroCheck(-0.445));
        }
    }
}