using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAppToTest;

namespace MyAppUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmployeeShouldHaveNameAndAge ()
        {
            var employee = new Employee("Jean", 24);
            Assert.AreEqual("Jean", employee.Name);
            Assert.AreEqual(24, employee.Age);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EmployeeShouldBeBelow60()
        {
            var employee = new Employee("Benoit", 61);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EmployeeShouldBeAbove16()
        {
            var employee = new Employee("Benoit", 15);
        }
    }
}
