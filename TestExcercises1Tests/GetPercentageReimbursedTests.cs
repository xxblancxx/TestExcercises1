using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestExcercises1;
namespace TestExcercises1Tests
{
    [TestClass]
    public class GetPercentageReimbursedTests
    {
        [TestMethod]
        public void DeductibleNotMetDoctorsVisit()
        {
            int expected = 0; // deductible not met.
            int reimbursed = Program.GetPercentageReimbursed(false,Program.VisitType.Doctor);
            Assert.AreEqual(expected, reimbursed);
        }

        [TestMethod]
        public void DeductibleNotMetHospitalVisit()
        {
            int expected = 0; // deductible not met.
            int reimbursed = Program.GetPercentageReimbursed(false, Program.VisitType.Hospital);
            Assert.AreEqual(expected, reimbursed);
        }

        [TestMethod]
        public void DeductibleMetDoctorsVisit()
        {
            int expected = 50;
            int reimbursed = Program.GetPercentageReimbursed(true, Program.VisitType.Doctor);
            Assert.AreEqual(expected, reimbursed);
        }

        [TestMethod]
        public void DeductibleMetHospitalVisit()
        {
            int expected = 80;
            int reimbursed = Program.GetPercentageReimbursed(true, Program.VisitType.Hospital);
            Assert.AreEqual(expected, reimbursed);
        }

       
    }
}
