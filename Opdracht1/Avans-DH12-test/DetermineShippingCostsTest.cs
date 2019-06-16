using System;
using Avans_DH12.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Avans_DH12_test
{
    [TestClass]
    public class DetermineShippingCostsTest
    {
        [TestMethod]
        public void TestShippingCosts()
        {
            var clazz = new DetermineShippingCosts();
            Assert.AreEqual(0, clazz.ShippingCosts(false, "Ground", 300));
            Assert.AreEqual(100, clazz.ShippingCosts(true, "Ground", 300));
            Assert.AreEqual(125, clazz.ShippingCosts(true, "SecondDayAir", 1401));
            Assert.AreEqual(0, clazz.ShippingCosts(true, "SecondDayAir", 1501));
            Assert.AreEqual(0, clazz.ShippingCosts(false, "fsdfsdfsdf", 300));
            Assert.AreEqual(50, clazz.ShippingCosts(true, "InStore", 300));
            Assert.AreEqual(250, clazz.ShippingCosts(true, "NextDayAir", 300));
            Assert.AreEqual(0, clazz.ShippingCosts(true, "NextDayAir", 1600));
        }
    }
}
