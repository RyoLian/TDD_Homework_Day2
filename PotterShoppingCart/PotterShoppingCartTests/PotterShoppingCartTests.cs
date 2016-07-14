using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart_Library;

namespace PotterShoppingCartTests
{
    [TestClass]
    public class PotterShoppingCartTests
    {
        [TestMethod]
        public void PotterShoppingCartTests_第一集買了一本_其他都沒買_價格應為_100元()
        {
            //arrange
            var Buy = new PotterShoppingCart();

            //act
            var actual = Buy.CalTotalPay(1, 0, 0, 0);

            //assert
            var expected = 100;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PotterShoppingCartTests_第一集買了1本_第二集也買了1本_價格應為_190()
        {
            //arrange
            var Buy = new PotterShoppingCart();

            //act
            var actual = Buy.CalTotalPay(1, 1, 0, 0);

            //assert
            var expected = 190;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PotterShoppingCartTests_一二三集各買了一本_價格應為_270()
        {
            //arrange
            var Buy = new PotterShoppingCart();

            //act
            var actual = Buy.CalTotalPay(1, 1, 1, 0);

            //assert
            var expected = 270;
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void PotterShoppingCartTests_一二三四集各買了一本_價格應為_320()
        {
            //arrange
            var Buy = new PotterShoppingCart();

            //act
            var actual = Buy.CalTotalPay(1, 1, 1, 1);

            //assert
            var expected = 320;
            Assert.AreEqual(expected, actual);

        }
    }
}
