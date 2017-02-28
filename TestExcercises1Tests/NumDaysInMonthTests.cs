using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestExcercises1;

namespace TestExcercises1Tests
{
    [TestClass]
    public class NumDaysInMonthTests
    {
        [TestMethod]
        public void GetNumDaysInMonthTest()
        {
            // Bryan Adams forgot how many days were in July 1969
            // ....Got my first real six-string...
            int expectedDays = 31; // Of course ...That summer seemed to last forever...
            var calculatedDays = Program.GetNumDaysInMonth(7, 1969);
            Assert.AreEqual(expectedDays, calculatedDays);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetNumDaysInMonthTestYearUpperBoundary()
        {
            var calculatedDays = Program.GetNumDaysInMonth(1, 11002); // Windows function, upper limit is 9999
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetNumDaysInMonthTestYearLowerBoundary()
        {
            var calculatedDays = Program.GetNumDaysInMonth(1, -500);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetNumDaysInMonthTestMonthUpperBoundary()
        {
            var calculatedDays = Program.GetNumDaysInMonth(13, 2000);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetNumDaysInMonthTestMonthLowerBoundary()
        {
            var calculatedDays = Program.GetNumDaysInMonth(0, 2000);
        }
        [TestMethod]
        public void GetNumDaysInMonthTestLeapYearPositive()
        {
            //February had 29 days in 2016
            var expectedDays = 29;
            var calculatedDays = Program.GetNumDaysInMonth(2, 2016);
            Assert.AreEqual(expectedDays, calculatedDays);
        }
        [TestMethod]
        public void GetNumDaysInMonthTestLeapYearNegative()
        {
            //February had 28 days in 1900
            var expectedDays = 28;
            var calculatedDays = Program.GetNumDaysInMonth(2, 1900);
            Assert.AreEqual(expectedDays, calculatedDays);
        }
    }
}
