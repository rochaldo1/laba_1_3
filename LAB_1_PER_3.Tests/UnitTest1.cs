using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LAB_1_PER_3.Tests
{
    [TestClass]
    public class LAB_1_PER_3Tests
    {
        [TestMethod]
        public void MoveInnerClock_1_0_dot_2()
        {
            // arange
            Flower flower = new Flower("Мак", (Color)1, 5, 12, 5000);
            decimal expected = 0.2M;

            // actual
            flower.MoveInnerClock(4);
            decimal actually = (decimal)(flower.State);

            // assert
            Assert.AreEqual(expected, actually);
        }
        [TestMethod]
        public void RealPrice_5000_1000()
        {
            // arange
            Flower flower = new Flower("Ромашка", (Color)1, 5, 12, 5000);
            decimal expected = 1000M;
            // actual
            flower.MoveInnerClock(4);
            decimal actually = (decimal)(flower.RealPrice());
            // assert
            Assert.AreEqual(expected, actually);
        }

    }
}
