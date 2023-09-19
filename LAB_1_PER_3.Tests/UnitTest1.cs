using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LAB_1_PER_3.Tests
{
    [TestClass]
    public class LAB_1_PER_3Tests
    {
        [TestMethod]
        public void moveInnerClock_5000_2500()
        {
            // arange
            Flower flower = new Flower("popa", (Color)1,6,12,5000);
            double expected = 2500;

            // actual
            flower.moveInnerClock(3);
            double actually = flower.RealPrice();

            // assert
            Assert.AreEqual(expected, actually);    
        }
    }
}
