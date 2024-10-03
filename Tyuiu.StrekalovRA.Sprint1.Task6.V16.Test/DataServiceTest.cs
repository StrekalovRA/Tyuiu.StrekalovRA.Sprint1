using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.StrekalovRA.Sprint1.Task6.V16.Lib;


namespace Tyuiu.StrekalovRA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DS = new DataService();
        [TestMethod] public void TestMethod1() { Assert.AreEqual(false, DS.CheckSpecSymbols("!999")); }
        [TestMethod] public void TestMethod2() { Assert.AreEqual(true, DS.CheckSpecSymbols("!!!!?!&!&!&?!?!?!?!9")); }
        [TestMethod] public void TestMethod3() { Assert.AreEqual(true, DS.CheckSpecSymbols("!99&&?!9")); }
        [TestMethod] public void TestMethod4() { Assert.AreEqual(false, DS.CheckSpecSymbols("!99&&!9")); }
    }
}