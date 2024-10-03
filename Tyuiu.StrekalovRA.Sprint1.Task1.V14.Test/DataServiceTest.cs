using Tyuiu.StrekalovRA.Sprint1.Task1.V14.Lib;

namespace Tyuiu.StrekalovRA.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(2.5, dataService.Calculate(2, 2, 2));
        }
    }
}