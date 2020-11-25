using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void abs_20and10_200returned()
        {
            //arrange
            int x = 20;
            int y = 10;
            int expected = 200;

            //act
            MyCalc c = new MyCalc();
            int actual = c.abs(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sum_20and10_30returned()
        {
            //arrange
            int x = 20;
            int y = 10;
            int expected = 30;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void divide_20and10_2returned()
        {
            //arrange
            int x = 20;
            int y = 10;
            int expected = 2;

            //act
            MyCalc c = new MyCalc();
            int actual = c.divide(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void subtract_20and10_10returned()
        {
            //arrange
            int x = 20;
            int y = 10;
            int expected = 10;

            //act
            MyCalc c = new MyCalc();
            int actual = c.subtract(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
