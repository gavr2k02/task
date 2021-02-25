using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestArea
{
    [TestClass]
    public class UnitTestArea
    {
        [TestMethod]
        public void CircleCalculate_WatchWalidArguments()
        {
            double arg = 5;
            double expected = Math.PI * (arg * arg);
            double actual = AreaLib.Area.CircleCalculate(arg);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCalculate_WatchWalidArguments()
        {
            double[] args = { 3, 4, 5 };
            var p = args.Sum() / 2;
            double expected = Math.Sqrt(p * (p - args[0]) * (p - args[1]) * (p - args[2]));
            double actual = AreaLib.Area.TriangleCalculate(args[0], args[1], args[2]);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FigureCalculate_WatchWalidArguments()
        {
            double a = 5;

            double expected = a * a;
            double actual = AreaLib.Area.FigureCalculate(a, a, a, a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FigureCalculate_WhenArgumaentIsLessThanZero_ShouldThrowArgumetLessThanZero()
        {
            double a = -1;

            Assert.ThrowsException<Exception>(() => AreaLib.Area.FigureCalculate(a, a, a, a));
        }

        [TestMethod]
        public void TriangleCalculate_WhenArgumaentIsLessThanZero_ShouldThrowArgumetLessThanZero()
        {
            double a = -1;

            Assert.ThrowsException<Exception>(() => AreaLib.Area.TriangleCalculate(a, a, a));
        }

        [TestMethod]
        public void CircleCalculate_WhenArgumaentIsLessThanZero_ShouldThrowArgumetLessThanZero()
        {
            double a = -1;

            Assert.ThrowsException<Exception>(() => AreaLib.Area.CircleCalculate(a));
        }
    }
}
