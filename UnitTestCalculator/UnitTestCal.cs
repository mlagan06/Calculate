using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestCal
    {
        [TestMethod]
        public void TestAllNumers()
        {
            string expected = "1, 2, 3, 4, 5";
            int number = 5;

            CalculateNumbers.PerformCalculations Calculate = new CalculateNumbers.PerformCalculations();
            string actual = Calculate.GetAllNumbers(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEvenNumers()
        {
            string expected = "2, 4, 6, 8, 10";
            int number = 10;

            CalculateNumbers.PerformCalculations Calculate = new CalculateNumbers.PerformCalculations();
            string actual = Calculate.GetAllEvenNumbers(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOddNumers()
        {
            string expected = "1, 3, 5, 7, 9";
            int number = 10;

            CalculateNumbers.PerformCalculations Calculate = new CalculateNumbers.PerformCalculations();
            string actual = Calculate.GetAllOddNumbers(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLetters()
        {
            string expected = "1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z";
            int number = 15;

            CalculateNumbers.PerformCalculations Calculate = new CalculateNumbers.PerformCalculations();
            string actual = Calculate.GetAllLetters(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFibSeries()
        {
            string expected = "0, 1, 1, 2, 3, 5, 8, 13, 21, 34";
            int number = 10;

            CalculateNumbers.PerformCalculations Calculate = new CalculateNumbers.PerformCalculations();
            string actual = Calculate.GetAllFibsNumbers(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
