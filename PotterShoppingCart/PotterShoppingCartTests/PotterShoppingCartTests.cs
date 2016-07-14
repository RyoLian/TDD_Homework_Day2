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
            var actual = Buy.CalTotalPay(1, 0, 0, 0, 0);

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
            var actual = Buy.CalTotalPay(1, 1, 0, 0, 0);

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
            var actual = Buy.CalTotalPay(1, 1, 1, 0, 0);

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
            var actual = Buy.CalTotalPay(1, 1, 1, 1, 0);

            //assert
            var expected = 320;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PotterShoppingCartTests_買了一整套_價格應為_375()
        {
            //arrange
            var Buy = new PotterShoppingCart();

            //act
            var actual = Buy.CalTotalPay(1, 1, 1, 1, 1);

            //assert
            var expected = 375;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void PotterShoppingCartTests_一二集各買了一本_第三集買了兩本_價格應為_370()
        {
            //arrange
            var Buy = new PotterShoppingCart();

            //act
            var actual = Buy.CalTotalPay(1, 1, 2, 0, 0);

            //assert
            var expected = 370;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void PotterShoppingCartTests_第一集買了一本_第二三集各買了兩本_價格應為_460()
        {
            //arrange
            var Buy = new PotterShoppingCart();

            //act
            var actual = Buy.CalTotalPay(1, 2, 2, 0, 0);

            //assert
            var expected = 460;
            Assert.AreEqual(expected, actual);

        }
    }
}
