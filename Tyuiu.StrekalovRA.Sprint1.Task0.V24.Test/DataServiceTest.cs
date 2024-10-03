using Tyuiu.StrekalovRA.Sprint1.Task0.V24.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var F = DS.Calculate();
            Assert.AreEqual(F, 2);
        }
    }
}